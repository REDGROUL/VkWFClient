namespace vk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Login = new MaterialSkin.Controls.MaterialTextBox();
            this.Password = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(209, 212);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(135, 39);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Войти";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Login
            // 
            this.Login.AnimateReadOnly = false;
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login.Depth = 0;
            this.Login.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Login.Hint = "Логин";
            this.Login.LeadingIcon = null;
            this.Login.Location = new System.Drawing.Point(110, 83);
            this.Login.MaxLength = 50;
            this.Login.MouseState = MaterialSkin.MouseState.OUT;
            this.Login.Multiline = false;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(342, 50);
            this.Login.TabIndex = 1;
            this.Login.Text = "";
            this.Login.TrailingIcon = null;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged_1);
            // 
            // Password
            // 
            this.Password.AnimateReadOnly = false;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Depth = 0;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Password.Hint = "Пароль";
            this.Password.LeadingIcon = null;
            this.Password.Location = new System.Drawing.Point(110, 153);
            this.Password.MaxLength = 50;
            this.Password.MouseState = MaterialSkin.MouseState.OUT;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.Password = true;
            this.Password.Size = new System.Drawing.Size(342, 50);
            this.Password.TabIndex = 2;
            this.Password.Text = "";
            this.Password.TrailingIcon = null;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 300);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.materialButton1);
            this.Name = "Form1";
            this.Text = "vk.net";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox Login;
        private MaterialSkin.Controls.MaterialTextBox Password;
    }
}