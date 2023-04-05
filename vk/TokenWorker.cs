using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vk
{
    internal class TokenWorker
    {

        private const string TokenFile = "AuthData.oi";

        static public void SaveToken(string token)
        {
            using (StreamWriter fstream = new StreamWriter(TokenFile, true))
            {
                fstream.WriteLine(token);
            }

        }

        static public dynamic LoadToken()
        {

            if (File.Exists(TokenFile))
            {
                using (StreamReader fstream = new StreamReader(TokenFile, true))
                {
                    return fstream.ReadToEnd();
                }
            }
            else
            {
                return "nope";
            }

        }

        static public string GetTokenFile()
        {
            return TokenFile;
        }
    }
}
