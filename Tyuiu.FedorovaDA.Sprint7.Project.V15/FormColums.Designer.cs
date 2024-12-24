namespace Tyuiu.FedorovaDA.Sprint7.Project.V15
{
    partial class FormColums
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
            buttonOK_FDA = new Button();
            labelColum_FDA = new Label();
            textBoxInputLabelColumn_FDA = new TextBox();
            SuspendLayout();
            // 
            // buttonOK_FDA
            // 
            buttonOK_FDA.Location = new Point(260, 83);
            buttonOK_FDA.Name = "buttonOK_FDA";
            buttonOK_FDA.Size = new Size(85, 28);
            buttonOK_FDA.TabIndex = 0;
            buttonOK_FDA.Text = "ОК";
            buttonOK_FDA.UseVisualStyleBackColor = true;
            buttonOK_FDA.Click += button1_Click;
            // 
            // labelColum_FDA
            // 
            labelColum_FDA.Anchor = AnchorStyles.Top;
            labelColum_FDA.AutoSize = true;
            labelColum_FDA.Font = new Font("Inter Tight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelColum_FDA.Location = new Point(56, 9);
            labelColum_FDA.Name = "labelColum_FDA";
            labelColum_FDA.Size = new Size(239, 27);
            labelColum_FDA.TabIndex = 1;
            labelColum_FDA.Text = "Введите название столбца";
            // 
            // textBoxInputLabelColumn_FDA
            // 
            textBoxInputLabelColumn_FDA.Location = new Point(12, 48);
            textBoxInputLabelColumn_FDA.Name = "textBoxInputLabelColumn_FDA";
            textBoxInputLabelColumn_FDA.Size = new Size(333, 23);
            textBoxInputLabelColumn_FDA.TabIndex = 2;
            // 
            // FormColums
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 123);
            Controls.Add(textBoxInputLabelColumn_FDA);
            Controls.Add(labelColum_FDA);
            Controls.Add(buttonOK_FDA);
            Name = "FormColums";
            Text = "FormColums";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_FDA;
        private Label labelColum_FDA;
        private TextBox textBoxInputLabelColumn_FDA;
    }
}