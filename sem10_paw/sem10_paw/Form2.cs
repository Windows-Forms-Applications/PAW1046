using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace sem10_paw
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = clienti.accdb");
            try
            {
                conexiune.Open();

                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;

                comanda.CommandText = "SELECT MAX(ID) FROM clienti";
                int id = Convert.ToInt32(comanda.ExecuteScalar());

                comanda.CommandText = "INSERT INTO clienti VALUES(?,?,?,?,?,?)";
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 100;
                comanda.Parameters.Add("nume", OleDbType.Char, 20).Value = tbNume.Text;
                comanda.Parameters.Add("prenume", OleDbType.Char, 20).Value = tbPrenume.Text;
                comanda.Parameters.Add("dataNasterii", OleDbType.Char, 10).Value = tbData.Text;
                comanda.Parameters.Add("nrTelefon", OleDbType.Char, 10).Value = tbTelefon.Text;
                comanda.Parameters.Add("salariu", OleDbType.Integer).Value = Convert.ToInt32(tbSalariu.Text);
                comanda.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbNume.Clear();
                tbPrenume.Clear();
                tbData.Clear();
                tbTelefon.Clear();
                tbSalariu.Clear();
            }
        }
    }
}
