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
        //private String codigo = "TURMA";

        //protected internal String Codigo
        //{
        //    get
        //    {
        //        return codigo;
        //    }
        //    set
        //    {
        //        //gerando número aleatório
        //        Random r = new();
        //        String random = r.Next(0, 999).ToString();

        //        //removendo whitespaces do parâmetro e transformando em maiúsculo
        //        value = value.Trim().ToUpper();

        //        //gerando código "único"
        //        codigo = codigo + value + random;
        //    }
        //}

        //public Turma(String codigo, List<Aluno> alunos)
        //{
        //    Alunos = new();
        //    this.Codigo = codigo;
        //    foreach (var aluno in alunos)
        //        this.InsereAlunoTurma(aluno);
        //}

        public void AdicionarAlunoTurma(Aluno alunoNovo)
        {
          //percorrendo lista de alunos
            for (int i = 0; i < this.Alunos.Count; i++)
            {
                var aluno = this.Alunos[i];
                Console.WriteLine(aluno);
                if (aluno.Equals(alunoNovo))
                    Console.WriteLine("Aluno já cadastrado na turma.");
                else
                    this.Alunos.Add(a);
            }
        }
        public void RemoveAlunoTurma(Aluno aluno)
        {
            this.Alunos.Remove(aluno);
        }
    }
}