using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.Companies;
using ClassLibrary.Houses;

namespace Lab2_FactoryMethod_BuildingHouses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BuildHouse(Company company, string filePictureHouse, int square, int cost, PictureBox picBox)
        {
            House house = company.BuildHouse(new Bitmap(@"..\..\images\" + filePictureHouse), square, cost);
            picBox.Image = house.View();

            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuildHouse(new ClassicCompany("Classic"), "ClassicHouse.jpg", 150, 500000, pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuildHouse(new BaroqueCompany("Baroque"), "BaroqueHouse.jpg", 90, 1500000, pictureBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuildHouse(new ModernCompany("Modern"), "ModernHouse.jpg", 120, 400000, pictureBox3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuildHouse(new Hi_TechCompany("Hi_Tech"), "Hi_TechHouse.jpg", 170, 3000000, pictureBox4);
        }
    }
}
