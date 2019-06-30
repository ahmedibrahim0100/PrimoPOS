using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primo.PrimoControls
{
    public partial class PrimoColoredTextBox : TextBox
    {
        public PrimoColoredTextBox()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Blue;
            this.ForeColor = Color.White;
           
        }
    }
}
