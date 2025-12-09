using System.Data;
using System.Data.SqlClient;

public class Database
{
    // ✅ STRING DE CONEXÃO — ajuste para o nome do seu servidor e banco
    private string connectionString = "Data Source=SEU_SERVIDOR;Initial Catalog=SEU_BANCO;Integrated Security=True";

    // ✅ MÉTODO PARA ABRIR CONEXÃO
    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    // ✅ MÉTODO PARA EXECUTAR PROCEDURES (INSERT, UPDATE, DELETE)
    public void ExecuteProcedure(string procedureName, SqlParameter[] parameters)
    {
        using (SqlConnection conn = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(procedureName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    // ✅ MÉTODO PARA SELECT (RETORNA TABELA)
    public DataTable ExecuteSelect(string procedureName, SqlParameter[] parameters)
    {
        using (SqlConnection conn = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(procedureName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}

