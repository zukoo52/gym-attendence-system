using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_attendence_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void nEWMEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
           NEW_MEMBERS f1 = new NEW_MEMBERS();
           f1.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dELETEMEMBERSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sUPLEMENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nEWSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Staff F2 = new New_Staff();
            F2.Show();
        }

        private void aDDPAYMENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_PAYMENT F3 = new ADD_PAYMENT();
            F3.Show();
        }
    }
}
