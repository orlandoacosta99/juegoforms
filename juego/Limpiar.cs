using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego
{
    class Limpiar
    {
        public void BorrarCampos(Control control, GroupBox gb, Control control1, GroupBox gb1)
        {
           
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).SelectedIndex = -1;
                }
                else if (combo is RichTextBox)
                {
                    ((RichTextBox)combo).Clear();
                }
            }
            
            foreach (var combo1 in gb1.Controls)
            {
                if (combo1 is RichTextBox)
                {
                    ((RichTextBox)combo1).Clear();
                }
                else if (combo1 is ComboBox)
                {
                    ((ComboBox)combo1).SelectedIndex = -1;
                }

            }
        }
    }
}
