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

        //naka public static para ma-access siya ng ibang form na hindi kailangan i-initialize
        //SRTFMain file name neto
        //ang tinutukoy ko sa initialize, alam niyo naman diba yung sa OOP na
        //SubClass s = new SubClass(); - kapag may "static" kase hindi mo na need yang ganyan
        //pwede mo na agad makuha sa ibang form yung mga VARIABLE at METHODS

        //Etong LIST, para lang siyang ARRAY
        //ang equivalent neto sa array (int[] ArrivalTime = new int[4]; )
        //sa ARRAY need mo pa mag set kung ilan pwede mong ilagay, sa LIST kahit ilan

        public static List<int> ArrivalTime = new List<int>();
        public static List<int> BurstTime = new List<int>();

        bool maxInput = false;

        //method kapag pinindot ang ENTER BUTTON
        //p.s. AT = Arrival Time, BT = Burst Time 
        private void btnEnterATBT_Click(object sender, EventArgs e)
        {
            int AT = 0, BT = 0;
            bool addAT = false, addBT = false;

            //tatawagin yung method 
            //bali tignan niyo yung buong code sa method na to
            ChecksMaxInput();

            //kapag daw naka false ang maxInput na boolean mag-r-run lahat ng nasa block of codes neto
            if (!maxInput)
            {
                //same process lang to sa pagkuha ng BT kaya etong part na lang basahin niyo
                //ang pinagkaiba nila, 0 ang minimum ng AT
                //while 1 ang minimum ng BT
                try
                {
                    //ipapasa yung value ng TextBoxtAT sa variable na AT
                    //Convert.ToInt32, since String ang value na nakukuha sa textbox
                    //yung Convert.ToInt32 is yung nagcoconvert ng String into int
                    AT = Convert.ToInt32(tbArrivalTime.Text);

                    //kapag daw ang ininput sa AT ay greater than or equal to 0
                    if (AT >= 0)
                    {
                        //yung addAT na boolean mag t-true
                        addAT = true;
                    }
                    else
                    {
                        //kapag hindi, mag po-pop up tong error message
                        MessageBox.Show("Arrival Time Must Be Greater than or equal to 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    //kapag WALANG LAMAN or LETTER ang ininput sa AT
                    //catch (Exception) - ibig sabihin huhulihin niya yung mga WALANG LAMAN or LETTER
                    //then may lalabas na message box na "Invalid Arrival Time"
                    MessageBox.Show("Invalid Arrival Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {

                    BT = Convert.ToInt32(tbBurstTime.Text);

                    if (BT >= 1)
                    {
                        addBT = true;
                    }
                    else
                    {
                        MessageBox.Show("Burst Time Must Be Greater than or equal to 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Burst Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //kapag nag true ang value ng addAT at addBT
                if (addAT && addBT)
                {
                    //i-a-add na sa LIST yung value 
                    ArrivalTime.Add(AT);
                    BurstTime.Add(BT);
                    //saka sa LISTBOX
                    lbArrivalTime.Items.Add(AT);
                    lbBurstTime.Items.Add(BT);
                    //tapos i-c-clear yung text sa 2 na textbox
                    tbArrivalTime.Clear();
                    tbBurstTime.Clear();
                }
            }

        }


        //method na pang check kung ilan maximum na 
        public void ChecksMaxInput()
        {
            //kapag daw ba ang laman ng LIST na AT at BT ay equals sa 4
            if (ArrivalTime.Count == 4 && BurstTime.Count == 4)
            {
                //yung maxInput mag-t-true
                maxInput = true;
                MessageBox.Show("4 is the max input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //then i-c-clear yung text sa textbox
                tbArrivalTime.Clear();
                tbBurstTime.Clear();
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            //iinitialize yung form2 parang sa OOP
            Computations computations = new Computations();

            // kapag daw 4 na yung laman ng AT at BT
            if (ArrivalTime.Count == 4 && BurstTime.Count == 4)
            {
                MessageBox.Show("Computations", "Compute", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //magbubukas yung form 2
                computations.ShowDialog();

                //tatawagin yung method na clearAll na method
                clearAll();
            }
            else
            {
                MessageBox.Show("Both Input must be 4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //may lalabas na pop up message
            //yung sagot ilalagay sa 'resetAnswer' 
            DialogResult resetAnswer = MessageBox.Show("Are you sure you want to reset? ", "Reset Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //kapag daw yung sagot is YES ma c-clear lahat ng 
            //BT at AT sa LISTBOX, AT at BT na LIST, saka yung dalawang textbox
            if (resetAnswer == DialogResult.Yes)
            {
                clearAll();
            }
        }

        public void clearAll()
        {
            //tatanggalin lahat ng value sa LISTBOX
            lbBurstTime.Items.Clear();
            lbArrivalTime.Items.Clear();
            //tatanggalin lahat ng value ng LIST
            ArrivalTime.Clear();
            BurstTime.Clear();
            //tatanggalin value sa TEXTFIELD
            tbArrivalTime.Clear();
            tbBurstTime.Clear();
            
        }

        private void SRTFMain_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }
    }
}
