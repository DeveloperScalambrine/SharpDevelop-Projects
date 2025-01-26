/*
 * Created by SharpDevelop.
 * User: Family
 * Date: 26/01/2025
 * Time: 02:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace FlightManager
{
	/// <summary>
	/// Description of DatabaseHelper.
	/// </summary>
	public class DatabaseHelper
	{
		const string DatabaseFile = "acme.sqlite";
		SQLiteConnection connection;		
		
		
		 // Inicializa e cria o banco de dados se necessário
        public void InitializeDatabase()
        {
            if (!File.Exists(DatabaseFile))
            {
                SQLiteConnection.CreateFile(DatabaseFile);
                MessageBox.Show("Arquivo criado com sucesso e criado uma nova conexão");
            }
            else
            {
            	 MessageBox.Show("Arquivo ja criado e conexão com o banco aberta");
            }
            string databaseFile = DatabaseFile;
			string connectionString = string.Format("Data Source={0};Version=3;", databaseFile);
			connection = new SQLiteConnection(connectionString);
            connection.Open();

            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS TB_VOO (
                    ID_VOO INTEGER PRIMARY KEY AUTOINCREMENT,
                    DATA_VOO DATETIME,
                    CUSTO NUMERIC(10,2),
                    DISTANCIA INT,
                    CAPTURA CHAR(1),
                    NIVEL_DOR INT
                )";
            using (var command = new SQLiteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
	}
}
