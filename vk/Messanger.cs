using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;

namespace vk
{
    public partial class Messanger : Form
    {
        public Messanger(VkApi api)
        {
            InitializeComponent();

            var p = api.Users.Get(new string[] { }, ProfileFields.All).FirstOrDefault();

           

            pictureBox1.ImageLocation = p.Photo400Orig.ToString();

            label1.Text = p.FirstName + " " + p.LastName;

            var getLists = api.Friends.GetLists();

            
            foreach (var item in getLists)
            {
                UserControl1 uc = new UserControl1();
                //uc.label1.Text = item.Name;
            }

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
