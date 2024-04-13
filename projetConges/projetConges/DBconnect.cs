using System;
using System.Data.SqlClient;

namespace projetConges
{
    class DBconnect
    {
        // Méthode pour effectuer des opérations sur la base de données
        public static void ExecuteDatabaseOperations()
        {
            string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connexion réussie.");

                    // Exemple de requête SELECT
                    string sqlQuery = "SELECT * FROM MaTable;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["Colonne1"]);
                        // Vous pouvez accéder aux valeurs des colonnes par leur nom ou leur index
                    }
                    reader.Close();

                    // Exemple de requête INSERT
                    sqlQuery = "INSERT INTO MaTable (Colonne1, Colonne2) VALUES ('Valeur1', 'Valeur2');";
                    command = new SqlCommand(sqlQuery, connection);
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Nombre de lignes affectées par l'insertion : " + rowsAffected);

                    // Exemple de requête UPDATE
                    sqlQuery = "UPDATE MaTable SET Colonne1 = 'NouvelleValeur' WHERE Colonne2 = 'Valeur2';";
                    command = new SqlCommand(sqlQuery, connection);
                    rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Nombre de lignes affectées par la mise à jour : " + rowsAffected);

                    // Exemple de requête DELETE
                    sqlQuery = "DELETE FROM MaTable WHERE Colonne1 = 'ValeurSupprimer';";
                    command = new SqlCommand(sqlQuery, connection);
                    rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Nombre de lignes affectées par la suppression : " + rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur : " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine("Connexion fermée.");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DBconnect.ExecuteDatabaseOperations();
        }
    }
}
