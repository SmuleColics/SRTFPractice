using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SRTFPractice
{
    public partial class SRTFMain : Form
    {
        public SRTFMain()
        {
            InitializeComponent();  
        }

        //TODO: 

        //gawing 'public static' para ma access sa ibang form
        public static List<int> ArrivalTime = new List<int>();
        public static List<int> BurstTime = new List<int>();

        public bool addAT = false;

        private void btnEnterATBT_Click(object sender, EventArgs e)
        {
            int AT = 0, BT = 0;
            bool continueATBT = true;

            if (ChecksMaxInput()) continueATBT = false;

            try
            {
                if (continueATBT)
                {
                    //ano kaya magiging limit ng AT at BT
                    if (ChecksNullorWhiteSpace(tbArrivalTime.Text, "Arrival Time")) continueATBT = false;
                    if (ChecksNullorWhiteSpace(tbBurstTime.Text, "Burst Time")) continueATBT = false;

                    if (continueATBT)
                    {
                        AT = Convert.ToInt32(tbArrivalTime.Text);

                        if (AT >= 0)
                        {
                            //che-check kung may duplicate sa arrival time
                            if (ChecksATDuplicate(AT)) return;
                        }
                        else
                        {
                            MessageBox.Show("Arrival Time must be greater than or equal to 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //di ko sure kung ang minimum ba dapat ng BT ay 1
                        BT = Convert.ToInt32(tbBurstTime.Text);

                        if (BT >= 1 && addAT)
                        {
                            BurstTime.Add(BT);
                            lbBurstTime.Items.Add(BT);
                            tbBurstTime.Clear();

                            //pag add ng Arrival Time
                            ArrivalTime.Add(AT);
                            tbArrivalTime.Clear();
                            lbArrivalTime.Items.Add(AT);
                        }
                        else
                        {
                            MessageBox.Show("Burst Time must be greater than or equal to 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continueATBT = false;
                        }

                    }
                }
               
            }
            catch (FormatException) {

                MessageBox.Show("Invalid Input. Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool ChecksNullorWhiteSpace(string input, string ATorBT)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show($"{ATorBT} cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public bool ChecksATDuplicate(int AT)
        {
            for (int i = 0; i < ArrivalTime.Count; i++)
            {
                if (ArrivalTime[i].Equals(AT))
                {
                    MessageBox.Show("Duplicate Arrival Time","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }

            addAT = true;
            return false;
        }

        public bool ChecksMaxInput()
        {
            if (ArrivalTime.Count == 4 && BurstTime.Count == 4)
            {
                MessageBox.Show("4 is the max input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbArrivalTime.Clear();
                tbBurstTime.Clear();
                return true;
            }
           return false ;
           
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            Computations computations = new Computations();

            if (ArrivalTime.Count == 4 && BurstTime.Count == 4)
            {
                MessageBox.Show("Compute", "Computation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //magbubukas ng bagong form to get the computation
                //this.Hide(); pang hide ng form
                Computations.newArrivalTime = new List<int>(SRTFMain.ArrivalTime);

                computations.ShowDialog();
                clearAll();
            }
            else
            {
                MessageBox.Show("Both Input must be 4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult resetAnswer = MessageBox.Show("Are you sure you want to reset? ", "Reset Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resetAnswer == DialogResult.Yes)
            {
                clearAll();
            }


        }

        public void clearAll()
        {
            //tatanggalin lahat ng value sa listbox
            lbBurstTime.Items.Clear();
            lbArrivalTime.Items.Clear();
            //tatanggalin lahat ng value ng list
            ArrivalTime.Clear();
            BurstTime.Clear();
            //tatanggalin value sa textfield
            tbArrivalTime.Clear();
            tbBurstTime.Clear();
            Computations.newArrivalTime.Clear();
        }
    } 
}
