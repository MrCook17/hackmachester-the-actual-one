﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InputsForm : Form
    {
        //public string name, age, whenPay, pay;
        //public string age;
        //public string whenyPay;
        //public string pay;

        public InputsForm()
        {
            InitializeComponent();
        }

        private void Return_To_MainScreen()
        {
            this.Hide();
            var form1 = new MainScreen();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Return_To_MainScreen();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            
            //age = userAge.Text;
            //whenPay = payDropDown.SelectedItem.ToString();
            //pay = monthPay.Text;
        }

        public string UserName
        {
            get { return userName.Text; }
        }

        //Return_To_MainScreen();
        //}
    }
}

