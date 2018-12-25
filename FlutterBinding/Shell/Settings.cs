namespace FlutterBinding.Shell
{
    public class Settings
    {
        // VM settings
        //public string vm_snapshot_data_path;
        //public string vm_snapshot_instr_path;
        //public string isolate_snapshot_data_path;
        //public string isolate_snapshot_instr_path;

        //public string application_library_path;
        //public string application_kernel_asset;
        //public string application_kernel_list_asset;

        //public string main_dart_file_path;
        //public string packages_file_path;

        //public string temp_directory_path;
        //public List<string> dart_flags;

        // Isolate settings
        //public bool start_paused = false;
        //public bool trace_skia = false;
        //public bool trace_startup = false;
        //public bool endless_trace_buffer = false;
        //public bool enable_dart_profiling = false;
        //public bool dart_non_checked_mode = false;
        // Used as the script URI in debug messages. Does not affect how the Dart code
        // is executed.
        //public string advisory_script_uri = "main.dart";
        // Used as the script entrypoint in debug messages. Does not affect how the
        // Dart code is executed.
        //public string advisory_script_entrypoint = "main";

        // Observatory settings
        //public bool enable_observatory = false;
        // Port on target will be auto selected by the OS. A message will be printed
        // on the target with the port after it has been selected.
        //public UInt32 observatory_port = 0;
        //public bool ipv6 = false;

        // Font settings
        public bool UseTestFonts = false;

        // Engine settings
        //public TaskObserverAdd task_observer_add;
        //public TaskObserverRemove task_observer_remove;
        // The main isolate is current when this callback is made. This is a good spot
        // to perform native Dart bindings for libraries not built in.
        //public closure root_isolate_create_callback;
        // The isolate is not current and may have already been destroyed when this
        // call is made.
        //public closure root_isolate_shutdown_callback;
        //public bool enable_software_rendering = false;
        //public bool skia_deterministic_rendering_on_cpu = false;
        //public bool verbose_logging = false;
        //public string log_tag = "flutter";
        //public string icu_data_path;

        // Assets settings
        public string AssetsDir = null;
        public string AssetsPath = null;
        //public string flx_path;
    }
}
