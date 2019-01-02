using Flutter.Shell.Droid.View;

namespace Flutter.Shell.Droid.Plugin.Common
{
    /**
     * Registry used by plugins to set up interaction with Android APIs.
     *
     * <p>Flutter applications by default include an auto-generated and auto-updated
     * plugin registrant class (GeneratedPluginRegistrant) that makes use of a
     * {@link PluginRegistry} to register contributions from each plugin mentioned
     * in the application's pubspec file. The generated registrant class is, again
     * by default, called from the application's main {@link Activity}, which
     * defaults to an instance of {@link io.flutter.app.FlutterActivity}, itself a
     * {@link PluginRegistry}.</p>
     */
    public interface IPluginRegistry
    {
        /**
         * Returns a {@link Registrar} for receiving the registrations pertaining
         * to the specified plugin.
         *
         * @param pluginKey a unique String identifying the plugin; typically the
         * fully qualified name of the plugin's main class.
         */
        IRegistrar RegistrarFor(string pluginKey);

        /**
         * Returns whether the specified plugin is known to this registry.
         *
         * @param pluginKey a unique String identifying the plugin; typically the
         * fully qualified name of the plugin's main class.
         * @return true if this registry has handed out a registrar for the
         * specified plugin.
         */
        bool HasPlugin(string pluginKey);

        /**
         * Returns the value published by the specified plugin, if any.
         *
         * <p>Plugins may publish a single value, such as an instance of the
         * plugin's main class, for situations where external control or
         * interaction is needed. Clients are expected to know the value's
         * type.</p>
         *
         * @param pluginKey a unique String identifying the plugin; typically the
         * fully qualified name of the plugin's main class.
         * @return the published value, possibly null.
         */
        T ValuePublishedByPlugin<T>(string pluginKey);
    }

    /// <summary>
    /// Delegate interface for handling user leave hints on behalf of the main {@link Activity}.
    /// </summary>
    public interface IUserLeaveHintListener
    {
        void OnUserLeaveHint();
    }

    /**
     * Delegate interface for handling an {@link Activity}'s onDestroy
     * method being called. A plugin that implements this interface can
     * adopt the FlutterNativeView by retaining a reference and returning true.
     */
    public interface IViewDestroyListener
    {
        bool OnViewDestroy(FlutterNativeView view);
    }

    /**
     * Callback interface for registering plugins with a plugin registry.
     *
     * <p>For example, an Application may use this callback interface to
     * provide a background service with a callback for calling its
     * GeneratedPluginRegistrant.registerWith method.</p>
     */
    public interface IPluginRegistrantCallback
    {
        void RegisterWith(IPluginRegistry registry);
    }
}
