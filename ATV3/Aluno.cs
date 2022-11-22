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
        public String Matricula { get; private set; }

        protected internal float P1;
        protected internal float P2;
        protected internal float NF;

        public Aluno(string nome, string matricula , float nf)
        {
           
                this.Nome = nome;
                this.Matricula = matricula;
                
        }


        public void NotasFinais(Aluno a, float p1, float p2)
        {
            a.P1 = p1;
            a.P2 = p2;
            a.NF = (p1 + p2) / 2;
        }



    }
} 
