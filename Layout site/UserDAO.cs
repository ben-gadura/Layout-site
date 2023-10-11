using layoutsite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout_site
{
    internal class UserDAO
    {
        public List<User> SelectUser()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM cliente";
            List<User> users = new List<User>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())

                {
                    
                    User objeto = new User(
                    (int)dr["Id"],
                    (string)dr["emailcliente"],
                    (string)dr["nomecliente"],
                    (string)dr["senha"],
                    (string)dr["cpf"]
                    );

                    users.Add(objeto);
                }
                dr.Close();
                return users;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return null;
        }
        public void UpdateUser(User user, int Id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE cliente SET 
             emailcliente = @emailcliente, 
             nomecliente = @nomecliente,
             senha = @senha, 
             cpf = @cpf
             WHERE Id   = @id"
            ;

            sqlCommand.Parameters.AddWithValue("@emailcliente", user.email);
            sqlCommand.Parameters.AddWithValue("@nomecliente", user.nome);
            sqlCommand.Parameters.AddWithValue("@senha", user.senha);
            sqlCommand.Parameters.AddWithValue("cpf", user.CPF);
            sqlCommand.Parameters.AddWithValue("@id", Id);


            sqlCommand.ExecuteNonQuery();
        }
        public void InsertUser(User user)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO cliente VALUES (@emailcliente, @nomecliente, @senha, @cpf)";
            sqlCommand.Parameters.AddWithValue("@emailcliente", user.email);
            sqlCommand.Parameters.AddWithValue("@nomecliente", user.nome);
            sqlCommand.Parameters.AddWithValue("@senha", user.senha);
            sqlCommand.Parameters.AddWithValue("cpf", user.CPF);
            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteUser(int Id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM cliente WHERE Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();

            }

           
        }
    }
}
