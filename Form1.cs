using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProj_WrightJ
{
    public partial class Form1 : Form
    {

        Casualty casualty = new Casualty();


        public Form1()
        {
            InitializeComponent();

            groupBox1.Visible = false;
            SpotBreath.Visible = false;
            ReposAirway.Visible = false;
            RespRate.Visible = false;
            Perfusion.Visible = false;
            MentalStat.Visible = false;
            TriageCat.Visible = false;
            Refresh.Visible = false;

        }


        private void AddCas_Click(object sender, EventArgs e)
        {
            //To do: implement edge case if user doesnt enter any values for weight and age
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox10.Text))
            {
                MessageBox.Show("Please enter valid integer values for Casualty weight and age");
            }
            else
            {
                int weight;
                int age;

                if (!Int32.TryParse(textBox1.Text, out weight) || !Int32.TryParse(textBox10.Text, out age))
                {
                    MessageBox.Show("Please enter valid integer values for Casualty weight and age");
                }
                else if (weight >= 500)
                {
                    MessageBox.Show("Please enter reasonable values for Weight (< 500)");
                }
                else if (age >= 100)
                {
                    MessageBox.Show("Please enter reasonable values for Age (< 100)");
                }
                else
                {
                    casualty.Weight = weight;
                    casualty.Age = age;
                    listBox1.Items.Add("Weight: " + casualty.Weight);
                    listBox1.Items.Add("Age: " + casualty.Age);
                    textBox1.Clear();
                    textBox10.Clear();
                    groupBox1.Visible = true;
                    Refresh.Visible = true;
                }
            }

            if (radioButton1.Checked)
            {
                casualty.Gender = "Male";
                listBox1.Items.Add("Gender: " + casualty.Gender);
                radioButton1.Checked = false;
            }
            else if (radioButton2.Checked)
            {
                casualty.Gender = "Female";
                listBox1.Items.Add("Gender: " + casualty.Gender);
                radioButton2.Checked = false;

            }
            else
            {
                MessageBox.Show("Please select a Gender before adding.");
            }
            
            //switch (TriageCat.Text)
            //{
            //    case var text when text == textBox2.Text:
            //        casualty.Evac = "Evacuation is not advised";
            //        break;
            //    case var text when text == textBox3.Text:
            //        casualty.Evac = "Urgent";
            //        break;
            //    case var text when text == textBox4.Text:
            //        casualty.Evac = "Priority";
            //        break;
            //    case var text when text == textBox5.Text:
            //        casualty.Evac = "Routine";
            //        break;
            //    default:
            //        casualty.Evac = "Triage criteria has not been met.";
            //        break;
            //}
            //listBox1.Items.Add("Evacuation Category: " + casualty.Evac);


        }


        private void mobilityYes_Click(object sender, EventArgs e)
        {

            TriageCat.Text = textBox5.Text;
            TriageCat.Visible = true;
            TriageCat.BackColor = Color.PaleGreen;


        }

        private void MobilityNo_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            SpotBreath.Visible = true;

        }
        private void SpotBreathYes_Click(object sender, EventArgs e)
        {
            SpotBreath.Visible = false;
            RespRate.Visible = true;

        }


        private void SpotBreathNo_Click(object sender, EventArgs e)
        {
            SpotBreath.Visible = false;
            ReposAirway.Visible = true;

        }
        private void RepoAirwayYes_Click(object sender, EventArgs e)
        {

            TriageCat.Text = textBox3.Text;
            TriageCat.Visible = true;
            TriageCat.BackColor = Color.Red;
        }
        private void ReposAirwayNo_Click(object sender, EventArgs e)
        {
            TriageCat.Text = textBox2.Text;
            TriageCat.Visible = true;
            TriageCat.BackColor = Color.Silver;
        }

        private void RespR_Lt30_Click(object sender, EventArgs e)
        {
            RespRate.Visible = false;
            Perfusion.Visible = true;

        }

        private void RespR_Gt30_Click(object sender, EventArgs e)
        {
            TriageCat.Text = textBox3.Text;
            TriageCat.Visible = true;
            TriageCat.BackColor = Color.Red;
        }

        private void PerfusionYes_Click(object sender, EventArgs e)
        {
            Perfusion.Visible = false;
            MentalStat.Visible = true;

        }

        private void PerfusionNo_Click(object sender, EventArgs e)
        {
            TriageCat.Text = textBox3.Text;
            TriageCat.Visible = true;
            TriageCat.BackColor = Color.Red;
        }

        private void MentalStatYes_Click(object sender, EventArgs e)
        {
            TriageCat.Text = textBox4.Text;
            TriageCat.Visible = true;
            TriageCat.BackColor = Color.Yellow;
        }

        private void MentalStatNo_Click(object sender, EventArgs e)
        {
            TriageCat.Text = textBox3.Text;
            TriageCat.Visible = true;
            TriageCat.BackColor = Color.Red;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            SpotBreath.Visible = false;
            ReposAirway.Visible = false;
            RespRate.Visible = false;
            Perfusion.Visible = false;
            MentalStat.Visible = false;
            TriageCat.Visible = false;

        }

        private void clearListBt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //textBox1.Clear();
            //textBox10.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adds the Casualty information to grid and Assigns an Evacuation Category.");
        }

        private void AddEvac_Click(object sender, EventArgs e)
        {
            Casualty_RollUp form2 = new Casualty_RollUp();
            Data.userCasualties.Add(casualty);
            form2.Show();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(this.Location.X + 30, this.Location.Y + 463);



        }



        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            int result;
            if (!Int32.TryParse(textBox1.Text, out result))//validates the values for textbox1(weight) so that it informs user to enter an integer only
            {
                MessageBox.Show("Please enter a valid integer value for weight.");
                e.Cancel = true;//cancels event
                textBox1.Clear();//clear textbox so user can enter a valid entry


            }
        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            int result;
            if (!Int32.TryParse(textBox10.Text, out result))//validates the values for textbox1(weight) so that it informs user to enter an integer only
            {
                MessageBox.Show("Please enter a valid integer value for age.");
                textBox10.Clear();//clear textbox so user can enter a valid entry
                e.Cancel = true;//cancels event


            }
        }

        private void TriageCat_TextChanged(object sender, EventArgs e)
        {
            switch (TriageCat.Text)
            {
                case var text when text == textBox2.Text:
                    casualty.Evac = "Evacuation is not advised";
                    break;
                case var text when text == textBox3.Text:
                    casualty.Evac = "Urgent";
                    break;
                case var text when text == textBox4.Text:
                    casualty.Evac = "Priority";
                    break;
                case var text when text == textBox5.Text:
                    casualty.Evac = "Routine";
                    break;
                default:
                    casualty.Evac = "Triage criteria has not been met.";
                    break;
            }
            listBox1.Items.Add("Evacuation Category: " + casualty.Evac);
        }
    }
}
