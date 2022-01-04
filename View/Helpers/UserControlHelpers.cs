using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Helpers
{
    public static class UserControlHelpers
    {
        public static bool EmptyFieldValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            } else
            {
                txt.BackColor= Color.White;
                return true;
            }
        }

        public static bool NumberPickerValidation(NumericUpDown nud)
        {
            if(nud.Value < 20 | nud.Value > 100)
            {
                nud.BackColor = Color.LightCoral;
                return false;
            } else {
                nud.BackColor = Color.White;
                return true;
            }
        }

        public static bool DateValidation(DateTimePicker dtp)
        {
            if (dtp.Value.Date < DateTime.Now)
            {
                dtp.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                dtp.BackColor = Color.White;
                return true;
            }
        }

        public static bool ComboBoxValidation(ComboBox cmb)
        {
            if (cmb.SelectedIndex == -1)
            {
                cmb.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                cmb.BackColor = Color.White;
                return true;
            }
        }

        public static bool JMBGValidation(TextBox txt)
        {
            if (txt.TextLength < 13)
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }
    }
}
