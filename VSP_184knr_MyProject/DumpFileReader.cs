using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSP_184knr_MyProject
{
    public class DumpFileReader
    {
        //Метод, който посредством File.ReadAllText(filePath), чете цялото съдържание на дъмп файла.
        public void MethodForReadingDumpFile(string filePath)
        {
            try
            {
                string dumpContent = File.ReadAllText(filePath);

                //И извежда съдържанието на файла на конзолата.
                Console.WriteLine(dumpContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}