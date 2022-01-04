using Domen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.CommunicationF;

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
            if (dtp.Value.Date < DateTime.Today)
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

        internal static bool TimeValidation(TextBox txtSati, TextBox txtMinuti)
        {
            int sati;
            int minuti;

            if (!int.TryParse(txtSati.Text, out sati) | !int.TryParse(txtMinuti.Text, out minuti))
            {
                txtSati.BackColor = Color.LightCoral;
                txtMinuti.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                if(sati>23 | sati<0 | minuti>59 | minuti < 0)
                {
                    txtSati.BackColor = Color.LightCoral;
                    txtMinuti.BackColor = Color.LightCoral;
                    return false;
                } else
                {
                    txtSati.BackColor = Color.White;
                    txtMinuti.BackColor = Color.White;
                    return true;
                }
            }
        }
    }
}
