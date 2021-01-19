using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference;

namespace Client
{
    public partial class Main : Form
    {
        public ServiceClient sc = new ServiceClient();
        public Main()
        {
            InitializeComponent();
            //((Control)tab_users).Enabled = false;
            label_yourUsername.Text = sc.loggedUser();
            label_tartozas.Text = sc.userPayment();
            listBorrowed();
            listUsers();
            listCars();
            listUserCars();
        }
        public void listUserCars()
        {
            lb_usercars.Items.Clear();
            try
            {             
                foreach (var x in sc.getUserCars())
                {
                    lb_usercars.Items.Add(x);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Neked ehhez nincs jogod!");
            }
        }

        public void listUsers()
        {
            try
            {
                lb_users.Items.Clear();
                foreach (var x in sc.getUsers())
                {
                    lb_users.Items.Add(x);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Neked ehhez nincs jogod!");
            } 
            
        }
        private void bt_List_Click(object sender, EventArgs e) //users list gomb
        {
            listUsers();
        }

        public void listCars()
        {
            lb_cars.Items.Clear();
            try
            {
                foreach (var x in sc.getCars())
                {
                    lb_cars.Items.Add(x);
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Neked ehhez nincs jogod!");
            }
            
        }
        #region cars tab
        private void bt_list_Cars_Click(object sender, EventArgs e)
        {
            listCars();
        }
        private void bt_cars_Add_Click(object sender, EventArgs e)
        {
            sc.addCar(tb_cars_platenumber.Text, tb_cars_type.Text, tb_cars_cost.Text);
            listCars();
        }
        private void bt_cars_modify_Click(object sender, EventArgs e)
        {
            sc.modifyCar(tb_cars_platenumber.Text, tb_cars_type.Text, tb_cars_cost.Text);
            listCars();
        }
        private void bt_cars_delete_Click(object sender, EventArgs e)
        {
            string selected = lb_cars.SelectedItem.ToString();
            string id = "";
            for (int i = 0; i < selected.Length; i++)
            {
                if (selected[i] != '|')
                {
                    id = id + selected[i];
                }
                else
                {
                    break;
                }
            }
            sc.deleteCar(id);
            listCars();

        }
        #endregion
        public void listBorrowed()
        {
            try
            {
                lb_borrowed.Items.Clear();
                foreach (var x in sc.getBorrows())
                {
                    lb_borrowed.Items.Add(x);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Neked ehhez nincs jogod!");
            }
            
        }
        private void bt_listBorrowed_Click(object sender, EventArgs e)
        {
            listBorrowed();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            sc.Logout();
            Thread thread = new Thread(openNewLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        static void openNewLogin()
        {
            Application.Run(new loginForm());
        }

        private void bt_cars_borrow_Click(object sender, EventArgs e)
        {
            string selected = lb_cars.SelectedItem.ToString();
            string id = "";
            for (int i = 0; i < selected.Length; i++)
            {
                if (selected[i] != '|')
                {
                    id = id + selected[i];
                }
                else
                {
                    break;
                }
            }
            sc.borrowCar(id);
            listCars();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            label_tartozas.Text = sc.userPayment();
            listUserCars();
        }

        private void bt_userpanel_idontneedthat_Click(object sender, EventArgs e)
        {
            string selected = lb_usercars.SelectedItem.ToString();
            string id = "";
            for (int i = 0; i < selected.Length; i++)
            {
                if (selected[i] != '|')
                {
                    id = id + selected[i];
                }
                else
                {
                    break;
                }
            }
            sc.giveBackCar(id);
            listUserCars();
            label_tartozas.Text = sc.userPayment();
        }

    }
}
