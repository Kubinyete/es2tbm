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
            // @TODO: Utilizar um algoritmo que faz o calculo matemático real e verifica o dado corretamente.
            return Regex.IsMatch(cpf, @"^[0-9]{11}$");
        }

        public static bool validarCnpj(string cnpj)
        {
            // @TODO: Utilizar um algoritmo que faz o calculo matemático real e verifica o dado corretamente.
            return true;
        }

        public static bool validarRg(string rg)
        {
            // @TODO: Utilizar um algoritmo que faz o calculo matemático real e verifica o dado corretamente.
            return Regex.IsMatch(rg, @"^[0-9]{8}$");
        }

        // @DEPRECATED: Por favor, utilize a versão da função em camelCase
        public static bool validarCPF(string alvo) => validarCpf(alvo);
        // @DEPRECATED: Por favor, utilize a versão da função em camelCase
        public static bool validarRG(string alvo) => validarRg(alvo);

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
    }
}
