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

        //process ID ng unang apat 
        public static List<string> listProcessID = new List<string>();

        //process ID ng gantt Chart
        public static List<string> processID = new List<string>();

        //No.Of Ms Process Executed
        public static List<int> listNMPE = new List<int>();
        public static List<int> TotalWT = new List<int>();

        //duplicate ng listAT na sort base sa BT
        public static List<int> duplicateListAT = new List<int>();
        public static List<string> duplicateProcessID = new List<string>();

        public Computations()
        {
            InitializeComponent();
        }

        private void Computations_Load(object sender, EventArgs e)
        {
            listAT = new List<int>(SRTFMain.ArrivalTime);
            listBT = new List<int>(SRTFMain.BurstTime);

            label1.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            lblAveWT.BackColor = Color.Transparent;

            getProcessID();
            showInputs();

            getLowestToHighest();

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
        int[] sortedIndices = new int[4];

        public void getLowestToHighest()
        {
            for (int i = 0; i < listAT.Count; i++)
            {
                sortedIndices[i] = i;  // Store the original indices before sorting
            }

            // Simple approach to sort based on arrival times first, then burst times
            for (int i = 0; i < listAT.Count; i++)
            {
                int minIndex = i;

                // Find the smallest arrival time, or if equal, the smallest burst time
                for (int j = i + 1; j < listAT.Count; j++)
                {
                    if (listAT[j] < listAT[minIndex] || (listAT[j] == listAT[minIndex] && listBT[j] < listBT[minIndex]))
                    {
                        minIndex = j;
                    }
                }

                // Swap listAT, listBT, listProcessID, and sortedIndices based on the minimum index found
                int tempAT = listAT[i];
                listAT[i] = listAT[minIndex];
                listAT[minIndex] = tempAT;

                int tempBT = listBT[i];
                listBT[i] = listBT[minIndex];
                listBT[minIndex] = tempBT;

                string tempPID = listProcessID[i];
                listProcessID[i] = listProcessID[minIndex];
                listProcessID[minIndex] = tempPID;

                // Swap the original indices in sortedIndices to keep track of where they came from
                int tempIndex = sortedIndices[i];
                sortedIndices[i] = sortedIndices[minIndex];
                sortedIndices[minIndex] = tempIndex;
            }


            foreach (int AT in listAT)
            {
                duplicateListAT.Add(AT);
            }

            foreach (string PID in listProcessID)
            {
                duplicateProcessID.Add(PID);
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


        public static List<int> ganttChart = new List<int>();
        static int remainingInGC = 4;

        public void showGanttChart()
        {
            bool continueRun = true;


            int difOne = 0, difTwo = 0, difThree = 0;
            int[] maxGC = new int[8];

            ganttChart.Add(listAT[0]);
            processID.Add(listProcessID[0]);

            if (listAT[0] + listBT[0] == listAT[1])
            {
                difOne = listAT[1] - listAT[0];

                maxGC[0] = listAT[0] + listBT[0];
                ganttChart.Add(maxGC[0]);
                processID.Add(listProcessID[1]);

                listNMPE.Add(0);

                listWT.Add(ganttChart[1]);
                pID1.Add(processID[0]);
            }
            else
            {


                difOne = listAT[1] - listAT[0];
                listBT[0] -= difOne;

                maxGC[0] = difOne - 0;
                ganttChart.Add(maxGC[0]);
                processID.Add(listProcessID[1]);

                listNMPE.Add(1);

            }

            if (listAT[1] + listBT[1] == listAT[2])
            {
                difTwo = listAT[2] - listAT[1];
                maxGC[1] = listAT[1] + listBT[1];

                ganttChart.Add(maxGC[1]);

                processID.Add(listProcessID[2]);

                listNMPE.Add(0);

                listWT.Add(ganttChart[2]);
                pID1.Add(processID[1]);
            }
            else
            {


                difTwo = listAT[2] - listAT[1];
                listBT[1] -= difTwo;

                maxGC[1] = difOne + difTwo;
                ganttChart.Add(maxGC[1]);

                processID.Add(listProcessID[2]);
                listNMPE.Add(1);

            }

            if (listAT[2] + listBT[2] == listAT[3])
            {
                maxGC[2] = listAT[2] + listBT[2];
                ganttChart.Add(maxGC[2]);
                processID.Add(listProcessID[3]);
                listNMPE.Add(0);

                listWT.Add(ganttChart[3]);
                pID1.Add(processID[2]);

                maxGC[3] = listAT[3] + listBT[3];
                ganttChart.Add(maxGC[3]);
                listNMPE.Add(0);

                listWT.Add(ganttChart[4]);
                pID1.Add(processID[3]);

                continueRun = false;
            }
            else
            {

                difThree = listAT[3] - listAT[2];
                listBT[2] -= difThree;

                maxGC[2] = difOne + difTwo + difThree;
                ganttChart.Add(maxGC[2]);

                processID.Add(listProcessID[3]);

                listNMPE.Add(1);

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
            }


            getWaitingTime();

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

            // Align all cells in middleCenter
            foreach (DataGridViewColumn column in dgvGanttChart.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            ganttChart.Clear();
            listProcessID.Clear();
            processID.Clear();
            listNMPE.Clear();
            TotalWT.Clear();
            listWT.Clear();

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

        public static List<int> listWT = new List<int>();
        public static List<string> pID1 = new List<string>();

        int[] sortedWT = new int[4];


        public void getWaitingTime()
        {
            double sumOfWT = 0;
            int[] totalWT = new int[4];


            // Find duplicates and add them to TotalWTValue and duplicatePID
            for (int i = 0; i < processID.Count; i++)
            {
                for (int j = i + 1; j < processID.Count; j++)
                {
                    if (processID[i] == processID[j])
                    {
                        listWT.Add(ganttChart[j]);
                        pID1.Add(processID[j]);
                    }

                }

            }

            //dapat ang makuha ko is yung index ng Arrival time 
            //since hindi palaging 0-3 ang input
            for (int i = 0; i < 4; i++)
            {
                sortedWT[i] = listWT[sortedIndices[i]];

                totalWT[i] = ((sortedWT[i] - listNMPE[i]) - SRTFMain.ArrivalTime[i]);
                sumOfWT += totalWT[i];
                lbWaitingTime.Items.Add(totalWT[i]);
            }

            double aveWT = sumOfWT / 4;
            lblAveWT.Text = aveWT.ToString();

        }


    }
}

