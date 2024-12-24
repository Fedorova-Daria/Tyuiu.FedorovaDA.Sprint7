namespace Tyuiu.FedorovaDA.Sprint7.Project.V15
{
    partial class AboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMe));
            buttonOK_FDA = new Button();
            pictureBox_FDA = new PictureBox();
            labelAboutMe_FDA = new Label();
            textBoxAboutMe_FDA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_FDA).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_FDA
            // 
            buttonOK_FDA.Location = new Point(473, 232);
            buttonOK_FDA.Name = "buttonOK_FDA";
            buttonOK_FDA.Size = new Size(75, 23);
            buttonOK_FDA.TabIndex = 0;
            buttonOK_FDA.Text = "OK";
            buttonOK_FDA.UseVisualStyleBackColor = true;
            buttonOK_FDA.Click += buttonOK_FDA_Click;
            // 
            // pictureBox_FDA
            // 
            pictureBox_FDA.Image = (Image)resources.GetObject("pictureBox_FDA.Image");
            pictureBox_FDA.Location = new Point(12, 25);
            pictureBox_FDA.Name = "pictureBox_FDA";
            pictureBox_FDA.Size = new Size(195, 199);
            pictureBox_FDA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_FDA.TabIndex = 1;
            pictureBox_FDA.TabStop = false;
            // 
            // labelAboutMe_FDA
            // 
            labelAboutMe_FDA.AutoSize = true;
            labelAboutMe_FDA.Font = new Font("Inter Tight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAboutMe_FDA.Location = new Point(303, 9);
            labelAboutMe_FDA.Name = "labelAboutMe_FDA";
            labelAboutMe_FDA.Size = new Size(126, 23);
            labelAboutMe_FDA.TabIndex = 2;
            labelAboutMe_FDA.Text = "О разработчике";
            // 
            // textBoxAboutMe_FDA
            // 
            textBoxAboutMe_FDA.BackColor = SystemColors.Control;
            textBoxAboutMe_FDA.BorderStyle = BorderStyle.None;
            textBoxAboutMe_FDA.Location = new Point(224, 53);
            textBoxAboutMe_FDA.Multiline = true;
            textBoxAboutMe_FDA.Name = "textBoxAboutMe_FDA";
            textBoxAboutMe_FDA.Size = new Size(295, 173);
            textBoxAboutMe_FDA.TabIndex = 3;
            textBoxAboutMe_FDA.Text = resources.GetString("textBoxAboutMe_FDA.Text");
            // 
            // AboutMe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 267);
            Controls.Add(textBoxAboutMe_FDA);
            Controls.Add(labelAboutMe_FDA);
            Controls.Add(pictureBox_FDA);
            Controls.Add(buttonOK_FDA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutMe";
            Text = "Разработчик";
            Load += AboutMe_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_FDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_FDA;
        private PictureBox pictureBox_FDA;
        private Label labelAboutMe_FDA;
        private TextBox textBoxAboutMe_FDA;
    }
}