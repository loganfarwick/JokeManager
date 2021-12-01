/*
 * Logan Farwick
 * farwicls@mail.uc.edu
 * Course/Term: IT3045C Fall 2021
 * Assignment: Final Project
 * Due Date: 12/7/2021
 * Description: Add functional GUI to forked and cloned repo from Prof. Also added functionality to the SaveJoke() method to properly use inputted parameters.
 * Citations: I used Assignment 03 from earlier this semester as reference on how to design a GUI quite often. 
 * Anything else: N/A
 */

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
            // Create strings to store the UCID and joke entered in through the form
            String UCID = txtUCID.Text;
            String joke = txtJoke.Text;
            // Create an int to store the return value of the SaveJoke() method. This will determine the outcome of the GUI
            int status = JokeManager.SaveJoke(UCID, joke);
            // Through debugging, I found that if the return value of SaveJoke() was 1, then there was an error in the insertion of the data
            // If the return value was -1, then the insertion was successful
            if (status == 1)
            {
                // On unsuccessful insertion, there will be a label that tells the user so
                lblStatus.Text = "Joke unsuccessfully submitted, please try again later.";
            } else
            {
                // On successful insertion, the label will tell the user so
                lblStatus.Text = "Joke submitted successfully.";
            }
        }
    }
}
