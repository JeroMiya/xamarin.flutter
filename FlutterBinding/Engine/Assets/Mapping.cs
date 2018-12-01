using System;

namespace FlutterBinding.Engine.Assets
{
    public interface Mapping
    {
        long GetSize();
        byte[] GetMapping();

        //FML_DISALLOW_COPY_AND_ASSIGN(Mapping);
    };

    public class FileMapping : Mapping
    {
        [Flags]
        public enum Protection
        {
            Read = 0x01,
            Write = 0x02,
            Execute = 0x04
        };

        public FileMapping(string fd, Protection protection = Protection.Read)
        {
            _mapping = System.IO.File.ReadAllBytes(fd);
            _size = _mapping?.Length ?? 0;
        }

        public long GetSize() => _size;
        public byte[] GetMapping() => _mapping;
        public byte[] GetMutableMapping() => _mutableMapping = (_mutableMapping ?? (byte[])_mapping.Clone());

        private readonly long _size = 0;
        private readonly byte[] _mapping = null;
        private byte[] _mutableMapping = null;

        //#if OS_WIN
        //fml::UniqueFD mapping_handle_;
        //#endif

        //FML_DISALLOW_COPY_AND_ASSIGN(FileMapping);
    };

    public class DataMapping : Mapping
    {
        public DataMapping(byte[] data)
        {
            _data = data;
        }

        public long GetSize() => _data.Length;
        public byte[] GetMapping() => _data;

        private readonly byte[] _data;

        //FML_DISALLOW_COPY_AND_ASSIGN(DataMapping);
    }

    public class NonOwnedMapping : Mapping
    {
        public NonOwnedMapping(byte[] data, long size)
        {
            _data = data;
            _size = size;
        }
    
        public long GetSize() => _size;
        public byte[] GetMapping() => _data;

        private readonly byte[] _data;
        private readonly long _size;

        //FML_DISALLOW_COPY_AND_ASSIGN(NonOwnedMapping);
    }
}
