using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Geometric_Brownian_motion__GBM__Stock_Price_Simulation__ActuaryProgrammer_
{
    class StandardNormalRandomNumbers 
    {
        public int myDaysForProjection;
        public int myNumofProjection;
        public double[,] StandardNormalRandomNumbersArray;
        
        public void InitilizeRandomNumberArrayTable(int NumofSimulationDays, int NumofSimulations)
        {
            myDaysForProjection = NumofSimulationDays;
            myNumofProjection = NumofSimulations;

            //number of rows = number of days to be projected
            //number of columns = number of simulations
        }

        public  double[,] GenerateRandomNumbers() {
            StandardNormalRandomNumbersArray = new double[myDaysForProjection, myNumofProjection];
            int eachRow = 1;
            int eachCol = 1;
            Random rand = new Random();

            while (eachCol <= myNumofProjection / 2) {
                eachRow = 1;
                while (eachRow <= myDaysForProjection) //generate number Random numbers for the 1st half of the array)
                {
                    double u1 = 1.0 - rand.NextDouble(); //uniform(0,1] random doubles
                    double u2 = 1.0 - rand.NextDouble();
                    
                    StandardNormalRandomNumbersArray[eachRow-1, eachCol-1] =  Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1);

                    eachRow++;
                }
                eachCol++;

            }

            eachRow = 1;
            eachCol = (myNumofProjection / 2)+1;
            //control variate method
            
            while (eachCol <= myNumofProjection)
            {
                eachRow = 1;
                while (eachRow <= myDaysForProjection) //generate number Random numbers for the 1st half of the array)
                {
                    
                    StandardNormalRandomNumbersArray[eachRow-1, eachCol-1] = StandardNormalRandomNumbersArray[eachRow-1, eachCol - (myNumofProjection/2)-1]*-1;
                    
                    eachRow++;
                }
                eachCol++;

            }
            return StandardNormalRandomNumbersArray;


        }
            


        
    }
}
