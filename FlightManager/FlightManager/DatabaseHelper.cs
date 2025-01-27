﻿/*
 * Created by SharpDevelop.
 * User: Family
 * Date: 26/01/2025
 * Time: 02:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

public class DatabaseHelper
{
    private const string DatabaseFile = "acme.sqlite";
    private SQLiteConnection connection;

    // Inicializa e cria o banco de dados, se necessário
    public void InitializeDatabase()
    {
        if (!File.Exists(DatabaseFile))
        {
            SQLiteConnection.CreateFile(DatabaseFile);
            MessageBox.Show("Arquivo criado com sucesso e criada uma nova conexão.");
        }
        else
        {
            MessageBox.Show("Arquivo já existe. Conexão com o banco aberta.");
        }

        const string databaseFile = DatabaseFile;
		string connectionString = string.Format("Data Source={0};Version=3;", databaseFile);
		connection = new SQLiteConnection(connectionString);
        connection.Open();
            
        const string createTableQuery = @"
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

    // Carrega os voos no ListView fornecido
    public void LoadFlights(ListView lstVoos)
    {
        lstVoos.Items.Clear();

        const string selectQuery = "SELECT ID_VOO, DATA_VOO, CAPTURA, NIVEL_DOR FROM TB_VOO";

        using (var command = new SQLiteCommand(selectQuery, connection))
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
            	  
            	string dataVooStr = reader["DATA_VOO"].ToString();
				string dataVooFormatada = "Data inválida";

// Tenta converter DATA_VOO para DateTime
				DateTime dataVoo;
				if (DateTime.TryParse(dataVooStr, out dataVoo))
				{
				    // Converte para o formato desejado
				    dataVooFormatada = dataVoo.ToString("dd/MM/yyyy HH:mm");
				}
				else
				{
				    // Se não for possível converter, mantemos "Data inválida"
				    dataVooFormatada = "Data inválida";
				}

            	
                var item = new ListViewItem(reader["DATA_VOO"].ToString());
                item.SubItems.Add(reader["CAPTURA"].ToString());
                item.SubItems.Add(reader["NIVEL_DOR"].ToString());
                item.Tag = reader["ID_VOO"];
                lstVoos.Items.Add(item);
            }
        }
    }
}
