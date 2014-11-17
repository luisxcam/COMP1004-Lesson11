
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

        private struct CoffeeSale
        {
            public string quantityString;
            public string typeString;
            public decimal priceDecimal;
        }

        //number of transaction to be saved
        private const int MAX_TRANSACTIONS_Integer = 5;
        //the list/array to save the transactions
        private CoffeeSale[] transactionsCoffeeSale = new CoffeeSale[MAX_TRANSACTIONS_Integer];
        private string selectedButtonString = "quarterPoundRadioButton";
        private int transactionNumberInteger = 0;


        public BulkCoffeeSalesForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the inputs and outputs; bacl to start or default
            coffeeTypeComboBox.SelectedIndex = -1;
            quarterPoundRadioButton.Checked = true;
            selectedButtonString = "quarterPountRadioButton";
            priceTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the application; check if report needs to 
            DialogResult confirm = MessageBox.Show("Do you want to print the transaction report?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);

            if (confirm == System.Windows.Forms.DialogResult.No) { 
                //call the print procedure
                printButton_Click(sender, e);
                //Closes the application
            }

            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (transactionNumberInteger > 0) {
                //preview the transaction report and print if required

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                //only if printing is required without previewing
                //printDocument1.Print();
            } else {
                MessageBox.Show("There's no transactions to print", "Print", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void findPriceButton_Click(object sender, EventArgs e)
        {
            //prices of the bulk coffee
            decimal[,] priceDecimal = {
                                          {2.6m,2.9m,3.25m},
                                          {4.9m,5.6m,6.1m},
                                          {8.75m,9.75m,11.25m}
                                      };

            int rowInteger, columnInteger;
            decimal salesPriceDecimal;

            //allow maximum numbers of transactions
            if (transactionNumberInteger < MAX_TRANSACTIONS_Integer)
            {
                //find coffee selected
                columnInteger = coffeeTypeComboBox.SelectedIndex;
                if (columnInteger != -1)
                {
                    switch (selectedButtonString)
                    {
                        case "quarterPoundRadioButton":
                            rowInteger = 0;
                            transactionsCoffeeSale[transactionNumberInteger].quantityString = "Quarter Pound";
                            break;
                        case "halfPoundRadioButton":
                            rowInteger = 1;
                            transactionsCoffeeSale[transactionNumberInteger].quantityString = "Half Pound";
                            break;
                        case "fullPoundRadioButton":
                            rowInteger = 2;
                            transactionsCoffeeSale[transactionNumberInteger].quantityString = "Full Pound";
                            break;
                        default:
                            rowInteger = 0;
                            transactionsCoffeeSale[transactionNumberInteger].quantityString = "Quarter Pound";
                            break;
                    }//switch

                    //retrieve the price
                    salesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                    //save the rest of the transaction
                    transactionsCoffeeSale[transactionNumberInteger].typeString = (string) coffeeTypeComboBox.Items[columnInteger];
                    transactionsCoffeeSale[transactionNumberInteger].priceDecimal = salesPriceDecimal;

                    transactionNumberInteger++;

                    //display the price
                    priceTextBox.Text = salesPriceDecimal.ToString("c");
                }
                else
                {
                    MessageBox.Show("Please select a coffee type", "Incomplete selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Only this" + MAX_TRANSACTIONS_Integer + " amount of transactions can be made", "Maximum Number of Transactions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;
            selectedButtonString = selectedRadioButton.Name;
        }


        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
                
                /*
                 * Option2:
                 * for(CoffeeSale transaction in transactionsCoffeeSales)
                */

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
            /*else
            {
                MessageBox.Show("No transactions to print", "Print Transactions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/

        }
    }
}
