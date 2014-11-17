
/*
 * Name: Anju Chawla
 * Date: November 2014
 * Purpose: Look up the prices of bulk coffee based on quantity and type. Print
 * a report of all the transactions/sales.
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

namespace Lesson8_BulkCoffeeSales1
{
    public partial class BulkCoffeeSalesForm : Form
    {
      
           

        public BulkCoffeeSalesForm()
        {
            InitializeComponent();
        }

     

      


        
        /*
        private void printButton_Click(object sender, EventArgs e)
        {
            //preview the transaction report and print if required

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            //only if printing is required without previewing
            //printDocument1.Print();

        }

      

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //setting up the print page for preview and print
            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial Black", 14, FontStyle.Bold);
            float lineHeightFloat = printFont.GetHeight();
            float col1HorizontalPrintLocationFloat = e.MarginBounds.Left;
            float col2HorizontalPrintLocationFloat = 300;
            float col3HorizontalPrintLocationFloat;
            float verticalPrintLocationFloat = e.MarginBounds.Top;
            SizeF fontSizeF = new SizeF();
            string formattedPriceString;
            //if there are any transactions to be printed
            if (transactionNumberInteger > 0)
            {
                //print the heading
                e.Graphics.DrawString("Coffee Bulk Sales Report", headingFont, Brushes.Black,
                    col2HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                verticalPrintLocationFloat += lineHeightFloat * 2;
                //headings to columns
                e.Graphics.DrawString("Quantity", headingFont, Brushes.Black,
                   col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                e.Graphics.DrawString("Type", headingFont, Brushes.Black,
                   col2HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                e.Graphics.DrawString("Price", headingFont, Brushes.Black,
                   500, verticalPrintLocationFloat);

                verticalPrintLocationFloat += lineHeightFloat * 2;

                //print the transactions
                for (int index = 0; index < transactionNumberInteger; index++)
                {
                    //print the quantity
                    e.Graphics.DrawString(transactionsCoffeeSale[index].quantityString, printFont,
                        Brushes.Black, col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                    //print the coffee type
                    e.Graphics.DrawString(transactionsCoffeeSale[index].typeString, printFont,
                       Brushes.Black, col2HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                    //format and right align the price
                    formattedPriceString = transactionsCoffeeSale[index].priceDecimal.ToString("c");
                    //measure string in this fone
                    fontSizeF = e.Graphics.MeasureString(formattedPriceString, printFont);
                    //subtract width from column position
                    col3HorizontalPrintLocationFloat = 550 - fontSizeF.Width;
                    //print the price
                    e.Graphics.DrawString(formattedPriceString, printFont,
                      Brushes.Black, col3HorizontalPrintLocationFloat, verticalPrintLocationFloat);

                    //go to next printing position
                    verticalPrintLocationFloat += lineHeightFloat;


                }
            }
            else
            {
                MessageBox.Show("No transactions to print", "Print Transactions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }
        */

    }
}
