
namespace CrudApp
{
    internal class Database
    {
        public bool HasConnection = false;

        public Database() 
        {
            try
            {
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
                connection.ConnectionString = CrudApp.Properties.Resources.DatabaseConnectionString;
                connection.Open();
                connection.Close();
                connection.Dispose();
                HasConnection = true;
            }
            catch (Exception ex)
            {
                HasConnection = false;
                MessageBox.Show(ex.Message, "Error in CRUD Database connection", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        public bool Update(CrudApp.Customer customerObject)
        {
            try
            {
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
                connection.ConnectionString = CrudApp.Properties.Resources.DatabaseConnectionString;
                connection.Open();

                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand();
                command.Connection = connection;


                System.Data.OleDb.OleDbParameter NameParameter = new System.Data.OleDb.OleDbParameter();
                NameParameter.ParameterName = "@CustomerName";
                NameParameter.DbType = System.Data.DbType.String;
                NameParameter.Value = customerObject.CustomerName;
                command.Parameters.Add(NameParameter);

                System.Data.OleDb.OleDbParameter DOBParameter = new System.Data.OleDb.OleDbParameter();
                DOBParameter.ParameterName = "@DOB";
                DOBParameter.DbType = System.Data.DbType.Date;
                DOBParameter.Value = customerObject.DOB;
                command.Parameters.Add(DOBParameter);

                System.Data.OleDb.OleDbParameter LicenseParameter = new System.Data.OleDb.OleDbParameter();
                LicenseParameter.ParameterName = "@Licensed";
                LicenseParameter.DbType = System.Data.DbType.Boolean;
                LicenseParameter.Value = customerObject.Licensed;
                command.Parameters.Add(LicenseParameter);

                System.Data.OleDb.OleDbParameter ContactParameter = new System.Data.OleDb.OleDbParameter();
                ContactParameter.ParameterName = "@ContactNumber";
                ContactParameter.DbType = System.Data.DbType.String;
                ContactParameter.Value = customerObject.ContactNumber;
                command.Parameters.Add(ContactParameter);

                command.CommandText = "UPDATE Details SET CustomerName = @CustomerName, DOB = @DOB, Licensed = @Licensed, ContactNumber = @ContactNumber " +
                    "WHERE ID =" + customerObject.CustomerID + ";";
                command.ExecuteNonQuery();

                connection.Close();
                command.Dispose();
                connection.Dispose();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Customer - Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool Delete(CrudApp.Customer customerObject)
        {
            try
            {
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
                connection.ConnectionString = CrudApp.Properties.Resources.DatabaseConnectionString;
                connection.Open();

                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand();
                command.Connection = connection;

                command.CommandText = "DELETE FROM Details WHERE ID =" + customerObject.CustomerID + ";";
                command.ExecuteNonQuery();

                connection.Close();
                command.Dispose();
                connection.Dispose();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Customer - Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public Customer[] Read()
        {
            CrudApp.Customer[] customers = [];
            try
            {
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
                connection.ConnectionString = CrudApp.Properties.Resources.DatabaseConnectionString;
                connection.Open();

                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM Details;";
                int recordCount = 0;
                var userNameObj = command.ExecuteScalar();
                if (userNameObj != null)
                {
                    recordCount = (int)userNameObj;
                }
                if (recordCount > 0)
                {
                    int i = 0;
                    customers = new Customer[recordCount];
                    command.CommandText = "SELECT * FROM Details;";
                    System.Data.OleDb.OleDbDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            customers[i] = new Customer();
                            customers[i].CustomerID = (int) reader[0];
                            customers[i].CustomerName = (string) reader[1];
                            customers[i].DOB = (DateTime)reader[2];
                            customers[i].Licensed = (bool)reader[3];
                            customers[i].ContactNumber = (string) reader[4];
                            i++;
                        }
                    }
                    reader.Close();
                    connection.Close();
                    command.Dispose();
                    connection.Dispose();
                    return customers;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error in Read Data - Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return customers;
        }

        public CrudApp.Customer GetCustomerByID(int id)
        {
            CrudApp.Customer customer = new CrudApp.Customer();
            try
            {
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
                connection.ConnectionString = CrudApp.Properties.Resources.DatabaseConnectionString;
                connection.Open();

                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand();
                command.Connection = connection;

                command.CommandText = "SELECT * FROM Details WHERE ID =" + id + ";";
                System.Data.OleDb.OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    customer.CustomerID = (int)reader[0];
                    customer.CustomerName = (string)reader[1];
                    customer.DOB = (DateTime)reader[2];
                    customer.Licensed = (bool)reader[3];
                    customer.ContactNumber = (string)reader[4];
                }
                reader.Close();
                connection.Close();
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Customer - Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return customer;
        }

        public bool Create(CrudApp.Customer customerObject)
        {
            try
            {
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
                connection.ConnectionString = CrudApp.Properties.Resources.DatabaseConnectionString;
                connection.Open();
                
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand();
                command.Connection = connection;


                System.Data.OleDb.OleDbParameter NameParameter = new System.Data.OleDb.OleDbParameter();
                NameParameter.ParameterName = "@CustomerName";
                NameParameter.DbType = System.Data.DbType.String;
                NameParameter.Value = customerObject.CustomerName;
                command.Parameters.Add(NameParameter);

                System.Data.OleDb.OleDbParameter DOBParameter = new System.Data.OleDb.OleDbParameter();
                DOBParameter.ParameterName = "@DOB";
                DOBParameter.DbType = System.Data.DbType.Date;
                DOBParameter.Value = customerObject.DOB;
                command.Parameters.Add(DOBParameter);

                System.Data.OleDb.OleDbParameter LicenseParameter = new System.Data.OleDb.OleDbParameter();
                LicenseParameter.ParameterName = "@Licensed";
                LicenseParameter.DbType = System.Data.DbType.Boolean;
                LicenseParameter.Value = customerObject.Licensed;
                command.Parameters.Add(LicenseParameter);

                System.Data.OleDb.OleDbParameter ContactParameter = new System.Data.OleDb.OleDbParameter();
                ContactParameter.ParameterName = "@ContactNumber";
                ContactParameter.DbType = System.Data.DbType.String;
                ContactParameter.Value = customerObject.ContactNumber;
                command.Parameters.Add(ContactParameter);


                command.CommandText = "INSERT INTO Details (CustomerName, DOB, Licensed, ContactNumber) " +
                    " values (@CustomerName, @DOB, @Licensed, @ContactNumber)";
                command.ExecuteNonQuery();


                connection.Close();
                command.Dispose();
                connection.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Create Data - Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
