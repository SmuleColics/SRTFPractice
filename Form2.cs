    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml.Linq;

    namespace SRTFPractice
    {
        public partial class Computations : Form
        {
            //NOTE: KAPAG SAME NG VALUE YUNG BURST TIME MAG DEDEPENDE SA ARRIVAL TIME
            //NOTE: NAKUHA NA LAHAT NG ARRIVAL TIME AT BURST TIME, NEED NA LANG YUNG LOGIC NG GANTT CHART
            //TODO: YUNG LOGIC NG GANTT CHART

            //Comment Code: Ctrl + K, Ctrl + C
            //Uncomment Code: Ctrl + K, Ctrl + U
            public Computations()
            {
                InitializeComponent();
            }

            int[] listBTIndex = new int[4];
            int[] listBTValue = new int[4];

            private void Computations_Load(object sender, EventArgs e)
            {

                newArrivalTime = new List<int>(SRTFMain.ArrivalTime);

                 DataTable dt = new DataTable();
                //Process ID
                for (int i = 1; i <= 4; i++) 
                {
                    lbProcessID.Items.Add($"P{i}");
                }
                //Arrival Time
                foreach (int AT in SRTFMain.ArrivalTime)
                {
                    lbArrivalTime.Items.Add(AT);
                }
                //Burst Time
                foreach (int BT in SRTFMain.BurstTime)
                {
                    lbBurstTime.Items.Add(BT);
                }
                //Waiting Time

                //Formula of Waiting Time: WT = Total WT - No. MS Process Executed - AT


                //kukunin ko muna burst time ng lahat
                int smallest = GetLowest();
                listBTIndex[0] = GetBurstTime(smallest);
                MessageBox.Show("Smallest BT: " + SRTFMain.BurstTime[listBTIndex[0]]);

                int secondSmallest = GetLowest();
                listBTIndex[1] = GetBurstTime(secondSmallest);
                MessageBox.Show("2nd Smallest BT: " + SRTFMain.BurstTime[listBTIndex[1]]);

                int thirdSmallest = GetLowest();
                listBTIndex[2] = GetBurstTime(thirdSmallest);
                MessageBox.Show("3rd Smallest BT: " + SRTFMain.BurstTime[listBTIndex[2]]);

                int highest = GetLowest();
                listBTIndex[3] = GetBurstTime(highest);
                MessageBox.Show("Highest BT: " + SRTFMain.BurstTime[listBTIndex[3]]);

                //dt.Columns.Add(smallest.ToString(), typeof(int));

                //if (SRTFMain.BurstTime[currentBurstTimeIndex] >= secondSmallest)
                //{
                //    dt.Columns.Add(secondSmallest.ToString(), typeof(int));
                //    SRTFMain.BurstTime[currentBurstTimeIndex] -= secondSmallest;
                //} else
                //{
                //    //not sure pa rito
                //    dt.Columns.Add(SRTFMain.BurstTime[currentBurstTimeIndex].ToString(), typeof(int));
                //}

                //MessageBox.Show("Burst Time: " + SRTFMain.BurstTime[currentBurstTimeIndex]);

                //dt.Columns.Add(secondSmallest.ToString(), typeof(int));
                //dt.Columns.Add(thirdSmallest.ToString(), typeof(int));
                //dt.Columns.Add(highest.ToString(), typeof(int));

                //TODO: dapat malaman yung index ng smallest to highest sa original na List na Arrival Time

                dgvGanttChart.DataSource = dt;

                // Automatically resize the columns to fit content
                //dgvGanttChart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Remove unnecessary row headers
                dgvGanttChart.RowHeadersVisible = false;
            }

            public static List<int> newArrivalTime;

            //get lowest index ng pinakamaliit na burst time
            public int GetLowest()
            {
                int smallest = newArrivalTime[0];

                for (int i = 1; i < newArrivalTime.Count; i++)
                {
                    if (newArrivalTime[i] < smallest)
                    {
                        smallest = newArrivalTime[i];
                    }
              
                }
 
                newArrivalTime.Remove(smallest);

                return smallest;
            }

            public int GetBurstTime(int AT)
            {
                int currentBurstTimeIndex = 0;

                for (int j = 0; j < SRTFMain.ArrivalTime.Count; j++)
                {
                    if (AT == SRTFMain.ArrivalTime[j])
                    {
                        currentBurstTimeIndex = j;
                        break;
                    }
                }

                return currentBurstTimeIndex;   
            }

            public void compareDuplicateBT()
            {
                int num;

                for (int i = 0; i < listBTIndex.Length; i++)
                {
                    num = SRTFMain.BurstTime[listBTIndex[i]];

                    if (listBTIndex[i].Equals(num))
                    {
                        
                    }
                }
            }

        }

    }
