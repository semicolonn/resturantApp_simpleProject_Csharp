using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResturantApp_bhe
{
    public partial class mainWindow : Form
    {


        //needed variables

        int total = 0;
        int res = 0;
        int temp = 0;

        //Pizz Costs
     
        int largeVar = 750;
        int smallVar = 280;
        int mediumVar = 400;

        //Mahali Foods Costs

        int qabeliVar = 150;
        int kababVar = 150;
        int mantoVar = 100;

        //Fast Foods Costs

        int burgarVar = 50;
        int shormaVar = 100;
        int germanrollVar = 100;

        //Beverages Costs

        int colaVar = 20;
        int redbullVar = 120;
        int waterVar = 20;


         public mainWindow()
        {

            InitializeComponent();
        }
        
        private void mainWindow_Load(object sender, EventArgs e)
        {

            temp = Convert.ToInt16(totalText.Text);
            totalText.ReadOnly = true;
            totalText.ReadOnly = true;
            largeTxt.ReadOnly = true;
            smallTxt.ReadOnly = true;
            mediumTxt.ReadOnly = true;

            qabeliTxt.ReadOnly = true;
            kababTxt.ReadOnly = true;
            mantoTxt.ReadOnly = true;

            burgarTxt.ReadOnly = true;
            shormaTxt.ReadOnly = true;
            germanrollTxt.ReadOnly = true;

            colaTxt.ReadOnly = true;
            redbullTxt.ReadOnly = true;
            waterTxt.ReadOnly = true;


            ////Pizza Section

            ////largeTxt.Text = "750" + " " + "Afs";
            ////smallTxt.Text = "280" + " " + "Afs";
            ////mediumTxt.Text = "400" + " " + "Afs";

            ////Mahali Foods

            //qabeliTxt.Text = "150" + " " + "Afs";
            //kababTxt.Text = "150" + " " + "Afs";
            //mantoTxt.Text = "100" + " " + "Afs";

            ////Fast Foods

            //burgarTxt.Text = "50" + " " + "Afs";
            //shormaTxt.Text = "100" + " " + "Afs";
            //germanrollTxt.Text = "100" + " " + "Afs";

            ////Beverages

            //colaTxt.Text = "20" + " " + "Afs";
            //redbullTxt.Text = "120" + " " + "Afs";
            //waterTxt.Text = "20" + " " + "Afs";
        }

        private void large_CheckedChanged(object sender, EventArgs e)
        {
            if(large.Checked){

                int cost = 750 + temp;
                totalText.Text = cost.ToString();
                temp = Convert.ToInt16(totalText.Text);
            
            }
            //res = Convert.ToInt16(temp) + largeVar;
            //temp = res;
            //totalText.Text = res.ToString();

        }

        private void small_CheckedChanged(object sender, EventArgs e)
        {

            int cost = 280 + temp;
            totalText.Text = cost.ToString();
            temp = Convert.ToInt16(totalText.Text);
            
            // res = temp + smallVar;
            //totalText.Text = res.ToString();

        }

        private void medium_CheckedChanged(object sender, EventArgs e)
        {
            int cost = 400 + temp;
            totalText.Text = cost.ToString();
            temp = Convert.ToInt16(totalText.Text);
        }

        private void mediumTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void burgarTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void shormaTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
       
    
    }
///////////////////////worked only up to some dummy on check box