using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Primo.PrimoControls
{
    public partial class PrimoButton : MaterialRaisedButton
    {
        public PrimoButton()
        {
            InitializeComponent();
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange800,
                MaterialSkin.Primary.Pink400, MaterialSkin.Primary.Purple100, MaterialSkin.Accent.Red100, MaterialSkin.TextShade.WHITE);
            //this.BackColor = Color.Blue;
            //this.ForeColor = Color.White;
        }
    }
}
