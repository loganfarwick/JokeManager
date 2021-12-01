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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokeManagerNamespace;

namespace TestMain
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // This runs...
            int status = JokeManager.SaveJoke("test1", "test1");
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JokeForm());
        }
    }
}
