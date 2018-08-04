// github https://github.com/Syy12345-Unity/EasyOutput 
using System.IO;
using System.Text;
using UnityEngine;

namespace Syy {
    public static class EasyOutput
    {
        private static StringBuilder _stringBuilder = new StringBuilder();
        public static void Append(string str)
        {
            _stringBuilder.Append(str);
        }

        public static void AppendLine(string str)
        {
            _stringBuilder.AppendLine(str);
        }

        public static void AppendFormat(string format, params object[] args)
        {
            _stringBuilder.AppendFormat(format, args);
        }

        public static void AppendFormatLine(string format, params object[] args)
        {
            _stringBuilder.AppendFormat(format, args);
            _stringBuilder.AppendLine("");
        }

        public static void Clear()
        {
            _stringBuilder = new StringBuilder();
        }

        public static void Output(string fileNameWithExtention = "output.txt")
        {
            string output = _stringBuilder.ToString();
            StreamWriter writer = new StreamWriter("Assets/" + fileNameWithExtention, false);
            writer.Write(output);
            writer.Close();

            Debug.Log(output);
        }
    }

}
