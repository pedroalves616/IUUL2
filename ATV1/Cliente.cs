using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV1
{
    internal class Cliente :ValidaCliente
    {
        public String Nome { get; private set; }
        public long Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public double Rendamensal { get; private set; }
        public char EstadoCivil { get; private set; }
        public int Depedentes { get; private set; }
        public Cliente(string nome, string cpf/*, string datanascimento, string rendamensal, string depedentes*/)
        {
            String nomeValidado = ValidaNOME(nome);
            this.Nome = nomeValidado;

            long CpfValidado = ValidaCpf(cpf);
            this.Cpf = CpfValidado;
        }


        

        
    }
}
