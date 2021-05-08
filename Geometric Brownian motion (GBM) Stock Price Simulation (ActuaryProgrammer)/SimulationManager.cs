using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Brownian_motion__GBM__Stock_Price_Simulation__ActuaryProgrammer_
{
    class SimulationManager
    {
        public int myDaysForSimulation;
        public int myNumofSimulation;
        public double[,] StandardNormalRandomNumbersArrayForSimulation;
        public double[,] SimulatedStockPrices;
        public double myPriceTime0;
        public double myDailyMu;
        public double myDailySigma;
        public void InitilizeSimulation(
            double[,] InputRandNumberArray,
            double InputPriceTime0,
            double inputMu,
            double inputSigma) {

            myDaysForSimulation = InputRandNumberArray.GetLength(0);
            myNumofSimulation = InputRandNumberArray.GetLength(1);
            StandardNormalRandomNumbersArrayForSimulation = InputRandNumberArray;
            SimulatedStockPrices = new double[myDaysForSimulation + 1, myNumofSimulation];
            myPriceTime0 = InputPriceTime0;
            myDailyMu = inputMu/100/252;
            myDailySigma = inputSigma/100/(Math.Sqrt(252));

            int eachCol = 1;

            while (eachCol <= myNumofSimulation)
            {
                SimulatedStockPrices[0, eachCol - 1] = myPriceTime0;
                eachCol++;
            }

            


        }

        public void Simulate() {
            int eachCol = 1;
            int eachrow = 2;

            while (eachCol <= myNumofSimulation)
            {
                eachrow = 2;
                while (eachrow <= myDaysForSimulation ) 
                {
                    SimulatedStockPrices[eachrow - 1, eachCol - 1] =
                        SimulatedStockPrices[eachrow - 2, eachCol - 1] +
                        SimulatedStockPrices[eachrow - 2, eachCol - 1] * myDailyMu +
                        SimulatedStockPrices[eachrow - 2, eachCol - 1] * myDailySigma *
                        StandardNormalRandomNumbersArrayForSimulation[eachrow - 2, eachCol - 1];

                    eachrow++;
                }
                eachCol++;

            }
            eachCol = 1;

            while (eachCol <= myNumofSimulation) {
                SimulatedStockPrices[myDaysForSimulation, eachCol - 1] =
                           SimulatedStockPrices[myDaysForSimulation-1, eachCol - 1] +
                           SimulatedStockPrices[myDaysForSimulation - 1, eachCol - 1] * myDailyMu +
                           SimulatedStockPrices[myDaysForSimulation - 1, eachCol - 1] * myDailySigma *
                           StandardNormalRandomNumbersArrayForSimulation[StandardNormalRandomNumbersArrayForSimulation.GetLength(0) - 1, eachCol - 1];

                eachCol++;
            }



        }
            public double [,] returnSimulation() {
            
            return SimulatedStockPrices;


                    }


        }


    }

