using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Simple_TextEditor
{
     class DocumentLoadSave
    {
        // filename reference
        public static string filename;

        // complete load

        public static string LoadDocument()
        {
            // check if filename has been set
            if (filename == null || filename.Length < 1) throw new Exception("No filename set");
            // create buffer
            StringBuilder buffer = new StringBuilder();
            // reader object
            StreamReader reader = new StreamReader(filename);
            // read first line of file
            string line = reader.ReadLine();
            // read remainder of file
            // store read data in buffer
            while (line != null)
            {
                buffer.Append(line + Environment.NewLine);
                line = reader.ReadLine();
            }
            reader.Close();
            return buffer.ToString();
        }

        //complete a save
        public static void SaveDocument(string data)
        {
            if (filename == null || filename.Length < 1) throw new Exception("No filename set");
            StreamWriter writer = new StreamWriter(filename);
            // write data to file
            // assume data contains new lines
            writer.Write(data);
            writer.Close();
        }
    }
}
