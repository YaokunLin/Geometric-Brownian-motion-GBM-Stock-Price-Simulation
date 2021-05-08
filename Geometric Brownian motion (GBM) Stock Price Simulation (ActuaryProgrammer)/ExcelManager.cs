using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Geometric_Brownian_motion__GBM__Stock_Price_Simulation__ActuaryProgrammer_
{
    class ExcelManager
    {
        // public Excel.Application xlApp;
        public Excel.Workbook xlWB;
        public Excel.Worksheet RandNumxlWS;
        public Excel.Worksheet SimPricexlWS;
        Excel.Application xlApp = new Excel.Application();
        public double[,] myRandNumbersArrayForExcel;
        public double[,] mySimulatedStockPricesArrayForExcel;


        public void InitilizeXL()
        {
            
            xlWB = xlApp.Workbooks.Add();
            
            //xlWS.Cells[2, 5].value = "happy";
            

        }

        public void generateSimulationTab(double[,] InputSimulatedNumberArrayForExce) {
            mySimulatedStockPricesArrayForExcel = InputSimulatedNumberArrayForExce;
            int eachRow = 1;
            int eachCol = 1;

            SimPricexlWS = xlWB.Worksheets.Add();
            SimPricexlWS.Name = "Simulation";

            SimPricexlWS.Cells[1, 1].value = "Trading Date\\Scenario#";
            SimPricexlWS.Cells[1, 1].Font.Bold = true;

            while (eachCol <= mySimulatedStockPricesArrayForExcel.GetLength(1))
            {
                SimPricexlWS.Cells[1, eachCol + 1].value = eachCol;
                SimPricexlWS.Cells[1, eachCol + 1].Font.Bold = true;
                eachCol++;
            }

            SimPricexlWS.Cells[2, 1] = 0;
            SimPricexlWS.Cells[2, 1].Font.Bold = true;

            while (eachRow <= mySimulatedStockPricesArrayForExcel.GetLength(0)-1)
            {
                SimPricexlWS.Cells[eachRow + 2, 1].value = eachRow;
                SimPricexlWS.Cells[eachRow + 2, 1].Font.Bold = true; ;
                eachRow++;
            }

            eachRow = 1;
            eachCol = 1;

            while (eachCol <= mySimulatedStockPricesArrayForExcel.GetLength(1))
            {
                eachRow = 1;
                while (eachRow <= mySimulatedStockPricesArrayForExcel.GetLength(0)) 
                {

                    SimPricexlWS.Cells[eachRow + 1, eachCol + 1].value = mySimulatedStockPricesArrayForExcel[eachRow - 1, eachCol - 1];

                    eachRow++;
                }
                eachCol++;

            }




        }
        public void GenerateRandNumberTab(double[,] InputRandNumberArrayForExcel) {
            int eachRow = 1;
            int eachCol = 1;
            myRandNumbersArrayForExcel = InputRandNumberArrayForExcel;

            RandNumxlWS = xlWB.Worksheets.Add();
            RandNumxlWS.Name = "StandardNormalRandomNumbers";
            RandNumxlWS.Cells[1, 1].value = "Trading Date\\Scenario#";
            RandNumxlWS.Cells[1, 1].Font.Bold = true;



            while (eachCol <= myRandNumbersArrayForExcel.GetLength(1)){
                RandNumxlWS.Cells[1, eachCol + 1].value = eachCol;
                RandNumxlWS.Cells[1, eachCol + 1].Font.Bold = true;
                eachCol++;
            }

            while (eachRow <= myRandNumbersArrayForExcel.GetLength(0))
            {
                RandNumxlWS.Cells[eachRow+2,  1].value = eachRow;
                RandNumxlWS.Cells[eachRow+2,  1].Font.Bold = true; ;
                eachRow++;
            }




            eachRow = 1;
             eachCol = 1;

            while (eachCol <= myRandNumbersArrayForExcel.GetLength(1))
            {
                eachRow = 1;
                while (eachRow <= myRandNumbersArrayForExcel.GetLength(0)) //generate number Random numbers for the 1st half of the array)
                {

                    RandNumxlWS.Cells[eachRow+2, eachCol+1].value = myRandNumbersArrayForExcel[eachRow - 1, eachCol - 1];

                    eachRow++;
                }
                eachCol++;

            }
            
        }
        public void FinalizeExcel()
        {
            xlApp.Visible = true;
        }
            

        
    }
}
