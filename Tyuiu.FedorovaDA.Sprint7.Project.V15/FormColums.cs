using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.FedorovaDA.Sprint7.Project.V15.Lib;

namespace Tyuiu.FedorovaDA.Sprint7.Project.V15
{
    public partial class FormColums : Form
    {
        public FormColums()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            DataService.Text = textBoxInputLabelColumn_FDA.Text;
            this.Close();
        }
    }
}
