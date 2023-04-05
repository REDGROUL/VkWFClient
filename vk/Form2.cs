using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using VkNet.Enums.Filters;
using VkNet;
using System.IO;
using Application = System.Windows.Forms.Application;
using VkNet.Model.RequestParams;
using VkNet.Abstractions;
using System.IO.Packaging;
using Newtonsoft.Json;
//using  = System.Windows.Forms.Application;

namespace vk
{
    public partial class Form2 : MaterialForm
    {
        public dynamic Api;

        long? Id;
        public Form2(VkApi api)
        {

            
            InitializeComponent();
            Api = api;
            Id = api.UserId;
           

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900,
            Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);
            var p = api.Users.Get(new string[] { }, ProfileFields.All).FirstOrDefault();
            
            
           
            uName.Text = p.FirstName+" "+ p.LastName;
            Status.Text = Convert.ToString(p.Status);
            if (p.City != null)
            {
                Info.Text = p.City.Title.ToString();
            }
            else {
                Info.Text = "Город не указан";
            }



            


            //online.Text = Convert.ToString(p.LastSeen);
            //Lastname.Text = p.LastName;


            pictureBox1.ImageLocation = p.Photo200.ToString();
            /* if (token != "")
             {
                 VKAuth vka = new VKAuth();

                 vka.TokenAuth(token);


             }*/

            
        }
        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_Click(object sender, EventArgs e)
        {
            // File.Delete(TokenWorker.GetTokenFile());


            // f1.Show();
            


        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            File.Delete(TokenWorker.GetTokenFile());
            Application.Restart();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
           
        }

        public void FriendsList(FlowLayoutPanel flowLayoutPanel1)
        {
            VKAuth vka = new VKAuth();

            var api = vka.TokenAuth(TokenWorker.LoadToken());
            var users = api.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams
            {

                Fields = ProfileFields.All,

            }); ;


            foreach (var item in users)
            {

                UserControl1 uc1 = new UserControl1();
                uc1.label1.Text = item.FirstName + " " + item.LastName;
                uc1.pictureBox1.ImageLocation = item.Photo200.ToString();
                flowLayoutPanel1.Controls.Add(uc1);

            }
        }

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {

            /* foreach (var item in users)
                    {

                        UserControl1 uc1 = new UserControl1();
                        uc1.label1.Text = item.FirstName + " " + item.LastName;
                        uc1.pictureBox1.ImageLocation = item.Photo200.ToString();
                        this.flowLayoutPanel1.Controls.Add(uc1);

                    }*/

          
            


           
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex == 3)
            {
                new Thread(() => {


                    Action action = () =>
                    {
                        VKAuth vka = new VKAuth();
                        var api = vka.TokenAuth(TokenWorker.LoadToken());
                        var users = api.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams
                        {

                            Fields = ProfileFields.All

                        });
                        SplitContainer sc1 = new SplitContainer();
                        sc1.Dock = DockStyle.Fill;
                        foreach (var item in users)
                        {

                            UserControl1 uc1 = new UserControl1();

                            // MessageBox.Show(item.FirstName);
                            uc1.label1.Text = item.FirstName + " " + item.LastName;
                           uc1.pictureBox1.ImageLocation = item.Photo200.ToString();
                            uc1.label2.Text = item.Id.ToString();
                           // MessageBox.Show(item.Id.ToString());
                            this.flowLayoutPanel1.Controls.Add(uc1);




                        }
                    };
                    Invoke(action);







                }).Start();
            }
        }
    }
}
