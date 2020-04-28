using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TBM.Uteis
{
    class StringUteis
    {
        public static bool validarCpf(string cpf)
        {
            return true;
        }

        public static bool validarCnpj(string cnpj)
        {
            return true;
        }

        public static bool validarRg(string rg)
        {
            return true;
        }

        public static bool validarEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)+$");
        }

        public static bool validarTelefone(string alvo)
        {
            return Regex.IsMatch(alvo, @"^([0-9]{2})?[0-9]{8}$");
        }

        public static bool validarCelular(string alvo)
        {
            return Regex.IsMatch(alvo, @"^([0-9]{2})?[0-9]{9}$");
        }

        public static bool validarCPF(string alvo)
        {
            return Regex.IsMatch(alvo, @"^[0-9]{11}$");
        }

        public static bool validarRG(string alvo)
        {
            return Regex.IsMatch(alvo, @"^[0-9]{8}$");
        }
    }
}
