using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Components;

namespace Primo.PrimoControls
{
    public partial class PrimoDataGrid : MetroGrid
    {
        public PrimoDataGrid()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;

            ContextMenuStrip _contextMenuStrip = new ContextMenuStrip();
            _contextMenuStrip.Items.Add("Delete");
            _contextMenuStrip.Items.Add("ViewProfile");
            this.ContextMenuStrip = _contextMenuStrip;
        }

    }
}
