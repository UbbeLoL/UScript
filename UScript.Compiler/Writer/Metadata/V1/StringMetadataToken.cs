﻿using System;
using System.IO;

namespace UScript.Compiler.Writer.Metadata.V1
{
    public sealed class StringMetadataToken : IMetadataToken
    {
        public long TokenBase => 0x20000000;
        public long RawToken { get; set; }

        public void WriteTo(Stream dest)
        {
            dest.Write(BitConverter.GetBytes(RawToken), 0, sizeof(long));
        }

        public override string ToString()
        {
            return RawToken.ToString("X4");
        }
    }
}