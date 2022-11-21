using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV3
{
    public class Aluno
    {
        public String Nome { get; private set; }
        public int Matricula { get; private set; }

   
        public Aluno(string nome, int matricula)
        {
           
                this.Nome = nome;
                this.Matricula = matricula;
        }


    }
}
