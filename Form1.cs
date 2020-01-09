using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace project
{
    public partial class Form1 : Form
    {

   
        public Form1()
        {
            InitializeComponent();

        }

      


        public static int[,] toshow = new int[4, 4];
        public static void square(int[,] array)
        {
           
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                   
                    toshow[i, j] = array[i, j];
                }

            }
        }

        public static int count = toshow.Length;

       

        public static System.Windows.Forms.TextBox[] txtarray;

        public static Label mylab;
       

        private void button1_Click(object sender, EventArgs e)
        {
           
            int i, j;
            int l = 0;
            txtarray = new System.Windows.Forms.TextBox[16];
            if (toshow[0, 0] != 0)
            {
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        txtarray[l] = new System.Windows.Forms.TextBox();
                        txtarray[l].Width = 50 + 60;
                        txtarray[l].Height = 50 + 20;

                        if (toshow[i, j] == 1)
                        {
                            int x = 1;
                            string y = x.ToString();
                            txtarray[l].BackColor = Color.DarkMagenta;
                            txtarray[l].Text = y;
                            txtarray[l].TextAlign = HorizontalAlignment.Center;
                            txtarray[l].Font = new Font(txtarray[l].Font.FontFamily, 14);
                            txtarray[l].ForeColor = Color.Azure;
                          
                        }

                        else if (toshow[i, j] == 2)
                        {
                            int x = 2;
                            string y = x.ToString();
                            txtarray[l].BackColor = Color.DarkGray;
                            txtarray[l].Text = y;
                            txtarray[l].TextAlign = HorizontalAlignment.Center;
                            txtarray[l].Font = new Font(txtarray[l].Font.FontFamily, 14);
                            txtarray[l].ForeColor = Color.Azure;
                        
                        }

                        else if (toshow[i, j] == 3)
                        {
                            int x = 3;
                            string y = x.ToString();
                            txtarray[l].BackColor = Color.BlueViolet;
                            txtarray[l].Text = y;
                            txtarray[l].TextAlign = HorizontalAlignment.Center;
                            txtarray[l].Font = new Font(txtarray[l].Font.FontFamily, 14);
                            txtarray[l].ForeColor = Color.Azure;
                            
                        }

                        else if (toshow[i, j] == 4)
                        {
                            int x = 4;
                            string y = x.ToString();
                            txtarray[l].BackColor = Color.Aquamarine;
                            txtarray[l].Text = y;
                            txtarray[l].TextAlign = HorizontalAlignment.Center;
                            txtarray[l].Font = new Font(txtarray[l].Font.FontFamily, 14);
                            txtarray[l].ForeColor = Color.Azure;
                           
                        }

                        else
                        {
                            int x = 5;
                            string y = x.ToString();
                            txtarray[l].BackColor = Color.DodgerBlue;
                            txtarray[l].Text = y;
                            txtarray[l].TextAlign = HorizontalAlignment.Center;
                            txtarray[l].Font = new Font(txtarray[l].Font.FontFamily, 14);
                            txtarray[l].ForeColor = Color.Azure;
                            
                        }



                        //txtarray[l].Margin = new Thickness(20);
                        l++;
                    }
                }

                txtarray[0].Location = new Point(110, 50);
                txtarray[1].Location = new Point(220, 50);
                txtarray[2].Location = new Point(330, 50);
                txtarray[3].Location = new Point(440, 50);
                txtarray[4].Location = new Point(110, 100);
                txtarray[5].Location = new Point(220, 100);
                txtarray[6].Location = new Point(330, 100);
                txtarray[7].Location = new Point(440, 100);
                txtarray[8].Location = new Point(110, 150);
                txtarray[9].Location = new Point(220, 150);
                txtarray[10].Location = new Point(330, 150);
                txtarray[11].Location = new Point(440, 150);
                txtarray[12].Location = new Point(110, 200);
                txtarray[13].Location = new Point(220, 200);
                txtarray[14].Location = new Point(330, 200);
                txtarray[15].Location = new Point(440, 200);
                this.Controls.Add(txtarray[0]);
                this.Controls.Add(txtarray[1]);
                this.Controls.Add(txtarray[2]);
                this.Controls.Add(txtarray[3]);
                this.Controls.Add(txtarray[4]);
                this.Controls.Add(txtarray[5]);
                this.Controls.Add(txtarray[6]);
                this.Controls.Add(txtarray[7]);
                this.Controls.Add(txtarray[8]);
                this.Controls.Add(txtarray[9]);
                this.Controls.Add(txtarray[10]);
                this.Controls.Add(txtarray[11]);
                this.Controls.Add(txtarray[12]);
                this.Controls.Add(txtarray[13]);
                this.Controls.Add(txtarray[14]);
                this.Controls.Add(txtarray[15]);
            }

            else
            {
                mylab = new Label();
                mylab.Text = "Sorry No Solution found";
                mylab.AutoSize = true;
                mylab.Font = new Font("Cambria", 18);
                mylab.ForeColor = Color.Gold;
                mylab.Padding = new Padding(6);
                mylab.Location = new Point(60, 50);
                mylab.BackColor = Color.AliceBlue;
                this.Controls.Add(mylab);
            }
        }

       
    }
}
