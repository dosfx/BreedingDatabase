using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreedingDatabase
{
    class DataGridViewIdCell : DataGridViewTextBoxCell
    {
        public override Type ValueType => typeof(long);

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // let the base take care of everything
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

            // all we care about it adding the key press handler to the editing control
            DataGridView.EditingControl.KeyPress += EditingControl_KeyPress;
        }
        
        private void EditingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            // handle everything that is either
            e.Handled =
                // numbers
                (e.KeyChar < '0' || '9' < e.KeyChar) &&
                // ctrl + keys
                !Control.ModifierKeys.HasFlag(Keys.Control) &&
                // backspace
                e.KeyChar != (char)Keys.Back;
        }
    }
}
