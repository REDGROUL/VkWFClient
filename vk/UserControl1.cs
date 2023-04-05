using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Model.RequestParams;

namespace vk
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            VKAuth vka = new VKAuth();
            var api = vka.TokenAuth(TokenWorker.LoadToken());
          

            var getHistory = api.Messages.GetHistory(new MessagesGetHistoryParams
            {
                UserId = api.UserId,
            });
        }
    }
}
