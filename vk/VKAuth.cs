using MaterialSkin;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace vk
{
    internal class VKAuth 
    {
        public void ClassicAuth(string login, string password)
        {
          
            var api = new VkApi();
            api.Authorize(new ApiAuthParams
            {
                ApplicationId = 51581716,
                Login = login,
                Password = password,
                Settings = Settings.All,
                TwoFactorAuthorization = () =>
                {
                    Form3 f3 = new Form3();
                    string d = " ";
                    if (f3.ShowDialog() == DialogResult.OK)
                    {
                        d = f3.Code.Text;
                    }
                    return d;
                }
            });

           

            
            TokenWorker.SaveToken(api.Token);

            Form2 f2 = new Form2(api);
            f2.Show();

        }

        public dynamic TokenAuth(string token)
        {
            var api = new VkApi();

            api.Authorize(new ApiAuthParams
            {
                AccessToken = token
            });
            try
            {
                var p = api.Users.Get(new string[] { }, ProfileFields.All).FirstOrDefault();
            }
            catch {
                MessageBox.Show("Пожалуйста авторизуйтесь снова");

                File.Delete(TokenWorker.GetTokenFile());
                Form1 f1 = new Form1();
                f1.Show();
                return false;
            }
            

            return api;


            


        }

    }
}
