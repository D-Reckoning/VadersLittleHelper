using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using VadersLittleHelper.BackEnd.ObjectTypes;

namespace VadersLittleHelper.Backend.dbClasses
{
    public static class BinaryReader
    {
        public static void WriteToFile(string relativePath, dynamic data)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(GetFullPath(relativePath), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static dynamic ReadFromFile(string relativePath)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(GetFullPath(relativePath), FileMode.Open, FileAccess.Read, FileShare.Read);
            dynamic data = formatter.Deserialize(stream);
            stream.Close();

            return data;
        }

        private static string GetFullPath(string relativePath)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string filename = Path.GetFullPath(Path.Combine(basePath, relativePath));

            return filename;
        }
    }
}
