using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;


namespace ConexaoDllMaster
{
    public class clsPostgres
    {
        #region Atributos

        private string _nomeBanco = string.Empty;
        private string _nomeServidor = string.Empty;
        private string _senha = string.Empty;
        private string _usuario = string.Empty;

        private NpgsqlConnection _conn;
        

        #endregion

        #region Propriedades

        public string connString
        {
            get
            { 
                return "Server=" + _nomeServidor + ";" + 
                    "Port=5432;" + 
                    "UserId=postgres;" + 
                    "Password='" + _senha + "';" +
                    "Database=" + _nomeBanco + "";  
            } 
        }
        
        #endregion

        #region Construtores

        public clsPostgres()
        { }


        /// <summary>
        /// Constroi o objeto para conectar no psql
        /// </summary>
        /// <param name="pNomeServidor">Passar o nome do servidor</param>
        /// <param name="pNomeBanco">Passar o nome do Banco. Inicial sempre minuscula</param>
        /// <param name="psenha">Passar a senha do usuário</param>
        public clsPostgres(string pNomeServidor,
                            string pNomeBanco,
                            string psenha)
        {
            _nomeServidor = pNomeServidor;
            _nomeBanco = pNomeBanco;
            _senha = psenha;        
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Método para Conectar Com o banco de Dados
        /// Postgres SQL
        /// Passe os paramentros corretos no Construtor.
        /// </summary>
        public void Conectar()
        {
            //MessageBox.Show("Vai Conectar em \n"
            //    + "Servidor: " + _nomeServidor
            //    + " Banco: " + _nomeBanco,
            //    "Atenção",MessageBoxButtons.OK,
            //    MessageBoxIcon.Exclamation);

            _conn.ConnectionString = connString;
            _conn.Open();
        }

        public void Desconectar()
        {
            _conn.Close();
            //MessageBox.Show("Desconectado. Volte Sempre");
        }
        

        #endregion

        #region Métodos Staticos

        public static DataTable getDataTable()
        {
            return null;
        }

        public static NpgsqlDataReader getDataReader()
        {
            return null;
        }

        public static void ExecCommand()
        { }



        #endregion

    }
}
