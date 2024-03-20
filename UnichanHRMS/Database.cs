using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnichanHRMS.Models;
using UnichanHRMS.Security;

namespace UnichanHRMS
{
    class Database
    {

        String connectionString = "";
        public MySqlConnection db;

        public Database()
        {
            connectionString = ConfigurationManager.ConnectionStrings["unichan"].ConnectionString;
            db = new MySqlConnection(connectionString);
        }

        private void checkConnection()
        {
            if (this.db.State == ConnectionState.Open)
            {
                this.db.Close();
                this.db.Open();
            }
            else
            {
                this.db.Open();
            }
        }
        private void closeConnection()
        {
            if (this.db.State == ConnectionState.Open)
            {
                this.db.Close();
            }
            else
            {
            }
        }

        public int passwordStrengthChecker(String password) {
            int result = 0;

            if (password.Length >= 8)
                result++;
            if (password.Length >= 12)
                result++;
            if (Regex.Match(password, @"/\d+/", RegexOptions.ECMAScript).Success)
                result++;
            if (Regex.Match(password, @"/[a-z]/", RegexOptions.ECMAScript).Success &&
              Regex.Match(password, @"/[A-Z]/", RegexOptions.ECMAScript).Success)
                result++;
            if (Regex.Match(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
                result++;

            return (result * 100) / 2 ;
        
        }
        public bool adminLogin(String username, String password)
        {
            bool result = false;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT username, password,ID, full_name FROM user WHERE username = @username OR password = @password AND access = 'admin'";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", encryptPassword(password, "yamato"));
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    try
                    {
                        if (reader.GetString(0) == username && reader.GetString(1) == encryptPassword(password,"yamato"))
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Properties.Settings.Default.UserStates =reader.GetString("full_name");
                            Properties.Settings.Default.Save();
                            command.Dispose();
                            this.db.Close();

                            checkForRegulars();
                            return true;
                        }
                        else if (reader.GetString(0) == username && reader.GetString(1) != password)
                        {
                            MessageBox.Show("You entered the wrong password", "Login Failed");
                            result = false;
                        }
                        else
                        {
                            MessageBox.Show("Invalid username and password.","Login Failed");
                            result = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        result = false;
                    }


                }
                else
                {
                    MessageBox.Show("User does not exist");
                    result = false;

                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public bool hrLogin(String username, String password)
        {
            bool result = false;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT username, password,ID FROM user WHERE username = @username OR password = @password AND access = 'hiring_manager'";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", encryptPassword(password,"yamato"));
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    try
                    {
                        if (reader.GetString(0) == username && reader.GetString(1) == password)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            command.Dispose();
                            this.db.Close();
                            return true;
                        }
                        else if (reader.GetString(0) == username && reader.GetString(1) != password)
                        {
                            MessageBox.Show("You entered the wrong password", "Login Failed");
                            result = false;
                        }
                        else
                        {
                            MessageBox.Show("Invalid username and password.", "Login Failed");
                            result = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        result = false;
                    }


                }
                else
                {
                    MessageBox.Show("User does not exist");
                    result = false;

                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public String encryptPassword(String originalPassword,String passwordKey) {
            string encrypted = Cryptography.Encrypt(originalPassword, passwordKey);
            return encrypted;
        }
        public String decryptPassword(String encryptedPassword, String passwordKey)
        {
            string decrypted = Cryptography.Decrypt(encryptedPassword, passwordKey);
            return decrypted;
        }
        public List<String> getRecipientNames()
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM recipient";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    recipientNames.Add(reader.GetString("name"));
                }

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }

        public List<String> getRecipientNumbers()
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM recipient";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    recipientNames.Add(reader.GetString("contact_number"));
                }

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }
        public void deleteAttendance(String month, String year, String date_from, String date_to)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "DELETE FROM `monthly_attendance` WHERE month = @month AND year = @year AND date_from = @date_from AND date_to = @date_to";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@date_from", date_from);
                command.Parameters.AddWithValue("@date_to", date_to);
                command.ExecuteNonQuery();
                MessageBox.Show("Records successfully deleted!");
                command.Dispose();
                this.db.Close();
            }
        }

        public DataTable fillEmployeesTable(ref DataGridView dgv,String employment_status)
        {
            DataTable dataTable1 = new DataTable(); 
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT  `employee_ID`, `generated_ID` AS 'ID'," +
                    " `first_name` AS 'First Name', `middle_name` AS 'Middle Name', " +
                    "`last_name` AS 'Last Name', `age` AS 'Age', `birth_date` AS 'Birthday', `gender` AS 'Gender', " +
                    "`contact` AS 'Contact #', `applicant`.`batch_number` AS 'Batch Number', `sss_number` AS 'SSS Number', " +
                    "`philhealth_number` AS 'PhilHealth Number', `pag_ibig_number` AS 'Pag-ibig Number', `TIN_number` AS " +
                    "'TIN', `orientation_date` AS 'Orientation Date', `employment_status` AS 'Employment Status'," +
                    " `employment_remarks` AS 'Employment Remarks'  ,(`available_leave` - `leaves_used`) AS 'Leaves Available' FROM `employee` INNER JOIN `applicant` ON `applicant`.`applicant_ID` = " +
                    " `employee`.`applicant_ID` WHERE `employment_status` = @employment_status;";
                command.Parameters.AddWithValue("@employment_status", employment_status);
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
               
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                dgv.Columns[0].Visible = false;
                command.Dispose();
                this.db.Close();
            }
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT  * ,(`available_leave` - `leaves_used`) AS 'Leaves Available' FROM `employee` INNER JOIN `applicant` ON `applicant`.`applicant_ID` = " +
                    " `employee`.`applicant_ID` WHERE `employment_status` = @employment_status;";
                command.Parameters.AddWithValue("@employment_status", employment_status);
                MySqlDataReader reader = command.ExecuteReader();


                dataTable1.Load(reader);
                command.Dispose();
                this.db.Close();
                return dataTable1;
            }
        }

        public DataTable filterEmployeesTable(ref DataGridView dgv, String filter,String criteria)
        {
            DataTable data = new DataTable();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `employee_ID` AS 'ID'," +
                    " `first_name` AS 'First Name', `middle_name` AS 'Middle Name', " +
                    "`last_name` AS 'Last Name', `age` AS 'Age', `birth_date` AS 'Birthday', `gender` AS 'Gender', " +
                    "`contact` AS 'Contact #', `applicant`.`batch_number` AS 'Batch Number', `sss_number` AS 'SSS Number', " +
                    "`philhealth_number` AS 'PhilHealth Number', `pag_ibig_number` AS 'Pag-ibig Number', `TIN_number` AS " +
                    "'TIN', `orientation_date` AS 'Orientation Date', `employment_status` AS 'Employment Status'," +
                    " `employment_remarks` AS 'Employment Remarks'  ,(`available_leave` - `leaves_used`) AS 'Leaves Available' FROM `employee` INNER JOIN `applicant` ON `applicant`.`applicant_ID` = " +
                    " `employee`.`applicant_ID` WHERE `employee`.`" + filter + "` = @criteria;";
                command.Parameters.AddWithValue("@criteria", criteria);
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();

            }
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT *  ,(`available_leave` - `leaves_used`) AS 'Leaves Available' FROM `employee` INNER JOIN `applicant` ON `applicant`.`applicant_ID` = " +
                    " `employee`.`applicant_ID` WHERE `employee`.`" + filter + "` = @criteria;";
                command.Parameters.AddWithValue("@criteria", criteria);
                MySqlDataReader reader = command.ExecuteReader();

                data.Load(reader);

                command.Dispose();
                this.db.Close();
                return data;
            }
        }
        public List<String> filterEmployeesTableByName(ref DataGridView dgv, String name)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `employee_ID` AS 'ID'," +
                    " `first_name` AS 'First Name', `middle_name` AS 'Middle Name', " +
                    "`last_name` AS 'Last Name', `age` AS 'Age', `birth_date` AS 'Birthday', `gender` AS 'Gender', " +
                    "`contact` AS 'Contact #', `applicant`.`batch_number` AS 'Batch Number', `sss_number` AS 'SSS Number', " +
                    "`philhealth_number` AS 'PhilHealth Number', `pag_ibig_number` AS 'Pag-ibig Number', `TIN_number` AS " +
                    "'TIN', `orientation_date` AS 'Orientation Date', `employment_status` AS 'Employment Status'," +
                    " `employment_remarks` AS 'Employment Remarks'  ,(`available_leave` - `leaves_used`) AS 'Leaves Available' FROM `employee` INNER JOIN `applicant` ON `applicant`.`applicant_ID` = " +
                    " `employee`.`applicant_ID` WHERE `middle_name` LIKE @criteria OR `first_name` LIKE @criteria OR `last_name` LIKE @criteria;";
                command.Parameters.AddWithValue("@criteria", "%"+name+"%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }
        public List<String> fillBatchTable(ref DataGridView dgv)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `batch_number` AS 'Batch Number', `number_of_applicants` AS 'Applicants', `number_of_hired_applicants`  AS 'Hired'," +
                    " `date_created`  AS 'Hiring Date' FROM `batch`";
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }
        public List<String> fillApplicantsTableWithRejected(ref DataGridView dgv)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `applicant_ID` AS 'ID', `first_name` AS 'First Name', " +
                    "`middle_name` AS 'Middle Name', `last_name` AS 'Last Name', `age` AS 'Age', `birth_date` AS 'Birthday', " +
                    "`gender` AS 'Gender', `contact` AS 'Contact', `application_date` AS 'Application Date'," +
                    " `exam_date` AS 'Exam Date', `initial_interview_date` AS 'Initial Interview Date'," +
                    " `final_interview_date` AS 'Final Interview Date',`application_status` AS 'Application Status',`remarks` AS 'Remarks'" +
                    " FROM `applicant` WHERE `application_status` != 'hired' ;";
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }
        public List<String> fillApplicantsTable(ref DataGridView dgv)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `applicant_ID` AS 'ID', `first_name` AS 'First Name', " +
                    "`middle_name` AS 'Middle Name', `last_name` AS 'Last Name', `age` AS 'Age', `birth_date` AS 'Birthday', " +
                    "`gender` AS 'Gender', `contact` AS 'Contact', `application_date` AS 'Application Date'," +
                    " `exam_date` AS 'Exam Date', `initial_interview_date` AS 'Initial Interview Date'," +
                    " `final_interview_date` AS 'Final Interview Date',`application_status` AS 'Application Status',`remarks` AS 'Remarks'" +
                    " FROM `applicant` WHERE `application_status` != 'hired'AND `application_status` != 'rejected';";
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }

        public List<String> fillUsersTable(ref DataGridView dgv,String type)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `ID`, `username` AS 'Username', `full_name` AS 'Full name', `password` AS 'Password'," +
                    " `address` AS 'Address', `contact` AS 'Contact #' FROM `user` WHERE `access` = @type";
                command.Parameters.AddWithValue("@type",type);
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                dgv.Columns[0].Visible = false;
                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }
        public List<String> fillVisitorsTable(ref DataGridView dgv)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `visitor_ID`, `name` AS 'Name', `company` AS 'Company', `time_in` AS 'Time in', `time_out` AS" +
                    " 'Time out', `date_of_visit` AS 'Date', `purpose` AS 'Purpose' FROM `visitor`;";
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                dgv.Columns[0].Visible = false;
                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }
        public List<String> filterApplicantsTable(ref DataGridView dgv,String searchTerm)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `applicant_ID` AS 'ID', `first_name` AS 'First Name', " +
                    "`middle_name` AS 'Middle Name', `last_name` AS 'Last Name', `age` AS 'Age', `birth_date` AS 'Birthday', `birth_date` AS 'Birthday', " +
                    "`gender` AS 'Gender', `contact` AS 'Contact', `application_date` AS 'Application Date'," +
                    " `exam_date` AS 'Exam Date', `initial_interview_date` AS 'Initial Interview Date'," +
                    " `final_interview_date` AS 'Final Interview Date',`application_status` AS 'Application Status' FROM `applicant` WHERE `application_status` != 'hired'" +
                    " AND (`first_name` LIKE @searchTerm OR `middle_name` LIKE @searchTerm OR `last_name` LIKE @searchTerm)";
                command.Parameters.AddWithValue("@searchTerm", "%"+searchTerm+"%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }
        public DataTable fillEmployeesTableByBatchNumber(ref DataGridView dgv,String batchNumber,String employment_status)
        {
            List<String> recipientNames = new List<String>();
            DataTable data = new DataTable();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `employee_ID` AS 'ID', `batch_number` AS 'Batch Number', `sss_number` AS 'SSS Number', " +
                    "`philhealth_number` AS 'PhilHealth Number', `pag_ibig_number` AS 'Pag-ibig Number', `TIN_number` AS " +
                    "'TIN', `orientation_date` AS 'Orientation Date', `employment_status` AS 'Employment Status'," +
                    " `employment_remarks` AS 'Employment Remarks'  FROM `employee` WHERE batch_number = @batch_number AND `employment_status` = @employment_status";
                command.Parameters.AddWithValue("@batch_number",batchNumber);
                command.Parameters.AddWithValue("@employment_status", employment_status);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `employee_ID` AS 'ID', `batch_number` AS 'Batch Number', `sss_number` AS 'SSS Number', " +
                    "`philhealth_number` AS 'PhilHealth Number', `pag_ibig_number` AS 'Pag-ibig Number', `TIN_number` AS " +
                    "'TIN', `orientation_date` AS 'Orientation Date', `employment_status` AS 'Employment Status'," +
                    " `employment_remarks` AS 'Employment Remarks'  FROM `employee` WHERE batch_number = @batch_number AND `employment_status` = @employment_status";
                command.Parameters.AddWithValue("@batch_number", batchNumber);
                command.Parameters.AddWithValue("@employment_status", employment_status);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                data.Load(reader);

                command.Dispose();
                this.db.Close();
                return data;
            }
        }

        public List<String> getBatchNumbers()
        {
            List<String> batchNumbers = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT `batch_number` FROM `batch` ORDER BY `batch_number` ASC";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    batchNumbers.Add(reader.GetInt32("batch_number").ToString());
                }

                command.Dispose();
                this.db.Close();
                return batchNumbers;
            }
        }
        public List<String> fillAttendanceTable(ref DataGridView dgv, String month, String year)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT employees.control_number AS 'Control Number', month AS 'Month', DATE_FORMAT(date_from, ' %M %d') AS 'From',  DATE_FORMAT(date_to, ' %M %d') AS 'To', days_present AS 'Operational days', days_absent AS 'Absent', days_breakdown AS 'Non operating days', name AS 'Employee', employees.shop_rate AS 'Shop Rate', employees.operational_rate AS 'Operational Rate',  IF(employees.rate = 0,'Variable','Flat') AS 'Rate type',IF(employees.rate = 0,FORMAT (((employees.operational_rate*days_present) + (employees.shop_rate*days_breakdown) +  ((employees.operational_rate/8)*monthly_attendance.overtime_hours)),2),FORMAT(employees.rate,2)) AS 'Total Receivable to date' FROM monthly_attendance INNER JOIN employees ON employee = employees.control_number WHERE month = @month AND year = @year;";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }
        public int getWorkingDays(String month, String year)
        {
            int workingDays = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT working_days FROM monthly_attendance WHERE month = @month AND year = @year GROUP BY working_days";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    workingDays = reader.GetInt32("working_days");
                }

                command.Dispose();
                this.db.Close();
                return workingDays;
            }
        }
        public List<String> fillAttendanceTable(ref DataGridView dgv, String month, String year, String site)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT employees.control_number AS 'Control Number', month AS 'Month', DATE_FORMAT(date_from, ' %M %d') AS 'From',  DATE_FORMAT(date_to, ' %M %d') AS 'To', days_present AS 'Operational days', days_absent AS 'Absent', days_breakdown AS 'Non operating days', name AS 'Employee', employees.shop_rate AS 'Shop Rate', employees.operational_rate AS 'Operational Rate',  IF(employees.rate = 0,'Variable','Flat') AS 'Rate type' FROM monthly_attendance INNER JOIN employees ON employee = employees.control_number WHERE employees.site = @site AND month = @month AND year = @year;";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@site", site);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }

        public Double getPayrollTotal(ref DataGridView dgv, String month, String year, String site)
        {
            Double result = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT FORMAT(SUM(IF(employees.rate = 0,(((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth), employees.rate - cash_advance - loan - sss - pag_ibig - philhealth)),2) AS 'total' FROM `monthly_attendance` INNER JOIN employees ON employee = employees.control_number WHERE employees.site LIKE @site AND month = @month AND year = @year;";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@site", site);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetDouble("total");
                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public Double getPayrollTotal(ref DataGridView dgv, String month, String year)
        {
            Double result = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT FORMAT(SUM(IF(employees.rate = 0,(((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth), employees.rate - cash_advance - loan - sss - pag_ibig - philhealth)),2) AS 'total' FROM `monthly_attendance` INNER JOIN employees ON employee = employees.control_number WHERE month = @month AND year = @year;";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetDouble("total");
                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public DataTable fillAttendanceReportTable(String month, String year, String site)
        {
            DataTable dataTable = new DataTable();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT *, employees.control_number, month , DATE_FORMAT(date_from, ' %M %d') AS 'From',  DATE_FORMAT(date_to, ' %M %d') AS 'To', days_present , days_absent, days_breakdown, name, FORMAT(employees.shop_rate,2) AS 'shop_rate', FORMAT(employees.operational_rate,2) AS 'operational_rate',  IF(employees.rate = 0,'Variable','Flat') AS 'rate_type',FORMAT((monthly_attendance.days_breakdown * employees.shop_rate),2) AS 'shop_cost',FORMAT((monthly_attendance.days_present * employees.operational_rate),2) AS 'operational_cost',(monthly_attendance.overtime_hours * (employees.operational_rate/8)) AS 'overtime_cost',IF(employees.rate = 0,FORMAT(((monthly_attendance.days_breakdown * employees.shop_rate)+(monthly_attendance.days_present * employees.operational_rate)),2),FORMAT(employees.rate,2)) AS 'gross_amount',IF(employees.rate = 0,FORMAT(((monthly_attendance.days_breakdown * employees.shop_rate)+(monthly_attendance.days_present * employees.operational_rate)+(monthly_attendance.overtime_hours * (employees.operational_rate/8))),2),FORMAT(employees.rate,2)) AS 'gross_with_overtime',employees.site, cash_advance, loan,sss,pag_ibig,philhealth, IF(employees.rate = 0, FORMAT((((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8)) - (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth), 2), FORMAT(employees.rate - cash_advance - loan - sss - pag_ibig - philhealth, 2)) AS 'net_amount', IF(IF(employees.rate = 0, FORMAT((((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth), 2), FORMAT(employees.rate - cash_advance - loan - sss - pag_ibig - philhealth, 2)) >= 0, IF(employees.rate = 0, FORMAT((((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth), 2), FORMAT(employees.rate - cash_advance - loan - sss - pag_ibig - philhealth, 2)), 0) AS 'positive_only',month_end_cash_advance AS 'month_end_cash_advance_allocation',IF(IF(employees.rate = 0, FORMAT((((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth), 2), FORMAT(employees.rate - cash_advance - loan - sss - pag_ibig - philhealth, 2)) >= 0, IF(employees.rate = 0, FORMAT(((((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth) + month_end_cash_advance), 2), FORMAT((employees.rate - cash_advance - loan - sss - pag_ibig - philhealth + month_end_cash_advance), 2)), 0) AS 'total_receivable_to_date', IF(employees.rate = 0, FORMAT((((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth - month_end_cash_advance), 2), FORMAT((employees.rate - cash_advance - loan - sss - pag_ibig - philhealth - month_end_cash_advance), 2)) AS 'carried_over_cash_advance' FROM monthly_attendance INNER JOIN employees ON employee = employees.control_number WHERE employees.site LIKE @site AND month = @month AND year = @year;";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@site", "%" + site + "%");
                MySqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
                command.Dispose();
                this.db.Close();
            }
            return dataTable;
        }

        public List<String> searchAttendanceTable(ref DataGridView dgv, String month, String year, String site, String name)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT employees.control_number AS 'Control Number', month AS 'Month', DATE_FORMAT(date_from, ' %M %d') AS 'From',  DATE_FORMAT(date_to, ' %M %d') AS 'To', days_present AS 'Operational days', days_absent AS 'Absent', days_breakdown AS 'Non operating days', name AS 'Employee', employees.shop_rate AS 'Shop Rate', employees.operational_rate AS 'Operational Rate',  IF(employees.rate = 0,'Variable','Flat') AS 'Rate type' FROM monthly_attendance INNER JOIN employees ON employee = employees.control_number WHERE employees.site LIKE @site AND last_name LIKE @name OR name LIKE @name  AND employees.name LIKE @name AND month = @month AND year = @year;";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@site", "%" + site + "%");
                command.Parameters.AddWithValue("@name", "%" + name + "%");
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }

        public void fillEquipmentsTable(ref DataGridView dgv)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', cr_number AS 'Certificate of Registration Number', plate_number AS 'Plate Number', mv_file_number AS 'MV File No.', engine_number AS 'Engine Number', chassis_number AS 'Chassis Number', denomination AS 'Denomination', " +
                    "piston_displacement AS 'Piston Displacement', no_of_cylinders AS 'No. of Cylinders', fuel AS 'Fuel', make AS 'Make', series AS 'Series'," +
                    " body_type AS 'Body Type', year_model AS 'Year Model',gross_weight AS 'Gross Weight', net_weight AS 'Net Weight'," +
                    " shipping_weight AS 'Shipping Weight', " +
                    "net_capacity AS 'Net Capacity', complete_owner_name AS 'Complete Owner Name', complete_owner_address AS 'Complete Owner Address'," +
                    "status AS 'Status',or_no AS 'O.R. Number',renewal_date AS 'Renewal Date',insurance_renewal AS 'Insurance Renewal',or_date AS 'O.R. Date'," +
                    "FORMAT(equipment_price, 2)   AS 'Equipment Price', serial AS 'Serial', site AS 'Site', FORMAT(cr_payment, 2)    AS 'Cert. of Registration Payment' " +
                    "FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
            }
        }
        public void fillPurchaseOrders(ref DataGridView dgv)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', supplier.supplier_name AS 'Supplier', purchase_order.date_created AS 'Date Created', delivered_to AS 'Delivered to', partial_payment AS 'Partial Payment' , remarks AS 'Remarks', mode_of_payment AS 'Mode of Payment', site AS 'Site' FROM `purchase_order` INNER JOIN supplier ON supplier.supplier_id = purchase_order.supplier_id INNER JOIN requester ON requester.requester_id = purchase_order.requester_id;";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
            }
        }
        public DataTable fillPurchaseOrderItems(String PO_control_number, DataGridView dgv)
        //Create a function that loads the purchase order items based
        //On the given control number
        //Need to fully implement this function
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `item_number` AS 'Item Number', `purchase_order` AS 'Purchase Order', `quantity` AS 'Quantity', `unit` AS 'Unit', `description` AS 'Description', `unit_cost` AS 'Unit Cost', `discount` AS 'Discount', CONCAT('PHP ',FORMAT(`amount`,2)) AS 'Amount',amount FROM `purchase_order_item` INNER JOIN purchase_order ON purchase_order.control_number = purchase_order_item.purchase_order WHERE purchase_order.control_number = @PO_control_number;";
                command.Parameters.AddWithValue("@PO_control_number", PO_control_number);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
                return dataTable;
            }
        }
        public DataTable fillPurchaseOrderItems(String PO_control_number)
        //Create a function that loads the purchase order items based
        //On the given control number
        //Need to fully implement this function
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `item_number` AS 'Item Number', `purchase_order` AS 'Purchase Order', `quantity` AS 'Quantity', `unit` AS 'Unit', `description` AS 'Description', CONCAT('PHP ',FORMAT(`unit_cost`,2)) AS 'unit_cost',  CONCAT('PHP ',FORMAT(`discount`,2))  AS 'discount', CONCAT('PHP ',FORMAT(`amount`,2)) AS 'Amount',amount FROM `purchase_order_item` INNER JOIN purchase_order ON purchase_order.control_number = purchase_order_item.purchase_order WHERE purchase_order.control_number = @PO_control_number;";
                command.Parameters.AddWithValue("@PO_control_number", PO_control_number);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                command.Dispose();
                this.db.Close();
                return dataTable;
            }
        }
        public double getPurchaseTotal(String PO_control_number)
        {
            Double subtotal = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `item_number` AS 'Item Number', `purchase_order` AS 'Purchase Order', `quantity` AS 'Quantity', `unit` AS 'Unit', `description` AS 'Description', `unit_cost` AS 'Unit Cost', `discount` AS 'Discount', CONCAT('PHP ',FORMAT(`amount`,2)) AS 'Amount',amount FROM `purchase_order_item` INNER JOIN purchase_order ON purchase_order.control_number = purchase_order_item.purchase_order WHERE purchase_order.control_number = @PO_control_number;";
                command.Parameters.AddWithValue("@PO_control_number", PO_control_number);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    subtotal += reader.GetDouble(8);
                }
                command.Dispose();
                this.db.Close();
                return subtotal;
            }
        }
        public void fillRepairTable(DataGridView dgv)
        //Create a function that loads the purchase order items based
        //On the given control number
        //Need to fully implement this function
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `control_number` AS 'Control Number', `shop_repaired` AS 'Shop Repaired', `total_repair_cost` AS 'Total Repair Cost', `date_of_repair` AS 'Date of Repair', `date_repaired` AS 'Date Finished Repairing' FROM `repair_record`";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
            }
        }
        public DataTable fillEmployeesTable(String site)
        {
            List<String> recipientNames = new List<String>();

            DataTable dataTable = new DataTable();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM employees WHERE site LIKE @site";
                command.Parameters.AddWithValue("@site", "%" + site + "%");
                MySqlDataReader reader = command.ExecuteReader();

                dataTable.Load(reader);

                command.Dispose();
                this.db.Close();
            }
            return dataTable;
        }
        public DataTable fillMonthlyAttendanceTable(ref DataGridView dgv)
        {
            List<String> recipientNames = new List<String>();

            DataTable dataTable = new DataTable();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT month AS 'Month', date_from AS 'Date From', date_to AS 'Date To', year AS 'Year',working_days  AS 'Working Days' FROM `monthly_attendance` GROUP BY month, year,date_from, date_to;SELECT month AS 'Month', date_from AS 'Date From', date_to AS 'Date To', year AS 'Year',working_days  AS 'Working Days' FROM `monthly_attendance` GROUP BY month, year,date_from, date_to;";
                MySqlDataReader reader = command.ExecuteReader();

                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
            }
            return dataTable;
        }

        public Applicant getApplicantByID(String id)
        {
            Applicant applicant = new Applicant();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM applicant  WHERE applicant_ID = @id";
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        applicant.applicant_ID = reader.GetInt32("applicant_ID");
                        applicant.first_name = reader.GetString("first_name");
                        applicant.middle_name = reader.GetString("middle_name");
                        applicant.last_name = reader.GetString("last_name");
                        applicant.batch_number = reader.GetInt32("batch_number");
                        applicant.age = reader.GetString("age");
                        applicant.gender = reader.GetString("gender");
                        applicant.contact = reader.GetString("contact");
                        applicant.application_date = reader.GetDateTime("application_date");
                        applicant.birth_date = reader.GetDateTime("birth_date");
                        applicant.exam_date = reader.GetDateTime("exam_date");
                        applicant.initial_interview_date = reader.GetString("initial_interview_date");
                        applicant.final_interview_date = reader.GetString("final_interview_date");
                        applicant.remarks = reader.GetString("remarks");
                    }
                }
                command.Dispose();
                this.db.Close();
                return applicant;
            }
        }

        public User getUserByID(String id)
        {
            User user = new User();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM user  WHERE ID = @id AND `access` = 'hiring_manager'";
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.username = reader.GetString("username");
                        user.password = decryptPassword(reader.GetString("password"),"yamato");
                        user.fullName = reader.GetString("full_name");
                        user.address = reader.GetString("address");
                        user.contact = reader.GetString("contact");
                        user.id = reader.GetInt32("ID");
                    }
                }
                command.Dispose();
                this.db.Close();
                return user;
            }
        }
        //public List<Employee> GetEmployees()
        //{
        //    List<Employee> employees = new List<Employee>();
        //    Employee employee = new Employee();
        //    using (MySqlCommand command = new MySqlCommand())
        //    {
        //        this.db.Open();
        //        command.Connection = this.db;
        //        command.CommandText = "SELECT * FROM employees";
        //        MySqlDataReader reader = command.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                employee = new Employee();
        //                employee.control_number = reader.GetString("control_number");
        //                employee.first_name = reader.GetString("first_name");
        //                employee.last_name = reader.GetString("last_name");
        //                employee.name = reader.GetString("name");
        //                employee.position = reader.GetString("position");
        //                employee.status = reader.GetString("status");
        //                employee.shop_rate = reader.GetFloat("shop_rate");
        //                employee.operational_rate = reader.GetFloat("operational_rate");
        //                employee.absent = reader.GetInt32("absent");
        //                employee.breakdown_days_present = reader.GetInt32("breakdown_days_present");
        //                employee.operation_days_present = reader.GetInt32("operation_days_present");
        //                employee.overtime_hours = reader.GetInt32("overtime_hours");
        //                employee.overtime_pay = reader.GetFloat("overtime_pay");
        //                employee.rate = reader.GetFloat("rate");
        //                employee.pay = reader.GetFloat("pay");
        //                employee.site = reader.GetString("site");
        //                employee.designation = reader.GetString("designation");
        //                employees.Add(employee);
        //            }
        //        }
        //        command.Dispose();
        //        this.db.Close();
        //        return employees;
        //    }
        //}
        public Employee getEmployeeByID(String employee_ID)
        {
            Employee employee = new Employee();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT *,(available_leave - leaves_used) FROM employee WHERE `employee_ID` = @employee_ID";
                command.Parameters.AddWithValue("@employee_ID", employee_ID);
                MySqlDataReader reader = command.ExecuteReader();
                while(reader.Read()){ 
                employee.employee_ID = reader.GetInt32(0);
                employee.applicant_ID = reader.GetInt32(2);
                employee.batch_number = reader.GetInt32(3);
                employee.sss_number = reader.GetString(4);
                employee.philhealth_number = reader.GetString(5);
                employee.pag_ibig_number = reader.GetString(6);
                employee.TIN_number = reader.GetString(7);
                employee.orientation_date = reader.GetDateTime(8);
                employee.employment_status = reader.GetString(9);
                employee.employment_remarks = reader.GetString(10);
                employee.available_leave = reader.GetInt32(12);
                employee.leaves_used = reader.GetInt32(13);
                employee.leaves_remaining = reader.GetInt32(14);
                }
                reader.Close();
                command.Dispose();
                this.db.Close();
                return employee;
            }
        }
        public List<String> getEmployeePositions()
        {
            List<String> employees = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM employees";
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employees.Add(reader.GetString("position"));
                    }
                }
                command.Dispose();
                this.db.Close();
                return employees;
            }
        }
        public List<String> getCriteria(String filter)
        {
            List<String> results = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `"+filter+"` FROM employee";
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        try
                        {

                            results.Add(reader.GetString(0));
                        }
                        catch (Exception ex)
                        {
                            if (ex is InvalidCastException)
                            {
                                try
                                {

                                results.Add(reader.GetDateTime(0).ToString("yyyy-MM-dd HH:mm:ss"));
                                }
                                catch (Exception ex1)
                                {
                                    if (ex is InvalidCastException)
                                    {
                                        results.Add(reader.GetInt32(0).ToString());
                                    }
                                    }
                            }
                            else
                            { }

                        }
                    }
                }
                command.Dispose();
                this.db.Close();
                return results;
            }
        }
        public void searchEmployee(ref DataGridView dgv, String searchTerm)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', first_name AS 'First Name',last_name AS 'Last Name',name AS 'Full Name',position AS 'Position',status AS 'Status',shop_rate AS 'Shop Rate',operational_rate AS 'Operational Rate',absent AS 'Absent'," +
                "breakdown_days_present AS 'Non Operational Days'," +
                "operation_days_present AS 'Operational Days'," +
                "overtime_hours AS 'Overtime Hours'," +
                "site AS 'Site'," +
                "designation AS 'Designation',FORMAT(IF(rate = 0, ((operation_days_present * operational_rate) + (shop_rate * breakdown_days_present) + (overtime_hours * (operational_rate / 8))),rate),2) AS 'Total Receivable to Date'" +
                "FROM `employees`  " +
                 "WHERE last_name LIKE @searchTerm OR first_name LIKE @searchTerm OR name LIKE @searchTerm " +
                "ORDER BY `employees`.`last_name`  ASC;";
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }
        public void addApplicant(Applicant applicant) {
            using (MySqlCommand command = new MySqlCommand()){
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `applicant`(`batch_number`,`first_name`, `middle_name`," +
                    " `last_name`, `age`, `gender`, `birth_date`, `contact`, `application_date`, `exam_date`, `initial_interview_date`," +
                    " `final_interview_date`, `application_status`) " +
                    "VALUES (@batch_number, @first_name, @middle_name, @last_name, @age, @gender,@birth_date, @contact, @application_date, @exam_date, " +
                    "@initial_interview_date, @final_interview_date, @application_status)";
                command.Parameters.AddWithValue("@batch_number", applicant.batch_number);
                command.Parameters.AddWithValue("@first_name", applicant.first_name);
                command.Parameters.AddWithValue("@middle_name", applicant.middle_name);
                command.Parameters.AddWithValue("@last_name", applicant.last_name);
                command.Parameters.AddWithValue("@age", applicant.age);
                command.Parameters.AddWithValue("@gender", applicant.gender);
                command.Parameters.AddWithValue("@birth_date", applicant.birth_date);
                command.Parameters.AddWithValue("@contact", applicant.contact);
                command.Parameters.AddWithValue("@application_date", applicant.application_date);
                command.Parameters.AddWithValue("@exam_date", applicant.exam_date);
                command.Parameters.AddWithValue("@initial_interview_date", applicant.initial_interview_date);
                command.Parameters.AddWithValue("@final_interview_date", applicant.final_interview_date);
                command.Parameters.AddWithValue("@application_status", applicant.application_status);
                command.ExecuteNonQuery();

                MessageBox.Show("Applicant added successfully!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }

        public void addVisitor(Visitor visitor)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `visitor`(`name`, `company`, `time_in`, `time_out`, `date_of_visit`, `purpose`)" +
                    " VALUES ( @name, @company, @time_in, @time_out, @date_of_visit, @purpose);";
                command.Parameters.AddWithValue("@name", visitor.name);
                command.Parameters.AddWithValue("@company", visitor.company);
                command.Parameters.AddWithValue("@time_in", visitor.time_in);
                command.Parameters.AddWithValue("@time_out", visitor.time_out);
                command.Parameters.AddWithValue("@date_of_visit", visitor.date_of_visit);
                command.Parameters.AddWithValue("@purpose", visitor.purpose);
                command.ExecuteNonQuery();

                MessageBox.Show("Visitor added successfully!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }
        public void addUser(User user)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `user`(`username`, `full_name`, `password`, `address`, `contact`, `access`) " +
                    "VALUES( @username, @full_name, @password, @address, @contact, @access);";
                command.Parameters.AddWithValue("@username", user.username);
                command.Parameters.AddWithValue("@full_name", user.fullName);
                command.Parameters.AddWithValue("@password", user.password);
                command.Parameters.AddWithValue("@address", user.address);
                command.Parameters.AddWithValue("@contact", user.contact);
                command.Parameters.AddWithValue("@access", user.access);
                command.ExecuteNonQuery();

                MessageBox.Show("User added successfully!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }
        public void updateUser(User user)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `user` SET `username` =  @username, `full_name` = @full_name, `password` = @password," +
                    " `address` = @address, `contact` =  @contact WHERE `ID` = @ID;";
                command.Parameters.AddWithValue("@username", user.username);
                command.Parameters.AddWithValue("@full_name", user.fullName);
                command.Parameters.AddWithValue("@password", user.password);
                command.Parameters.AddWithValue("@address", user.address);
                command.Parameters.AddWithValue("@contact", user.contact);
                command.Parameters.AddWithValue("@ID", user.id);
                command.ExecuteNonQuery();

                MessageBox.Show("User udpated successfully!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }
        public void addEmployee(Employee employee)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `employee`(`employee_ID`, `applicant_ID`, `batch_number`, `sss_number`," +
                    " `philhealth_number`, `pag_ibig_number`, `TIN_number`, `orientation_date`, `employment_status`, `employment_remarks`, `generated_ID`)" +
                    " VALUES(@employee_ID, @applicant_ID, @batch_number, @sss_number, @philhealth_number, @pag_ibig_number, @TIN_number, @orientation_date," +
                    " @employment_status, @employment_remarks, @generated_ID)";
                command.Parameters.AddWithValue("@employee_ID", employee.employee_ID);
                command.Parameters.AddWithValue("@applicant_ID", employee.applicant_ID);
                command.Parameters.AddWithValue("@batch_number", employee.batch_number);
                command.Parameters.AddWithValue("@sss_number", employee.sss_number);
                command.Parameters.AddWithValue("@philhealth_number", employee.philhealth_number);
                command.Parameters.AddWithValue("@pag_ibig_number", employee.pag_ibig_number);
                command.Parameters.AddWithValue("@TIN_number", employee.TIN_number);
                command.Parameters.AddWithValue("@orientation_date", employee.orientation_date);
                command.Parameters.AddWithValue("@generated_ID", employee.generated_ID);
                command.Parameters.AddWithValue("@employment_status", "ACTIVE");
                command.Parameters.AddWithValue("@employment_remarks", "PASSED ALL EXAMS");
                command.ExecuteNonQuery();

                MessageBox.Show("Applicant is now your employee!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }

        public void updateEmployee(Employee employee)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `employee` SET  `batch_number` = @batch_number, `sss_number` = @sss_number," +
                    " `philhealth_number` = @philhealth_number, `pag_ibig_number` = @pag_ibig_number, `TIN_number` =  @TIN_number," +
                    " `orientation_date` =  @orientation_date, `employment_status` = @employment_status, `employment_remarks` = @employment_remarks" +
                    " WHERE applicant_ID = @applicant_ID;";
                command.Parameters.AddWithValue("@applicant_ID", employee.applicant_ID);
                command.Parameters.AddWithValue("@batch_number", employee.batch_number);
                command.Parameters.AddWithValue("@sss_number", employee.sss_number);
                command.Parameters.AddWithValue("@philhealth_number", employee.philhealth_number);
                command.Parameters.AddWithValue("@pag_ibig_number", employee.pag_ibig_number);
                command.Parameters.AddWithValue("@TIN_number", employee.TIN_number);
                command.Parameters.AddWithValue("@orientation_date", employee.orientation_date);
                command.Parameters.AddWithValue("@employment_status", employee.employment_status);
                command.Parameters.AddWithValue("@employment_remarks", employee.employment_remarks);
                command.ExecuteNonQuery();

                MessageBox.Show("Employee data updated!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }
        public void grantLeave(Employee employee)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `employee` SET `leaves_used` = (`leaves_used` + 1) WHERE `applicant_ID` = @applicant_ID;";
                command.Parameters.AddWithValue("@applicant_ID", employee.applicant_ID);
                command.ExecuteNonQuery();

                MessageBox.Show("Leave granted!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }
        public int getNextEmployeeID()
        {
            int result = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT IF(employee_ID IS NULL,0,MAX(employee_ID)+1) FROM `employee`;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetInt32(0);
                }
                command.Dispose();
                this.db.Close();
            }
            return result;
        }

        public void addBatch(Batch batch)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `batch`(`batch_number`, `number_of_applicants`, `number_of_hired_applicants`, `date_created`) " +
                    "VALUES ( @batch_number, @number_of_applicants, @number_of_hired_applicants, @date_created)";
                command.Parameters.AddWithValue("@batch_number", batch.batch_number);
                command.Parameters.AddWithValue("@number_of_applicants", batch.applicants);
                command.Parameters.AddWithValue("@number_of_hired_applicants", batch.hired_applicants);
                command.Parameters.AddWithValue("@date_created", batch.hiring_date);
                command.ExecuteNonQuery();

                MessageBox.Show("Batch added successfully!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }


        public void updateApplicant(Applicant applicant)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `applicant` SET " +
                    "`first_name`= @first_name,`middle_name`= @middle_name,`last_name`= @last_name," +
                    "`age`= @age,`gender`= @gender,`contact`= @contact,`application_date`= @application_date, `birth_date` = @birth_date , `application_status` = @application_status, " +
                    "`exam_date`= @exam_date,`initial_interview_date`= @initial_interview_date,`final_interview_date`= @final_interview_date, `remarks` = " +
                    "@remarks WHERE applicant_ID = @applicant_ID";
                command.Parameters.AddWithValue("@first_name", applicant.first_name);
                command.Parameters.AddWithValue("@middle_name", applicant.middle_name);
                command.Parameters.AddWithValue("@last_name", applicant.last_name);
                command.Parameters.AddWithValue("@age", applicant.age);
                command.Parameters.AddWithValue("@gender", applicant.gender);
                command.Parameters.AddWithValue("@contact", applicant.contact);
                command.Parameters.AddWithValue("@application_date", applicant.application_date);
                command.Parameters.AddWithValue("@birth_date", applicant.birth_date);
                command.Parameters.AddWithValue("@application_status", applicant.application_status);
                command.Parameters.AddWithValue("@exam_date", applicant.exam_date);
                command.Parameters.AddWithValue("@initial_interview_date", applicant.initial_interview_date);
                command.Parameters.AddWithValue("@final_interview_date", applicant.final_interview_date);
                command.Parameters.AddWithValue("@applicant_ID", applicant.applicant_ID);
                command.Parameters.AddWithValue("@remarks", applicant.remarks);
                command.ExecuteNonQuery();

                MessageBox.Show("Applicant information updated successfully!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }
        public void checkForRegulars()
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `employee` SET `employment_remarks`='REGULAR',`available_leave` = TIMESTAMPDIFF(MONTH,DATE_ADD(orientation_date, INTERVAL 6 MONTH),CURRENT_DATE()) WHERE DATE_ADD(orientation_date, INTERVAL 6 MONTH) <= CURRENT_DATE;";
                command.ExecuteNonQuery();
                command.Dispose();
                this.db.Close();
            }
        }
        public void deleteApplicant(Applicant applicant)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "DELETE FROM `applicant` WHERE applicant_ID = @applicant_ID";
                command.Parameters.AddWithValue("@applicant_ID", applicant.applicant_ID);
                command.ExecuteNonQuery();

                MessageBox.Show("Applicant information deleted successfully!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }
        public void deleteUser(User user)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "DELETE FROM `user` WHERE ID = @id";
                command.Parameters.AddWithValue("@id", user.id);
                command.ExecuteNonQuery();

                MessageBox.Show("User information deleted successfully!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }
        public void deleteEmployee(Employee employee)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "DELETE FROM `employee` WHERE applicant_ID = @applicant_ID";
                command.Parameters.AddWithValue("@applicant_ID", employee.applicant_ID);
                command.ExecuteNonQuery();

                MessageBox.Show("Employee information deleted successfully!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }
        public void deleteEmployee(String applicant_ID)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "DELETE FROM `employee` WHERE applicant_ID = @applicant_ID";
                command.Parameters.AddWithValue("@applicant_ID", applicant_ID);
                command.ExecuteNonQuery();

                MessageBox.Show("Employee information deleted successfully!", "Success");

                command.Dispose();
                this.db.Close();
            }
        }
        public void searchPurchaseOrder(ref DataGridView dgv, String searchTerm)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM `purchase_order` INNER JOIN supplier ON supplier.supplier_id = purchase_order.supplier_id INNER JOIN requester ON requester.requester_id  = purchase_order.requester_id " +
                 "WHERE site LIKE @searchTerm OR control_number LIKE @searchTerm;";
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }
        public void searchEquipment(ref DataGridView dgv, String searchTerm)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', cr_number AS 'Certificate of Registration Number', plate_number AS 'Plate Number', mv_file_number AS 'MV File No.', engine_number AS 'Engine Number', chassis_number AS 'Chassis Number', denomination AS 'Denomination', " +
                "piston_displacement AS 'Piston Displacement', no_of_cylinders AS 'No. of Cylinders', fuel AS 'Fuel', make AS 'Make', series AS 'Series'," +
                " body_type AS 'Body Type', year_model AS 'Year Model',gross_weight AS 'Gross Weight', net_weight AS 'Net Weight'," +
                " shipping_weight AS 'Shipping Weight', " +
                "net_capacity AS 'Net Capacity', complete_owner_name AS 'Complete Owner Name', complete_owner_address AS 'Complete Owner Address'," +
                "status AS 'Status',or_no AS 'O.R. Number',renewal_date AS 'Renewal Date',insurance_renewal AS 'Insurance Renewal',or_date AS 'O.R. Date'," +
                "FORMAT(equipment_price, 2)   AS 'Equipment Price', serial AS 'Serial', site AS 'Site', FORMAT(cr_payment, 2)    AS 'Cert. of Registration Payment' " +
                "FROM `equipment` WHERE cr_number LIKE @searchTerm OR plate_number LIKE @searchTerm  OR chassis_number LIKE @searchTerm  OR control_number LIKE @searchTerm OR make LIKE @searchTerm   OR engine_number LIKE @searchTerm OR series LIKE @searchTerm   OR mv_file_number LIKE @searchTerm OR series LIKE @searchTerm  OR year_model LIKE @searchTerm " +
                "ORDER BY `equipment`.`control_number`  ASC;";
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }
 

        public void filterEquipmentsBySite(ref DataGridView dgv, String searchTerm)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', cr_number AS 'Certificate of Registration Number', plate_number AS 'Plate Number', mv_file_number AS 'MV File No.', engine_number AS 'Engine Number', chassis_number AS 'Chassis Number', denomination AS 'Denomination', " +
                    "piston_displacement AS 'Piston Displacement', no_of_cylinders AS 'No. of Cylinders', fuel AS 'Fuel', make AS 'Make', series AS 'Series'," +
                    " body_type AS 'Body Type', year_model AS 'Year Model',gross_weight AS 'Gross Weight', net_weight AS 'Net Weight'," +
                    " shipping_weight AS 'Shipping Weight', " +
                    "net_capacity AS 'Net Capacity', complete_owner_name AS 'Complete Owner Name', complete_owner_address AS 'Complete Owner Address'," +
                    "status AS 'Status',or_no AS 'O.R. Number',renewal_date AS 'Renewal Date',insurance_renewal AS 'Insurance Renewal',or_date AS 'O.R. Date'," +
                    "FORMAT(equipment_price, 2)   AS 'Equipment Price', serial AS 'Serial', site AS 'Site', FORMAT(cr_payment, 2)    AS 'Cert. of Registration Payment' " +
                    "FROM `equipment` WHERE site LIKE @searchTerm " +
                "ORDER BY `equipment`.`control_number`  ASC;";
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }
        public void filterPurchaseOrdersBySite(ref DataGridView dgv, String searchTerm)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', supplier.supplier_name AS 'Supplier', purchase_order.date_created AS 'Date Created', delivered_to AS 'Delivered to', partial_payment AS 'Partial Payment' , remarks AS 'Remarks', mode_of_payment AS 'Mode of Payment', site AS 'Site' FROM `purchase_order` INNER JOIN supplier ON supplier.supplier_id = purchase_order.supplier_id INNER JOIN requester ON requester.requester_id = purchase_order.requester_id  WHERE site LIKE @searchTerm";
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }
        public void filterEmployeesBySite(ref DataGridView dgv, String site)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', first_name AS 'First Name',last_name AS 'Last Name',name AS 'Full Name',position AS 'Position',status AS 'Status',shop_rate AS 'Shop Rate',operational_rate AS 'Operational Rate',absent AS 'Absent'," +
                    "breakdown_days_present AS 'Non Operational Days'," +
                    "operation_days_present AS 'Operational Days'," +
                    "overtime_hours AS 'Overtime Hours'," +
                    "site AS 'Site'," +
                    "designation AS 'Designation',FORMAT(IF(rate = 0, ((operation_days_present * operational_rate) + (shop_rate * breakdown_days_present) + (overtime_hours * (operational_rate / 8))),rate),2) AS 'Total Receivable to Date'" +
                    "FROM `employees`  " +
                     "WHERE site LIKE @searchTerm " +
                    "ORDER BY `employees`.`last_name`  ASC;";
                command.Parameters.AddWithValue("@searchTerm", "%" + site + "%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }

        public List<String> getSiteList()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT site FROM employees";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString("site"));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }
        public List<String> getEquipmentSiteList()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT site FROM equipment";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString("site"));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }
        public DataTable getEquipmentReport()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM equipment";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();

                dataTable.Load(reader);

                command.Dispose();
                this.db.Close();
                return dataTable;
            }
        }
        public List<String> getPurchaseOrderSiteList()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT site FROM purchase_order";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString("site"));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }
        public List<String> getDesignationList()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT designation FROM employees";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString("designation"));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }
        public Dictionary<String, String> getSupplierList()
        {
            Dictionary<String, String> result = new Dictionary<String, String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT supplier_id, supplier_name FROM supplier";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString("supplier_name"), reader.GetString("supplier_id"));
                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
 
        public Dictionary<String, String> getRequesterList()
        {
            Dictionary<String, String> result = new Dictionary<String, String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT `requester_id`, `name` FROM requester";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString("name"), reader.GetString("requester_id")); ;
                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public List<String> getDenominations()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT denomination FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getFuels()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT fuel FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getMakes()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT make FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getSeries()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT series FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getBodyTypes()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT body_type FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getYearModels()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT year_model FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getCON()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT complete_owner_name FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getCOA()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT complete_owner_address FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getStatus()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT status FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getSites()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT site FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }



        public List<String> getPositionList()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT position FROM employees";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString("position"));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getRecipientEmails()
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM recipient";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    recipientNames.Add(reader.GetString("email_address"));
                }

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }



        public void fillRecipientTable(ref DataGridView dgv)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT ID AS 'Recipient ID', email_address AS 'Email Address', contact_number AS 'Contact Number', name AS 'Name', position AS 'Position', office AS 'Office'  FROM `recipient` ";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
            }
        }


        //public void editEmployeeAttendance(Employee employee, String month, String year)
        //{
        //    using (MySqlCommand command = new MySqlCommand())
        //    {
        //        this.db.Open();
        //        command.Connection = this.db;
        //        command.CommandText = "UPDATE `monthly_attendance` SET days_breakdown = @breakdown_days_present, days_present = @operation_days_present," +
        //            " overtime_hours = @overtime_hours, undertime_hours = @undertime_hours WHERE employee = @control_number AND month = @month AND year = @year";
        //        command.Parameters.AddWithValue("@control_number", employee.control_number);
        //        command.Parameters.AddWithValue("@breakdown_days_present", employee.breakdown_days_present);
        //        command.Parameters.AddWithValue("@operation_days_present", employee.operation_days_present);
        //        command.Parameters.AddWithValue("@overtime_hours", employee.overtime_hours);
        //        command.Parameters.AddWithValue("@undertime_hours", employee.undertime_hours);
        //        command.Parameters.AddWithValue("@month", month);
        //        command.Parameters.AddWithValue("@year", year);
        //        command.ExecuteNonQuery();
        //        MessageBox.Show("Information Saved Successfully!");
        //        command.Dispose();
        //        this.db.Close();
        //    }
        //}
        //public void editEmployee(Employee employee)
        //{
        //    using (MySqlCommand command = new MySqlCommand())
        //    {
        //        this.db.Open();
        //        command.Connection = this.db;
        //        command.CommandText = "UPDATE `employees` SET `first_name`= @first_name,`last_name`= @last_name,`name`= @name,`position`= @position, `shop_rate`= @shop_rate, `operational_rate`= @operational_rate, `rate`= @rate, `site`= @site, `designation`= @designation WHERE  control_number = @control_number ";
        //        command.Parameters.AddWithValue("@first_name", employee.first_name);
        //        command.Parameters.AddWithValue("@last_name", employee.last_name);
        //        command.Parameters.AddWithValue("@name", employee.name);
        //        command.Parameters.AddWithValue("@position", employee.position);
        //        command.Parameters.AddWithValue("@shop_rate", employee.shop_rate);
        //        command.Parameters.AddWithValue("@operational_rate", employee.operational_rate);
        //        command.Parameters.AddWithValue("@rate", employee.rate);
        //        command.Parameters.AddWithValue("@site", employee.site);
        //        command.Parameters.AddWithValue("@designation", employee.designation);
        //        command.Parameters.AddWithValue("@control_number", employee.control_number);
        //        command.ExecuteNonQuery();
        //        MessageBox.Show("Information Saved Successfully!");
        //        command.Dispose();
        //        this.db.Close();
        //    }
        //}

        //public void deleteEmployee(Employee employee)
        //{
        //    using (MySqlCommand command = new MySqlCommand())
        //    {
        //        this.db.Open();
        //        command.Connection = this.db;
        //        command.CommandText = "DELETE FROM `employees`  WHERE  control_number = @control_number ";
        //        command.Parameters.AddWithValue("@control_number", employee.control_number);
        //        command.ExecuteNonQuery();
        //        MessageBox.Show("Information Deleted Successfully!");
        //        command.Dispose();
        //        this.db.Close();
        //    }
        //}
        //public void addEmployee(Employee employee)
        //{
        //    using (MySqlCommand command = new MySqlCommand())
        //    {
        //        this.db.Open();
        //        command.Connection = this.db;
        //        command.CommandText = "INSERT INTO `employees`(`control_number`,`first_name`,`last_name`,`name`,`position`, `shop_rate`, `operational_rate`, `rate`, `site`, `designation`) VALUES(@control_number, @first_name, @last_name, @name, @position, @shop_rate, @operational_rate, @rate, @site, @designation)";
        //        command.Parameters.AddWithValue("@control_number", employee.control_number);
        //        command.Parameters.AddWithValue("@first_name", employee.first_name);
        //        command.Parameters.AddWithValue("@last_name", employee.last_name);
        //        command.Parameters.AddWithValue("@name", employee.name);
        //        command.Parameters.AddWithValue("@position", employee.position);
        //        command.Parameters.AddWithValue("@shop_rate", employee.shop_rate);
        //        command.Parameters.AddWithValue("@operational_rate", employee.operational_rate);
        //        command.Parameters.AddWithValue("@rate", employee.rate);
        //        command.Parameters.AddWithValue("@site", employee.site);
        //        command.Parameters.AddWithValue("@designation", employee.designation);
        //        command.ExecuteNonQuery();
        //        MessageBox.Show("Information Saved Successfully!");
        //        command.Dispose();
        //        this.db.Close();
        //    }
        //}
        //public void updateDeductibles(Employee employee, String month, String year)
        //{
        //    using (MySqlCommand command = new MySqlCommand())
        //    {
        //        this.db.Open();
        //        command.Connection = this.db;
        //        command.CommandText = "UPDATE `monthly_attendance` SET cash_advance = @cash_advance, loan = @loan," +
        //            " sss = @sss, pag_ibig = @pag_ibig, philhealth = @philhealth, month_end_cash_advance = @month_end_cash_advance WHERE employee = @control_number AND month = @month AND year = @year";
        //        command.Parameters.AddWithValue("@control_number", employee.control_number);
        //        command.Parameters.AddWithValue("@cash_advance", employee.cash_advance);
        //        command.Parameters.AddWithValue("@loan", employee.loan);
        //        command.Parameters.AddWithValue("@sss", employee.sss);
        //        command.Parameters.AddWithValue("@pag_ibig", employee.pag_ibig);
        //        command.Parameters.AddWithValue("@philhealth", employee.philhealth);
        //        command.Parameters.AddWithValue("@month_end_cash_advance", employee.month_end_cash_advance);
        //        command.Parameters.AddWithValue("@month", month);
        //        command.Parameters.AddWithValue("@year", year);
        //        command.ExecuteNonQuery();
        //        MessageBox.Show("Information Saved Successfully!");
        //        command.Dispose();
        //        this.db.Close();
        //    }
        //}
        public void editWorkingDays(String month, String year, int workingDays)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `monthly_attendance` SET working_days = @working_days WHERE  month = @month AND year = @year";
                command.Parameters.AddWithValue("@working_days", workingDays);
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.ExecuteNonQuery();
                MessageBox.Show("Information Saved Successfully!");
                command.Dispose();
                this.db.Close();
            }
        }



    }

}