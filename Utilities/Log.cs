
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Log
    {
        static object lockObj = new object();

        public static void Write2Log(string msg)
        {


            lock (lockObj)
            {
                try
                {

                    DateTime now = DateTime.Now;
                    msg = now + " " + msg;
                    string fullPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;


                    string fileName = fullPath + ".log";
                    if (File.Exists(fileName) != true)
                    {
                        using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
                        {
                            sw.WriteLine(msg);
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Open, FileAccess.Write)))
                        {
                            (sw.BaseStream).Seek(0, SeekOrigin.End);
                            sw.WriteLine(msg);
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    
                }
            }
        }
    }
}
