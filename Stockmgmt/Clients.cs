using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stockmgmt
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }
        Model1 model = new Model1();

        private void Addbtn_Click(object sender, EventArgs e)
        {


            Person person = new Person();
            person.Per_Name = ClientName_txtbox.Text;
            person.Per_Mobile = ClientMobile_txtbox.Text;
            person.Per_Phone = ClientPhone_txtbox.Text;
            person.Per_Email = ClientEmail_txtbox.Text;
            person.Per_Fax = ClientFax_txtbox.Text;
            person.Per_Website = ClientWebsite_txtbox.Text;
            person.Per_Type = "Client";


            model.People.Add(person);
            model.SaveChanges();
            MessageBox.Show("Client added successfully");


        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            if (client_comboBox1.Text!=" ")
            {
                var data = (from d in model.People
                            where (d.Per_Name == client_comboBox1.Text )
                            
                            select d).First();

                //var s = (from st in model.Stocks
                //         where st.Stock_Name == stocknametxtbox.Text
                //         select st).First();

                ClientMobile_txtbox.Text = data.Per_Mobile;
                ClientPhone_txtbox.Text = data.Per_Phone;
                ClientWebsite_txtbox.Text = data.Per_Website;
                //   SuppAddr_txtbox.Text=data.per
                ClientFax_txtbox.Text = data.Per_Fax;
                ClientEmail_txtbox.Text = data.Per_Email;

                // stocknametxtbox.Text = s.Stock_Name;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = model.People.FirstOrDefault(a => a.Per_Name == client_comboBox1.SelectedItem.ToString());


                person.Per_Name = client_comboBox1.SelectedText;
                person.Per_Mobile = ClientMobile_txtbox.Text;
                person.Per_Phone = ClientPhone_txtbox.Text;
                person.Per_Email = ClientEmail_txtbox.Text;
                person.Per_Fax = ClientFax_txtbox.Text;
                person.Per_Website = ClientWebsite_txtbox.Text;
                person.Per_Type = "Client";


                model.SaveChanges();

                MessageBox.Show("Client Updated ");
            }
            // catch (DbEntityValidationException) { MessageBox.Show("Error occured"); }
            catch (DbEntityValidationException ex)
            {
                foreach (var errors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in errors.ValidationErrors)
                    {
                        // get the error message 
                        string errorMessage = validationError.ErrorMessage;
                    }
                }
            }
        }

        private void client_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockmgmtDBDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.stockmgmtDBDataSet.Person);

            var cli = from Person in model.People  where Person.Per_Type=="Client" select Person.Per_Name ;
            client_comboBox1.DataSource = cli.ToList();
            client_comboBox1.DisplayMember = "Client_Name";
        }
    }
}

