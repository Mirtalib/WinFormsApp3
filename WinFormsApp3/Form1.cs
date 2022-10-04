namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        double OilPrice = 0;
        double OilAmount = 0;
        double MiniMrPrice = 0;
        double MiniMrAmount = 0;
        double temp = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void PriceCalculation(TextBox textBoxAmount , TextBox textBoxPrice)
        {
            MiniMrAmount = Convert.ToDouble(textBoxAmount.Text);
            if (!string.IsNullOrEmpty(textBoxPrice.Text))
            {
                try
                {
                    temp = 0;
                    MiniMrPrice = Convert.ToDouble(textBoxPrice.Text);
                    temp = Convert.ToDouble(label1.Text);
                    temp += (MiniMrAmount * MiniMrPrice);
                    label1.Text = temp.ToString();
                }
                catch (Exception ex)
                {
                    textBoxPrice.Text = string.Empty;
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "A-92")
            {
                textBox3.Text = "1.0";
            }
            else if (comboBox1.SelectedItem.ToString() == "A-95")
            {
                textBox3.Text = "1.7";
            }
            else if (comboBox1.SelectedItem.ToString() == "A-98")
            {
                textBox3.Text = "2.5";
            }
            else if (comboBox1.SelectedItem.ToString() == "Dizel")
            {
                textBox3.Text = "0.8";
            }
            OilPrice = Convert.ToDouble(textBox3.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.ReadOnly = false;
            }
            else
            {
                textBox1.ReadOnly = true;
                textBox1.Text = string.Empty;
                textBox3.Text = string.Empty;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox2.ReadOnly = false;
            }
            else
            {
                textBox2.ReadOnly = true;
                textBox2.Text = string.Empty;
                label4.Text = string.Empty;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    if (OilPrice == 0)
                    {
                        textBox1.Text = string.Empty;
                        MessageBox.Show("Enter Type Oil");
                    }
                    else
                    {
                        OilAmount = Convert.ToDouble(textBox1.Text);
                        label4.Text = (OilAmount* OilPrice).ToString();
                    }
                }
                catch (Exception ex)
                {
                    textBox1.Text = string.Empty;
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                try
                {
                    if (OilPrice == 0)
                    {
                        textBox2.Text = string.Empty;
                        MessageBox.Show("Enter Type Oil");
                    }
                    else
                    {
                        OilAmount = Convert.ToDouble(textBox2.Text);
                        label4.Text = OilAmount.ToString();
                    }
                }
                catch (Exception ex)
                {
                    textBox2.Text = string.Empty;
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox61.Enabled = true;
            }
            else
            {
                textBox61.Enabled = false;
                textBox61.Text = string.Empty;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox62.Enabled = true;
            }
            else
            {
                textBox62.Enabled = false;
                textBox62.Text = string.Empty;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox64.Enabled = true;
            }
            else
            {
                textBox64.Enabled = false;
                textBox64.Text = string.Empty;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox63.Enabled = true;
            }
            else
            {
                textBox63.Enabled = false;
                textBox63.Text = string.Empty;
            }
        }


        private void textBox62_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            PriceCalculation(textBox10, textBox61);
            PriceCalculation(textBox8, textBox62);
            PriceCalculation(textBox4, textBox63);
            PriceCalculation(textBox5, textBox64);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(label4.Text);
            double s1 = Convert.ToDouble(label1.Text);

            label7.Text =  (s1+s).ToString();
        }
    }
}