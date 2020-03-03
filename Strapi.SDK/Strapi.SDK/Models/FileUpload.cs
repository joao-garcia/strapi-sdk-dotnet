using System.Collections.Generic;
using System.IO;

namespace Strapi.SDK
{
    public class FileUpload
    {
        public FileUpload(Stream stream, string fileName, List<FormData> formData)
        {
            Stream = stream;
            FileName = fileName;
            FormData = formData;
        }

        public Stream Stream { get; private set; }

        public string FileName { get; private set; }

        public List<FormData> FormData { get; private set; }
    }
}