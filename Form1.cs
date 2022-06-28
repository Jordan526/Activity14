using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14___2
{
    //CST150_OC2.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Activity14();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //intialize global variables that I will need for the program. 
        public GroupBox groupBox;
        public RadioButton radioButton2;
        public RadioButton radioButtonChoosed;
        public Button choosedRadioButton;

        public void Activity14()
        {
            //setting up my groupbox and radio buttons (size, location, and text)
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.choosedRadioButton = new System.Windows.Forms.Button();

            this.groupBox.Controls.Add(this.radioButton1);
            this.groupBox.Controls.Add(this.radioButton2);
            this.groupBox.Controls.Add(this.choosedRadioButton);
            this.groupBox.Location = new System.Drawing.Point(55, 100);
            this.groupBox.Size = new System.Drawing.Size(225, 110);
            this.groupBox.Text = "Please Choose a Door to Look Behind!";

            this.radioButton1.Location = new System.Drawing.Point(25, 20);
            this.radioButton1.Name = "radioButton";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.Text = "Door #1";
            this.radioButton1.CheckedChanged += new EventHandler(radioButton_checkButtonChange);
            this.radioButton1.Text += ": There is nothing behind door 1. Sorry!";

            this.radioButton2.Location = new System.Drawing.Point(25, 50);
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.Text = "Door #2";
            this.radioButton2.CheckedChanged += new EventHandler(radioButton_checkButtonChange);
            this.radioButton2.Text += ": There is $1,000,000.00 Behind Door #2!!!";

            this.choosedRadioButton.Location = new System.Drawing.Point(15, 70);
            this.choosedRadioButton.Size = new System.Drawing.Size(200, 30);
            this.choosedRadioButton.Text = "Look Behind Door";
            this.choosedRadioButton.Click += new EventHandler(showSelectedRadioButtonText_Click);

            this.ClientSize = new System.Drawing.Size(325, 250);
            this.Controls.Add(this.groupBox);
        }

        //check the status of the button and see if the button has changed its status. 
        public void radioButton_checkButtonChange(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            //if button is null, thow a message to try again. 
            if (button == null)
            {
                MessageBox.Show("Not a Radio Button, Please Try Again.");
                return;
            }

            if (button.Checked)
            {
                radioButtonChoosed = button;
            }
        }
   
        //show text for selected radio button.
        public void showSelectedRadioButtonText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(radioButtonChoosed.Text);
        }
    }

}
