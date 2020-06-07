using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace EmployeeManagementSystem
{
    /// <summary>
    /// A class for reading values by section and key from a standard ".ini" initialization file.

    public class iniFile
    {
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
        private static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        // Declare the unmanaged functions.
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);



        //The path of the file we are operating on.
        private static string m_path;
        public const int MaxSectionSize = 32767; // 32 KB
        public static string sDefault = "";
        StringBuilder buffer = new StringBuilder(MaxSectionSize);

        public iniFile(string path)
        {
            //Convert to the full path.  Because of backward compatibility, 
            // the win32 functions tend to assume the path should be the 
            // root Windows directory if it is not specified.  By calling 
            // GetFullPath, we make sure we are always passing the full path
            // the win32 functions.
            m_path = System.IO.Path.GetFullPath(path);

        }

        public void WriteValue(string sectionName, string keyName, string value)
        {
            // Write a new value.
            WritePrivateProfileString(sectionName, keyName, value, m_path);
        }
        public string ReadValue(string sectionName, string keyName)
        {
            if (GetPrivateProfileString(sectionName, keyName, sDefault, buffer, MaxSectionSize, m_path) != 0)
            {
                return buffer.ToString();
            }
            else
            {
                return "";
            }
        }

        public Boolean UpdateValue(string FileName, string value)
        {
            try
            {
                string Text = File.ReadAllText(FileName);
                const string PATTERN = "(= |=)[a-zA-Z0-9]+";
                Match match = Regex.Match(Text, PATTERN);

                if (match.Success)
                {

                    int index = match.Index;
                    int length = match.Length;

                    Text = Text.Remove(index, length);
                    Text = Text.Insert(index, "=" + value);

                    File.WriteAllText(FileName, Text);
                    return (true);
                }
                else
                {
                   // AppendLog.LogFile(1, "Could not Find Value PATTERN. " + PATTERN);
                    return (false);
                }


            }
            

            catch (Exception e)
            {
               // AppendLog.LogFile(1, "Could not Update Value. " + e.ToString());
                return (false);

            }
        }
    }
}
