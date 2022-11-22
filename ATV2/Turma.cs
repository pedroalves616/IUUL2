using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATV3;
namespace ATV2
{
    internal class Turma
    {

        protected internal List<Aluno> Alunos { get; set; }


        public void AdicionarAlunoTurma(Aluno alunoNovo)
        {
          
            for (int i = 0; i < this.Alunos.Count; i++)
            {
                var aluno = this.Alunos[i];
                if (aluno.Equals(alunoNovo))
                    Console.WriteLine("Aluno já cadastrado na turma.");
                else
                    this.Alunos.Add(aluno);
            }
        }
        public void RemoveAlunoTurma(Aluno aluno)
        {
            this.Alunos.Remove(aluno);
        }
    }
}