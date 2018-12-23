using System.Collections.Generic;

namespace Flutter.Shell.Droid.Plugin.Platform
{
    /**
     * Registry for platform view factories.
     * <p>
     * Plugins can register factories for specific view types.
     */
    public interface IPlatformViewRegistry
    {
        /**
         * Registers a factory for a platform view.
         *
         * @param viewTypeId unique identifier for the platform view's type.
         * @param factory    factory for creating platform views of the specified type.
         * @return true if succeeded, false if a factory is already registered for viewTypeId.
         */
        bool RegisterViewFactory(string viewTypeId, PlatformViewFactory factory);
    }

    public class PlatformViewRegistryImpl : IPlatformViewRegistry
    {
        public PlatformViewRegistryImpl()
        {
            _viewFactories = new Dictionary<string, PlatformViewFactory>();
        }

        // Maps a platform view type id to its factory.
        private readonly Dictionary<string, PlatformViewFactory> _viewFactories;

        //@Override
        public bool RegisterViewFactory(string viewTypeId, PlatformViewFactory factory)
        {
            if (_viewFactories.ContainsKey(viewTypeId))
                return false;
            _viewFactories[viewTypeId] = factory;
            return true;
        }

        public PlatformViewFactory GetFactory(string viewTypeId)
        {
            return _viewFactories[viewTypeId];
        }
    }

}