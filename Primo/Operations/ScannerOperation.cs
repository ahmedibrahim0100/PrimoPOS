using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primo.Operations
{
    class ScannerOperation
    {
        /// <summary>
        /// Function to realize that scanner got used and pick the barcode.
        /// It uses a PrimoTextBox in parameters, not TextBox.
        /// The bool is to inform if the barcode got picked or not to proceed to the upcoming function.
        /// </summary>
        /// <param name="lastItemAddedTime"></param>
        /// <param name="arg"></param>
        /// <param name="txtbxBarcode"></param>
        /// <param name="isBarcodePicked"></param>
        public void PickScannerCode(DateTime lastItemAddedTime, KeyPressEventArgs arg, PrimoControls.PrimoTextBox 
            txtbxBarcode, DateTime _lastKeystroke, List<char> _barcode, bool isBarcodePicked)
        {
            //DateTime _lastKeystroke = new DateTime(0);
            //List<char> _barcode = new List<char>();

            // check timing (keystrokes within 100 ms)
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            if (elapsed.TotalMilliseconds > 100)
            {
                _barcode.Clear();
            }

            // record keystroke & timestamp
            _barcode.Add(arg.KeyChar);
            _lastKeystroke = DateTime.Now;

            TimeSpan addItemInterval = DateTime.Now - lastItemAddedTime;

            if (addItemInterval.TotalMilliseconds > 100)
            {
                // process barcode
                if (arg.KeyChar == 13 && _barcode.Count > 1)
                {
                    _barcode.RemoveAt(_barcode.Count - 1);
                    string msg = new String(_barcode.ToArray());
                    txtbxBarcode.Text = msg;
                    isBarcodePicked = true;
                    _barcode.Clear();
                }
            }
            
        }
    }
}
