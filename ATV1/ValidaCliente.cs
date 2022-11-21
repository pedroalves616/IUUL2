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



            return long.Parse(cpf);


        }
    }
}

//referencias
//https://social.msdn.microsoft.com/Forums/pt-BR/1dbe81e6-c063-4ae5-ae1d-5643fb4b0e62/validar-cpf-em-c?forum=vscsharppt