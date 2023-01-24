using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.View.Aluno
{
    public partial class AlunoIndex : Form
    {
        public AlunoIndex()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Nome é obrigatório");
                txtName.BackColor = Color.Red;
            }
            if(txtIdade.Text == "")
            {
                MessageBox.Show("Idade é obrigatório.");
                txtIdade.BackColor = Color.Red;
            }
            if ((txtNome.Text != "") & (txtIdade.Text != ""))
            {
                listAluno.Items.Add(txtName.Text + " | " + txtIdade.Text);
                txtNom
            }







                if ( (txtName.Text!= "") & (txtIdade.Text != ""))
            {
                listAluno.Items.Add(txtName.Text + " | " + txtIdade.Text);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Alunos.txt");

            foreach (ListViewItem item in listAluno.Items)
            {
                sw.WriteLine(item.Text);
            }
            sw.Close();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //System.IO.FileNotFoundException
            StreamWriter sw = new StreamWriter("Alunos.txt");
            sw.Flush();
            sw.Close();
            listAluno.Clear();
        }

        private void AlunoIndex_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Alunos.txt");

                string linha = sr.ReadLine();
                while (sr.ReadLine() != null)
                {
                    listAluno.Items.Add(linha);
                    linha = sr.ReadLine();
                }
                sr.Close();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Erro de leitura de Arquivo. Arquivo não existe, ou endereço inválido");
            }

        }
    }
}
