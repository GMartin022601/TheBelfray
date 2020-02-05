namespace TheBelfray
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUserInfo = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picSideMenu = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.lblRestaurantStock = new System.Windows.Forms.Label();
            this.lblRoomStock = new System.Windows.Forms.Label();
            this.lblRestaurantBooking = new System.Windows.Forms.Label();
            this.lblRoomBooking = new System.Windows.Forms.Label();
            this.picRestaurantStock = new System.Windows.Forms.PictureBox();
            this.picRoomStock = new System.Windows.Forms.PictureBox();
            this.picRestaurantBooking = new System.Windows.Forms.PictureBox();
            this.picRoomBooking = new System.Windows.Forms.PictureBox();
            this.picContactInfo = new System.Windows.Forms.PictureBox();
            this.picBelfrayLogo = new System.Windows.Forms.PictureBox();
            this.pnlRoomBooking = new System.Windows.Forms.Panel();
            this.btnRoomBookingExit = new System.Windows.Forms.Button();
            this.tabRoomBooking = new System.Windows.Forms.TabControl();
            this.tabRBDisplay = new System.Windows.Forms.TabPage();
            this.dgvRoomBooking = new System.Windows.Forms.DataGridView();
            this.tabRBAdd = new System.Windows.Forms.TabPage();
            this.tabRBEdit = new System.Windows.Forms.TabPage();
            this.tabRBDelete = new System.Windows.Forms.TabPage();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSideMenu)).BeginInit();
            this.pnlMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurantStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurantBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContactInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBelfrayLogo)).BeginInit();
            this.pnlRoomBooking.SuspendLayout();
            this.tabRoomBooking.SuspendLayout();
            this.tabRBDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DimGray;
            this.pnlMenu.Controls.Add(this.picAdmin);
            this.pnlMenu.Controls.Add(this.picPassword);
            this.pnlMenu.Controls.Add(this.picUserInfo);
            this.pnlMenu.Controls.Add(this.picHome);
            this.pnlMenu.Controls.Add(this.picSideMenu);
            this.pnlMenu.Location = new System.Drawing.Point(9, 129);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(80, 78);
            this.pnlMenu.TabIndex = 13;
            // 
            // picAdmin
            // 
            this.picAdmin.BackColor = System.Drawing.Color.Transparent;
            this.picAdmin.Image = global::TheBelfray.Properties.Resources.Admin;
            this.picAdmin.Location = new System.Drawing.Point(-2, 251);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(83, 50);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmin.TabIndex = 4;
            this.picAdmin.TabStop = false;
            this.picAdmin.MouseEnter += new System.EventHandler(this.picAdmin_MouseEnter);
            this.picAdmin.MouseLeave += new System.EventHandler(this.picAdmin_MouseLeave);
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.Transparent;
            this.picPassword.Image = global::TheBelfray.Properties.Resources.Password;
            this.picPassword.Location = new System.Drawing.Point(-2, 195);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(83, 50);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassword.TabIndex = 3;
            this.picPassword.TabStop = false;
            this.picPassword.MouseEnter += new System.EventHandler(this.picPassword_MouseEnter);
            this.picPassword.MouseLeave += new System.EventHandler(this.picPassword_MouseLeave);
            // 
            // picUserInfo
            // 
            this.picUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.picUserInfo.Image = global::TheBelfray.Properties.Resources.User_Info;
            this.picUserInfo.Location = new System.Drawing.Point(-2, 139);
            this.picUserInfo.Name = "picUserInfo";
            this.picUserInfo.Size = new System.Drawing.Size(83, 50);
            this.picUserInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserInfo.TabIndex = 2;
            this.picUserInfo.TabStop = false;
            this.picUserInfo.MouseEnter += new System.EventHandler(this.picUserInfo_MouseEnter);
            this.picUserInfo.MouseLeave += new System.EventHandler(this.picUserInfo_MouseLeave);
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.Image = global::TheBelfray.Properties.Resources.Home1;
            this.picHome.Location = new System.Drawing.Point(-2, 83);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(83, 50);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            this.picHome.MouseEnter += new System.EventHandler(this.picHome_MouseEnter);
            this.picHome.MouseLeave += new System.EventHandler(this.picHome_MouseLeave);
            // 
            // picSideMenu
            // 
            this.picSideMenu.BackColor = System.Drawing.Color.Transparent;
            this.picSideMenu.Image = global::TheBelfray.Properties.Resources.SideMenu;
            this.picSideMenu.Location = new System.Drawing.Point(13, 13);
            this.picSideMenu.Name = "picSideMenu";
            this.picSideMenu.Size = new System.Drawing.Size(53, 52);
            this.picSideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSideMenu.TabIndex = 0;
            this.picSideMenu.TabStop = false;
            this.picSideMenu.Click += new System.EventHandler(this.picSideMenu_Click);
            this.picSideMenu.MouseEnter += new System.EventHandler(this.picSideMenu_MouseEnter);
            this.picSideMenu.MouseLeave += new System.EventHandler(this.picSideMenu_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(9, 545);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 34);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainMenu.Controls.Add(this.lblRestaurantStock);
            this.pnlMainMenu.Controls.Add(this.lblRoomStock);
            this.pnlMainMenu.Controls.Add(this.lblRestaurantBooking);
            this.pnlMainMenu.Controls.Add(this.lblRoomBooking);
            this.pnlMainMenu.Controls.Add(this.picRestaurantStock);
            this.pnlMainMenu.Controls.Add(this.picRoomStock);
            this.pnlMainMenu.Controls.Add(this.picRestaurantBooking);
            this.pnlMainMenu.Controls.Add(this.picRoomBooking);
            this.pnlMainMenu.Location = new System.Drawing.Point(99, 129);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(811, 450);
            this.pnlMainMenu.TabIndex = 11;
            // 
            // lblRestaurantStock
            // 
            this.lblRestaurantStock.AutoSize = true;
            this.lblRestaurantStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantStock.Location = new System.Drawing.Point(503, 415);
            this.lblRestaurantStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRestaurantStock.Name = "lblRestaurantStock";
            this.lblRestaurantStock.Size = new System.Drawing.Size(210, 29);
            this.lblRestaurantStock.TabIndex = 7;
            this.lblRestaurantStock.Text = "Restaurant Stock";
            this.lblRestaurantStock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRoomStock
            // 
            this.lblRoomStock.AutoSize = true;
            this.lblRoomStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomStock.Location = new System.Drawing.Point(532, 190);
            this.lblRoomStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomStock.Name = "lblRoomStock";
            this.lblRoomStock.Size = new System.Drawing.Size(154, 29);
            this.lblRoomStock.TabIndex = 6;
            this.lblRoomStock.Text = "Room Stock";
            this.lblRoomStock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRestaurantBooking
            // 
            this.lblRestaurantBooking.AutoSize = true;
            this.lblRestaurantBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantBooking.Location = new System.Drawing.Point(81, 415);
            this.lblRestaurantBooking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRestaurantBooking.Name = "lblRestaurantBooking";
            this.lblRestaurantBooking.Size = new System.Drawing.Size(241, 29);
            this.lblRestaurantBooking.TabIndex = 5;
            this.lblRestaurantBooking.Text = "Restaurant Booking";
            this.lblRestaurantBooking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRoomBooking
            // 
            this.lblRoomBooking.AutoSize = true;
            this.lblRoomBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomBooking.Location = new System.Drawing.Point(110, 190);
            this.lblRoomBooking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomBooking.Name = "lblRoomBooking";
            this.lblRoomBooking.Size = new System.Drawing.Size(185, 29);
            this.lblRoomBooking.TabIndex = 4;
            this.lblRoomBooking.Text = "Room Booking";
            this.lblRoomBooking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picRestaurantStock
            // 
            this.picRestaurantStock.BackColor = System.Drawing.Color.Transparent;
            this.picRestaurantStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRestaurantStock.Image = global::TheBelfray.Properties.Resources.Restaurant_Icon;
            this.picRestaurantStock.Location = new System.Drawing.Point(515, 225);
            this.picRestaurantStock.Name = "picRestaurantStock";
            this.picRestaurantStock.Size = new System.Drawing.Size(187, 187);
            this.picRestaurantStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestaurantStock.TabIndex = 3;
            this.picRestaurantStock.TabStop = false;
            this.picRestaurantStock.Click += new System.EventHandler(this.picRestaurantStock_Click);
            this.picRestaurantStock.MouseEnter += new System.EventHandler(this.picRestaurantStock_MouseEnter);
            this.picRestaurantStock.MouseLeave += new System.EventHandler(this.picRestaurantStock_MouseLeave);
            // 
            // picRoomStock
            // 
            this.picRoomStock.BackColor = System.Drawing.Color.Transparent;
            this.picRoomStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRoomStock.Image = global::TheBelfray.Properties.Resources.Bed_Icon;
            this.picRoomStock.Location = new System.Drawing.Point(515, 0);
            this.picRoomStock.Name = "picRoomStock";
            this.picRoomStock.Size = new System.Drawing.Size(187, 187);
            this.picRoomStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoomStock.TabIndex = 2;
            this.picRoomStock.TabStop = false;
            this.picRoomStock.Click += new System.EventHandler(this.picRoomStock_Click);
            this.picRoomStock.MouseEnter += new System.EventHandler(this.picRoomStock_MouseEnter);
            this.picRoomStock.MouseLeave += new System.EventHandler(this.picRoomStock_MouseLeave);
            // 
            // picRestaurantBooking
            // 
            this.picRestaurantBooking.BackColor = System.Drawing.Color.Transparent;
            this.picRestaurantBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRestaurantBooking.Image = global::TheBelfray.Properties.Resources.Restaurant_Icon;
            this.picRestaurantBooking.Location = new System.Drawing.Point(109, 225);
            this.picRestaurantBooking.Name = "picRestaurantBooking";
            this.picRestaurantBooking.Size = new System.Drawing.Size(187, 187);
            this.picRestaurantBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestaurantBooking.TabIndex = 1;
            this.picRestaurantBooking.TabStop = false;
            this.picRestaurantBooking.Click += new System.EventHandler(this.picRestaurantBooking_Click);
            this.picRestaurantBooking.MouseEnter += new System.EventHandler(this.picRestaurantBooking_MouseEnter);
            this.picRestaurantBooking.MouseLeave += new System.EventHandler(this.picRestaurantBooking_MouseLeave);
            // 
            // picRoomBooking
            // 
            this.picRoomBooking.BackColor = System.Drawing.Color.Transparent;
            this.picRoomBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRoomBooking.Image = global::TheBelfray.Properties.Resources.Bed_Icon;
            this.picRoomBooking.Location = new System.Drawing.Point(109, 0);
            this.picRoomBooking.Name = "picRoomBooking";
            this.picRoomBooking.Size = new System.Drawing.Size(187, 187);
            this.picRoomBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoomBooking.TabIndex = 0;
            this.picRoomBooking.TabStop = false;
            this.picRoomBooking.Click += new System.EventHandler(this.picRoomBooking_Click);
            this.picRoomBooking.MouseEnter += new System.EventHandler(this.picRoomBooking_MouseEnter);
            this.picRoomBooking.MouseLeave += new System.EventHandler(this.picRoomBooking_MouseLeave);
            // 
            // picContactInfo
            // 
            this.picContactInfo.BackColor = System.Drawing.Color.Transparent;
            this.picContactInfo.Image = global::TheBelfray.Properties.Resources.Belfray_Contact_Info_final;
            this.picContactInfo.Location = new System.Drawing.Point(590, 9);
            this.picContactInfo.Name = "picContactInfo";
            this.picContactInfo.Size = new System.Drawing.Size(320, 100);
            this.picContactInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContactInfo.TabIndex = 15;
            this.picContactInfo.TabStop = false;
            // 
            // picBelfrayLogo
            // 
            this.picBelfrayLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBelfrayLogo.Image = global::TheBelfray.Properties.Resources.Belfray_Logo;
            this.picBelfrayLogo.Location = new System.Drawing.Point(9, 9);
            this.picBelfrayLogo.Name = "picBelfrayLogo";
            this.picBelfrayLogo.Size = new System.Drawing.Size(320, 100);
            this.picBelfrayLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBelfrayLogo.TabIndex = 14;
            this.picBelfrayLogo.TabStop = false;
            // 
            // pnlRoomBooking
            // 
            this.pnlRoomBooking.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoomBooking.Controls.Add(this.btnRoomBookingExit);
            this.pnlRoomBooking.Controls.Add(this.tabRoomBooking);
            this.pnlRoomBooking.Location = new System.Drawing.Point(99, 129);
            this.pnlRoomBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRoomBooking.Name = "pnlRoomBooking";
            this.pnlRoomBooking.Size = new System.Drawing.Size(809, 448);
            this.pnlRoomBooking.TabIndex = 16;
            this.pnlRoomBooking.Visible = false;
            // 
            // btnRoomBookingExit
            // 
            this.btnRoomBookingExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomBookingExit.Location = new System.Drawing.Point(717, 267);
            this.btnRoomBookingExit.Name = "btnRoomBookingExit";
            this.btnRoomBookingExit.Size = new System.Drawing.Size(80, 34);
            this.btnRoomBookingExit.TabIndex = 17;
            this.btnRoomBookingExit.Text = "Exit";
            this.btnRoomBookingExit.UseVisualStyleBackColor = true;
            this.btnRoomBookingExit.Click += new System.EventHandler(this.btnRoomBookingExit_Click);
            // 
            // tabRoomBooking
            // 
            this.tabRoomBooking.Controls.Add(this.tabRBDisplay);
            this.tabRoomBooking.Controls.Add(this.tabRBAdd);
            this.tabRoomBooking.Controls.Add(this.tabRBEdit);
            this.tabRoomBooking.Controls.Add(this.tabRBDelete);
            this.tabRoomBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRoomBooking.Location = new System.Drawing.Point(0, 2);
            this.tabRoomBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRoomBooking.Name = "tabRoomBooking";
            this.tabRoomBooking.SelectedIndex = 0;
            this.tabRoomBooking.Size = new System.Drawing.Size(712, 449);
            this.tabRoomBooking.TabIndex = 0;
            // 
            // tabRBDisplay
            // 
            this.tabRBDisplay.Controls.Add(this.dgvRoomBooking);
            this.tabRBDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRBDisplay.Location = new System.Drawing.Point(4, 29);
            this.tabRBDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRBDisplay.Name = "tabRBDisplay";
            this.tabRBDisplay.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRBDisplay.Size = new System.Drawing.Size(704, 416);
            this.tabRBDisplay.TabIndex = 0;
            this.tabRBDisplay.Text = "Display";
            this.tabRBDisplay.UseVisualStyleBackColor = true;
            // 
            // dgvRoomBooking
            // 
            this.dgvRoomBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomBooking.Location = new System.Drawing.Point(4, 4);
            this.dgvRoomBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRoomBooking.Name = "dgvRoomBooking";
            this.dgvRoomBooking.RowTemplate.Height = 28;
            this.dgvRoomBooking.Size = new System.Drawing.Size(695, 414);
            this.dgvRoomBooking.TabIndex = 0;
            // 
            // tabRBAdd
            // 
            this.tabRBAdd.Location = new System.Drawing.Point(4, 29);
            this.tabRBAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRBAdd.Name = "tabRBAdd";
            this.tabRBAdd.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRBAdd.Size = new System.Drawing.Size(704, 416);
            this.tabRBAdd.TabIndex = 1;
            this.tabRBAdd.Text = "Add";
            this.tabRBAdd.UseVisualStyleBackColor = true;
            // 
            // tabRBEdit
            // 
            this.tabRBEdit.Location = new System.Drawing.Point(4, 29);
            this.tabRBEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRBEdit.Name = "tabRBEdit";
            this.tabRBEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRBEdit.Size = new System.Drawing.Size(701, 416);
            this.tabRBEdit.TabIndex = 2;
            this.tabRBEdit.Text = "Edit";
            this.tabRBEdit.UseVisualStyleBackColor = true;
            // 
            // tabRBDelete
            // 
            this.tabRBDelete.Location = new System.Drawing.Point(4, 29);
            this.tabRBDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRBDelete.Name = "tabRBDelete";
            this.tabRBDelete.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRBDelete.Size = new System.Drawing.Size(701, 416);
            this.tabRBDelete.TabIndex = 3;
            this.tabRBDelete.Text = "Delete";
            this.tabRBDelete.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 588);
            this.Controls.Add(this.pnlRoomBooking);
            this.Controls.Add(this.picContactInfo);
            this.Controls.Add(this.picBelfrayLogo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlMainMenu);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Belfray Country Inn";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSideMenu)).EndInit();
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurantStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurantBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContactInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBelfrayLogo)).EndInit();
            this.pnlRoomBooking.ResumeLayout(false);
            this.tabRoomBooking.ResumeLayout(false);
            this.tabRBDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox picSideMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.PictureBox picRestaurantBooking;
        private System.Windows.Forms.PictureBox picRoomBooking;
        private System.Windows.Forms.PictureBox picContactInfo;
        private System.Windows.Forms.PictureBox picBelfrayLogo;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.PictureBox picUserInfo;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label lblRestaurantStock;
        private System.Windows.Forms.Label lblRoomStock;
        private System.Windows.Forms.Label lblRestaurantBooking;
        private System.Windows.Forms.Label lblRoomBooking;
        private System.Windows.Forms.PictureBox picRestaurantStock;
        private System.Windows.Forms.PictureBox picRoomStock;
        private System.Windows.Forms.Panel pnlRoomBooking;
        private System.Windows.Forms.TabControl tabRoomBooking;
        private System.Windows.Forms.TabPage tabRBDisplay;
        private System.Windows.Forms.TabPage tabRBAdd;
        private System.Windows.Forms.TabPage tabRBEdit;
        private System.Windows.Forms.TabPage tabRBDelete;
        private System.Windows.Forms.Button btnRoomBookingExit;
        private System.Windows.Forms.DataGridView dgvRoomBooking;
    }
}