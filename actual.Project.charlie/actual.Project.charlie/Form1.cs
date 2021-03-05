using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actual.Project.charlie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool buttonwasclicked = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonwasclicked = true;

            Form2 ft = new Form2();
            if (ft.ShowDialog()==DialogResult.OK)
            {
                if (ft.radioButton1.Checked == true)
                    button2.Text = ft.radioButton1.Text;
                else if (ft.radioButton2.Checked == true)
                    button2.Text = ft.radioButton2.Text;
                else if (ft.radioButton3.Checked == true)
                    button2.Text = ft.radioButton3.Text;
                else if (ft.radioButton4.Checked == true)
                    button2.Text = ft.radioButton4.Text;

            }

            

        }
       


        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;// fo rnum validation 
            if (textBox1.Text == "") //empty val
            {
                MessageBox.Show("Field cannot be left empty");
                textBox1.BackColor = Color.Red;
                textBox1.Focus();
            }
            else if (textBox2.Text == "") //empty val
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("Field cannot be left empty");
                textBox2.BackColor = Color.Red;
                textBox2.Focus();
            }

            else if (int.TryParse(textBox3.Text, out num) == false)
            {
                textBox2.BackColor = Color.White;
                MessageBox.Show("Enter digits only");
                textBox3.BackColor = Color.Red;
            }
            else if (textBox4.Text == "") //empty val
            {
                textBox3.BackColor = Color.White;
                MessageBox.Show("Field cannot be left empty");
                textBox4.BackColor = Color.Red;
                textBox4.Focus();
            }
            else if (dateTimePicker1.Checked == false )
            {
                textBox4.BackColor = Color.White;
                MessageBox.Show("Field cannot be left empty");
                textBox4.Focus();
            }

            else if (numericUpDown1.Value == 0)
            {
                
                MessageBox.Show(" Pleaase enter the hour ");
            }
            else if (numericUpDown2.Value == 0)
            {
                MessageBox.Show(" Pleaase enter the minute ");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show(" Please select any item");
            }
            else if (buttonwasclicked == false)
            {
                MessageBox.Show(" please click the button");

            }
            else if (buttonwasclicked==true)
            { 
                listBox1.Items.Add("Name: " + textBox1.Text + " " + textBox2.Text);
                listBox1.Items.Add("Time of meeting: " + numericUpDown1.Value +":"+ numericUpDown2.Value);
                listBox1.Items.Add("Meeting with: " + comboBox1.SelectedItem);
                listBox1.Items.Add("Meeting aim: " + button2.Text);
                resetfields();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        void resetfields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;

           // comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Please select one";

            //button2.ResetText();
            button2.Text = "meeting aim";

            //dateTimePicker1.ResetText();
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
