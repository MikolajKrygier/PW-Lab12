namespace PW_Lab_12
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            

           if(numericUpDown1.Value > 0 ) 
           {
                Form2.form2Instance.label1.Text = "Dla wartoœci 2: ";

                for(int i=0; i<numericUpDown1.Value; i++) 
                {
                    Random r = new Random();
                    int rInt = r.Next(1, 3);
                    Form2.form2Instance.label1.Text += rInt.ToString() +", ";
                }
           }
            if (numericUpDown2.Value > 0)
            {
                Form2.form2Instance.label1.Text += "\nDla wartoœci 4: ";

                for (int i = 0; i < numericUpDown2.Value; i++)
                {
                    Random r = new Random();
                    int rInt = r.Next(1, 5);
                    Form2.form2Instance.label1.Text += rInt.ToString() + ", ";
                }
            }
            if (numericUpDown3.Value > 0)
            {
                Form2.form2Instance.label1.Text += "\nDla wartoœci 6: ";

                for (int i = 0; i < numericUpDown3.Value; i++)
                {
                    Random r = new Random();
                    int rInt = r.Next(1, 7);
                    Form2.form2Instance.label1.Text += rInt.ToString() + ", ";
                }
            }
            if (numericUpDown4.Value > 0)
            {
                Form2.form2Instance.label1.Text += "\nDla wartoœci 8: ";

                for (int i = 0; i < numericUpDown4.Value; i++)
                {
                    Random r = new Random();
                    int rInt = r.Next(1, 9);
                    Form2.form2Instance.label1.Text += rInt.ToString() + ", ";
                }
            }
            if (numericUpDown5.Value > 0)
            {
                Form2.form2Instance.label1.Text += "\nDla wartoœci 10: ";

                for (int i = 0; i < numericUpDown5.Value; i++)
                {
                    Random r = new Random();
                    int rInt = r.Next(1, 11);
                    Form2.form2Instance.label1.Text += rInt.ToString() + ", ";
                }
            }
            if (numericUpDown6.Value > 0)
            {
                Form2.form2Instance.label1.Text += "\nDla wartoœci 12: ";

                for (int i = 0; i < numericUpDown6.Value; i++)
                {
                    Random r = new Random();
                    int rInt = r.Next(1, 13);
                    Form2.form2Instance.label1.Text += rInt.ToString() + ", ";
                }
            }
            if (numericUpDown7.Value > 0)
            {
                Form2.form2Instance.label1.Text += "\nDla wartoœci 20: ";

                for (int i = 0; i < numericUpDown7.Value; i++)
                {
                    Random r = new Random();
                    int rInt = r.Next(1, 21);
                    Form2.form2Instance.label1.Text += rInt.ToString() + ", ";
                }
            }
            if (numericUpDown8.Value > 0)
            {
                Form2.form2Instance.label1.Text += "\nDla wartoœci 100: ";

                for (int i = 0; i < numericUpDown8.Value; i++)
                {
                    Random r = new Random();
                    int rInt = r.Next(1, 101);
                    Form2.form2Instance.label1.Text += rInt.ToString() + ", ";
                }
            }

            f2.ShowDialog();
        }
    }
}