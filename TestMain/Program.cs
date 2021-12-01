/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
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
