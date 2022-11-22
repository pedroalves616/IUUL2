using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV1
{
    abstract class ValidaCliente
    {

        public String ValidaNOME(string nome)
        {
            while (nome.Length < 5)
            {
                Console.WriteLine("inserir nome de pelo menos 5 caracteres: ");
                nome = Console.ReadLine();
            }
            return nome;
        }

        protected long ValidaCpf(string cpf)

        {
            valida:
            if (cpf.Length != 11)
            {
                Console.WriteLine("Erro: CPF deve conter 11 dígitos.");
                cpf = Console.ReadLine();
                goto valida;
            }
            
           if (    cpf == "00000000000"|| cpf == "11111111111"|| cpf == "22222222222"|| cpf == "33333333333" || cpf == "44444444444"
                || cpf == "55555555555"|| cpf == "66666666666"|| cpf == "77777777777"|| cpf == "88888888888"|| cpf == "99999999999")  
            {
                Console.WriteLine("Erro: CPF não deve conter numeros iguais.");
                goto valida;
            }

                    return long.Parse(cpf);


        }
        protected float ValidaRenda(string renda) {

            float.Parse(renda);
            if (renda<0)
            {

            }

            
        }
    }
}

////referencias
////https://social.msdn.microsoft.com/Forums/pt-BR/1dbe81e6-c063-4ae5-ae1d-5643fb4b0e62/validar-cpf-em-c?forum=vscsharppt
//https://www.programiz.com/csharp-programming/goto