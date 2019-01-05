using System;
using System.Collections.Generic;
using System.Text;

namespace FlutterBinding.Plugin.Platform
{
    public interface IAssetAccess
    {
        string GetLookupKeyForAsset(string asset, string packageName);
        string GetLookupKeyForAsset(string asset);
    }
}
