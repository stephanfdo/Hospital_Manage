﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Admin : Form
    {
        public string id, name, phone;
        public Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Users manage_Users = new Manage_Users();
            manage_Users.Show();
            Hide();
        }


        //show user detais
        private void Form1_Load(object sender, EventArgs e)
        {
            id = DBconnection.id;
            name = DBconnection.name;
            phone = DBconnection.phoneNumber;
            textBox1.Text=id;
            textBox2.Text=name;
            textBox3.Text=phone;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PatientDetails patientDetails = new PatientDetails();
            patientDetails.Show();
            Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchApointment appointment = new SearchApointment();
            appointment.Show();
            Hide();
        }
    }
}
