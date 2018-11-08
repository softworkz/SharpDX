using System;
using System.Runtime.InteropServices;

namespace SharpDX.MediaFoundation.DirectX
{
    [StructLayout(LayoutKind.Sequential, Size = 0x10)]
    struct _GUID
    {
        public Int32 Data1;
        public Int16 Data2;
        public Int16 Data3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] Data4;

        public Guid ToGuid()
        {
           return new Guid(this.Data1, this.Data2, this.Data3, this.Data4);
        }

        public static _GUID FromGuid(Guid guid)
        {
            _GUID  newGuid  = new _GUID();
            byte[] guidData = guid.ToByteArray();
            newGuid.Data1 = BitConverter.ToInt32(guidData, 0);
            newGuid.Data2 = BitConverter.ToInt16(guidData, 4);
            newGuid.Data3 = BitConverter.ToInt16(guidData, 6);
            newGuid.Data4 = new byte[8];
            Array.Copy(guidData, 8, newGuid.Data4, 0, 8);
            return newGuid;
        }
    }}
