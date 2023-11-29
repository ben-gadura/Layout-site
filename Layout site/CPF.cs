using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout_site
{
    internal class CPF
    {

        public static bool ValidateCpf(string cpf)
        {
            if (cpf.Length != 11)
                return false;
            else
            {
                int soma = 0;
                for (int i = 0; i < 9; i++)
                    soma += (Convert.ToInt32(cpf[i]) - 48) * (10 - i);
                int digito = (11 - (soma % 11)) > 9 ? 0 : 11 - (soma % 11);
                if (digito == Convert.ToInt32(cpf[9] - 48))
                {
                    soma = 0; for (int i = 0; i < 10; i++) soma += (Convert.ToInt32(cpf[i]) - 48) * (11 - i);
                    digito = (11 - (soma % 11)) > 9 ? 0 : 11 - (soma % 11);
                    if (digito == Convert.ToInt32(cpf[10] - 48)) return true;
                }
            }
            return false;
        }
    }
}
