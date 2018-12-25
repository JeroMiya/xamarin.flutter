using System.IO;

namespace FlutterBinding.Engine.Assets
{
    public class DirectoryAssetBundle : AssetResolver
    {
        private readonly string _path;

        public DirectoryAssetBundle(string path)
        {
            _path = path;
        }
        /// <inheritdoc />
        public bool IsValid() => Directory.Exists(_path);

        /// <inheritdoc />
        public Mapping GetAsMapping(string asset_name)
        {
            var filename = Path.Combine(_path, asset_name);
            var contents = File.ReadAllBytes(filename);
            return new DataMapping(contents);
        }
    }
}
