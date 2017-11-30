using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseService;  // koristimo servis
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;


namespace WindowsFormsUsers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Crud Crud = new Crud();
            List <User> lUsers = Crud.GetUsers();
            dataGridViewUsers.DataSource = lUsers;

            // gumb za azuriranje korisnika
            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();   
            oEditButton.Image = Image.FromFile("D:/DomagojBodo/icons/icon.png");
            oEditButton.Width = 20;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewUsers.Columns.Add(oEditButton);

            // za brisanje korisnika
            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("D:/DomagojBodo/icons/icon2.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewUsers.Columns.Add(oDeleteButton);


            dataGridViewUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dataGridViewUsers.AutoGenerateColumns = false;
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewUsers.Rows[e.RowIndex].Selected = true;
            if (dataGridViewUsers.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                FormEditUser FormEditUser = new FormEditUser(this);
                FormEditUser.lblEditUserID.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormEditUser.lblEditUserName.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditUser.inptEditPassword.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditUser.inptEditName.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormEditUser.inptEditSurname.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();            
                FormEditUser.Show();
            }
            if(dataGridViewUsers.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                FormDeleteUser FormDeleteUser = new FormDeleteUser(this);
                FormDeleteUser.ID = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteUser.UserName = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormDeleteUser.Password = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormDeleteUser.FirstName = dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormDeleteUser.Surname = dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                FormDeleteUser.Show();
            }          
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser AddNewUser = new FormAddUser(this);
            AddNewUser.Show();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
           
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void izbornikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}

