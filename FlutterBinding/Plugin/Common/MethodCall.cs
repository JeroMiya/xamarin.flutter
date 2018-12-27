using System.Collections;
using System.Collections.Generic;

namespace FlutterBinding.Plugin.Common
{
    /**
     * Command object representing a method call on a {@link MethodChannel}.
     */
    public sealed class MethodCall
    {
        /// The name of the called method.
        public string Method { get; }

        /**
         * Arguments for the call.
         *
         * <p>Consider using {@link #arguments()} for cases where a particular run-time type is expected.
         * Consider using {@link #argument(String)} when that run-time type is {@link Map} or
         * {@link JSONObject}.</p>
         */
        public object Arguments { get; }

        /**
         * Creates a {@link MethodCall} with the specified method name and arguments.
         *
         * @param method the method name String, not null.
         * @param arguments the arguments, a value supported by the channel's message codec.
         */
        public MethodCall(string method, object arguments)
        {
            //assert method != null;
            Method    = method;
            Arguments = arguments;
        }

        /**
         * Returns the arguments of this method call with a static type determined by the call-site.
         *
         * @param <T> the intended type of the arguments.
         * @return the arguments with static type T
         */
        //@SuppressWarnings("unchecked")
        public T GetArguments<T>() where T : class
        {
            return (T)Arguments;
        }

        /**
         * Returns a String-keyed argument of this method call, assuming {@link #arguments} is a
         * {@link Map} or a {@link JSONObject}. The static type of the returned result is determined
         * by the call-site.
         *
         * @param <T> the intended type of the argument.
         * @param key the String key.
         * @return the argument value at the specified key, with static type T, or {@code null}, if
         * such an entry is not present.
         * @throws ClassCastException if {@link #arguments} can be cast to neither {@link Map} nor
         * {@link JSONObject}.
         */
        //@SuppressWarnings("unchecked")
        //@Nullable
        public T Argument<T>(string key) where T : class
        {
            if (Arguments == null)
                return null;

            if (Arguments is IDictionary dict)
                return (T)dict[key];

            //if (Arguments is JSONObject jsonObject)
            //    return (T)jsonObject.Opt(key);

            throw new KeyNotFoundException(key);
        }

        /**
         * Returns whether this method call involves a mapping for the given argument key,
         * assuming {@link #arguments} is a {@link Map} or a {@link JSONObject}. The value associated
         * with the key, as returned by {@link #argument(String)}, is not considered, and may be
         * {@code null}.
         *
         * @param key the String key.
         * @return {@code true}, if {@link #arguments} is a {@link Map} containing key, or a
         * {@link JSONObject} with a mapping for key.
         * @throws ClassCastException if {@link #arguments} can be cast to neither {@link Map} nor
         * {@link JSONObject}.
         */
        public bool HasArgument(string key)
        {
            if (Arguments == null)
                return false;

            if (Arguments is IDictionary dict)
                return dict.Contains(key);

            //if (arguments is JSONObject jsonObj)
            //    return (jsonObj).Has(key);

            throw new KeyNotFoundException(key);
        }
    }
}
