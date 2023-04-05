namespace vk
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Code = new MaterialSkin.Controls.MaterialTextBox();
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
            this.materialButton1.Location = new System.Drawing.Point(158, 170);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Подтвердить";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Code
            // 
            this.Code.AnimateReadOnly = true;
            this.Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Code.Depth = 0;
            this.Code.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Code.Hint = "Код подтверждения";
            this.Code.LeadingIcon = null;
            this.Code.Location = new System.Drawing.Point(111, 99);
            this.Code.MaxLength = 50;
            this.Code.MouseState = MaterialSkin.MouseState.OUT;
            this.Code.Multiline = false;
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(260, 50);
            this.Code.TabIndex = 1;
            this.Code.Text = "";
            this.Code.TrailingIcon = null;
            this.Code.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 255);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.materialButton1);
            this.Name = "Form3";
            this.Text = "Двухэтапная аутентификация ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public MaterialSkin.Controls.MaterialButton materialButton1;
        public MaterialSkin.Controls.MaterialTextBox Code;
    }
}