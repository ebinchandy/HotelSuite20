namespace Hotel_Suite
{
    partial class frm_Login
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
            this.txt_Username = new MetroFramework.Controls.MetroTextBox();
            this.txt_Password = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            // 
            // 
            // 
            this.txt_Username.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Username.CustomButton.Image = null;
            this.txt_Username.CustomButton.Location = new System.Drawing.Point(303, 1);
            this.txt_Username.CustomButton.Name = "";
            this.txt_Username.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_Username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Username.CustomButton.TabIndex = 1;
            this.txt_Username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Username.CustomButton.UseSelectable = true;
            this.txt_Username.CustomButton.Visible = false;
            this.txt_Username.DisplayIcon = true;
            this.txt_Username.Lines = new string[0];
            this.txt_Username.Location = new System.Drawing.Point(141, 163);
            this.txt_Username.MaxLength = 32767;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.PromptText = "Username";
            this.txt_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Username.SelectedText = "";
            this.txt_Username.SelectionLength = 0;
            this.txt_Username.SelectionStart = 0;
            this.txt_Username.ShortcutsEnabled = true;
            this.txt_Username.Size = new System.Drawing.Size(339, 37);
            this.txt_Username.TabIndex = 0;
            this.txt_Username.UseSelectable = true;
            this.txt_Username.WaterMark = "Username";
            this.txt_Username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_Password
            // 
            // 
            // 
            // 
            this.txt_Password.CustomButton.Image = null;
            this.txt_Password.CustomButton.Location = new System.Drawing.Point(303, 1);
            this.txt_Password.CustomButton.Name = "";
            this.txt_Password.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Password.CustomButton.TabIndex = 1;
            this.txt_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Password.CustomButton.UseSelectable = true;
            this.txt_Password.CustomButton.Visible = false;
            this.txt_Password.DisplayIcon = true;
            this.txt_Password.Lines = new string[0];
            this.txt_Password.Location = new System.Drawing.Point(141, 206);
            this.txt_Password.MaxLength = 32767;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.PromptText = "Password";
            this.txt_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Password.SelectedText = "";
            this.txt_Password.SelectionLength = 0;
            this.txt_Password.SelectionStart = 0;
            this.txt_Password.ShortcutsEnabled = true;
            this.txt_Password.Size = new System.Drawing.Size(339, 37);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.UseSelectable = true;
            this.txt_Password.WaterMark = "Password";
            this.txt_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroPanel1
            // 
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(575, 315);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 395);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frm_Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox txt_Username;
        private MetroFramework.Controls.MetroTextBox txt_Password;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}