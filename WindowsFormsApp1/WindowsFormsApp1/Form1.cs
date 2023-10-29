using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainScreen : Form
    {

        public bool configuregoal;
        List<Label> GoalName = new List<Label>();



        //public MainScreen(bool GoalNo, string value)
        public MainScreen()
        {
            InitializeComponent();
            //configuregoal = GoalNo;
            //createGoal();
            
        }


        public void createGoal()
        {
            if (configuregoal == true)
            {
                Label Goalnumber = new Label();
                Goalnumber.Text = "Test";
                Goalnumber.Location = new System.Drawing.Point(615, 95);
                Goalnumber.AutoSize = true;
                this.Controls.Add(Goalnumber);
                Goalnumber.BringToFront();
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void pictureBox1_Click_1(object sender, EventArgs e)
        {


            InputGoalScreen F2 = new InputGoalScreen(); 
            F2.Show(); 
            Hide(); 
            this.Close(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WeeklyMonthlyAllowance_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inputs = new InputsForm();
            inputs.Closed += (s, args) => this.Close();
            inputs.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (InputsForm inputsform = new InputsForm())
            {
                if (inputsform.ShowDialog() == DialogResult.OK)
                {
                    string name = inputsform.Name;
                    //string age = inputsform.age;
                    //string whenPay = inputsform.whenPay;
                    //string pay = inputsform.pay;
                }
            }
            //this.Hide();
            //var office = new OfficeForm();
            //office.Closed += (s, args) => this.Close();
            //office.Show();
        }
    }
}
