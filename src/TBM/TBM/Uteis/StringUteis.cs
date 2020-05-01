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
            // @NOTE (vitorkubinyete):
            // Algoritmo de verificação dos dois digitos verificadores do CPF
            // baseado em https://www.geradorcpf.com/algoritmo_do_cpf.htm
            // até o momento está funcionando normalmente, unico problema que encontrei é que
            // um CPF com digitos todos iguais vai passar como válido, mesmo as APIs falando que não são
            // Ex: 111.111.111-11 é valido neste algoritmo

            if (!Regex.IsMatch(cpf, @"^[0-9]{11}$"))
                return false;

            char[] cpfarray = cpf.ToArray<char>();

            char dgv, dgv2;

            int sumDgv, sumDgv2;

            int buffer;

            dgv = dgv2 = '\0';
            sumDgv = sumDgv2 = 0;

            // XXX.XXX.XXX-VV
            for (int i = 0; i < cpfarray.Length - 1; i++)
            {
                buffer   = cpfarray[i] - '0';
                sumDgv  += (cpfarray.Length - i - 1) * buffer;
                sumDgv2 += (cpfarray.Length - i)     * buffer;

                if (i == 8) {
                    // Calculando o primeiro digito verificador, antes de iterarmos nele (proximo char)
                    dgv = (buffer = sumDgv % 11) < 2 ? '0' : (11 - buffer).ToString()[0];

                    if (cpfarray[9] != dgv)
                        return false;
                }
            }

            // Saimos do loop, precisamos verificar agora o ultimo digito verificador
            dgv2 = (buffer = sumDgv2 % 11) < 2 ? '0' : (11 - buffer).ToString()[0];

            return cpfarray[10] == dgv2;
        }

        public static bool validarCnpj(string cnpj)
        {
            // @TODO: Utilizar um algoritmo que faz o calculo matemático real e verifica o dado corretamente.
            return true;
        }

        public static bool validarRg(string rg)
        {
            // @TODO: Utilizar um algoritmo que faz o calculo matemático real e verifica o dado corretamente
            return Regex.IsMatch(rg, @"^[0-9]{9}$");
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
