using System;

namespace pattern_decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // var data = "This is uploading data.";
            var cloudStream = new CloudStream();
            var compressStream = new CompressCloudStream(cloudStream);
            var encryptStream = new EncryptedCloudStream(compressStream);
            
            // encryptStream.Write(data);
            WriteCreditCard(compressStream);
        }

        static void WriteCreditCard(Stream stream) {
            stream.Write("1234-1234-1234-1234");
        }
    }
}
