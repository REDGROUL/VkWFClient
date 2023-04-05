using System.Windows.Forms;
using VkNet;
using VkNet.Abstractions;
using VkNet.Enums.Filters;
using VkNet.Infrastructure.Authorization.ImplicitFlow;
using VkNet.Model;
using VkNet.Model.RequestParams;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using VkNet.AudioBypassService.Extensions;
using Microsoft.Extensions.DependencyInjection;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Security.Cryptography.X509Certificates;

namespace vk
{
    public partial class Form1 : MaterialForm
    {
        dynamic api = new VkApi();
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900,
            Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);

        }


        public void materialButton1_Click(object sender, EventArgs e)
        {

            VKAuth vka = new VKAuth();

            

            
            vka.ClassicAuth(Login.Text, Password.Text);
        }


        public void NewFormRender(dynamic p)
        {
           // Form2 f = new Form2();
            /*  if (Convert.ToString(p.Sex) == "Male")
              {
                  var s = "Мужской";
                  f.Sex.Text = s;

              }
              else if (Convert.ToString(p.Sex) == "Female")
              {
                  var s = "Женский";
                  f.Sex.Text = s;
              }
              else
              {
                  var s = "Не указан";
                  f.Sex.Text = s;
              }
              f.Show();
              f.Firstname.Text = p.FirstName;
              f.Lastname.Text = p.LastName;
              f.Birthday.Text = p.BirthDate;
              f.Hometown.Text = p.HomeTown;
              f.Status.Text = p.Status;
              f.pictureBox1.ImageLocation = Convert.ToString(p.Photo200);
              f.Photo.Text = Convert.ToString(p.Counters.Photos);
              f.Friends.Text = Convert.ToString(p.Counters.Friends);
              f.Video.Text = Convert.ToString(p.Counters.Videos);
              f.ID.Text = Convert.ToString("ID " + p.ScreenName);
            
            if (Convert.ToString(p.OnlineMobile) == "True")
            {
                var onof = "online";
                f.OnOf.Text = onof;
            }
            else if (Convert.ToString(p.OnlineMobile) == "False")
            {
                var onof = "offline";
                f.OnOf.Text = onof;
            }


            if (Convert.ToString(p.Online) == "True")
            {
                var onof = "D.online";
                f.OnOf2.Text = onof;
            }
            else if (Convert.ToString(p.Online) == "False")
            {
                var onof = "D.offline";
                f.OnOf2.Text = onof;
            }

            ProfileFields pf = ProfileFields.FirstName | ProfileFields.LastName;
            var users = api.Friends.Get(new FriendsGetParams { UserId = api.UserId, Fields = pf });
            foreach (var friends in users)
            {
                f.listBox1.Items.Add(friends.Id + " " + friends.FirstName + " " + friends.LastName);

            }*/
        }


        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void Login_TextChanged(object sender, EventArgs e)
        {

        }

        public void Password_TextChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Login_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void Password_TextChanged_1(object sender, EventArgs e)
        {

        }

      
    }
}