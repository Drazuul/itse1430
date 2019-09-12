using System;
using System.Windows.Forms;
using Itse130.MovieLib;

namespace Itse430.MovieLib.Host
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();

            Movie movie = new Movie ();
        }
    }
}
