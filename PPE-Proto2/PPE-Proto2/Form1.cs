using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 Data = new Class1();

        public MySqlDataAdapter DAPays, DAAuteurs, DALivre, DAEcrire, DAGenre, DAGenreLivre,
            DAEdition, DAExemplaire, DAEBook, DAAdherent, DARetourEmprunt, DABlog, DAAdherentExclu,
            DAArchive, DAPerdu;

        public DataSet DSPays, DSAuteurs, DSLivre, DSEcrire, DSGenre, DSGenreLivre,
            DSEdition, DSExemplaire, DSEBook, DSAdherent, DSRetouremprunt, DSBlog, DSAdherentExclu,
            DSArchive, DSPerdu;

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("Database=" + Data.DBName + ";Data Source=" + Data.DBSource + ";UserID=root;Password=" + Data.DBPass + ";convert zero datetime=True");
            cn.Open();

            DSPays = new DataSet();
            DAPays = new MySqlDataAdapter("Select * from Pays", cn);
            DAPays.Fill(DSPays);
            dataGridView1.DataSource = DSPays.Tables[0];
            

            DSAuteurs = new DataSet();
            DAAuteurs = new MySqlDataAdapter("Select * from Auteurs", cn);
            DAAuteurs.Fill(DSAuteurs);
            dataGridView2.DataSource = DSAuteurs.Tables[0];

            DSLivre = new DataSet();
            DALivre = new MySqlDataAdapter("Select * from Livre", cn);
            DALivre.Fill(DSLivre);
            dataGridView3.DataSource = DSLivre.Tables[0];

            DSEcrire = new DataSet();
            DAEcrire = new MySqlDataAdapter("Select * from Ecrire", cn);
            DAEcrire.Fill(DSEcrire);
            dataGridView4.DataSource = DSEcrire.Tables[0];

            DSGenre = new DataSet();
            DAGenre = new MySqlDataAdapter("Select * from Genre", cn);
            DAGenre.Fill(DSGenre);
            dataGridView5.DataSource = DSGenre.Tables[0];

            DSGenreLivre = new DataSet();
            DAGenreLivre = new MySqlDataAdapter("Select * from GenreLivre", cn);
            DAGenreLivre.Fill(DSGenreLivre);
            dataGridView6.DataSource = DSGenreLivre.Tables[0];

            DSEdition = new DataSet();
            DAEdition = new MySqlDataAdapter("Select * from Edition", cn);
            DAEdition.Fill(DSEdition);
            dataGridView7.DataSource = DSEdition.Tables[0];

            DSExemplaire = new DataSet();
            DAExemplaire = new MySqlDataAdapter("Select * from Exemplaire", cn);
            DAExemplaire.Fill(DSExemplaire);
            dataGridView8.DataSource = DSExemplaire.Tables[0];

            DSEBook = new DataSet();
            DAEBook = new MySqlDataAdapter("Select * from EBook", cn);
            DAEBook.Fill(DSEBook);
            dataGridView9.DataSource = DSEBook.Tables[0];

            DSAdherent = new DataSet();
            DAAdherent = new MySqlDataAdapter("Select * from Adherent", cn);
            DAAdherent.Fill(DSAdherent);
            dataGridView10.DataSource = DSAdherent.Tables[0];

            DSRetouremprunt = new DataSet();
            DARetourEmprunt = new MySqlDataAdapter("Select * from RetourEmprunt", cn);
            DARetourEmprunt.Fill(DSRetouremprunt);
            dataGridView11.DataSource = DSRetouremprunt.Tables[0];

            DSBlog = new DataSet();
            DABlog = new MySqlDataAdapter("Select * from BlogArticle", cn);
            DABlog.Fill(DSBlog);
            dataGridView12.DataSource = DSBlog.Tables[0];

            DSAdherentExclu = new DataSet();
            DAAdherentExclu = new MySqlDataAdapter("Select * from Adherentexclut", cn);
            DAAdherentExclu.Fill(DSAdherentExclu);
            dataGridView13.DataSource = DSAdherentExclu.Tables[0];

            DSArchive = new DataSet();
            DAArchive = new MySqlDataAdapter("Select * from Archive_Emprunts", cn);
            DAArchive.Fill(DSArchive);
            dataGridView14.DataSource = DSArchive.Tables[0];

            DSPerdu = new DataSet();
            DAPerdu = new MySqlDataAdapter("Select * from ExemplairePerdu", cn);
            DAPerdu.Fill(DSPerdu);
            dataGridView15.DataSource = DSPerdu.Tables[0];


        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DAPays);
                    DAPays.UpdateCommand = cmd.GetUpdateCommand();
                    DAPays.Update(DSPays);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DAAuteurs);
                    DAAuteurs.UpdateCommand = cmd.GetUpdateCommand();
                    DAAuteurs.Update(DSAuteurs);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DALivre);
                    DALivre.UpdateCommand = cmd.GetUpdateCommand();
                    DALivre.Update(DSLivre);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DAEcrire);
                    DAEcrire.UpdateCommand = cmd.GetUpdateCommand();
                    DAEcrire.Update(DSEcrire);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DAGenre);
                    DAGenre.UpdateCommand = cmd.GetUpdateCommand();
                    DAGenre.Update(DSGenre);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DAGenreLivre);
                    DAGenreLivre.UpdateCommand = cmd.GetUpdateCommand();
                    DAGenreLivre.Update(DSGenreLivre);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DAEdition);
                    DAEdition.UpdateCommand = cmd.GetUpdateCommand();
                    DAEdition.Update(DSEdition);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DAExemplaire);
                    DAExemplaire.UpdateCommand = cmd.GetUpdateCommand();
                    DAExemplaire.Update(DSExemplaire);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DAEBook);
                    DAEBook.UpdateCommand = cmd.GetUpdateCommand();
                    DAEBook.Update(DSEBook);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DAAdherent);
                    DAAdherent.UpdateCommand = cmd.GetUpdateCommand();
                    DAAdherent.Update(DSAdherent);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DARetourEmprunt);
                    DARetourEmprunt.UpdateCommand = cmd.GetUpdateCommand();
                    DARetourEmprunt.Update(DSRetouremprunt);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DABlog);
                    DABlog.UpdateCommand = cmd.GetUpdateCommand();
                    DABlog.Update(DSBlog);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DAAdherentExclu);
                    DAAdherentExclu.UpdateCommand = cmd.GetUpdateCommand();
                    DAAdherentExclu.Update(DSAdherentExclu);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DAArchive);
                    DAArchive.UpdateCommand = cmd.GetUpdateCommand();
                    DAArchive.Update(DSArchive);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }


        }
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment appliquer ces changements ?", "Mise à jour de la base de données", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    MySqlCommandBuilder cmd = new MySqlCommandBuilder(DAPerdu);
                    DAPerdu.UpdateCommand = cmd.GetUpdateCommand();
                    DAPerdu.Update(DSPerdu);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL.\nVeuillez vérifier vos clés primaires.");
            }

        }
    }
}
