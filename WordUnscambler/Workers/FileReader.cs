using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WordUnscambler.Workers
{
    public class FileReader
    {
        public string[] Read(string filename)
        {
            string[] fileContent;
            try
            {
                fileContent = File.ReadAllLines(filename);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return fileContent;
        }
    }
}
