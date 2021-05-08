using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Geometric_Brownian_motion__GBM__Stock_Price_Simulation__ActuaryProgrammer_
{
    public partial class Form1 : Form
    {
        public double[,] RandomNumbersArray;
        public double[,] simulatedStockPrices;


        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //Controls for the price input
            PriceTime0.Minimum = 0;
            PriceTime0.DecimalPlaces = 2;
            PriceTime0.Increment = .01m;

            //Controls for the volatility input
            volatility.Minimum = 0;
            volatility.Maximum = 100;
            volatility.DecimalPlaces = 2;
            volatility.Increment = 0.01m;


            //Controls for the return input
            AnnualReturn.Minimum = 0;
            AnnualReturn.Maximum = 100;
            AnnualReturn.DecimalPlaces = 2;
            AnnualReturn.Increment = 0.01m;


            

            

        }

      

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Run_Click(object sender, EventArgs e)
        {

            if (NumofSim.Value % 2 == 1)
            {
                NumofSim.Value = NumofSim.Value + 1;
            }//make sure we can apply control variate
           // 

        StandardNormalRandomNumbers myStandardNormalRandomNumbers = new StandardNormalRandomNumbers();
            myStandardNormalRandomNumbers.InitilizeRandomNumberArrayTable(Convert.ToInt32(DaysForProjection.Value), Convert.ToInt32(NumofSim.Value));
            RandomNumbersArray = myStandardNormalRandomNumbers.GenerateRandomNumbers();
            ExcelManager myXlManager = new ExcelManager();
            myXlManager.InitilizeXL();
            SimulationManager mySimManager = new SimulationManager();
            mySimManager.InitilizeSimulation( 
                RandomNumbersArray,
                Convert.ToDouble(PriceTime0.Value),
                Convert.ToDouble(AnnualReturn.Value),
                Convert.ToDouble(volatility.Value));

            mySimManager.Simulate();

            simulatedStockPrices = mySimManager.returnSimulation();

            myXlManager.GenerateRandNumberTab(RandomNumbersArray);
            myXlManager.generateSimulationTab(simulatedStockPrices);


            myXlManager.FinalizeExcel();

        }

     
    }
}
