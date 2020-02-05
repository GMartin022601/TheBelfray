using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBelfray
{
    public partial class MainWindow : Form
    {
        public bool menuExpanded = false;

        public MainWindow()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(128, 128, 128);
            pnlMenu.BackColor = Color.FromArgb(72, 72, 72);

            lblRoomBooking.ForeColor = Color.FromArgb(241, 218, 117);
            lblRestaurantBooking.ForeColor = Color.FromArgb(241, 218, 117);
            lblRoomStock.ForeColor = Color.FromArgb(241, 218, 117);
            lblRestaurantStock.ForeColor = Color.FromArgb(241, 218, 117);
        }

        private void picSideMenu_MouseEnter(object sender, EventArgs e)
        {
            picSideMenu.BackColor = Color.Black;
        }

        private void picSideMenu_MouseLeave(object sender, EventArgs e)
        {
            picSideMenu.BackColor = Color.Transparent;
        }

        private void picRoomBooking_MouseEnter(object sender, EventArgs e)
        {
            picRoomBooking.BackColor = Color.Black;
            lblRoomBooking.BackColor = Color.Black;
        }

        private void picRoomBooking_MouseLeave(object sender, EventArgs e)
        {
            picRoomBooking.BackColor = Color.Transparent;
            lblRoomBooking.BackColor = Color.Transparent;
        }

        private void picRestaurantBooking_MouseEnter(object sender, EventArgs e)
        {
            picRestaurantBooking.BackColor = Color.Black;
            lblRestaurantBooking.BackColor = Color.Black;
        }

        private void picRestaurantBooking_MouseLeave(object sender, EventArgs e)
        {
            picRestaurantBooking.BackColor = Color.Transparent;
            lblRestaurantBooking.BackColor = Color.Transparent;
        }

        private void picHome_MouseEnter(object sender, EventArgs e)
        {
            picHome.BackColor = Color.Black;
        }

        private void picHome_MouseLeave(object sender, EventArgs e)
        {
            picHome.BackColor = Color.Transparent;
        }

        private void picUserInfo_MouseEnter(object sender, EventArgs e)
        {
            picUserInfo.BackColor = Color.Black;
        }

        private void picUserInfo_MouseLeave(object sender, EventArgs e)
        {
            picUserInfo.BackColor = Color.Transparent;
        }

        private void picPassword_MouseEnter(object sender, EventArgs e)
        {
            picPassword.BackColor = Color.Black;
        }

        private void picPassword_MouseLeave(object sender, EventArgs e)
        {
            picPassword.BackColor = Color.Transparent;
        }

        private void picAdmin_MouseEnter(object sender, EventArgs e)
        {
            picAdmin.BackColor = Color.Black;
        }

        private void picAdmin_MouseLeave(object sender, EventArgs e)
        {
            picAdmin.BackColor = Color.Transparent;
        }

        private void picSideMenu_Click(object sender, EventArgs e)
        {
            if (!menuExpanded)
            {
                for (int x = 0; x < 110; x++)
                {
                    pnlMenu.Height += 3;
                }

                menuExpanded = true;
            }
            else
            {
                for (int x = 0; x < 110; x++)
                {
                    pnlMenu.Height -= 3;
                }

                menuExpanded = false;
            }
        }

        private void picRoomStock_MouseEnter(object sender, EventArgs e)
        {
            picRoomStock.BackColor = Color.Black;
            lblRoomStock.BackColor = Color.Black;
        }

        private void picRoomStock_MouseLeave(object sender, EventArgs e)
        {
            picRoomStock.BackColor = Color.Transparent;
            lblRoomStock.BackColor = Color.Transparent;
        }

        private void picRestaurantStock_MouseEnter(object sender, EventArgs e)
        {
            picRestaurantStock.BackColor = Color.Black;
            lblRestaurantStock.BackColor = Color.Black;
        }

        private void picRestaurantStock_MouseLeave(object sender, EventArgs e)
        {
            picRestaurantStock.BackColor = Color.Transparent;
            lblRestaurantStock.BackColor = Color.Transparent;
        }

        private void picRoomBooking_Click(object sender, EventArgs e)
        {
            pnlRoomBooking.Visible = true;
        }

        private void picRoomStock_Click(object sender, EventArgs e)
        {

        }

        private void picRestaurantBooking_Click(object sender, EventArgs e)
        {

        }

        private void picRestaurantStock_Click(object sender, EventArgs e)
        {

        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Reset();

        }

        public void Reset()
        {
            tabRoomBooking.SelectedIndex = 0;
            pnlRoomBooking.Visible = false;
        }

        private void btnRoomBookingExit_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
