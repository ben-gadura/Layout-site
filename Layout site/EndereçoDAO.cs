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
    internal class EndereçoDAO
    {
        public bool LoginAdress(string rua, string numero)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM address WHERE + rua = @rua AND numero = @numero";

            sqlCom.Parameters.AddWithValue("@rua", rua);
            sqlCom.Parameters.AddWithValue("@bairro", numero);
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();
                if (dr.HasRows)
                {

                    dr.Close();
                    return true;

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return false;

        }
        public List<Endereço> SelectAddress()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM address";
            List<Endereço> users = new List<Endereço>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())

                {

                    Endereço objeto = new Endereço(
                    (int)dr["idadress"],
                    (string)dr["rua"],
                    (string)dr["numero"],
                    (string)dr["bairro"],
                    (string)dr["cidade"],
                    (string)dr["estado"],
                    (string)dr["telefone"]
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
        public void UpdateUser(Endereço user)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE address SET 
             rua = @rua,
             numero = @numero, 
             bairro = @bairro,
             cidade = @cidade,
             estado = @estado,
             telefone = @telefone,
             WHERE idaddress = @idaddress"
            ;

            sqlCommand.Parameters.AddWithValue("@rua", user.rua);
            sqlCommand.Parameters.AddWithValue("@numero", user.numero);
            sqlCommand.Parameters.AddWithValue("@bairro", user.bairro);
            sqlCommand.Parameters.AddWithValue("@cidade", user.cidade);
            sqlCommand.Parameters.AddWithValue("@estado", user.estado);
            sqlCommand.Parameters.AddWithValue("@telefone", user.telefone);
            sqlCommand.Parameters.AddWithValue("@idaddress", user.idaddress);


            sqlCommand.ExecuteNonQuery();
        }
        public void InsertUser(Endereço user)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO address VALUES (@rua, @numero, @bairro, @cidade, @estado, @telefone, @idaddress)";
            sqlCommand.Parameters.AddWithValue("@rua", user.rua);
            sqlCommand.Parameters.AddWithValue("@numero", user.numero);
            sqlCommand.Parameters.AddWithValue("@bairro", user.bairro);
            sqlCommand.Parameters.AddWithValue("@cidade", user.cidade);
            sqlCommand.Parameters.AddWithValue("@estado", user.estado);
            sqlCommand.Parameters.AddWithValue("@telefone", user.telefone);
            sqlCommand.Parameters.AddWithValue("@idaddress", user.idaddress);
            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteUser(int Idaddress)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM address WHERE idaddress = @idaddress";
            sqlCommand.Parameters.AddWithValue("@idaddress", Idaddress);
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
