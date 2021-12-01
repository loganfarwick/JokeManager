using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokeManagerNamespace;

namespace TestMain
{
    public partial class JokeForm : Form
    {
        public JokeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This code runs when... the form loads
            JokeManager joker = new JokeManager();
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            // This code runs when the submit button is clicked
            // Get the UCID and joke entered in through the form
            String UCID = txtUCID.Text;
            String joke = txtJoke.Text;
            int status = JokeManager.SaveJoke(UCID, joke);
            if (status == 1)
            {
                lblStatus.Text = "Joke unsuccessfully submitted, please try again later.";
            } else
            {
                lblStatus.Text = "Joke submitted";
            }
        }
    }
}
