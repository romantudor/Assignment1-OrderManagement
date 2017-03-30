using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using Operations;
namespace OrderManagement
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            UserOperations up = new UserOperations();
            User user = new User();
            user = retrieve();
            up.AddUser(user);
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            UserOperations up = new UserOperations();
            dataGrid1.DataSource = up.view();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            UserOperations up = new UserOperations();
            User user = new User();
            user = retrieve();
            up.DeleteUser(user);
        }

        private User retrieve()
        {
            User user = new User();
            user.id = Convert.ToInt32(idText.Text);
            user.name = nameText.Text;
            user.password = passwordText.Text;
            if (adminBox.Checked)
                user.IsAdmin = true;
            else
                user.IsAdmin = false;
           
            return user;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UserOperations up = new UserOperations();
            User user = new User();
            user = retrieve();
            up.UpdateUser(user);
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            DateTime data1 = date1.Value;
            DateTime data2 = date2.Value;
            int id = Convert.ToInt32(idText.Text);
            UserOperations up = new UserOperations();
            dataGridView1.DataSource = up.generateDet(data1,data2,id);

        }
    }
}
