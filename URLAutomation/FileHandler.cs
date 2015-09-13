using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLAutomation
{
    
    class FileHandler
    {
       public string[] urlArray;
        public void ReadURLFile()
        {
           string fileName= "c:\\users\\somukher\\documents\\visual studio 2013\\Projects\\URLAutomation\\URLAutomation\\ListOfURLs.txt";
            //string fileName = "ListOfURLs.txt";
            // string textLine = "";
            // Read each line of the file into a string array. Each element 
        // of the array is one line of the file. 
            urlArray = System.IO.File.ReadAllLines(fileName);

            //this.StoreURL(urlArray);

           // throw new System.NotImplementedException();
        }

        public void StoreURL(string [] urlArray)

        {
            foreach (string line in urlArray)
            {
                // Use a tab to indent each line of the file.
                //Console.WriteLine("\t" + line);

            }


            throw new System.NotImplementedException();
        }
    }
}
