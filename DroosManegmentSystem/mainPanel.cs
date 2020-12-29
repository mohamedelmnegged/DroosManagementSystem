using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using DroosManegmentSystem.Forms;

namespace DroosManegmentSystem
{ 
	public partial class mainPanel : Form
	{
		// Fields
		private IconButton currentBtn;
		private Panel rightBorderBtn;
		private Form currentChildForm;
		public string teacherid, teachername;

		// Constructor
		public mainPanel(string id, string name)
		{
			InitializeComponent();
			customeDesign();
			this.teacherid = id;
			this.teachername = name;
			//this to show teacher name 
			label2.Text = name;

			// this to make pictuerbox in a circule  shape 
			System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
			gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
			Region rg = new Region(gp);
			pictureBox1.Region = rg;

			// 
			new mainPageForm(this.teacherid);
		}

		// RGB Colors
		//this is the colors used in the program 
		
		private struct RGBColors
		{ 
			
			public static Color color1 = Color.FromArgb(52, 152, 219);
			public static Color color2 = Color.FromArgb(38, 194, 129);
			public static Color color3 = Color.FromArgb(142, 68, 173);
			public static Color color4 = Color.FromArgb(211, 84, 0);
			public static Color color5 = Color.FromArgb(192, 57, 43);
		}

		private void customeDesign()
		{
			// Make a custom Right Border To Buttons
			rightBorderBtn = new Panel();
			rightBorderBtn.Size = new Size(10, 65);
			sideMenu.Controls.Add(rightBorderBtn);

			// Activate Home Button
			activatBtn(homeBtn, RGBColors.color1);
			openChildForm(new mainPageForm(this.teacherid));

		}

		// Active Button Design Method

		private void activatBtn(object senderBtn, Color color)
		{
			if (senderBtn != null)
			{
				disaleBtn();
				// Custmize Button
				currentBtn = (IconButton)senderBtn;
				currentBtn.ForeColor = color;
				currentBtn.IconColor = color;

				// Add Right Border
				rightBorderBtn.BackColor = color;
				rightBorderBtn.Location = new Point(280, currentBtn.Location.Y);
				rightBorderBtn.Visible = true;
				rightBorderBtn.BringToFront();

				// Change Navbar Active Page Data

				changeNavbarTitle(currentBtn, color);
			}
		}

		private void disaleBtn()
		{
			if (currentBtn != null)
			{
				// Custmize Button
				currentBtn.BackColor = Color.FromArgb(34, 42, 45);
				currentBtn.ForeColor = Color.White;
				currentBtn.IconColor = Color.White;
			}
		}

		// Hide SubMenu Panels Method
		private void hideSubMenus()
		{

		}

		// Show SubMenu Panels Method

		//private void showSubMenu(Panel subMenu)
		//{
		//	if (subMenu.Visible == false)
		//	{
		//		hideSubMenus();
		//		subMenu.Visible = true;
		//	}
		//	else
		//	{
		//		subMenu.Visible = false;
		//	}
		//}

		// Change Navbar Active Page Data Method
		private void changeNavbarTitle(object btn, Color color)
		{

			currentBtn = (IconButton)btn;
			navbarActivePage.Text = currentBtn.Text;
			navbarActivePage.IconChar = currentBtn.IconChar;

			navbarActivePage.ForeColor = color;
			navbarActivePage.IconColor = color;
		}

		// Show Different Forms
		
		private void openChildForm(Form childForm)
		{
			if(currentChildForm != null)
			{
				// We Close The Previous Form to Open The new One
				currentChildForm.Close();
			}
			currentChildForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			childFormPnl.Controls.Add(childForm);
			childFormPnl.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}


		// Button Click Events
		//// Sidebar Buttons

		private void homeBtn_Click(object sender, EventArgs e)
		{
			hideSubMenus();
			activatBtn(sender, RGBColors.color1);
			openChildForm(new mainPageForm(this.teacherid));

		}

		private void groupsBtn_Click(object sender, EventArgs e)
		{
			activatBtn(sender, RGBColors.color2);

			openChildForm(new groupsForm(this.teacherid));

		}

		private void studentMBtn_Click(object sender, EventArgs e)
		{
			activatBtn(sender, RGBColors.color3);
			openChildForm(new studentsForm(this.teacherid));

		}

		private void lesonBtn_Click(object sender, EventArgs e)
		{
			activatBtn(sender, RGBColors.color4);
			openChildForm(new lessonsForm(this.teacherid));
		}

		private void employerBtn_Click(object sender, EventArgs e)
		{
			activatBtn(sender, RGBColors.color5);
			openChildForm(new employersForm(this.teacherid));
		}

		//private void espenseBtn_Click(object sender, EventArgs e)
		//{
		//	activatBtn(sender, RGBColors.color2);
		//	openChildForm(new expensesForm());
		//}

		//private void accBtn_Click(object sender, EventArgs e)
		//{
		//	activatBtn(sender, RGBColors.color3);
		//	openChildForm(new acountingForm());
		//}

		//// Navbar Buttons

		private void activeUserPnlBtn_Click(object sender, EventArgs e)
		{
			
		}

		private void activeUserSitBtn_Click(object sender, EventArgs e)
		{
			changeNavbarTitle(sender, activeUserSitBtn.ForeColor);
		}

		private void childFormPnl_Paint(object sender, PaintEventArgs e)
		{

		}

        private void mainPanel_Load(object sender, EventArgs e)
        {

			
        }

        private void logOut_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void mainPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
			Application.Exit();
        }
    }
}
