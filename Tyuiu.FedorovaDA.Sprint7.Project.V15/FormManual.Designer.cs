namespace Tyuiu.FedorovaDA.Sprint7.Project.V15
{
    partial class FormManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            pictureBox_FDA = new PictureBox();
            buttonOK_FDA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_FDA).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_FDA
            // 
            pictureBox_FDA.Image = (Image)resources.GetObject("pictureBox_FDA.Image");
            pictureBox_FDA.Location = new Point(-4, -5);
            pictureBox_FDA.Name = "pictureBox_FDA";
            pictureBox_FDA.Size = new Size(1088, 648);
            pictureBox_FDA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_FDA.TabIndex = 0;
            pictureBox_FDA.TabStop = false;
            // 
            // buttonOK_FDA
            // 
            buttonOK_FDA.Font = new Font("Inter Tight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOK_FDA.Location = new Point(421, 565);
            buttonOK_FDA.Name = "buttonOK_FDA";
            buttonOK_FDA.Size = new Size(204, 38);
            buttonOK_FDA.TabIndex = 1;
            buttonOK_FDA.Text = "Удачного пользования";
            buttonOK_FDA.UseVisualStyleBackColor = true;
            buttonOK_FDA.Click += button1_Click;
            // 
            // FormManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 615);
            Controls.Add(buttonOK_FDA);
            Controls.Add(pictureBox_FDA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormManual";
            Text = "Руководство";
            ((System.ComponentModel.ISupportInitialize)pictureBox_FDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_FDA;
        private Button buttonOK_FDA;
    }
}