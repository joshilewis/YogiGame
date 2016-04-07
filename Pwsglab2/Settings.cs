using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pwsglab2
{
    public partial class Settings : Form
    {
        public string leftKey;
        public string rightKey;

        public Settings()
        {
            leftKey = "Left";
            rightKey = "Right";
            InitializeComponent();
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            leftKey =(String) comboBoxLeft.SelectedItem;
            rightKey = (String)comboBoxRight.SelectedItem;

            this.Hide();
        }
    }
}
