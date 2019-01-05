//===============================================================================
// TinyIoC
//
// An easy to use, hassle free, Inversion of Control Container for small projects
// and beginners alike.
//
// https://github.com/grumpydev/TinyIoC
//===============================================================================
// Copyright © Steven Robbins.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

// Uncomment this line if you want the container to automatically
// register the TinyMessenger messenger/event aggregator
#define TINYMESSENGER

namespace TinyIoC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Threading;

    public class SafeDictionary<TKey, TValue> : IDisposable
    {
        private readonly ReaderWriterLockSlim _padlock = new ReaderWriterLockSlim();
        private readonly Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();

        public TValue this[TKey key]
        {
            set
            {
                _padlock.EnterWriteLock();

                try
                {
                    if (_dictionary.TryGetValue(key, out TValue current))
                    {
                        if (current is IDisposable disposable)
                            disposable.Dispose();
                    }

                    _dictionary[key] = value;
                }
                finally
                {
                    _padlock.ExitWriteLock();
                }
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            _padlock.EnterReadLock();
            try
            {
                return _dictionary.TryGetValue(key, out value);
            }
            finally
            {
                _padlock.ExitReadLock();
            }
        }

        public bool Remove(TKey key)
        {
            _padlock.EnterWriteLock();
            try
            {
                return _dictionary.Remove(key);
            }
            finally
            {
                _padlock.ExitWriteLock();
            }
        }

        public void Clear()
        {
            _padlock.EnterWriteLock();
            try
            {
                _dictionary.Clear();
            }
            finally
            {
                _padlock.ExitWriteLock();
            }
        }

        public IEnumerable<TKey> Keys
        {
            get
            {
                _padlock.EnterReadLock();
                try
                {
                    return new List<TKey>(_dictionary.Keys);
                }
                finally
                {
                    _padlock.ExitReadLock();
                }
            }
        }


        public void Dispose()
        {
            _padlock.EnterWriteLock();

            try
            {
                foreach (IDisposable item in _dictionary.Values.OfType<IDisposable>())
                    item.Dispose();
            }
            finally
            {
                _padlock.ExitWriteLock();
            }

            GC.SuppressFinalize(this);
        }
    }

    public static class AssemblyExtensions
    {
        public static Type[] SafeGetTypes(this Assembly assembly)
        {
            Type[] assemblies;

            try
            {
                assemblies = assembly.GetTypes();
            }
            catch (System.IO.FileNotFoundException)
            {
                assemblies = new Type[] { };
            }
            catch (NotSupportedException)
            {
                assemblies = new Type[] { };
            }
            catch (ReflectionTypeLoadException e)
            {
                assemblies = e.Types.Where(t => t != null).ToArray();
            }

            return assemblies;
        }
    }

    public static class TypeExtensions
    {
        private static readonly SafeDictionary<GenericMethodCacheKey, MethodInfo> GenericMethodCache;

        static TypeExtensions()
        {
            GenericMethodCache = new SafeDictionary<GenericMethodCacheKey, MethodInfo>();
        }

        /// <summary>
        /// Gets a generic method from a type given the method name, binding flags, generic types and parameter types
        /// </summary>
        /// <param name="sourceType">Source type</param>
        /// <param name="bindingFlags">Binding flags</param>
        /// <param name="methodName">Name of the method</param>
        /// <param name="genericTypes">Generic types to use to make the method generic</param>
        /// <param name="parameterTypes">Method parameters</param>
        /// <returns>MethodInfo or null if no matches found</returns>
        /// <exception cref="System.Reflection.AmbiguousMatchException"/>
        /// <exception cref="System.ArgumentException"/>
        public static MethodInfo GetGenericMethod(
            this Type sourceType,
            BindingFlags bindingFlags,
            string methodName,
            Type[] genericTypes,
            Type[] parameterTypes)
        {
            GenericMethodCacheKey cacheKey = new GenericMethodCacheKey(sourceType, methodName, genericTypes, parameterTypes);

            // Shouldn't need any additional locking
            // we don't care if we do the method info generation
            // more than once before it gets cached.
            if (!GenericMethodCache.TryGetValue(cacheKey, out MethodInfo method))
            {
                method                       = GetMethod(sourceType, bindingFlags, methodName, genericTypes, parameterTypes);
                GenericMethodCache[cacheKey] = method;
            }

            return method;
        }


        private static MethodInfo GetMethod(Type sourceType, BindingFlags bindingFlags, string methodName, Type[] genericTypes, Type[] parameterTypes)
        {
            List<MethodInfo> methods =
                sourceType.GetMethods(bindingFlags)
                          .Where(mi => string.Equals(methodName, mi.Name, StringComparison.Ordinal))
                          .Where(mi => mi.ContainsGenericParameters)
                          .Where(mi => mi.GetGenericArguments().Length == genericTypes.Length)
                          .Where(mi => mi.GetParameters().Length == parameterTypes.Length)
                          .Select(mi => mi.MakeGenericMethod(genericTypes))
                          .Where(mi => mi.GetParameters().Select(pi => pi.ParameterType).SequenceEqual(parameterTypes))
                          .ToList();
            if (methods.Count > 1)
                throw new AmbiguousMatchException();

            return methods.FirstOrDefault();
        }

        private sealed class GenericMethodCacheKey
        {
            private readonly Type _sourceType;
            private readonly string _methodName;
            private readonly Type[] _genericTypes;
            private readonly Type[] _parameterTypes;
            private readonly int _hashCode;

            public GenericMethodCacheKey(Type sourceType, string methodName, Type[] genericTypes, Type[] parameterTypes)
            {
                _sourceType     = sourceType;
                _methodName     = methodName;
                _genericTypes   = genericTypes;
                _parameterTypes = parameterTypes;
                _hashCode       = GenerateHashCode();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is GenericMethodCacheKey cacheKey))
                    return false;

                if (_sourceType != cacheKey._sourceType)
                    return false;

                if (!string.Equals(_methodName, cacheKey._methodName, StringComparison.Ordinal))
                    return false;

                if (_genericTypes.Length != cacheKey._genericTypes.Length)
                    return false;

                if (_parameterTypes.Length != cacheKey._parameterTypes.Length)
                    return false;

                for (int i = 0; i < _genericTypes.Length; ++i)
                {
                    if (_genericTypes[i] != cacheKey._genericTypes[i])
                        return false;
                }

                for (int i = 0; i < _parameterTypes.Length; ++i)
                {
                    if (_parameterTypes[i] != cacheKey._parameterTypes[i])
                        return false;
                }

                return true;
            }

            public override int GetHashCode()
            {
                return _hashCode;
            }

            private int GenerateHashCode()
            {
                unchecked
                {
                    int result = _sourceType.GetHashCode();

                    result = (result * 397) ^ _methodName.GetHashCode();

                    for (int i = 0; i < _genericTypes.Length; ++i)
                    {
                        result = (result * 397) ^ _genericTypes[i].GetHashCode();
                    }

                    for (int i = 0; i < _parameterTypes.Length; ++i)
                    {
                        result = (result * 397) ^ _parameterTypes[i].GetHashCode();
                    }

                    return result;
                }
            }
        }
    }

    public class TinyIoCResolutionException : Exception
    {
        private const string ErrorText = "Unable to resolve type: {0}";

        public TinyIoCResolutionException(Type type)
            : base(string.Format(ErrorText, type.FullName)) { }

        public TinyIoCResolutionException(Type type, Exception innerException)
            : base(string.Format(ErrorText, type.FullName), innerException) { }
    }

    public class TinyIoCRegistrationTypeException : Exception
    {
        private const string RegisterErrorText = "Cannot register type {0} - abstract classes or interfaces are not valid implementation types for {1}.";

        public TinyIoCRegistrationTypeException(Type type, string factory)
            : base(string.Format(RegisterErrorText, type.FullName, factory)) { }

        public TinyIoCRegistrationTypeException(Type type, string factory, Exception innerException)
            : base(string.Format(RegisterErrorText, type.FullName, factory), innerException) { }
    }

    public class TinyIoCRegistrationException : Exception
    {
        private const string ConvertErrorText = "Cannot convert current registration of {0} to {1}";
        private const string GenericConstraintErrorText = "Type {1} is not valid for a registration of type {0}";

        public TinyIoCRegistrationException(Type type, string method)
            : base(string.Format(ConvertErrorText, type.FullName, method)) { }

        public TinyIoCRegistrationException(Type type, string method, Exception innerException)
            : base(string.Format(ConvertErrorText, type.FullName, method), innerException) { }

        public TinyIoCRegistrationException(Type registerType, Type implementationType)
            : base(string.Format(GenericConstraintErrorText, registerType.FullName, implementationType.FullName)) { }

        public TinyIoCRegistrationException(Type registerType, Type implementationType, Exception innerException)
            : base(string.Format(GenericConstraintErrorText, registerType.FullName, implementationType.FullName), innerException) { }
    }

    public class TinyIoCWeakReferenceException : Exception
    {
        private const string ErrorText = "Unable to instantiate {0} - referenced object has been reclaimed";

        public TinyIoCWeakReferenceException(Type type)
            : base(string.Format(ErrorText, type.FullName)) { }

        public TinyIoCWeakReferenceException(Type type, Exception innerException)
            : base(string.Format(ErrorText, type.FullName), innerException) { }
    }

    public class TinyIoCConstructorResolutionException : Exception
    {
        private const string ErrorText = "Unable to resolve constructor for {0} using provided Expression.";

        public TinyIoCConstructorResolutionException(Type type)
            : base(string.Format(ErrorText, type.FullName)) { }

        public TinyIoCConstructorResolutionException(Type type, Exception innerException)
            : base(string.Format(ErrorText, type.FullName), innerException) { }

        public TinyIoCConstructorResolutionException(string message, Exception innerException)
            : base(message, innerException) { }

        public TinyIoCConstructorResolutionException(string message)
            : base(message) { }
    }

    public class TinyIoCAutoRegistrationException : Exception
    {
        private const string ErrorText = "Duplicate implementation of type {0} found ({1}).";

        public TinyIoCAutoRegistrationException(Type registerType, IEnumerable<Type> types)
            : base(string.Format(ErrorText, registerType, GetTypesString(types))) { }

        public TinyIoCAutoRegistrationException(Type registerType, IEnumerable<Type> types, Exception innerException)
            : base(string.Format(ErrorText, registerType, GetTypesString(types)), innerException) { }

        private static string GetTypesString(IEnumerable<Type> types)
        {
            IEnumerable<string> typeNames = from type in types
                select type.FullName;

            return string.Join(",", typeNames.ToArray());
        }
    }

    /// <summary>
    /// Name/Value pairs for specifying "user" parameters when resolving
    /// </summary>
    public sealed class NamedParameterOverloads : Dictionary<string, object>
    {
        public static NamedParameterOverloads FromIDictionary(IDictionary<string, object> data)
        {
            return data as NamedParameterOverloads ?? new NamedParameterOverloads(data);
        }

        public NamedParameterOverloads() { }

        public NamedParameterOverloads(IDictionary<string, object> data)
            : base(data) { }

        public static NamedParameterOverloads Default { get; } = new NamedParameterOverloads();
    }

    public enum UnregisteredResolutionActions
    {
        /// <summary>
        /// Attempt to resolve type, even if the type isn't registered.
        /// 
        /// Registered types/options will always take precedence.
        /// </summary>
        AttemptResolve,

        /// <summary>
        /// Fail resolution if type not explicitly registered
        /// </summary>
        Fail,

        /// <summary>
        /// Attempt to resolve unregistered type if requested type is generic
        /// and no registration exists for the specific generic parameters used.
        /// 
        /// Registered types/options will always take precedence.
        /// </summary>
        GenericsOnly
    }

    public enum NamedResolutionFailureActions
    {
        AttemptUnnamedResolution,
        Fail
    }

    public enum DuplicateImplementationActions
    {
        RegisterSingle,
        RegisterMultiple,
        Fail
    }

    /// <summary>
    /// Resolution settings
    /// </summary>
    public sealed class ResolveOptions
    {
        public UnregisteredResolutionActions UnregisteredResolutionAction { get; set; } = UnregisteredResolutionActions.AttemptResolve;
        public NamedResolutionFailureActions NamedResolutionFailureAction { get; set; } = NamedResolutionFailureActions.Fail;

        /// <summary>
        /// Gets the default options (attempt resolution of unregistered types, fail on named resolution if name not found)
        /// </summary>
        public static ResolveOptions Default { get; } = new ResolveOptions();

        /// <summary>
        /// Preconfigured option for attempting resolution of unregistered types and failing on named resolution if name not found
        /// </summary>
        public static ResolveOptions FailNameNotFoundOnly { get; }
            = new ResolveOptions
            {
                NamedResolutionFailureAction = NamedResolutionFailureActions.Fail,
                UnregisteredResolutionAction = UnregisteredResolutionActions.AttemptResolve
            };

        /// <summary>
        /// Preconfigured option for failing on resolving unregistered types and on named resolution if name not found
        /// </summary>
        public static ResolveOptions FailUnregisteredAndNameNotFound { get; }
            = new ResolveOptions
            {
                NamedResolutionFailureAction = NamedResolutionFailureActions.Fail,
                UnregisteredResolutionAction = UnregisteredResolutionActions.Fail
            };

        /// <summary>
        /// Preconfigured option for failing on resolving unregistered types, but attempting unnamed resolution if name not found
        /// </summary>
        public static ResolveOptions FailUnregisteredOnly { get; }
            = new ResolveOptions
            {
                NamedResolutionFailureAction = NamedResolutionFailureActions.AttemptUnnamedResolution,
                UnregisteredResolutionAction = UnregisteredResolutionActions.Fail
            };
    }

    public sealed class TinyIoCContainer : IDisposable
    {
        /// <summary>
        /// Registration options for "fluent" API
        /// </summary>
        public sealed class RegisterOptions
        {
            private readonly TinyIoCContainer _container;
            private readonly TypeRegistration _registration;

            public RegisterOptions(TinyIoCContainer container, TypeRegistration registration)
            {
                _container    = container;
                _registration = registration;
            }

            /// <summary>
            /// Make registration a singleton (single instance) if possible
            /// </summary>
            /// <returns>RegisterOptions</returns>
            /// <exception cref="TinyIoCRegistrationException"></exception>
            public RegisterOptions AsSingleton()
            {
                ObjectFactoryBase currentFactory = _container.GetCurrentFactory(_registration);

                if (currentFactory == null)
                    throw new TinyIoCRegistrationException(_registration.Type, "singleton");

                return _container.AddUpdateRegistration(_registration, currentFactory.SingletonVariant);
            }

            /// <summary>
            /// Make registration multi-instance if possible
            /// </summary>
            /// <returns>RegisterOptions</returns>
            /// <exception cref="TinyIoCRegistrationException"></exception>
            public RegisterOptions AsMultiInstance()
            {
                ObjectFactoryBase currentFactory = _container.GetCurrentFactory(_registration);

                if (currentFactory == null)
                    throw new TinyIoCRegistrationException(_registration.Type, "multi-instance");

                return _container.AddUpdateRegistration(_registration, currentFactory.MultiInstanceVariant);
            }

            /// <summary>
            /// Make registration hold a weak reference if possible
            /// </summary>
            /// <returns>RegisterOptions</returns>
            /// <exception cref="TinyIoCRegistrationException"></exception>
            public RegisterOptions WithWeakReference()
            {
                ObjectFactoryBase currentFactory = _container.GetCurrentFactory(_registration);

                if (currentFactory == null)
                    throw new TinyIoCRegistrationException(_registration.Type, "weak reference");

                return _container.AddUpdateRegistration(_registration, currentFactory.WeakReferenceVariant);
            }

            /// <summary>
            /// Make registration hold a strong reference if possible
            /// </summary>
            /// <returns>RegisterOptions</returns>
            /// <exception cref="TinyIoCRegistrationException"></exception>
            public RegisterOptions WithStrongReference()
            {
                ObjectFactoryBase currentFactory = _container.GetCurrentFactory(_registration);

                if (currentFactory == null)
                    throw new TinyIoCRegistrationException(_registration.Type, "strong reference");

                return _container.AddUpdateRegistration(_registration, currentFactory.StrongReferenceVariant);
            }

            public RegisterOptions UsingConstructor<TRegisterType>(Expression<Func<TRegisterType>> constructor)
            {
                if (!(constructor is LambdaExpression lambda))
                    throw new TinyIoCConstructorResolutionException(typeof(TRegisterType));

                if (!(lambda.Body is NewExpression newExpression))
                    throw new TinyIoCConstructorResolutionException(typeof(TRegisterType));

                ConstructorInfo constructorInfo = newExpression.Constructor;
                if (constructorInfo == null)
                    throw new TinyIoCConstructorResolutionException(typeof(TRegisterType));

                ObjectFactoryBase currentFactory = _container.GetCurrentFactory(_registration);
                if (currentFactory == null)
                    throw new TinyIoCConstructorResolutionException(typeof(TRegisterType));

                currentFactory.SetConstructor(constructorInfo);

                return this;
            }

            /// <summary>
            /// Switches to a custom lifetime manager factory if possible.
            /// 
            /// Usually used for RegisterOptions "To*" extension methods such as the ASP.Net per-request one.
            /// </summary>
            /// <param name="instance">RegisterOptions instance</param>
            /// <param name="lifetimeProvider">Custom lifetime manager</param>
            /// <param name="errorString">Error string to display if switch fails</param>
            /// <returns>RegisterOptions</returns>
            public static RegisterOptions ToCustomLifetimeManager(RegisterOptions instance, ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorString)
            {
                if (instance == null)
                    throw new ArgumentNullException(nameof(instance), "instance is null.");

                if (lifetimeProvider == null)
                    throw new ArgumentNullException(nameof(lifetimeProvider), "lifetimeProvider is null.");

                if (string.IsNullOrEmpty(errorString))
                    throw new ArgumentException("errorString is null or empty.", nameof(errorString));

                ObjectFactoryBase currentFactory = instance._container.GetCurrentFactory(instance._registration);

                if (currentFactory == null)
                    throw new TinyIoCRegistrationException(instance._registration.Type, errorString);

                return instance._container.AddUpdateRegistration(instance._registration, currentFactory.GetCustomObjectLifetimeVariant(lifetimeProvider, errorString));
            }
        }

        /// <summary>
        /// Registration options for "fluent" API when registering multiple implementations
        /// </summary>
        public sealed class MultiRegisterOptions
        {
            private IEnumerable<RegisterOptions> _registerOptions;

            /// <summary>
            /// Initializes a new instance of the MultiRegisterOptions class.
            /// </summary>
            /// <param name="registerOptions">Registration options</param>
            public MultiRegisterOptions(IEnumerable<RegisterOptions> registerOptions)
            {
                _registerOptions = registerOptions;
            }

            /// <summary>
            /// Make registration a singleton (single instance) if possible
            /// </summary>
            /// <returns>RegisterOptions</returns>
            /// <exception cref="TinyIoCRegistrationException"></exception>
            public MultiRegisterOptions AsSingleton()
            {
                _registerOptions = ExecuteOnAllRegisterOptions(ro => ro.AsSingleton());
                return this;
            }

            /// <summary>
            /// Make registration multi-instance if possible
            /// </summary>
            /// <returns>MultiRegisterOptions</returns>
            /// <exception cref="TinyIoCRegistrationException"></exception>
            public MultiRegisterOptions AsMultiInstance()
            {
                _registerOptions = ExecuteOnAllRegisterOptions(ro => ro.AsMultiInstance());
                return this;
            }

            /// <summary>
            /// Switches to a custom lifetime manager factory if possible.
            /// 
            /// Usually used for RegisterOptions "To*" extension methods such as the ASP.Net per-request one.
            /// </summary>
            /// <param name="instance">MultiRegisterOptions instance</param>
            /// <param name="lifetimeProvider">Custom lifetime manager</param>
            /// <param name="errorString">Error string to display if switch fails</param>
            /// <returns>MultiRegisterOptions</returns>
            public static MultiRegisterOptions ToCustomLifetimeManager(
                MultiRegisterOptions instance,
                ITinyIoCObjectLifetimeProvider lifetimeProvider,
                string errorString)
            {
                if (instance == null)
                    throw new ArgumentNullException(nameof(instance), "instance is null.");

                if (lifetimeProvider == null)
                    throw new ArgumentNullException(nameof(lifetimeProvider), "lifetimeProvider is null.");

                if (string.IsNullOrEmpty(errorString))
                    throw new ArgumentException("errorString is null or empty.", nameof(errorString));

                instance._registerOptions = instance.ExecuteOnAllRegisterOptions(ro => RegisterOptions.ToCustomLifetimeManager(ro, lifetimeProvider, errorString));

                return instance;
            }

            private IEnumerable<RegisterOptions> ExecuteOnAllRegisterOptions(Func<RegisterOptions, RegisterOptions> action)
            {
                return _registerOptions.Select(action).ToList();
            }
        }

        public TinyIoCContainer GetChildContainer()
        {
            return new TinyIoCContainer(this);
        }

        /// <summary>
        /// Attempt to automatically register all non-generic classes and interfaces in the specified assemblies
        /// Types will only be registered if they pass the supplied registration predicate.
        /// </summary>
        /// <param name="assemblies">Assemblies to process.  Null for all assemblies in domain</param>
        /// <param name="duplicateAction">What action to take when encountering duplicate implementations of an interface/base class. default: RegisterSingle</param>
        /// <param name="registrationPredicate">Predicate to determine if a particular type should be registered</param>
        /// <exception cref="TinyIoCAutoRegistrationException"/>
        public void AutoRegister(
            IEnumerable<Assembly> assemblies = null, 
            DuplicateImplementationActions duplicateAction = DuplicateImplementationActions.RegisterSingle, 
            Func<Type, bool> registrationPredicate = null)
        {
            assemblies = assemblies ?? AppDomain.CurrentDomain.GetAssemblies().Where(a => !IsIgnoredAssembly(a));
            AutoRegisterInternal(assemblies, duplicateAction, registrationPredicate);
        }

        /// <summary>
        /// Creates/replaces a named container class registration with default options.
        /// </summary>
        /// <param name="registerType">Type to register</param>
        /// <param name="name">Name of registration</param>
        /// <returns>RegisterOptions for fluent API</returns>
        public RegisterOptions Register(Type registerType, string name = null)
        {
            return RegisterInternal(registerType, name, GetDefaultObjectFactory(registerType, registerType));
        }

        /// <summary>
        /// Creates/replaces a named container class registration with a given implementation and default options.
        /// </summary>
        /// <param name="registerType">Type to register</param>
        /// <param name="registerImplementation">Type to instantiate that implements RegisterType</param>
        /// <param name="name">Name of registration</param>
        /// <returns>RegisterOptions for fluent API</returns>
        public RegisterOptions Register(Type registerType, Type registerImplementation, string name = null)
        {
            return RegisterInternal(registerType, name, GetDefaultObjectFactory(registerType, registerImplementation));
        }

        /// <summary>
        /// Creates/replaces a named container class registration with a specific, strong referenced, instance.
        /// </summary>
        /// <param name="registerType">Type to register</param>
        /// <param name="instance">Instance of RegisterType to register</param>
        /// <param name="name">Name of registration</param>
        /// <returns>RegisterOptions for fluent API</returns>
        public RegisterOptions Register(Type registerType, object instance, string name = null)
        {
            return RegisterInternal(registerType, name, new InstanceFactory(registerType, registerType, instance));
        }

        /// <summary>
        /// Creates/replaces a named container class registration with a specific, strong referenced, instance.
        /// </summary>
        /// <param name="registerType">Type to register</param>
        /// <param name="registerImplementation">Type of instance to register that implements RegisterType</param>
        /// <param name="instance">Instance of RegisterImplementation to register</param>
        /// <param name="name">Name of registration</param>
        /// <returns>RegisterOptions for fluent API</returns>
        public RegisterOptions Register(Type registerType, Type registerImplementation, object instance, string name = null)
        {
            return RegisterInternal(registerType, name, new InstanceFactory(registerType, registerImplementation, instance));
        }

        /// <summary>
        /// Creates/replaces a container class registration with a user specified factory
        /// </summary>
        /// <param name="registerType">Type to register</param>
        /// <param name="factory">Factory/lambda that returns an instance of RegisterType</param>
        /// <param name="name">Name of registration</param>
        /// <returns>RegisterOptions for fluent API</returns>
        public RegisterOptions Register(
            Type registerType, Func<TinyIoCContainer, NamedParameterOverloads, object> factory = null, string name = null)
        {
            return RegisterInternal(registerType, name, new DelegateFactory(registerType, factory));
        }

        //-------------------------------------

        /// <summary>
        /// Creates/replaces a named container class registration with default options.
        /// </summary>
        /// <typeparam name="TRegisterType">Type to register</typeparam>
        /// <param name="name">Name of registration</param>
        /// <returns>RegisterOptions for fluent API</returns>
        public RegisterOptions Register<TRegisterType>(string name = null) where TRegisterType : class
        {
            return Register(typeof(TRegisterType), name);
        }

        /// <summary>
        /// Creates/replaces a named container class registration with a given implementation and default options.
        /// </summary>
        /// <typeparam name="TRegisterType">Type to register</typeparam>
        /// <typeparam name="TRegisterImplementation">Type to instantiate that implements RegisterType</typeparam>
        /// <param name="name">Name of registration</param>
        /// <returns>RegisterOptions for fluent API</returns>
        public RegisterOptions Register<TRegisterType, TRegisterImplementation>(string name = null)
            where TRegisterType : class
            where TRegisterImplementation : class, TRegisterType
        {
            return Register(typeof(TRegisterType), typeof(TRegisterImplementation), name);
        }

        /// <summary>
        /// Creates/replaces a named container class registration with a specific, strong referenced, instance.
        /// </summary>
        /// <typeparam name="TRegisterType">Type to register</typeparam>
        /// <param name="instance">Instance of RegisterType to register</param>
        /// <param name="name">Name of registration</param>
        /// <returns>RegisterOptions for fluent API</returns>
        public RegisterOptions Register<TRegisterType>(TRegisterType instance, string name = null)
            where TRegisterType : class
        {
            return Register(typeof(TRegisterType), instance, name);
        }

        /// <summary>
        /// Creates/replaces a named container class registration with a specific, strong referenced, instance.
        /// </summary>
        /// <typeparam name="TRegisterType">Type to register</typeparam>
        /// <typeparam name="TRegisterImplementation">Type of instance to register that implements RegisterType</typeparam>
        /// <param name="instance">Instance of RegisterImplementation to register</param>
        /// <param name="name">Name of registration</param>
        /// <returns>RegisterOptions for fluent API</returns>
        public RegisterOptions Register<TRegisterType, TRegisterImplementation>(TRegisterImplementation instance, string name = null)
            where TRegisterType : class
            where TRegisterImplementation : class, TRegisterType
        {
            return Register(typeof(TRegisterType), typeof(TRegisterImplementation), instance, name);
        }

        /// <summary>
        /// Creates/replaces a named container class registration with a user specified factory
        /// </summary>
        /// <typeparam name="TRegisterType">Type to register</typeparam>
        /// <param name="factory">Factory/lambda that returns an instance of RegisterType</param>
        /// <param name="name">Name of registration</param>
        /// <returns>RegisterOptions for fluent API</returns>
        public RegisterOptions Register<TRegisterType>(Func<TinyIoCContainer, NamedParameterOverloads, TRegisterType> factory, string name = null)
            where TRegisterType : class
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            return Register(typeof(TRegisterType), factory, name);
        }

        /// <summary>
        /// Register multiple implementations of a type.
        /// 
        /// Internally this registers each implementation using the full name of the class as its registration name.
        /// </summary>
        /// <typeparam name="TRegisterType">Type that each implementation implements</typeparam>
        /// <param name="implementationTypes">Types that implement RegisterType</param>
        /// <returns>MultiRegisterOptions for the fluent API</returns>
        public MultiRegisterOptions RegisterMultiple<TRegisterType>(IEnumerable<Type> implementationTypes)
        {
            return RegisterMultiple(typeof(TRegisterType), implementationTypes);
        }

        /// <summary>
        /// Register multiple implementations of a type.
        /// 
        /// Internally this registers each implementation using the full name of the class as its registration name.
        /// </summary>
        /// <param name="registrationType">Type that each implementation implements</param>
        /// <param name="implementationTypes">Types that implement RegisterType</param>
        /// <returns>MultiRegisterOptions for the fluent API</returns>
        public MultiRegisterOptions RegisterMultiple(Type registrationType, IEnumerable<Type> implementationTypes)
        {
            if (implementationTypes == null)
                throw new ArgumentNullException(nameof(implementationTypes), "types is null.");

            implementationTypes = implementationTypes.ToList();
            foreach (Type type in implementationTypes)
            {
                if (!registrationType.IsAssignableFrom(type))
                    throw new ArgumentException($"types: The type {registrationType.FullName} is not assignable from {type.FullName}");
            }

            if (implementationTypes.Count() != implementationTypes.Distinct().Count())
            {
                var queryForDuplicatedTypes = implementationTypes
                                             .GroupBy(i => i)
                                             .Where(j => j.Count() > 1)
                                             .Select(j => j.Key.FullName)
                                             .ToList();

                string fullNamesOfDuplicatedTypes = string.Join(",\n", queryForDuplicatedTypes.ToArray());
                string multipleRegMessage = $"types: The same implementation type cannot be specified multiple times for {registrationType.FullName}\n\n{fullNamesOfDuplicatedTypes}";
                throw new ArgumentException(multipleRegMessage);
            }

            var registerOptions = implementationTypes
                                 .Select(type => Register(registrationType, type, type.FullName))
                                 .ToList();

            return new MultiRegisterOptions(registerOptions);
        }

        /// <summary>
        /// Attempts to resolve a named type using specified options and the supplied constructor parameters.
        ///
        /// Parameters are used in conjunction with normal container resolution to find the most suitable constructor (if one exists).
        /// All user supplied parameters must exist in at least one resolvable constructor of RegisterType or resolution will fail.
        /// </summary>
        /// <param name="resolveType">Type to resolve</param>
        /// <param name="name">Name of registration</param>
        /// <param name="parameters">User specified constructor parameters</param>
        /// <param name="options">Resolution options</param>
        /// <returns>Instance of type</returns>
        /// <exception cref="TinyIoCResolutionException">Unable to resolve the type.</exception>
        public object Resolve(
            Type resolveType, 
            string name = null, 
            NamedParameterOverloads parameters = null, 
            ResolveOptions options = null)
        {
            name = name ?? string.Empty;
            parameters = parameters ?? NamedParameterOverloads.Default;
            options = options ?? ResolveOptions.Default;

            return ResolveInternal(new TypeRegistration(resolveType, name), parameters, options);
        }

        /// <summary>
        /// Attempts to resolve a named type using specified options and the supplied constructor parameters.
        ///
        /// Parameters are used in conjunction with normal container resolution to find the most suitable constructor (if one exists).
        /// All user supplied parameters must exist in at least one resolvable constructor of RegisterType or resolution will fail.
        /// </summary>
        /// <typeparam name="TResolveType">Type to resolve</typeparam>
        /// <param name="name">Name of registration</param>
        /// <param name="parameters">User specified constructor parameters</param>
        /// <param name="options">Resolution options</param>
        /// <returns>Instance of type</returns>
        /// <exception cref="TinyIoCResolutionException">Unable to resolve the type.</exception>
        public TResolveType Resolve<TResolveType>(
            string name = null, 
            NamedParameterOverloads parameters = null, 
            ResolveOptions options = null)
            where TResolveType : class
        {

            return (TResolveType)Resolve(typeof(TResolveType), name, parameters, options);
        }

        /// <summary>
        /// Attempts to predict whether a given named type can be resolved with the supplied constructor parameters options.
        ///
        /// Parameters are used in conjunction with normal container resolution to find the most suitable constructor (if one exists).
        /// All user supplied parameters must exist in at least one resolvable constructor of RegisterType or resolution will fail.
        /// 
        /// Note: Resolution may still fail if user defined factory registrations fail to construct objects when called.
        /// </summary>
        /// <param name="resolveType">Type to resolve</param>
        /// <param name="name">Name of registration</param>
        /// <param name="parameters">User supplied named parameter overloads</param>
        /// <param name="options">Resolution options</param>
        /// <returns>Bool indicating whether the type can be resolved</returns>
        public bool CanResolve(
            Type resolveType, 
            string name = null, 
            NamedParameterOverloads parameters = null, 
            ResolveOptions options = null)
        {
            name = name ?? string.Empty;
            parameters = parameters ?? NamedParameterOverloads.Default;
            options = options ?? ResolveOptions.Default;

            return CanResolveInternal(new TypeRegistration(resolveType, name), parameters, options);
        }

        /// <summary>
        /// Attempts to predict whether a given named type can be resolved with the supplied constructor parameters options.
        ///
        /// Parameters are used in conjunction with normal container resolution to find the most suitable constructor (if one exists).
        /// All user supplied parameters must exist in at least one resolvable constructor of RegisterType or resolution will fail.
        /// 
        /// Note: Resolution may still fail if user defined factory registrations fail to construct objects when called.
        /// </summary>
        /// <typeparam name="TResolveType">Type to resolve</typeparam>
        /// <param name="name">Name of registration</param>
        /// <param name="parameters">User supplied named parameter overloads</param>
        /// <param name="options">Resolution options</param>
        /// <returns>Bool indicating whether the type can be resolved</returns>
        public bool CanResolve<TResolveType>(
            string name = null, 
            NamedParameterOverloads parameters = null, 
            ResolveOptions options = null)
            where TResolveType : class
        {
            name       = name ?? string.Empty;
            parameters = parameters ?? NamedParameterOverloads.Default;
            options    = options ?? ResolveOptions.Default;

            return CanResolve(typeof(TResolveType), name, parameters, options);
        }

        /// <summary>
        /// Attempts to resolve a type using the supplied name, options and constructor parameters
        /// </summary>
        /// <param name="resolveType">Type to resolve</param>
        /// <param name="name">Name of registration</param>
        /// <param name="parameters">User specified constructor parameters</param>
        /// <param name="options">Resolution options</param>
        /// <param name="resolvedType">Resolved type or default if resolve fails</param>
        /// <returns>True if resolved successfully, false otherwise</returns>
        public bool TryResolve(
            Type resolveType,
            out object resolvedType,
            string name = null, 
            NamedParameterOverloads parameters = null, 
            ResolveOptions options = null)
        {
            try
            {
                resolvedType = Resolve(resolveType, name, parameters, options);
                return true;
            }
            catch (TinyIoCResolutionException)
            {
                resolvedType = null;
                return false;
            }
        }

        // -----------------------------------------------------

        /// <summary>
        /// Attempts to resolve a type using the supplied name, options and constructor parameters
        /// </summary>
        /// <typeparam name="TResolveType">Type to resolve</typeparam>
        /// <param name="name">Name of registration</param>
        /// <param name="parameters">User specified constructor parameters</param>
        /// <param name="options">Resolution options</param>
        /// <param name="resolvedType">Resolved type or default if resolve fails</param>
        /// <returns>True if resolved successfully, false otherwise</returns>
        public bool TryResolve<TResolveType>(
            out TResolveType resolvedType,
            string name = null, 
            NamedParameterOverloads parameters = null, 
            ResolveOptions options = null)
            where TResolveType : class
        {
            try
            {
                resolvedType = Resolve<TResolveType>(name, parameters, options);
                return true;
            }
            catch (TinyIoCResolutionException)
            {
                resolvedType = default;
                return false;
            }
        }

        /// <summary>
        /// Returns all registrations of a type
        /// </summary>
        /// <param name="resolveType">Type to resolveAll</param>
        /// <param name="includeUnnamed">Whether to include un-named (default) registrations</param>
        /// <returns>IEnumerable</returns>
        public IEnumerable<object> ResolveAll(Type resolveType, bool includeUnnamed = false)
        {
            return ResolveAllInternal(resolveType, includeUnnamed);
        }

        /// <summary>
        /// Returns all registrations of a type
        /// </summary>
        /// <typeparam name="TResolveType">Type to resolveAll</typeparam>
        /// <param name="includeUnnamed">Whether to include un-named (default) registrations</param>
        /// <returns>IEnumerable</returns>
        public IEnumerable<TResolveType> ResolveAll<TResolveType>(bool includeUnnamed = false)
            where TResolveType : class
        {
            return ResolveAll(typeof(TResolveType), includeUnnamed).Cast<TResolveType>();
        }

        /// <summary>
        /// Attempts to resolve all public property dependencies on the given object using the given resolve options.
        /// </summary>
        /// <param name="input">Object to "build up"</param>
        /// <param name="resolveOptions">Resolve options to use</param>
        public void BuildUp(object input, ResolveOptions resolveOptions = null)
        {
            resolveOptions = resolveOptions ?? ResolveOptions.Default;

            BuildUpInternal(input, resolveOptions);
        }


        /// <summary>
        /// Provides custom lifetime management for ASP.Net per-request lifetimes etc.
        /// </summary>
        public interface ITinyIoCObjectLifetimeProvider
        {
            /// <summary>
            /// Gets the stored object if it exists, or null if not
            /// </summary>
            /// <returns>Object instance or null</returns>
            object GetObject();

            /// <summary>
            /// Store the object
            /// </summary>
            /// <param name="value">Object to store</param>
            void SetObject(object value);

            /// <summary>
            /// Release the object
            /// </summary>
            void ReleaseObject();
        }

        private abstract class ObjectFactoryBase
        {
            /// <summary>
            /// Whether to assume this factory successfully constructs its objects
            /// 
            /// Generally set to true for delegate style factories as CanResolve cannot delve
            /// into the delegates they contain.
            /// </summary>
            public virtual bool AssumeConstruction => false;

            /// <summary>
            /// The type the factory instantiates
            /// </summary>
            public abstract Type CreatesType { get; }

            /// <summary>
            /// Constructor to use, if specified
            /// </summary>
            public ConstructorInfo Constructor { get; protected set; }

            /// <summary>
            /// Create the type
            /// </summary>
            /// <param name="requestedType">Type user requested to be resolved</param>
            /// <param name="container">Container that requested the creation</param>
            /// <param name="parameters">Any user parameters passed</param>
            /// <param name="options"></param>
            /// <returns></returns>
            public abstract object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options);

            public virtual ObjectFactoryBase SingletonVariant => throw new TinyIoCRegistrationException(GetType(), "singleton");
            public virtual ObjectFactoryBase MultiInstanceVariant => throw new TinyIoCRegistrationException(GetType(), "multi-instance");
            public virtual ObjectFactoryBase StrongReferenceVariant => throw new TinyIoCRegistrationException(GetType(), "strong reference");
            public virtual ObjectFactoryBase WeakReferenceVariant => throw new TinyIoCRegistrationException(GetType(), "weak reference");

            public virtual ObjectFactoryBase GetCustomObjectLifetimeVariant(ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorString)
            {
                throw new TinyIoCRegistrationException(GetType(), errorString);
            }

            public virtual void SetConstructor(ConstructorInfo constructor)
            {
                Constructor = constructor;
            }

            public virtual ObjectFactoryBase GetFactoryForChildContainer(Type type, TinyIoCContainer parent, TinyIoCContainer child)
            {
                return this;
            }
        }

        /// <summary>
        /// IObjectFactory that creates new instances of types for each resolution
        /// </summary>
        private class MultiInstanceFactory : ObjectFactoryBase
        {
            private readonly Type _registerType;
            private readonly Type _registerImplementation;
            public override Type CreatesType => _registerImplementation;

            public MultiInstanceFactory(Type registerType, Type registerImplementation)
            {
                if (registerImplementation.IsAbstract || registerImplementation.IsInterface)
                    throw new TinyIoCRegistrationTypeException(registerImplementation, "MultiInstanceFactory");
                if (!IsValidAssignment(registerType, registerImplementation))
                    throw new TinyIoCRegistrationTypeException(registerImplementation, "MultiInstanceFactory");

                _registerType           = registerType;
                _registerImplementation = registerImplementation;
            }

            public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
            {
                try
                {
                    return container.ConstructType(requestedType, _registerImplementation, Constructor, parameters, options);
                }
                catch (TinyIoCResolutionException ex)
                {
                    throw new TinyIoCResolutionException(_registerType, ex);
                }
            }

            public override ObjectFactoryBase SingletonVariant => new SingletonFactory(_registerType, _registerImplementation);
            public override ObjectFactoryBase MultiInstanceVariant => this;

            public override ObjectFactoryBase GetCustomObjectLifetimeVariant(ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorString)
            {
                return new CustomObjectLifetimeFactory(_registerType, _registerImplementation, lifetimeProvider, errorString);
            }
        }

        /// <summary>
        /// IObjectFactory that invokes a specified delegate to construct the object
        /// </summary>
        private class DelegateFactory : ObjectFactoryBase
        {
            private readonly Type _registerType;
            private readonly Func<TinyIoCContainer, NamedParameterOverloads, object> _factory;
            public override bool AssumeConstruction => true;
            public override Type CreatesType => _registerType;

            public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
            {
                try
                {
                    return _factory.Invoke(container, parameters);
                }
                catch (Exception ex)
                {
                    throw new TinyIoCResolutionException(_registerType, ex);
                }
            }

            public DelegateFactory(Type registerType, Func<TinyIoCContainer, NamedParameterOverloads, object> factory)
            {
                _factory = factory ?? throw new ArgumentNullException(nameof(factory));

                _registerType = registerType;
            }

            public override ObjectFactoryBase WeakReferenceVariant => new WeakDelegateFactory(_registerType, _factory);
            public override ObjectFactoryBase StrongReferenceVariant => this;

            public override void SetConstructor(ConstructorInfo constructor)
            {
                throw new TinyIoCConstructorResolutionException("Constructor selection is not possible for delegate factory registrations");
            }
        }

        /// <summary>
        /// IObjectFactory that invokes a specified delegate to construct the object
        /// Holds the delegate using a weak reference
        /// </summary>
        private class WeakDelegateFactory : ObjectFactoryBase
        {
            private readonly Type _registerType;
            private readonly WeakReference _factory;
            public override bool AssumeConstruction => true;
            public override Type CreatesType => _registerType;

            public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
            {
                if (!(_factory.Target is Func<TinyIoCContainer, NamedParameterOverloads, object> factory))
                    throw new TinyIoCWeakReferenceException(_registerType);

                try
                {
                    return factory.Invoke(container, parameters);
                }
                catch (Exception ex)
                {
                    throw new TinyIoCResolutionException(_registerType, ex);
                }
            }

            public WeakDelegateFactory(Type registerType, Func<TinyIoCContainer, NamedParameterOverloads, object> factory)
            {
                if (factory == null)
                    throw new ArgumentNullException(nameof(factory));

                _factory = new WeakReference(factory);

                _registerType = registerType;
            }

            public override ObjectFactoryBase StrongReferenceVariant
            {
                get
                {
                    if (!(_factory.Target is Func<TinyIoCContainer, NamedParameterOverloads, object> factory))
                        throw new TinyIoCWeakReferenceException(_registerType);

                    return new DelegateFactory(_registerType, factory);
                }
            }

            public override ObjectFactoryBase WeakReferenceVariant => this;

            public override void SetConstructor(ConstructorInfo constructor)
            {
                throw new TinyIoCConstructorResolutionException("Constructor selection is not possible for delegate factory registrations");
            }
        }

        /// <summary>
        /// Stores an particular instance to return for a type
        /// </summary>
        private class InstanceFactory : ObjectFactoryBase, IDisposable
        {
            private readonly Type _registerType;
            private readonly Type _registerImplementation;
            private readonly object _instance;

            public override bool AssumeConstruction => true;

            public InstanceFactory(Type registerType, Type registerImplementation, object instance)
            {
                if (!IsValidAssignment(registerType, registerImplementation))
                    throw new TinyIoCRegistrationTypeException(registerImplementation, "InstanceFactory");

                _registerType           = registerType;
                _registerImplementation = registerImplementation;
                _instance               = instance;
            }

            public override Type CreatesType => _registerImplementation;

            public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
            {
                return _instance;
            }

            public override ObjectFactoryBase MultiInstanceVariant => new MultiInstanceFactory(_registerType, _registerImplementation);
            public override ObjectFactoryBase WeakReferenceVariant => new WeakInstanceFactory(_registerType, _registerImplementation, _instance);
            public override ObjectFactoryBase StrongReferenceVariant => this;

            public override void SetConstructor(ConstructorInfo constructor)
            {
                throw new TinyIoCConstructorResolutionException("Constructor selection is not possible for instance factory registrations");
            }

            public void Dispose()
            {
                if (_instance is IDisposable disposable)
                    disposable.Dispose();
            }
        }

        /// <summary>
        /// Stores an particular instance to return for a type
        /// 
        /// Stores the instance with a weak reference
        /// </summary>
        private class WeakInstanceFactory : ObjectFactoryBase, IDisposable
        {
            private readonly Type _registerType;
            private readonly Type _registerImplementation;
            private readonly WeakReference _instance;

            public WeakInstanceFactory(Type registerType, Type registerImplementation, object instance)
            {
                if (!IsValidAssignment(registerType, registerImplementation))
                    throw new TinyIoCRegistrationTypeException(registerImplementation, "WeakInstanceFactory");

                _registerType           = registerType;
                _registerImplementation = registerImplementation;
                _instance               = new WeakReference(instance);
            }

            public override Type CreatesType => _registerImplementation;

            public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
            {
                object instance = _instance.Target;

                if (instance == null)
                    throw new TinyIoCWeakReferenceException(_registerType);

                return instance;
            }

            public override ObjectFactoryBase MultiInstanceVariant => new MultiInstanceFactory(_registerType, _registerImplementation);
            public override ObjectFactoryBase WeakReferenceVariant => this;

            public override ObjectFactoryBase StrongReferenceVariant
            {
                get
                {
                    object instance = _instance.Target;

                    if (instance == null)
                        throw new TinyIoCWeakReferenceException(_registerType);

                    return new InstanceFactory(_registerType, _registerImplementation, instance);
                }
            }

            public override void SetConstructor(ConstructorInfo constructor)
            {
                throw new TinyIoCConstructorResolutionException("Constructor selection is not possible for instance factory registrations");
            }

            public void Dispose()
            {
                if (_instance.Target is IDisposable disposable)
                    disposable.Dispose();
            }
        }

        /// <summary>
        /// A factory that lazy instantiates a type and always returns the same instance
        /// </summary>
        private class SingletonFactory : ObjectFactoryBase, IDisposable
        {
            private readonly Type _registerType;
            private readonly Type _registerImplementation;
            private readonly object _singletonLock = new object();
            private object _current;

            public SingletonFactory(Type registerType, Type registerImplementation)
            {
                if (registerImplementation.IsAbstract || registerImplementation.IsInterface)
                    throw new TinyIoCRegistrationTypeException(registerImplementation, "SingletonFactory");

                if (!IsValidAssignment(registerType, registerImplementation))
                    throw new TinyIoCRegistrationTypeException(registerImplementation, "SingletonFactory");

                _registerType           = registerType;
                _registerImplementation = registerImplementation;
            }

            public override Type CreatesType => _registerImplementation;

            public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
            {
                if (parameters.Count != 0)
                    throw new ArgumentException("Cannot specify parameters for singleton types");

                lock (_singletonLock)
                    if (_current == null)
                        _current = container.ConstructType(requestedType, _registerImplementation, Constructor, options);

                return _current;
            }

            public override ObjectFactoryBase SingletonVariant => this;
            public override ObjectFactoryBase MultiInstanceVariant => new MultiInstanceFactory(_registerType, _registerImplementation);

            public override ObjectFactoryBase GetCustomObjectLifetimeVariant(ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorString)
            {
                return new CustomObjectLifetimeFactory(_registerType, _registerImplementation, lifetimeProvider, errorString);
            }

            public override ObjectFactoryBase GetFactoryForChildContainer(Type type, TinyIoCContainer parent, TinyIoCContainer child)
            {
                // We make sure that the singleton is constructed before the child container takes the factory.
                // Otherwise the results would vary depending on whether or not the parent container had resolved
                // the type before the child container does.
                GetObject(type, parent, NamedParameterOverloads.Default, ResolveOptions.Default);
                return this;
            }

            public void Dispose()
            {
                if (_current is IDisposable disposable)
                    disposable.Dispose();
            }
        }

        /// <summary>
        /// A factory that offloads lifetime to an external lifetime provider
        /// </summary>
        private class CustomObjectLifetimeFactory : ObjectFactoryBase, IDisposable
        {
            private readonly object _singletonLock = new object();
            private readonly Type _registerType;
            private readonly Type _registerImplementation;
            private readonly ITinyIoCObjectLifetimeProvider _lifetimeProvider;

            public CustomObjectLifetimeFactory(Type registerType, Type registerImplementation, ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorMessage)
            {
                if (!IsValidAssignment(registerType, registerImplementation))
                    throw new TinyIoCRegistrationTypeException(registerImplementation, "SingletonFactory");

                if (registerImplementation.IsAbstract || registerImplementation.IsInterface)
                    throw new TinyIoCRegistrationTypeException(registerImplementation, errorMessage);

                _registerType           = registerType;
                _registerImplementation = registerImplementation;
                _lifetimeProvider       = lifetimeProvider ?? throw new ArgumentNullException(nameof(lifetimeProvider), "lifetimeProvider is null.");
            }

            public override Type CreatesType => _registerImplementation;

            public override object GetObject(Type requestedType, TinyIoCContainer container, NamedParameterOverloads parameters, ResolveOptions options)
            {
                object current;

                lock (_singletonLock)
                {
                    current = _lifetimeProvider.GetObject();
                    if (current == null)
                    {
                        current = container.ConstructType(requestedType, _registerImplementation, Constructor, options);
                        _lifetimeProvider.SetObject(current);
                    }
                }

                return current;
            }

            public override ObjectFactoryBase SingletonVariant
            {
                get
                {
                    _lifetimeProvider.ReleaseObject();
                    return new SingletonFactory(_registerType, _registerImplementation);
                }
            }

            public override ObjectFactoryBase MultiInstanceVariant
            {
                get
                {
                    _lifetimeProvider.ReleaseObject();
                    return new MultiInstanceFactory(_registerType, _registerImplementation);
                }
            }

            public override ObjectFactoryBase GetCustomObjectLifetimeVariant(ITinyIoCObjectLifetimeProvider lifetimeProvider, string errorString)
            {
                _lifetimeProvider.ReleaseObject();
                return new CustomObjectLifetimeFactory(_registerType, _registerImplementation, lifetimeProvider, errorString);
            }

            public override ObjectFactoryBase GetFactoryForChildContainer(Type type, TinyIoCContainer parent, TinyIoCContainer child)
            {
                // We make sure that the singleton is constructed before the child container takes the factory.
                // Otherwise the results would vary depending on whether or not the parent container had resolved
                // the type before the child container does.
                GetObject(type, parent, NamedParameterOverloads.Default, ResolveOptions.Default);
                return this;
            }

            public void Dispose()
            {
                _lifetimeProvider.ReleaseObject();
            }
        }

        static TinyIoCContainer() { }

        /// <summary>
        /// Lazy created Singleton instance of the container for simple scenarios
        /// </summary>
        public static TinyIoCContainer Current { get; } = new TinyIoCContainer();

        public sealed class TypeRegistration
        {
            private readonly int _hashCode;

            public Type Type { get; }
            public string Name { get; }

            public TypeRegistration(Type type)
                : this(type, string.Empty) { }

            public TypeRegistration(Type type, string name)
            {
                Type = type;
                Name = name;

                _hashCode = string.Concat(Type.FullName, "|", Name).GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is TypeRegistration typeRegistration))
                    return false;

                if (Type != typeRegistration.Type)
                    return false;

                if (string.Compare(Name, typeRegistration.Name, StringComparison.Ordinal) != 0)
                    return false;

                return true;
            }

            public override int GetHashCode()
            {
                return _hashCode;
            }
        }

        private readonly SafeDictionary<TypeRegistration, ObjectFactoryBase> _registeredTypes;
        private delegate object ObjectConstructor(params object[] parameters);
        private static readonly SafeDictionary<ConstructorInfo, ObjectConstructor> ObjectConstructorCache = new SafeDictionary<ConstructorInfo, ObjectConstructor>();

        public TinyIoCContainer()
        {
            _registeredTypes = new SafeDictionary<TypeRegistration, ObjectFactoryBase>();
            RegisterDefaultTypes();
        }

        private readonly TinyIoCContainer _parent;

        private TinyIoCContainer(TinyIoCContainer parent) : this()
        {
            _parent = parent;
        }

        private readonly object _autoRegisterLock = new object();

        private void AutoRegisterInternal(IEnumerable<Assembly> assemblies, DuplicateImplementationActions duplicateAction, Func<Type, bool> registrationPredicate)
        {
            lock (_autoRegisterLock)
            {
                var types = assemblies.SelectMany(a => a.SafeGetTypes())
                                      .Where(t => !IsIgnoredType(t, registrationPredicate))
                                      .ToList();

                var concreteTypes = types
                                   .Where(
                                        type => type.IsClass && 
                                        type.IsAbstract == false && 
                                        type != GetType() && 
                                        type.DeclaringType != GetType() && 
                                        !type.IsGenericTypeDefinition)
                                   .ToList();

                foreach (Type type in concreteTypes)
                {
                    try
                    {
                        RegisterInternal(type, string.Empty, GetDefaultObjectFactory(type, type));
                    }
                    catch (MethodAccessException)
                    {
                        // Ignore methods we can't access
                    }
                }

                var abstractInterfaceTypes = types
                                            .Where(
                                                 type => (type.IsInterface || type.IsAbstract) &&
                                                     type.DeclaringType != GetType() &&
                                                     !type.IsGenericTypeDefinition)
                                            .ToList();

                foreach (Type type in abstractInterfaceTypes)
                {
                    Type localType = type;
                    var implementations = concreteTypes.Where(implementationType => localType.IsAssignableFrom(implementationType))
                                                       .ToList();

                    if (implementations.Count > 1)
                    {
                        if (duplicateAction == DuplicateImplementationActions.Fail)
                            throw new TinyIoCAutoRegistrationException(type, implementations);

                        if (duplicateAction == DuplicateImplementationActions.RegisterMultiple)
                        {
                            RegisterMultiple(type, implementations);
                        }
                    }

                    Type firstImplementation = implementations.FirstOrDefault();
                    if (firstImplementation != null)
                    {
                        try
                        {
                            RegisterInternal(type, string.Empty, GetDefaultObjectFactory(type, firstImplementation));
                        }
                        catch (MethodAccessException)
                        {
                            // Ignore methods we can't access
                        }
                    }
                }
            }
        }

        private bool IsIgnoredAssembly(Assembly assembly)
        {
            // TODO - find a better way to remove "system" assemblies from the auto registration
            var ignoreChecks = new List<Func<Assembly, bool>>
            {
                asm => asm.FullName.StartsWith("Microsoft.", StringComparison.Ordinal),
                asm => asm.FullName.StartsWith("System.", StringComparison.Ordinal),
                asm => asm.FullName.StartsWith("System,", StringComparison.Ordinal),
                asm => asm.FullName.StartsWith("CR_ExtUnitTest", StringComparison.Ordinal),
                asm => asm.FullName.StartsWith("mscorlib,", StringComparison.Ordinal),
                asm => asm.FullName.StartsWith("CR_VSTest", StringComparison.Ordinal),
                asm => asm.FullName.StartsWith("DevExpress.CodeRush", StringComparison.Ordinal),
            };

            foreach (var check in ignoreChecks)
            {
                if (check(assembly))
                    return true;
            }

            return false;
        }

        private bool IsIgnoredType(Type type, Func<Type, bool> registrationPredicate)
        {
            // TODO - find a better way to remove "system" types from the auto registration
            var ignoreChecks = new List<Func<Type, bool>>
            {
                t => t.FullName?.StartsWith("System.", StringComparison.Ordinal) ?? false,
                t => t.FullName?.StartsWith("Microsoft.", StringComparison.Ordinal) ?? false,
                t => t.IsPrimitive,
                t => t.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length == 0 && !(t.IsInterface || t.IsAbstract)
            };

            if (registrationPredicate != null)
                ignoreChecks.Add(t => !registrationPredicate(t));

            foreach (var check in ignoreChecks)
            {
                if (check(type))
                    return true;
            }

            return false;
        }

        private void RegisterDefaultTypes()
        {
            Register(this);

#if TINYMESSENGER
            // Only register the TinyMessenger singleton if we are the root container
            if (_parent == null)
                Register<TinyMessenger.ITinyMessengerHub, TinyMessenger.TinyMessengerHub>();
#endif
        }

        private ObjectFactoryBase GetCurrentFactory(TypeRegistration registration)
        {
            _registeredTypes.TryGetValue(registration, out ObjectFactoryBase current);
            return current;
        }

        private RegisterOptions RegisterInternal(Type registerType, string name, ObjectFactoryBase factory)
        {
            name = name ?? string.Empty;
            if (factory == null)
                factory = GetDefaultObjectFactory(registerType, registerType);
            TypeRegistration typeRegistration = new TypeRegistration(registerType, name);

            return AddUpdateRegistration(typeRegistration, factory);
        }

        private RegisterOptions AddUpdateRegistration(TypeRegistration typeRegistration, ObjectFactoryBase factory)
        {
            _registeredTypes[typeRegistration] = factory;
            return new RegisterOptions(this, typeRegistration);
        }

        private void RemoveRegistration(TypeRegistration typeRegistration)
        {
            _registeredTypes.Remove(typeRegistration);
        }

        private ObjectFactoryBase GetDefaultObjectFactory(Type registerType, Type registerImplementation)
        {
            if (registerType.IsInterface || registerType.IsAbstract)
                return new SingletonFactory(registerType, registerImplementation);

            return new MultiInstanceFactory(registerType, registerImplementation);
        }

        private bool CanResolveInternal(TypeRegistration registration, NamedParameterOverloads parameters, ResolveOptions options)
        {
            if (parameters == null)
                throw new ArgumentNullException(nameof(parameters));

            Type checkType = registration.Type;
            string name = registration.Name;

            if (_registeredTypes.TryGetValue(new TypeRegistration(checkType, name), out ObjectFactoryBase factory))
            {
                if (factory.AssumeConstruction)
                    return true;

                if (factory.Constructor == null)
                    return GetBestConstructor(factory.CreatesType, parameters, options) != null;
                return CanConstruct(factory.Constructor, parameters, options);
            }

            if (checkType.IsInterface && checkType.IsGenericType)
            {
                // if the type is registered as an open generic, then see if the open generic is registered
                if (_registeredTypes.TryGetValue(new TypeRegistration(checkType.GetGenericTypeDefinition(), name), out factory))
                {
                    if (factory.AssumeConstruction)
                        return true;

                    if (factory.Constructor == null)
                        return GetBestConstructor(factory.CreatesType, parameters, options) != null;
                    return CanConstruct(factory.Constructor, parameters, options);
                }
            }

            // Fail if requesting named resolution and settings set to fail if unresolved
            // Or bubble up if we have a parent
            if (!string.IsNullOrEmpty(name) && options.NamedResolutionFailureAction == NamedResolutionFailureActions.Fail)
                return (_parent != null) ? _parent.CanResolveInternal(registration, parameters, options) : false;

            // Attempted unnamed fallback container resolution if relevant and requested
            if (!string.IsNullOrEmpty(name) && options.NamedResolutionFailureAction == NamedResolutionFailureActions.AttemptUnnamedResolution)
            {
                if (_registeredTypes.TryGetValue(new TypeRegistration(checkType), out factory))
                {
                    if (factory.AssumeConstruction)
                        return true;

                    return GetBestConstructor(factory.CreatesType, parameters, options) != null;
                }
            }

            // Check if type is an automatic lazy factory request
            if (IsAutomaticLazyFactoryRequest(checkType))
                return true;

            // Check if type is an IEnumerable<ResolveType>
            if (IsIEnumerableRequest(registration.Type))
                return true;

            // Attempt unregistered construction if possible and requested
            // If we cant', bubble if we have a parent
            if ((options.UnregisteredResolutionAction == UnregisteredResolutionActions.AttemptResolve) ||
                (checkType.IsGenericType && options.UnregisteredResolutionAction == UnregisteredResolutionActions.GenericsOnly))
            {
                return GetBestConstructor(checkType, parameters, options) != null ||
                    (_parent?.CanResolveInternal(registration, parameters, options) ?? false);
            }

            // Bubble resolution up the container tree if we have a parent
            return _parent?.CanResolveInternal(registration, parameters, options) ?? false;
        }

        private bool IsIEnumerableRequest(Type type)
        {
            if (!type.IsGenericType)
                return false;

            return type.GetGenericTypeDefinition() == typeof(IEnumerable<>);
        }

        private bool IsAutomaticLazyFactoryRequest(Type type)
        {
            if (!type.IsGenericType)
                return false;

            Type genericType = type.GetGenericTypeDefinition();

            // Just a func
            if (genericType == typeof(Func<>))
                return true;

            // 2 parameter func with string as first parameter (name)
            if ((genericType == typeof(Func<,>) && type.GetGenericArguments()[0] == typeof(string)))
                return true;

            // 3 parameter func with string as first parameter (name) and IDictionary<string, object> as second (parameters)
            if ((genericType == typeof(Func<,,>) && 
                type.GetGenericArguments()[0] == typeof(string) && 
                type.GetGenericArguments()[1] == typeof(IDictionary<string, object>)))
                return true;

            return false;
        }

        private ObjectFactoryBase GetParentObjectFactory(TypeRegistration registration)
        {
            if (_parent == null)
                return null;

            if (_parent._registeredTypes.TryGetValue(registration, out ObjectFactoryBase factory))
                return factory.GetFactoryForChildContainer(registration.Type, _parent, this);

            return _parent.GetParentObjectFactory(registration);
        }

        private object ResolveInternal(TypeRegistration registration, NamedParameterOverloads parameters, ResolveOptions options)
        {
            // Attempt container resolution
            if (_registeredTypes.TryGetValue(registration, out ObjectFactoryBase factory))
            {
                try
                {
                    return factory.GetObject(registration.Type, this, parameters, options);
                }
                catch (TinyIoCResolutionException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw new TinyIoCResolutionException(registration.Type, ex);
                }
            }

            // Attempt container resolution of open generic
            if (registration.Type.IsGenericType)
            {
                TypeRegistration openTypeRegistration = new TypeRegistration(
                    registration.Type.GetGenericTypeDefinition(),
                    registration.Name);

                if (_registeredTypes.TryGetValue(openTypeRegistration, out factory))
                {
                    try
                    {
                        return factory.GetObject(registration.Type, this, parameters, options);
                    }
                    catch (TinyIoCResolutionException)
                    {
                        throw;
                    }
                    catch (Exception ex)
                    {
                        throw new TinyIoCResolutionException(registration.Type, ex);
                    }
                }
            }

            // Attempt to get a factory from parent if we can
            ObjectFactoryBase bubbledObjectFactory = GetParentObjectFactory(registration);
            if (bubbledObjectFactory != null)
            {
                try
                {
                    return bubbledObjectFactory.GetObject(registration.Type, this, parameters, options);
                }
                catch (TinyIoCResolutionException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw new TinyIoCResolutionException(registration.Type, ex);
                }
            }

            // Fail if requesting named resolution and settings set to fail if unresolved
            if (!string.IsNullOrEmpty(registration.Name) && options.NamedResolutionFailureAction == NamedResolutionFailureActions.Fail)
                throw new TinyIoCResolutionException(registration.Type);

            // Attempted unnamed fallback container resolution if relevant and requested
            if (!string.IsNullOrEmpty(registration.Name) && options.NamedResolutionFailureAction == NamedResolutionFailureActions.AttemptUnnamedResolution)
            {
                if (_registeredTypes.TryGetValue(new TypeRegistration(registration.Type, string.Empty), out factory))
                {
                    try
                    {
                        return factory.GetObject(registration.Type, this, parameters, options);
                    }
                    catch (TinyIoCResolutionException)
                    {
                        throw;
                    }
                    catch (Exception ex)
                    {
                        throw new TinyIoCResolutionException(registration.Type, ex);
                    }
                }
            }

            // Attempt to construct an automatic lazy factory if possible
            if (IsAutomaticLazyFactoryRequest(registration.Type))
                return GetLazyAutomaticFactoryRequest(registration.Type);
            if (IsIEnumerableRequest(registration.Type))
                return GetIEnumerableRequest(registration.Type);

            // Attempt unregistered construction if possible and requested
            if ((options.UnregisteredResolutionAction == UnregisteredResolutionActions.AttemptResolve) || 
                (registration.Type.IsGenericType && options.UnregisteredResolutionAction == UnregisteredResolutionActions.GenericsOnly))
            {
                if (!registration.Type.IsAbstract && !registration.Type.IsInterface)
                    return ConstructType(null, registration.Type, parameters, options);
            }

            // Unable to resolve - throw
            throw new TinyIoCResolutionException(registration.Type);
        }

        private object GetLazyAutomaticFactoryRequest(Type type)
        {
            if (!type.IsGenericType)
                return null;

            Type genericType = type.GetGenericTypeDefinition();
            Type[] genericArguments = type.GetGenericArguments();

            // Just a func
            if (genericType == typeof(Func<>))
            {
                Type returnType = genericArguments[0];

                MethodInfo resolveMethod = typeof(TinyIoCContainer).GetMethod("Resolve", new Type[] { });
                if (resolveMethod == null)
                    throw new ArgumentException("TinyIoCContainer does not contain Resolve method");

                resolveMethod = resolveMethod.MakeGenericMethod(returnType);

                MethodCallExpression resolveCall = Expression.Call(Expression.Constant(this), resolveMethod);
                Delegate resolveLambda = Expression.Lambda(resolveCall).Compile();

                return resolveLambda;
            }

            // 2 parameter func with string as first parameter (name)
            if ((genericType == typeof(Func<,>)) && (genericArguments[0] == typeof(string)))
            {
                Type returnType = genericArguments[1];

                MethodInfo resolveMethod = typeof(TinyIoCContainer).GetMethod("Resolve", new Type[] {typeof(string)});
                resolveMethod = resolveMethod.MakeGenericMethod(returnType);

                var resolveParameters = new []{ Expression.Parameter(typeof(string), "name") };
                MethodCallExpression resolveCall = Expression.Call(Expression.Constant(this), resolveMethod, resolveParameters);

                Delegate resolveLambda = Expression.Lambda(resolveCall, resolveParameters).Compile();

                return resolveLambda;
            }

            // 3 parameter func with string as first parameter (name) and IDictionary<string, object> as second (parameters)
            if ((genericType == typeof(Func<,,>) && type.GetGenericArguments()[0] == typeof(string) && type.GetGenericArguments()[1] == typeof(IDictionary<string, object>)))
            {
                Type returnType = genericArguments[2];

                ParameterExpression name = Expression.Parameter(typeof(string), "name");
                ParameterExpression parameters = Expression.Parameter(typeof(IDictionary<string, object>), "parameters");

                MethodInfo resolveMethod = typeof(TinyIoCContainer).GetMethod("Resolve", new [] {typeof(string), typeof(NamedParameterOverloads)});
                resolveMethod = resolveMethod.MakeGenericMethod(returnType);

                MethodCallExpression resolveCall = Expression.Call(Expression.Constant(this), resolveMethod, name, Expression.Call(typeof(NamedParameterOverloads), "FromIDictionary", null, parameters));
                Delegate resolveLambda = Expression.Lambda(resolveCall, name, parameters).Compile();
                return resolveLambda;
            }

            throw new TinyIoCResolutionException(type);
        }

        private object GetIEnumerableRequest(Type type)
        {
            MethodInfo genericResolveAllMethod = GetType().GetGenericMethod(BindingFlags.Public | BindingFlags.Instance, "ResolveAll", type.GetGenericArguments(), new[] {typeof(bool)});
            return genericResolveAllMethod.Invoke(this, new object[] {false});
        }

        private bool CanConstruct(ConstructorInfo ctor, NamedParameterOverloads parameters, ResolveOptions options)
        {
            if (parameters == null)
                throw new ArgumentNullException(nameof(parameters));

            foreach (ParameterInfo parameter in ctor.GetParameters())
            {
                if (string.IsNullOrEmpty(parameter.Name))
                    return false;

                bool isParameterOverload = parameters.ContainsKey(parameter.Name);

                if (parameter.ParameterType.IsPrimitive && !isParameterOverload)
                    return false;

                if (!isParameterOverload && !CanResolveInternal(new TypeRegistration(parameter.ParameterType), NamedParameterOverloads.Default, options))
                    return false;
            }

            return true;
        }

        private ConstructorInfo GetBestConstructor(Type type, NamedParameterOverloads parameters, ResolveOptions options)
        {
            if (parameters == null)
                throw new ArgumentNullException(nameof(parameters));

            if (type.IsValueType)
                return null;

            // Get constructors in reverse order based on the number of parameters
            // i.e. be as "greedy" as possible so we satisfy the most amount of dependencies possible
            var ctors = GetTypeConstructors(type);

            foreach (ConstructorInfo ctor in ctors)
            {
                if (CanConstruct(ctor, parameters, options))
                    return ctor;
            }

            return null;
        }

        private IEnumerable<ConstructorInfo> GetTypeConstructors(Type type)
        {
            return type.GetConstructors().OrderByDescending(ctor => ctor.GetParameters().Count());
        }

        private object ConstructType(Type requestedType, Type implementationType, ResolveOptions options)
        {
            return ConstructType(requestedType, implementationType, null, NamedParameterOverloads.Default, options);
        }

        private object ConstructType(Type requestedType, Type implementationType, ConstructorInfo constructor, ResolveOptions options)
        {
            return ConstructType(requestedType, implementationType, constructor, NamedParameterOverloads.Default, options);
        }

        private object ConstructType(Type requestedType, Type implementationType, NamedParameterOverloads parameters, ResolveOptions options)
        {
            return ConstructType(requestedType, implementationType, null, parameters, options);
        }

        private object ConstructType(Type requestedType, Type implementationType, ConstructorInfo constructor, NamedParameterOverloads parameters, ResolveOptions options)
        {
            Type typeToConstruct = implementationType;

            if (implementationType.IsGenericTypeDefinition)
            {
                if (requestedType == null || !requestedType.IsGenericType || !requestedType.GetGenericArguments().Any())
                    throw new TinyIoCResolutionException(typeToConstruct);

                typeToConstruct = typeToConstruct.MakeGenericType(requestedType.GetGenericArguments());
            }

            if (constructor == null)
            {
                // Try and get the best constructor that we can construct
                // if we can't construct any then get the constructor
                // with the least number of parameters so we can throw a meaningful
                // resolve exception
                constructor = GetBestConstructor(typeToConstruct, parameters, options) ?? GetTypeConstructors(typeToConstruct).LastOrDefault();
            }

            if (constructor == null)
                throw new TinyIoCResolutionException(typeToConstruct);

            ParameterInfo[] ctorParams = constructor.GetParameters();
            object[] args = new object[ctorParams.Length];

            for (int parameterIndex = 0; parameterIndex < ctorParams.Length; parameterIndex++)
            {
                ParameterInfo currentParam = ctorParams[parameterIndex];

                try
                {
                    args[parameterIndex] = parameters.ContainsKey(currentParam.Name)
                        ? parameters[currentParam.Name]
                        : ResolveInternal(
                            new TypeRegistration(currentParam.ParameterType),
                            NamedParameterOverloads.Default,
                            options);
                }
                catch (TinyIoCResolutionException ex)
                {
                    // If a constructor parameter can't be resolved
                    // it will throw, so wrap it and throw that this can't
                    // be resolved.
                    throw new TinyIoCResolutionException(typeToConstruct, ex);
                }
                catch (Exception ex)
                {
                    throw new TinyIoCResolutionException(typeToConstruct, ex);
                }
            }

            try
            {
                ObjectConstructor constructionDelegate = CreateObjectConstructionDelegateWithCache(constructor);
                return constructionDelegate.Invoke(args);
            }
            catch (Exception ex)
            {
                throw new TinyIoCResolutionException(typeToConstruct, ex);
            }
        }

        private static ObjectConstructor CreateObjectConstructionDelegateWithCache(ConstructorInfo constructor)
        {
            if (ObjectConstructorCache.TryGetValue(constructor, out ObjectConstructor objectConstructor))
                return objectConstructor;

            // We could lock the cache here, but there's no real side
            // effect to two threads creating the same ObjectConstructor
            // at the same time, compared to the cost of a lock for 
            // every creation.
            ParameterInfo[] constructorParams = constructor.GetParameters();
            ParameterExpression lambdaParams = Expression.Parameter(typeof(object[]), "parameters");
            Expression[] newParams = new Expression[constructorParams.Length];

            for (int i = 0; i < constructorParams.Length; i++)
            {
                BinaryExpression paramsParameter = Expression.ArrayIndex(lambdaParams, Expression.Constant(i));

                newParams[i] = Expression.Convert(paramsParameter, constructorParams[i].ParameterType);
            }

            NewExpression newExpression = Expression.New(constructor, newParams);

            LambdaExpression constructionLambda = Expression.Lambda(typeof(ObjectConstructor), newExpression, lambdaParams);

            objectConstructor = (ObjectConstructor)constructionLambda.Compile();

            ObjectConstructorCache[constructor] = objectConstructor;
            return objectConstructor;
        }

        private void BuildUpInternal(object input, ResolveOptions resolveOptions)
        {
            IEnumerable<PropertyInfo> properties = from property in input.GetType().GetProperties()
                where (property.GetGetMethod() != null) && (property.GetSetMethod() != null) && !property.PropertyType.IsValueType
                select property;

            foreach (PropertyInfo property in properties)
            {
                if (property.GetValue(input, null) == null)
                {
                    try
                    {
                        property.SetValue(input, ResolveInternal(new TypeRegistration(property.PropertyType), NamedParameterOverloads.Default, resolveOptions), null);
                    }
                    catch (TinyIoCResolutionException)
                    {
                        // Catch any resolution errors and ignore them
                    }
                }
            }
        }

        private IEnumerable<TypeRegistration> GetParentRegistrationsForType(Type resolveType)
        {
            if (_parent == null)
                return new TypeRegistration[] { };

            IEnumerable<TypeRegistration> registrations = _parent._registeredTypes.Keys.Where(tr => tr.Type == resolveType);

            return registrations.Concat(_parent.GetParentRegistrationsForType(resolveType));
        }

        private IEnumerable<object> ResolveAllInternal(Type resolveType, bool includeUnnamed)
        {
            IEnumerable<TypeRegistration> registrations = _registeredTypes.Keys.Where(tr => tr.Type == resolveType).Concat(GetParentRegistrationsForType(resolveType));

            if (!includeUnnamed)
                registrations = registrations.Where(tr => tr.Name != string.Empty);

            return registrations.Select(registration => ResolveInternal(registration, NamedParameterOverloads.Default, ResolveOptions.Default));
        }

        private static bool IsValidAssignment(Type registerType, Type registerImplementation)
        {
            if (!registerType.IsGenericTypeDefinition)
            {
                if (!registerType.IsAssignableFrom(registerImplementation))
                    return false;
            }
            else
            {
                if (registerType.IsInterface)
                {
                    if (!registerImplementation.FindInterfaces((t, o) => t.Name == registerType.Name, null).Any())
                        return false;
                }
                else if (registerType.IsAbstract && registerImplementation.BaseType != registerType)
                {
                    return false;
                }
            }

            return true;
        }

        private bool _disposed;

        public void Dispose()
        {
            if (_disposed) return;

            _disposed = true;
            _registeredTypes.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
