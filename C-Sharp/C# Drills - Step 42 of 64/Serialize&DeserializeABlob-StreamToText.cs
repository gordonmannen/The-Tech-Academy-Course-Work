// Serialization of an object - BLOB (Binary Large Object).  The object should be
// streamed to a text file.  Show also the retrieval of the object from that file and
// conversion back to its original form.

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Test;

namespace BlobToSerialize
{
    class Program
    {
        FileStream fs = File.Open(BlobToSerialize.img, FileMode.CreateNew, FileAccess.Write);
    }

    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8));
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Test;

namespace BlobToDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(fs, System.Encoding.img));
        }
    }
}