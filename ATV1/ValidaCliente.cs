using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATV1
{
    internal class ValidaCliente
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

            if (cpf == "00000000000" || cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" || cpf == "44444444444"
                 || cpf == "55555555555" || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999")
            {
                Console.WriteLine("Erro: CPF não deve conter numeros iguais.");
                cpf = Console.ReadLine();
                goto valida;
            }

            return long.Parse(cpf);


        }
        protected float validaRenda(string renda) {


            if (renda.Contains(','))
            {
                Console.WriteLine("Renda validada");
                renda = Console.ReadLine();
            }
            float rendaValidada = float.Parse(renda);
            if (rendaValidada > 0)
            {
                Console.WriteLine("Renda validada");
                renda = Console.ReadLine();
            }

            return (rendaValidada);


        }
        protected DateTime ValidaDataNascimento(string dt)
        {
            DateTime dataEmDateTime = DateTime.ParseExact(dt, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));

            return DateTime.Parse(dt);
        
        }
        protected char ValidaEstadoCivil(string estadocivil)
        {
            validaEstado:
            if (estadocivil == "C" || estadocivil == "S" || estadocivil == "V" || estadocivil == "D") {
                Console.WriteLine("Estado civil  validado");
            }
            else
            {
                Console.WriteLine("Estado civil não validado");
                estadocivil = Console.ReadLine();
                goto validaEstado;
            }
            return char.Parse(estadocivil);

        }
    }
}

////referencias
////https://social.msdn.microsoft.com/Forums/pt-BR/1dbe81e6-c063-4ae5-ae1d-5643fb4b0e62/validar-cpf-em-c?forum=vscsharppt
//https://www.programiz.com/csharp-programming/goto