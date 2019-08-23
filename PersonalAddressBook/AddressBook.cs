using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Web;

namespace PersonalAddressBook
{
    public partial class AddressBook : Form
    {
        public AddressBook()
        {
            InitializeComponent();
        }
       

        private void StoreBtn_Click(object sender, EventArgs e)
        {
            //verifies data was entered
            if (string.IsNullOrEmpty(FirstNameTextbox.Text))
            {
                MessageBox.Show("Please enter your First Name.");
                return;
            }
            if (string.IsNullOrEmpty(LastNameTextbox.Text))
            {
                MessageBox.Show("Please enter your Last Name.");
                return;
            }
            if (string.IsNullOrEmpty(AddressTextBox.Text))
            {
                MessageBox.Show("Please enter your Address.");
                return;
            }
            if (string.IsNullOrEmpty(AddressTextBox.Text))
            {
                MessageBox.Show("Please enter your City/State/Zipcode.");
                return;
            }
            if (string.IsNullOrEmpty(PhoneNumberTextbox.Text))
            {
                MessageBox.Show("Please enter your Phone Number");
                return;
            }
            //calls method to add data
            addData(FirstNameTextbox.Text, LastNameTextbox.Text, AddressTextBox.Text, CityStateZipcodeTextboc.Text, PhoneNumberTextbox.Text);





            //clears all items
            FirstNameTextbox.Clear();
            LastNameTextbox.Clear();
            AddressTextBox.Clear();
            CityStateZipcodeTextboc.Clear();
            PhoneNumberTextbox.Clear();
        }

        private void addData(string First_Name, string Last_Name, string Address, string City_State_Zipcode, string Phone_Number)
        {
            String[] row = { First_Name, Last_Name, Address, City_State_Zipcode, Phone_Number };
            //adds row
            AddressGrid.Rows.Add(row);
        }

        private void AddressBook_Load(object sender, EventArgs e)
        {
            //access csv file for mock data
            string FileName = @"C:\Exports\CSV-EXPORT.csv";

            //creates connection
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + Path.GetDirectoryName(FileName) + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\"");
            conn.Open();

            //selects data and creates the adapter
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM " + Path.GetFileName(FileName), conn);
            //queries-sorts-fills table
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataView dv = new DataView(dt);
            dv.Sort = "Last_Name, First_Name";
            //closes connectiom
            conn.Close();

            AddressGrid.DataSource = dv;
        }

        private void ExportCSVbtn_Click(object sender, EventArgs e)
        {
            SaveCSV();
        }

        private void ExportJSONbtn_Click(object sender, EventArgs e)
        {
            string JsonFpath = @"C:\Exports\MockJSON.json";
            try
            {
                System.IO.StreamWriter JSONFileWriter = new StreamWriter(JsonFpath, false);

                string columnHeaderText = "";

                int countColumn = AddressGrid.ColumnCount - 1;

                if (countColumn >= 0)
                {
                    columnHeaderText = AddressGrid.Columns[0].HeaderText;
                }

                for (int i = 1; i <= countColumn; i++)
                {
                    columnHeaderText = columnHeaderText + ',' + AddressGrid.Columns[i].HeaderText;
                }


                JSONFileWriter.WriteLine(columnHeaderText);

                foreach (DataGridViewRow dataRowObject in AddressGrid.Rows)
                {
                    if (!dataRowObject.IsNewRow)
                    {
                        string dataFromGrid = "";

                        dataFromGrid = dataRowObject.Cells[0].Value.ToString();

                        for (int i = 1; i <= countColumn; i++)
                        {
                            dataFromGrid = dataFromGrid + ',' + dataRowObject.Cells[i].Value.ToString();

                            JSONFileWriter.WriteLine(dataFromGrid);
                        }
                    }
                }


                JSONFileWriter.Flush();
                JSONFileWriter.Close();
            }
            catch (Exception exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
            }
        }

        private void ExportXMLbtn_Click(object sender, EventArgs e)
        {
            string XMLFpath = @"C:\Exports\MockXML.xml";
            try
            {
                System.IO.StreamWriter XMLFileWriter = new StreamWriter(XMLFpath, false);

                string columnHeaderText = "";

                int countColumn = AddressGrid.ColumnCount - 1;

                if (countColumn >= 0)
                {
                    columnHeaderText = AddressGrid.Columns[0].HeaderText;
                }

                for (int i = 1; i <= countColumn; i++)
                {
                    columnHeaderText = columnHeaderText + ',' + AddressGrid.Columns[i].HeaderText;
                }


                XMLFileWriter.WriteLine(columnHeaderText);

                foreach (DataGridViewRow dataRowObject in AddressGrid.Rows)
                {
                    if (!dataRowObject.IsNewRow)
                    {
                        string dataFromGrid = "";

                        dataFromGrid = dataRowObject.Cells[0].Value.ToString();

                        for (int i = 1; i <= countColumn; i++)
                        {
                            dataFromGrid = dataFromGrid + ',' + dataRowObject.Cells[i].Value.ToString();

                            XMLFileWriter.WriteLine(dataFromGrid);
                        }
                    }
                }


                XMLFileWriter.Flush();
                XMLFileWriter.Close();
            }
            catch (Exception exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
            }
        }

        private void PhoneNumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure you want to close?",
                                            "Closing", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                {
                    SaveCSV();
                    Application.Exit();
                }

            if (dr == DialogResult.No)
                return;
        }

        private void SaveCSV()
        {
            string CsvFpath = @"C:\Exports\CSV-EXPORT.csv";
            try
            {
                System.IO.StreamWriter csvFileWriter = new StreamWriter(CsvFpath, false);

                string columnHeaderText = "";

                int countColumn = AddressGrid.ColumnCount - 1;

                if (countColumn >= 0)
                {
                    columnHeaderText = AddressGrid.Columns[0].HeaderText;
                }

                for (int i = 1; i <= countColumn; i++)
                {
                    columnHeaderText = columnHeaderText + ',' + AddressGrid.Columns[i].HeaderText;
                }


                csvFileWriter.WriteLine(columnHeaderText);

                foreach (DataGridViewRow dataRowObject in AddressGrid.Rows)
                {
                    if (!dataRowObject.IsNewRow)
                    {
                        string dataFromGrid = "";

                        dataFromGrid = dataRowObject.Cells[0].Value.ToString();

                        for (int i = 1; i <= countColumn; i++)
                        {
                            dataFromGrid = dataFromGrid + ',' + dataRowObject.Cells[i].Value.ToString();

                            csvFileWriter.WriteLine(dataFromGrid);
                        }
                    }
                }


                csvFileWriter.Flush();
                csvFileWriter.Close();
            }
            catch (Exception exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
            }
        }
    }
}

