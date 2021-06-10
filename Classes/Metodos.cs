using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_André.Classes
{
    public static class Metodos
    {
        public static string getStringData(this DateTimePicker temp_data)
        {
            temp_data.Format = DateTimePickerFormat.Custom;
            string data = temp_data.Text;
            temp_data.Format = DateTimePickerFormat.Short;

            return data;
        }

        public static string getStringTelefone(this MaskedTextBox temp_fone)
        {
            temp_fone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            String fone = temp_fone.Text;
            temp_fone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            return fone;
        }
    }
}
