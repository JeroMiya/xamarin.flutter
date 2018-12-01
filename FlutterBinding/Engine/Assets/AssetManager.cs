using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlutterBinding.Engine.Assets
{

    public class AssetManager : AssetResolver
    {
        public void PushFront(AssetResolver resolver)
        {
            if (resolver == null || !resolver.IsValid())
                return;

            resolvers_.Insert(0, resolver);
        }

        public void PushBack(AssetResolver resolver)
        {
            if (resolver == null || !resolver.IsValid())
                return;

            resolvers_.Add(resolver);
        }

        // |blink::AssetResolver|
        public bool IsValid() => resolvers_.Any();

        // |blink::AssetResolver|
        public Mapping GetAsMapping(string asset_name)
        {
            if (string.IsNullOrWhiteSpace(asset_name))
                return null;

            //TRACE_EVENT1("flutter", "AssetManager::GetAsMapping", "name", asset_name);
            foreach (var resolver in resolvers_)
            {
                var mapping = resolver.GetAsMapping(asset_name);
                if (mapping != null)
                    return mapping;
            }

            //FML_DLOG(WARNING) << "Could not find asset: " << asset_name;
            return null;

        }

        private List<AssetResolver> resolvers_ = new List<AssetResolver>();

        //FML_DISALLOW_COPY_AND_ASSIGN(AssetManager);
    }

    public interface AssetResolver
    {
        bool IsValid();

        //FML_WARN_UNUSED_RESULT
        Mapping GetAsMapping(string asset_name);

        //FML_DISALLOW_COPY_AND_ASSIGN(AssetResolver);
    }

}
