using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace _509ITCRUDapp
{
     public class DbConn
    {
        private string connString = "Server=localhost;User ID=root ;Password=; Database=509itcrudsys";

        public DataTable getAllPersonal()
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                DataTable personalContactDt = new DataTable();
                List<PersContact> persContacts = new List<PersContact>();
                using (var cmd = new MySqlCommand("CALL select_all_personal();", conn)) {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            persContacts.Add(new PersContact
                            {
                                id = reader.GetInt32(0),
                                first_name = reader.GetString(1),
                                last_name = reader.GetString(2),
                                email = reader.GetString(3),
                                phone_number = reader.GetString(4),
                                address_line_1 = reader.GetString(5),
                                address_line_2 = reader.GetString(6),
                                postcode = reader.GetString(7),
                                country = reader.GetString(8)
                            });
                        }
                    }
                }          

                personalContactDt.Columns.Add("Personal ID");
                personalContactDt.Columns.Add("First Name");
                personalContactDt.Columns.Add("Last Name");
                personalContactDt.Columns.Add("Email");
                personalContactDt.Columns.Add("Phone number");
                personalContactDt.Columns.Add("Address line 1");
                personalContactDt.Columns.Add("Address line 2");
                personalContactDt.Columns.Add("Postcode");
                personalContactDt.Columns.Add("Country");

                foreach (var item in persContacts)
                {
                    var row = personalContactDt.NewRow();

                    row["Personal ID"] = item.id;
                    row["First Name"] = item.first_name;
                    row["Last Name"] = item.last_name;
                    row["Email"] = item.email;
                    row["Phone number"] = item.phone_number;
                    row["Address line 1"] = item.address_line_1;
                    row["Address line 2"] = item.address_line_2;
                    row["Postcode"] = item.postcode;
                    row["Country"] = item.country;

                    personalContactDt.Rows.Add(row);
                }

                return personalContactDt;
            }
        }




        public DataTable getAllBusiness()
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                DataTable businessContactDt = new DataTable();
                List<BusiContact> busiContacts = new List<BusiContact>();
                using (var cmd = new MySqlCommand("CALL select_all_business();", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            busiContacts.Add(new BusiContact
                            {
                                id = reader.GetInt32(0),
                                first_name = reader.GetString(1),
                                last_name = reader.GetString(2),
                                email = reader.GetString(3),
                                address_line_1 = reader.GetString(5),
                                address_line_2 = reader.GetString(6),
                                postcode = reader.GetString(7),
                                country = reader.GetString(8),
                                company = reader.GetString(9),
                                business_phone_number = reader.GetString(10)
                            });
                        }
                    }
                       
                }
                   
                businessContactDt.Columns.Add("Personal ID");
                businessContactDt.Columns.Add("First Name");
                businessContactDt.Columns.Add("Last Name");
                businessContactDt.Columns.Add("Email");
                businessContactDt.Columns.Add("Business phone number");
                businessContactDt.Columns.Add("Address line 1");
                businessContactDt.Columns.Add("Address line 2");
                businessContactDt.Columns.Add("Postcode");
                businessContactDt.Columns.Add("Country");
                businessContactDt.Columns.Add("Company");

                foreach (var item in busiContacts)
                {
                    var row = businessContactDt.NewRow();

                    row["Personal ID"] = item.id;
                    row["First Name"] = item.first_name;
                    row["Last Name"] = item.last_name;
                    row["Email"] = item.email;
                    row["Business phone number"] = item.business_phone_number;
                    row["Address line 1"] = item.address_line_1;
                    row["Address line 2"] = item.address_line_2;
                    row["Postcode"] = item.postcode;
                    row["Country"] = item.country;
                    row["Company"] = item.company;

                    businessContactDt.Rows.Add(row);
                }
                return businessContactDt;
            }
        }


        public async void InsertPersoanl(PersContact personalContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL add_personal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8);";
                    cmd.Parameters.AddWithValue("p1", personalContact.first_name);
                    cmd.Parameters.AddWithValue("p2", personalContact.last_name);
                    cmd.Parameters.AddWithValue("p3", personalContact.email);
                    cmd.Parameters.AddWithValue("p4", personalContact.phone_number);
                    cmd.Parameters.AddWithValue("p5", personalContact.address_line_1);
                    cmd.Parameters.AddWithValue("p6", personalContact.address_line_2);
                    cmd.Parameters.AddWithValue("p7", personalContact.postcode);
                    cmd.Parameters.AddWithValue("p8", personalContact.country);
                    await cmd.ExecuteNonQueryAsync();
                }
            }

        }


        public async void InsertBusiness(BusiContact businessContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL add_business(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    cmd.Parameters.AddWithValue("p1", businessContact.first_name);
                    cmd.Parameters.AddWithValue("p2", businessContact.last_name);
                    cmd.Parameters.AddWithValue("p3", businessContact.email);
                    cmd.Parameters.AddWithValue("p4", businessContact.address_line_1);
                    cmd.Parameters.AddWithValue("p5", businessContact.address_line_2);
                    cmd.Parameters.AddWithValue("p6", businessContact.postcode);
                    cmd.Parameters.AddWithValue("p7", businessContact.country);
                    cmd.Parameters.AddWithValue("p8", businessContact.company);
                    cmd.Parameters.AddWithValue("p9", businessContact.business_phone_number);
                    await cmd.ExecuteNonQueryAsync();
                }
            }

        }


        public async void UpdatePersonal (PersContact personalContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL update_personal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    cmd.Parameters.AddWithValue("p1", personalContact.id);
                    cmd.Parameters.AddWithValue("p2", personalContact.first_name);
                    cmd.Parameters.AddWithValue("p3", personalContact.last_name);
                    cmd.Parameters.AddWithValue("p4", personalContact.email);
                    cmd.Parameters.AddWithValue("p5", personalContact.phone_number);
                    cmd.Parameters.AddWithValue("p6", personalContact.address_line_1);
                    cmd.Parameters.AddWithValue("p7", personalContact.address_line_2);
                    cmd.Parameters.AddWithValue("p8", personalContact.postcode);
                    cmd.Parameters.AddWithValue("p9", personalContact.country);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async void UpdateBusiness(BusiContact businessContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL update_business(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10);";
                    cmd.Parameters.AddWithValue("p1", businessContact.id);
                    cmd.Parameters.AddWithValue("p2", businessContact.first_name);
                    cmd.Parameters.AddWithValue("p3", businessContact.last_name);
                    cmd.Parameters.AddWithValue("p4", businessContact.email);
                    cmd.Parameters.AddWithValue("p5", businessContact.address_line_1);
                    cmd.Parameters.AddWithValue("p6", businessContact.address_line_2);
                    cmd.Parameters.AddWithValue("p7", businessContact.postcode);
                    cmd.Parameters.AddWithValue("p8", businessContact.country);
                    cmd.Parameters.AddWithValue("p9", businessContact.company);
                    cmd.Parameters.AddWithValue("p10", businessContact.business_phone_number);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async void DeletePersonal(int id)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL delete_personal(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                     await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async void DeleteBusiness(int id)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL delete_business(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
