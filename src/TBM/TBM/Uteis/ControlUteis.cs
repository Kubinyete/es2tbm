using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.Uteis
{
    public abstract class ControlUteis
    {
        public static string obterStringSemMascara(MaskedTextBox tb)
        {
            string ret = null;
            MaskFormat prev = tb.TextMaskFormat;

            tb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            ret = tb.Text;
            tb.TextMaskFormat = prev;

            return ret;
        }

        public static void selecionarEmTabela(DataGridView dgv, object prev)
        {
            if (prev != null)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    object curr = row.DataBoundItem;

                    if (curr.Equals(prev))
                    {
                        row.Selected = true;
                    }
                }
            }
        }
    }
}
