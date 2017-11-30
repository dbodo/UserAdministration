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
        public FormDeleteUser(Form1 FormUsers)
        {
            FormUserList = FormUsers;
            InitializeComponent();
        }
    }
}
