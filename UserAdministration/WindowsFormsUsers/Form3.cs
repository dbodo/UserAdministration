using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DatabaseService;

namespace WindowsFormsUsers
{
    public partial class FormDeleteUser : Form
    {
        private readonly Form1 FormUserList;
        public string ID;
        public string UserName;
        public string FirstName;
        public string Surname;
        public string Password;
        public FormDeleteUser(Form1 FormUsers)
        {
            FormUserList = FormUsers;
            InitializeComponent();
        }

        private void FormDeleteUser_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            User oUser = new User();
            oUser.nUserID = Int32.Parse(ID);
            oUser.sUserFirstName = FirstName;
            oUser.sUserLastName = Surname;
            oUser.sUserPassword = Password;
            oUser.sUserName = UserName;
            Crud Crud = new Crud();
            Crud.DeleteUsers(oUser);

            this.FormUserList.dataGridViewUsers.DataSource = Crud.GetUsers();
            this.Hide();
        }
    }
}
