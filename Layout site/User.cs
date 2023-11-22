using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Layout_site
{
    internal class User
    {
        private int _id;
        private string _email;
        private string _nome;
        private string _senha;
        private string _CPF;

        public User(int id, string email, string nome, string senha, string CPF)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.CPF = CPF;
        }

        public int id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string nome
        {

            set
            {
                if(value.Length < 3)
                {
                    throw new Exception("O campo nome ");
                }
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo nome não esta preenchido corretamente");
                _nome = value;
            }
            get { return _nome; }
        }

        public string email
        {
            set
            {
               
                    try
                    {
                        MailAddress m = new MailAddress(value);
                    }
                    catch (FormatException)
                    {
                    throw new Exception("O campo e-mail não esta valido"); ;
                    }
                
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo e-mail não esta preenchido corretamente");
                _email = value;
            }
            get { return _email; }
        }

        public string senha
        {
            set
            {
                if (value.Length < 10)
                {
                    throw new Exception("O campo senha precisa de, no minimo, 10 caracteres");
                }
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo senha não esta preenchido corretamente");
                _senha = value;
            }
            get { return _senha; }
        }

        public string CPF
        {
            set
            {
            
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo cpf não esta preenchido corretamente");
                _CPF = value;
            }
            get { return _CPF; }
        }


    }
}



