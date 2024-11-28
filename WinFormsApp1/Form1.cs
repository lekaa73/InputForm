namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox1.Enabled = checkBox1.Checked;
            button1.Enabled = checkBox1.Checked && comboBox1.SelectedIndex != -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Your data is Submitted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked && comboBox1.SelectedIndex != -1;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox2.Enabled = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox3.Enabled = checkBox4.Checked;
            if (checkBox4.Checked)
            {
                checkBox5.Enabled = false;
            }
            else
            {
                checkBox5.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox4.Enabled = checkBox6.Checked;
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox5.Enabled = checkBox7.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox4.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                checkBox4.Enabled = true;
                textBox3.Enabled = true;
            }
        }
    }
}
