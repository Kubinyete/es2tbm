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
    }
}
