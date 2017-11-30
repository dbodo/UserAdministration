using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseService;
using System.Configuration;

namespace WindowsFormsUsers
{
    public partial class FormAddUser : Form
    {
        private readonly Form1 FormUserList;

        public FormAddUser(Form1 FormUsers)
        {
            FormUserList = FormUsers;
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User oUser = new User();
            oUser.sUserFirstName = inptAddName.Text;
            oUser.sUserLastName = inptAddSurname.Text;
            oUser.sUserName = inptAddUsername.Text;
            oUser.sUserPassword = inptAddPassword.Text;
            Crud Crud = new Crud();
            Crud.AddUsers(oUser);

            this.FormUserList.dataGridViewUsers.DataSource = Crud.GetUsers();
            this.Hide();
        }

        private void btnEditUserExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
