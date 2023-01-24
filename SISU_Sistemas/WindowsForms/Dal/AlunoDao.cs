using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Models;

namespace WindowsForms.Dal
{
    public class AlunoDao
    {
        private Stream enderecoArquivo;

        public string Nome { get; set; }
        public int Idade { get; set; }

        public void inserir (Aluno aluno)
        {

        }
        public List<Aluno> getTodosAlunos()
        {
            List<Aluno> novaLista = new List<Aluno>();
            StreamReader sr = new StreamReader(enderecoArquivo);
            string linha = sr.ReadLine();
            while (sr.ReadLine() != null)
            {
                Aluno novoAluno = new Aluno();
                string[] dados = linha.Split("|");
                novoAluno.Nome = dados[0];
                novoAluno.Idade = Convert.ToInt32(dados[1]);
                novaLista.Add(novoAluno);
                linha = sr.ReadLine();

            }
            sr.Close();
            return novaLista;
        }
    }
}
