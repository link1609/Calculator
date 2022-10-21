namespace Calculator
{
    public partial class Form1 : Form
    {
        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
        public Form1()
        {
            InitializeComponent();
            txtScreen.Text = "0";
        }
       

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "3";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "3";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "2";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "2";
            }

        }
        private void btnminus_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "-";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "-";
            }
          
        }

        private void txtScreen_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "0";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "1";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "1";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "4";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "4";
            }
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0" )
            {
                txtScreen.Text = "5";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "5";
            }
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "6";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "7";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "7";
            }
          
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "8";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "9";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "9";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null)
            {
                txtScreen.Text = "0";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "+";
            }
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "0";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "*";
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "0";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "/";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "0";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + ")";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "0";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "(";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "0";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "%";
            }
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == null || txtScreen.Text == "0")
            {
                txtScreen.Text = "0";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + ".";
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double ans = Evaluate(txtScreen.Text);
            txtScreen.Text = ans.ToString();
        }
    }
}