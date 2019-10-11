//Jacob Ivey
//ITSE 1430
//Character Creator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class AboutForm : Form
    {
        public AboutForm ()
        {
            InitializeComponent ();
        }

        private void OnCloseClick ( object sender, EventArgs e )
        {
            Close ();
        }
    }
}
