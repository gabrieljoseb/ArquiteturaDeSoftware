using System.Data;
using System.Data.SqlClient;

namespace SOLID.SRP.Solucao
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE(NOME, EMAIL, CPF, DATACADASTRO) VALUE (@nome, @email, @cpf, @dataCad)";

                cmd.Parameters.AddWithValue(parameterName: "nome", cliente.Nome);
                cmd.Parameters.AddWithValue(parameterName: "email", cliente.Email);
                cmd.Parameters.AddWithValue(parameterName: "cpf", cliente.CPF);
                cmd.Parameters.AddWithValue(parameterName: "dataCad", cliente.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
