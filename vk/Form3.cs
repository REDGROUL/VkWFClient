using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace vk
{
    public partial class Form3 : MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
           
            
            var materialSkinManager1 = MaterialSkinManager.Instance;
            materialSkinManager1.AddFormToManage(this);
            materialSkinManager1.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager1.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900,
            Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);
            
        }

       

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
             DialogResult = DialogResult.OK;
        }
    }
}
