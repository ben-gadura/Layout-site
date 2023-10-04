using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout_site
{
    public class usuario
    {
        private int _id;
        private string _email;
        private string _nome;
        private string _senha;
        private string _CPF;

        public usuario(string email, string nome, string senha, string CPF)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.CPF = CPF;
        }

        public string id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string nome 
        {
            set { _nome = value; }
            get { return _nome; }
        }

        public string email
        {
            set { _email = value; }
            get { return _email; }
        }

        public string senha
        {
            set { _senha = value; }
            get { return _senha; }
        }

        public string CPF
        {
            set { _CPF = value; }
            get { return _CPF; }
        }

    }
}
