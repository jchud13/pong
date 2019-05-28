using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                //send cursor up
            }
            else
            {
                //send cursor down
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }

        private void mouseisdown(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            try
            {
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {

                    //   Application.Restart();
                    this.Hide();
                    Form1 form1 = new Form1();
               //     Application.Run(new Form1());
                    form1.Show();
                    //Form1 = new Form1;
                }
            }
            catch(Exception ex) { }

        }
    }
}
