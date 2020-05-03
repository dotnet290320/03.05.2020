using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsapp
{
    public partial class MainWindow : Form
    {
        string chatteraName = "Ralph";
        string chatterbName = "Suzan";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void chatterATxtBx_TextChanged(object sender, EventArgs e)
        {
            chatterAStatusLbl.Text = chatteraName + " is typing...";
        }

        private void chatterBTxtBx_TextChanged(object sender, EventArgs e)
        {
            chatterBStatusLbl.Text = chatterbName + " is typing...";
        }

        private void chatterATxtBx_Leave(object sender, EventArgs e)
        {
            chatterAStatusLbl.Text = chatteraName + " last seen at " + DateTime.Now;
        }

        private void chatterBTxtBx_Leave(object sender, EventArgs e)
        {
            chatterBStatusLbl.Text = chatterbName + " last seen at " + DateTime.Now;
        }

        private void chatterATxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                //MessageBox.Show("You pressed ENTER");

                chatLB.Items.Add(chatteraName + ": " + chatterATxtBx.Text);

                chatterATxtBx.Text = "";
                chatterAStatusLbl.Text = "Online";

                countLinesLbl.Text = chatLB.Items.Count.ToString();
            }
        }

        private void chatterBTxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                //MessageBox.Show("You pressed ENTER");

                chatLB.Items.Add(chatterbName + ": " + chatterBTxtBx.Text);

                chatterBTxtBx.Text = "";
                chatterBStatusLbl.Text = "Online";

                countLinesLbl.Text = chatLB.Items.Count.ToString();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            chatLB.Items.Clear();
            countLinesLbl.Text = chatLB.Items.Count.ToString();
        }

        private void changeANameBtn_Click(object sender, EventArgs e)
        {
            chatteraName = chatterANameTxtBx.Text;
            chatterANameTxtBx.Text = "";
        }

        private void changeBNameBtn_Click(object sender, EventArgs e)
        {
            chatterbName = chatterBNameTxtBx.Text;
            chatterBNameTxtBx.Text = "";
        }

        private void chatterANameTxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                chatteraName = chatterANameTxtBx.Text;
                chatterANameTxtBx.Text = "";
            }
        }

        private void chatterBNameTxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                chatterbName = chatterBNameTxtBx.Text;
                chatterBNameTxtBx.Text = "";
            }
        }

        private void chatLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndexLbl.Text = chatLB.SelectedIndex.ToString();
            if (chatLB.SelectedIndex >= 0)
            {
                selectedItemLbl.Text = chatLB.SelectedItem.ToString();
                selectedItemLbl.ForeColor = Color.Black;
            }
            else
            {
                selectedItemLbl.Text = "none selected ...";
                selectedItemLbl.ForeColor = Color.Red;
            }
        }

        private void chatLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("=== " + chatLB.SelectedIndex);
            Debug.WriteLine("=== " + chatLB.SelectedItem);

            if (chatLB.SelectedIndex >= 0)
            {
                chatLB.Items.RemoveAt( chatLB.SelectedIndex );
            }
        }
    }
}
