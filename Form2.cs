using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SRTFPractice
{
    public partial class Computations : Form
    {
        //Comment Code: Ctrl + K, Ctrl + C
        //Uncomment Code: Ctrl + K, Ctrl + U

        public static List<int> listAT;
        public static List<int> listBT;

        public static List<string> listProcessID = new List<string>();
        public static List<string> processID = new List<string>();

        //No.Of Ms Process Executed
        public static List<int> listNMPE = new List<int>();
        public static List<int> TotalWT = new List<int>();
        public Computations()
        {
            InitializeComponent();
        }

        private void Computations_Load(object sender, EventArgs e)
        {
            listAT = new List<int>(SRTFMain.ArrivalTime);
            listBT = new List<int>(SRTFMain.BurstTime);

            getProcessID();
            showInputs();

            getLowestToHighest();

            debug();

            showGanttChart();
        }

        public void getProcessID()
        {
            for (int i = 0; i < listAT.Count; i++)
            {
                listProcessID.Add("P" + (i + 1));
            }
        }

        //i-a-arrange yung Arrival Time in ascending order
        //kase yung lowest AT yung unang pinaprocess
        public void getLowestToHighest()
        {
            // Sorting listAT with consideration of listBT
            for (int i = 0; i < listAT.Count; i++)
            {
                for (int j = i + 1; j < listAT.Count; j++)
                {
                    // Compare arrival times
                    if (listAT[i] > listAT[j] ||
                       (listAT[i] == listAT[j] && listBT[i] > listBT[j]))
                    {
                        // Swap listAT
                        int tempAT = listAT[i];
                        listAT[i] = listAT[j];
                        listAT[j] = tempAT;

                        // Swap corresponding listBT
                        int tempBT = listBT[i];
                        listBT[i] = listBT[j];
                        listBT[j] = tempBT;

                        // Swap corresponding listProcessID
                        string tempPID = listProcessID[i];
                        listProcessID[i] = listProcessID[j];
                        listProcessID[j] = tempPID;
                    }
                }
            }
 
        }
    

        public void showInputs()
        {
            for (int i = 1; i <= 4; i++)
            {
                lbProcessID.Items.Add("P" + i);
            }
            foreach (int AT in listAT)
            {
                lbArrivalTime.Items.Add(AT);
            }
            foreach (int BT in listBT)
            {
                lbBurstTime.Items.Add(BT);
            }

        }

        public void debug()
        {
            foreach (int AT in listAT)
            {
                lbDebugAT.Items.Add(AT.ToString());
            }

            foreach (int BT in listBT)
            {
                lbDebugBT.Items.Add(BT.ToString());
            }
        }

        public static List<int> ganttChart = new List<int>();


        public void showGanttChart()
        {
            bool continueRun = true;

            if (listAT[0] == 0)
            {
                int difOne = 0, difTwo = 0, difThree = 0;
                int[] maxGC = new int[8];

                ganttChart.Add(0);
                processID.Add(listProcessID[0]);

                if (listBT[0] > listAT[1])
                {
                    difOne = listAT[1] - listAT[0];
                    listBT[0] -= difOne;

                    maxGC[0] = difOne - 0;
                    ganttChart.Add(maxGC[0]);
                    processID.Add(listProcessID[1]);

                    listNMPE.Add(1);

                }
                else if (listAT[0] + listBT[0] == listAT[1])
                {
                   
                    maxGC[0] = listAT[0] + listBT[0];
                    ganttChart.Add(maxGC[0]);
                    processID.Add(listProcessID[1]);


                }

                if (listBT[1] > listAT[2])
                {
                    difTwo = listAT[2] - listAT[1];
                    listBT[1] -= difTwo;

                    maxGC[1] = difOne + difTwo;
                    ganttChart.Add(maxGC[1]);

                    processID.Add(listProcessID[2]);
                    listNMPE.Add(1);

                }
                else if (listAT[1] + listBT[1] == listAT[2])
                {
                    maxGC[1] = listAT[1] + listBT[1];

                    ganttChart.Add(maxGC[1]);

                    processID.Add(listProcessID[2]);
                }

                if (listBT[2] > listAT[3])
                {
                    difThree = listAT[3] - listAT[2];
                    listBT[2] -= difThree;

                    maxGC[2] = difOne + difTwo + difThree;
                    ganttChart.Add(maxGC[2]);

                    processID.Add(listProcessID[3]);

                    listNMPE.Add(1);
                }
                else if (listAT[2] + listBT[2] == listAT[3])
                {
                    maxGC[2] = listAT[2] + listBT[2];
                    ganttChart.Add(maxGC[2]);
                    processID.Add(listProcessID[3]);


                    maxGC[3] = listAT[3] + listBT[3];
                    ganttChart.Add(maxGC[3]);

       

                    continueRun = false;
                }

                if (continueRun)
                {

                    if (!(listBT[3] >= listBT[2]
                            && listBT[3] >= listBT[1]
                            && listBT[3] >= listBT[0]))
                    {
                        listBT[3] -= 1;

                        maxGC[3] += maxGC[2] + 1;
                        ganttChart.Add(maxGC[3]);

                        listNMPE.Add(1);

                    }

                    sortBurstTime();

                    for (int i = 0; i < 4; i++)
                    {
                        maxGC[4 + i] += maxGC[3 + i] + listBT[i];
                        ganttChart.Add(maxGC[4 + i]);

                        processID.Add(listProcessID[i]);
                  
                    }

                    getWaitingTime();
                }

                DataTable dt = new DataTable();

                foreach (int gc in ganttChart)
                {
                    dt.Columns.Add(gc.ToString(), typeof(String));
                }

                dt.Rows.Add(processID.ToArray());

                dgvGanttChart.DataSource = dt;

                dgvGanttChart.RowHeadersVisible = false;
                dgvGanttChart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvGanttChart.AllowUserToResizeColumns = true;

                // Align all cells in the rightmost side (right-align text in columns)
                foreach (DataGridViewColumn column in dgvGanttChart.Columns)
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                ganttChart.Clear();
                listProcessID.Clear();
                processID.Clear();
            }
        }

        public void sortBurstTime()
        {
            for (int i = 0; i < listBT.Count; i++)
            {
                for (int j = i + 1; j < listBT.Count; j++)
                {
                    // Compare burst times
                    if (listBT[i] > listBT[j]
                            || (listBT[i] == listBT[j] && listAT[i] > listAT[j]))
                    {
                        // Swap listBT
                        int tempBT = listBT[i];
                        listBT[i] = listBT[j];
                        listBT[j] = tempBT;

                        // Swap corresponding listAT
                        int tempAT = listAT[i];
                        listAT[i] = listAT[j];
                        listAT[j] = tempAT;

                        string tempPID = listProcessID[i];
                        listProcessID[i] = listProcessID[j];
                        listProcessID[j] = tempPID;
                    }
                }
            }
        }

        public void getWaitingTime()
        {
            for (int i = 0; i < processID.Count; i++)
            {
                for (int j = i + 1; j < processID.Count; j++)
                {
                    if (processID[i] == processID[j])
                    {
                        lbWaitingTime.Items.Add(ganttChart[j]);
                        break; // Break the inner loop once a duplicate is found
                    }
                }
            }
        }
        
        //if P1 is equals sa lbngprocess ID
    }
}
