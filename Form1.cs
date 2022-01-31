/*
 * Full Name: Harshal Thavrani
 * Student #: 8733610
 * Section  : 3
 * Date     : 24/5/2021
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {

        //Declaring Variabes
        string[,] arraytable = new string[15, 5];

        Button btnCtrl;
        List<string> lstWaitingList = new List<string>();
        bool isOddTableSelected = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void GetEvenTableInfo(Button btn) //Method For Even table
        {

            tblNumber.ForeColor = Color.Blue; //changes the color to blue
            tblNumber.Text = btn.Text; //outputs the button text
            tblCapacity.ForeColor = Color.Blue; //changes the color to blue
            tblCapacity.Text = "4";
            btnCtrl = btn;
            //loop begins
            for (int i = 0; i < 15; i++)
            {
                if (arraytable[i, 0].ToUpper() == btn.Text.ToUpper())
                {
                    if (arraytable[i, 1] != "")
                    {
                        tblNumber.Text = arraytable[i, 0];
                        txtCustomerName.Text = arraytable[i, 1];
                        nmbOfGuest.Text = arraytable[i, 2];
                    }
                    btnAssign.Enabled = true; //Enables the Assign Button
                    btnCancel.Enabled = true; //Enables the Cancel Button
                }
            }
            isOddTableSelected = false;
            //loop ends
        }

        private void GetOddTableInfo(Button btn) //Method for odd Table
        {
            tblNumber.ForeColor = Color.Blue; //changes the color to blue
            tblNumber.Text = btn.Text; //outputs the button text
            tblCapacity.Text = "8";
            tblCapacity.ForeColor = Color.Blue; //changes the color to blue
            btnCtrl = btn;
            for (int i = 0; i < 15; i++)
            {
                if (arraytable[i, 0].ToUpper() == btn.Text.ToUpper())
                {
                    if (arraytable[i, 1] != "")
                    {
                        tblNumber.Text = arraytable[i, 0];
                        txtCustomerName.Text = arraytable[i, 1];
                        nmbOfGuest.Text = arraytable[i, 2];
                    }
                    else if (nmbOfGuest.Value > 8)
                    {
                        MessageBox.Show("Number of Guest can't be more than the table capacity"); //Pops out a message in a message box that Number of Guest can't be more than the table capacity
                        return;
                    }
                    btnAssign.Enabled = true; //Enables the Assign Button
                    btnCancel.Enabled = true; //Enables the Cancel Button
                }
            }
            isOddTableSelected = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetOddTableInfo(btnTable1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetOddTableInfo(btnTable5);
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            GetEvenTableInfo(btnTable2);
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            GetOddTableInfo(btnTable3);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            GetEvenTableInfo(btnTable4);
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            GetEvenTableInfo(btnTable6);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            GetOddTableInfo(btnTable7);
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            GetEvenTableInfo(btnTable8);
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            GetOddTableInfo(btnTable9);
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            GetEvenTableInfo(btnTable10);
        }

        private void btnTable11_Click(object sender, EventArgs e)
        {
            GetOddTableInfo(btnTable11);
        }

        private void btnTable12_Click(object sender, EventArgs e)
        {
            GetEvenTableInfo(btnTable12);
        }

        private void btnTable13_Click(object sender, EventArgs e)
        {
            GetOddTableInfo(btnTable13);
        }

        private void btnTable14_Click(object sender, EventArgs e)
        {
            GetEvenTableInfo(btnTable14);
        }

        private void btnTable15_Click(object sender, EventArgs e)
        {
            GetOddTableInfo(btnTable15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string customername = txtCustomerName.Text; //Declaring a Variable and initializing it
            if (txtCustomerName.Text.Trim() == "" || nmbOfGuest.Value == 0)
            {
                MessageBox.Show("Customer Name and Number Of Guest Required"); //Pops out a message in a message box that Customer Name and Number Of Guest Required
                return;
            }

            else
            {
                //loop Begins
                for (int i = 0; i < 15; i++)
                {
                    if (arraytable[i, 0] == btnCtrl.Text)
                    {
                        if (arraytable[i, 1] != "")
                        {
                            MessageBox.Show("Table is Occupied "); //Pops Out a message in a message box that Table is occupied
                            return;
                        }
                        else
                        {
                            if (isOddTableSelected)
                            {
                                if (nmbOfGuest.Value > 8)
                                {
                                    MessageBox.Show("Number of Guest can't be more than the table capacity"); //Pops out a message in a message box that Number of Guest can't be more than the table capacity
                                    return;
                                }
                            }
                            else
                            {
                                if (nmbOfGuest.Value > 4)
                                {
                                    MessageBox.Show("Number of Guest can't be more than the table capacity"); //Pops out a message in a message box that Number of Guest can't be more than the table capacity
                                    return;
                                }
                            }
                        }

                        arraytable[i, 1] = txtCustomerName.Text; //Assigning the array value to Cutomer text box 
                        arraytable[i, 2] = nmbOfGuest.Value.ToString(); //Assigning the array value to up down number list
                        arraytable[i, 3] = "Occupied";
                        btnCtrl.ForeColor = Color.Red; //Changes the color to Red
                        txtCustomerName.Text = "";
                        nmbOfGuest.Value = 0;
                        btnAssign.Enabled = true; //Enables the Assign Button
                        btnCancel.Enabled = true; //Enables the Cancel Button
                        MessageBox.Show("The Table Is Occupied Now");
                        break;
                    }
                }
                //loop Ends
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            arraytable[0, 0] = "Table 1";
            arraytable[0, 1] = "";
            arraytable[0, 2] = "";
            arraytable[0, 3] = "8";
            arraytable[0, 4] = "Free";

            arraytable[1, 0] = "Table 2";
            arraytable[1, 1] = "";
            arraytable[1, 2] = "";
            arraytable[1, 3] = "4";
            arraytable[1, 4] = "Free";

            arraytable[2, 0] = "Table 3";
            arraytable[2, 1] = "";
            arraytable[2, 2] = "";
            arraytable[2, 3] = "8";
            arraytable[2, 4] = "Free";

            arraytable[3, 0] = "Table 4";
            arraytable[3, 1] = "";
            arraytable[3, 2] = "";
            arraytable[3, 3] = "4";
            arraytable[3, 4] = "Free";

            arraytable[4, 0] = "Table 5";
            arraytable[4, 1] = "";
            arraytable[4, 2] = "";
            arraytable[4, 3] = "8";
            arraytable[4, 4] = "Free";

            arraytable[5, 0] = "Table 6";
            arraytable[5, 1] = "";
            arraytable[5, 2] = "";
            arraytable[5, 3] = "4";
            arraytable[5, 4] = "Free";

            arraytable[6, 0] = "Table 7";
            arraytable[6, 1] = "";
            arraytable[6, 2] = "";
            arraytable[6, 3] = "8";
            arraytable[6, 4] = "Free";

            arraytable[7, 0] = "Table 8";
            arraytable[7, 1] = "";
            arraytable[7, 2] = "";
            arraytable[7, 3] = "4";
            arraytable[7, 4] = "Free";

            arraytable[8, 0] = "Table 9";
            arraytable[8, 1] = "";
            arraytable[8, 2] = "";
            arraytable[8, 3] = "8";
            arraytable[8, 4] = "Free";

            arraytable[9, 0] = "Table 10";
            arraytable[9, 1] = "";
            arraytable[9, 2] = "";
            arraytable[9, 3] = "4";
            arraytable[9, 4] = "Free";

            arraytable[10, 0] = "Table 11";
            arraytable[10, 1] = "";
            arraytable[10, 2] = "";
            arraytable[10, 3] = "8";
            arraytable[10, 4] = "Free";

            arraytable[11, 0] = "Table 12";
            arraytable[11, 1] = "";
            arraytable[11, 2] = "";
            arraytable[11, 3] = "4";
            arraytable[11, 4] = "Free";

            arraytable[12, 0] = "Table 13";
            arraytable[12, 1] = "";
            arraytable[12, 2] = "";
            arraytable[12, 3] = "8";
            arraytable[12, 4] = "Free";

            arraytable[13, 0] = "Table 14";
            arraytable[13, 1] = "";
            arraytable[13, 2] = "";
            arraytable[13, 3] = "4";
            arraytable[13, 4] = "Free";

            arraytable[14, 0] = "Table 15";
            arraytable[14, 1] = "";
            arraytable[14, 2] = "";
            arraytable[14, 3] = "8";
            arraytable[14, 4] = "Free";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtrichbox.Clear(); //Clears The Rich text box
            for (int i = 0; i < 15; i++)
            {
                if (arraytable[i, 1] != "")
                    txtrichbox.AppendText(arraytable[i, 0] + " - " + arraytable[i, 1] + " - " + arraytable[i, 2] + " Guests " + Environment.NewLine); //Displays the List 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Loop Begins
            for (int i = 0; i < 15; i++)
            {
                if (arraytable[i, 0].ToUpper() == btnCtrl.Text.ToUpper())
                {
                    
                    arraytable[i, 1] = "";
                    txtCustomerName.Text = "";
                    nmbOfGuest.Value = 0;
                    arraytable[i, 3] = "Free";
                    btnAssign.Enabled = false; //Disables the Assign Buttuon
                    btnCancel.Enabled = false; //Disables the Cancel Buttuon
                    btnCtrl.ForeColor = Color.Black; //Changes the color of the button back to Black
                    MessageBox.Show("The Table Is Free Now");
                    break;

                }

            }
        }

        private void btnAddToWaiting_Click(object sender, EventArgs e)
        {
            
            string customername = txtCustomerName.Text; //Declares a string variable and initializes it as well
            
            if (txtCustomerName.Text.Trim() == "" || nmbOfGuest.Value == 0)
            {
                MessageBox.Show("Customer Name or Number Of Guest must have missed please check both the fields"); //Pops us a message in a message box that Customer Name or Number Of Guest must have missed please check both the fields
                return;
            }
            else
            {
                //loop Begins
                for (int i = 0; i < 15; i++)
                {
                    if (arraytable[i, 0] == btnCtrl.Text)
                    {
                        //arraytable[i, 1] = txtCustomerName.Text;
                        //arraytable[i, 2] = nmbOfGuest.Value.ToString();
                       

                        lstWaitingList.Add(txtCustomerName.Text + " - " + nmbOfGuest.Value); //Adds the array value in the list
                        txtCustomerName.Text = "";
                        nmbOfGuest.Value = 0;
                        MessageBox.Show("The entry has been put into the waiting list");
                        break;
                    }
                    else
                    {

                    }
                }
                if (isOddTableSelected)
                {
                    if (nmbOfGuest.Value > 8)
                    {
                        MessageBox.Show("Number of Guest can't be more than the table capacity"); //Pops out a message in a message box that Number of Guest can't be more than the table capacity
                        return;
                    }
                }
                else
                {
                    if (nmbOfGuest.Value > 4)
                    {
                        MessageBox.Show("Number of Guest can't be more than the table capacity"); //Pops out a message in a message box that Number of Guest can't be more than the table capacity
                        return;
                    }
                }
                
            }
        }

        private void btnWaitingList_Click(object sender, EventArgs e)
        {

            txtRichBox2.Clear();
            for (int i = 0; i < 15; i++)
            {
                if (arraytable[i, 1] != "")
                {
                    txtRichBox2.Lines = lstWaitingList.ToArray();//Displays the list in the Rich Text Box
                }

            }

        }

        private void nmbOfGuest_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
