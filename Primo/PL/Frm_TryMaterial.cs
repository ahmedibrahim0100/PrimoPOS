using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Primo.PL
{
    public partial class Frm_TryMaterial : Form
    {
        public Frm_TryMaterial()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange50, Primary.Purple200, Primary.Blue100, Accent.Cyan100, TextShade.BLACK);
        }
    }
}
