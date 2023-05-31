using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing
{
    public partial class Main : Form
    {
        /// <summary>

        /// for PrintDialog, PrintPreviewDialog and PrintDocument:

        /// </summary> 

        private readonly System.Windows.Forms.PrintDialog prnDialog;

        private readonly System.Windows.Forms.PrintPreviewDialog prnPreview;

        private readonly System.Drawing.Printing.PrintDocument prnDocument;

        /// <summary>

        /// Font and Color:------------------

        /// Title Font

        /// <summary>

        private readonly Font InvTitleFont = new Font("Arial", 16, FontStyle.Bold);

        // Title Font height

        // private int InvTitleHeight;

        // SubTitle Font

        private readonly Font InvSubTitleFont = new Font("Arial", 14, FontStyle.Regular);

        // SubTitle Font height

        //private int InvSubTitleHeight;

        // Invoice Font

        private readonly Font InvoiceFont = new Font("Arial", 10, FontStyle.Regular);

        // Invoice FontBold

        private readonly Font InvoiceFontBold = new Font("Arial", 10, FontStyle.Bold);

        // Invoice Font10

        private readonly Font InvoiceFont9 = new Font("Arial", 9, FontStyle.Italic);

        // Invoice Font height

        private int InvoiceFontHeight;

        // Blue Color

        //private readonly SolidBrush BlueBrush = new SolidBrush(Color.Blue);

        // Red Color

        //private readonly SolidBrush RedBrush = new SolidBrush(Color.Red);

        // Black Color

        private readonly SolidBrush BlackBrush = new SolidBrush(Color.Black);



        //private string InvImage;



        /// <summary>

        /// for Report:

        /// </summary>

        private int CurrentY;

        private int CurrentX;

        private int leftMargin = 100;

        private int rightMargin = 600;//А4->600; Letter->750 

        private int topMargin = 100;

        private int bottomMargin = 1000;

        private int InvoiceWidth;

        private int InvoiceHeight;

        private int InvoiceAttributesY;

        private int InvoiceRowsY;

        private int InvoiceTotalY;

        private int InvoiceInAWordY;

        private int InvoiceSignaturesY;

        //

        private int WidthRectangle;

        //private int HightRectangle = 100;

        private int xRightRectangle;//827

        // eventUpdateInvoice става true когато се влезе в режим UPDATE

        private bool eventUpdateInvoice = false;

        //

        private string customersName;

        private string customersIDNumber;

        private string customersVatNumber;

        private string customersCity;

        private string customersAddress;

        private string customersMOL;

        //

        private string SellerName;

        private string SallerIDNumber;

        private string SallerVatNumber;

        private string SallerCity;

        private string SallerAddress;

        private string SallerMOL;

        private string SallerIBAN;

        private string SallerBIC;

        private string SallerBank;

        private string SallerIdentificationCode;

        //

        private string SaleID;

        private string SaleNOMERFAKT;

        private string SaleInvoiceNumber;

        private string SaleDate;

        private string SalePaymentType;

        private string TaxRate;//Данъчна ставка - 9 OR 20

        //private decimal SubTotal;

        //private decimal InvoiceTotal;

        private int AmountPosition;

        /// <summary>

        /// // Result of the Event 'PrintPage'

        /// </summary>

        private void PrnDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)

        {

            leftMargin = (int)e.MarginBounds.Left;

            rightMargin = (int)e.MarginBounds.Right;

            topMargin = (int)e.MarginBounds.Top;

            bottomMargin = (int)e.MarginBounds.Bottom;

            InvoiceWidth = (int)e.MarginBounds.Width;

            InvoiceHeight = (int)e.MarginBounds.Height;



            WidthRectangle = (rightMargin - leftMargin - 10) / 2;

            xRightRectangle = rightMargin - WidthRectangle;//827





            DisplayInvoiceHead(e.Graphics);       // Draw Invoice Head

            DisplayInvoiceAttributes(e.Graphics); // Атрибутите на фактурата

            SetInvoiceData(e.Graphics, e);        // Draw Invoice Data

        }

        private void GetSellerData()

        {

            string query = $"SELECT * FROM myfirms where MyFirmID = {this.comboBoxClients.SelectedIndex + 1} LIMIT 1";

            //cs.SingleResult(query);
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myfirms");
            da.Fill(table);

            foreach (DataRow row in table.Rows)

            {

                SellerName = row["MyFirmName"].ToString();

                SallerIDNumber = row["MyFirmECODE"].ToString();

                SallerVatNumber = row["MyFirmVATECODE"].ToString();

                SallerAddress = row["MyFirmAddress"].ToString();

                SallerMOL = row["MyFirmMOL"].ToString();

                SallerIdentificationCode = row["MyFirmID"].ToString();

                SallerIBAN = row["MyFirmIBAN"].ToString();

                SallerBIC = row["MyFirmBANKCODE"].ToString();

                SallerBank = row["MyFirmBANKNAME"].ToString();

            }

        }

        private void GetCustomerData()
        {
            string query = $"Select * from customers where CustomersID = {this.comboBoxClients.SelectedIndex + 1} limit 1";
            MySqlConnection cn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("customers");
            da.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                customersName = row["CustomerName"].ToString();
                customersIDNumber = row["CustomerECODE"].ToString();
                customersVatNumber = row["CustomerVATCODE"].ToString();
                customersAddress = row["CustomerAddress"].ToString();
                customersMOL = row["CustomerMOL"].ToString();
            }
        }





        //private void SetInvoiceHead(Graphics g)

        //{

        // Зареждане на картинка във фактурата

        //CurrentY = topMargin;

        //CurrentX = leftMargin;

        // int ImageHeight = 0;



        // Draw Invoice image:

        //if (System.IO.File.Exists(InvImage))

        //{

        //    Bitmap oInvImage = new Bitmap(InvImage);

        //    // Set Image Left to center Image:

        //    int xImage = CurrentX + (InvoiceWidth - oInvImage.Width) / 2;

        //    ImageHeight = oInvImage.Height; // Get Image Height

        //    g.DrawImage(oInvImage, xImage, CurrentY);

        //}



        //}



        private void DisplayInvoiceHead(Graphics g)

        {

            // int ImageHeight = 0;



            // Draw Invoice image:

            //if (System.IO.File.Exists(InvImage))

            //{

            //    Bitmap oInvImage = new Bitmap(InvImage);

            //    // Set Image Left to center Image:

            //    int xImage = CurrentX + (InvoiceWidth - oInvImage.Width) / 2;

            //    ImageHeight = oInvImage.Height; // Get Image Height

            //    g.DrawImage(oInvImage, xImage, CurrentY);

            //}



            ////////////////////////////////////////////////////////////////

            // customers Data - "Получател"

            // Left Rectangle 

            // Set Company Name, City, Salesperson, Order ID and Order Date

            ////////////////////////////////////////////////////////////////// 

            InvoiceFontHeight = (int)(InvoiceFont.GetHeight(g));



            string FieldValue = "Получател";



            CurrentX = leftMargin + 4;

            CurrentY = topMargin + 8;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);



            CurrentY += InvoiceFontHeight + 8;

            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, leftMargin + WidthRectangle, CurrentY);

            //g.DrawLine(new Pen(Brushes.Black), leftMargin + WidthRectangle + 10, CurrentY, rightMargin, CurrentY);

            FieldValue = customersName;

            CurrentY += 8;

            g.DrawString(FieldValue, InvoiceFontBold, BlackBrush, CurrentX, CurrentY);



            FieldValue = "ЕИК: " + customersIDNumber;

            CurrentY += InvoiceFontHeight + 8;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);



            FieldValue = "ИН по ЗДДС: " + customersVatNumber;

            CurrentY += InvoiceFontHeight + 8;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);



            FieldValue = "Град: " + customersCity;

            CurrentY += InvoiceFontHeight + 8;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);



            FieldValue = "Адрес: " + customersAddress;

            CurrentY += InvoiceFontHeight + 8;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);



            FieldValue = "МОЛ: " + customersMOL;

            CurrentY += InvoiceFontHeight + 8;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            CurrentY += InvoiceFontHeight + 8;



            ////////////////////////////////////////////////////////////////////////

            /// Right Rectangle

            /// Saller Data - Доставчик

            ////////////////////////////////////////////////////////////////////////

            FieldValue = "Доставчик";



            CurrentX = CurrentX = leftMargin + WidthRectangle + 14;

            CurrentY = topMargin + 8;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);



            CurrentY += InvoiceFontHeight + 8;

            xRightRectangle = leftMargin + WidthRectangle + 10;

            g.DrawLine(new Pen(Brushes.Black), leftMargin + WidthRectangle + 10, CurrentY, rightMargin, CurrentY);

            //g.DrawLine(new Pen(Brushes.Black), xRightRectangle, CurrentY, rightMargin, CurrentY);

            //g.DrawLine(new Pen(Brushes.Black), xRightRectangle, CurrentY, xRightRectangle + WidthRectangle, CurrentY);

            FieldValue = SellerName;

            CurrentY += 8;

            g.DrawString(FieldValue, InvoiceFontBold, BlackBrush, CurrentX, CurrentY);



            FieldValue = "ЕИК: " + SallerIDNumber;

            CurrentY += InvoiceFontHeight + 8;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);



            FieldValue = "ИН по ЗДДС: " + SallerVatNumber;

            CurrentY += InvoiceFontHeight + 8;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);



            FieldValue = "Град: " + SallerCity;

            CurrentY += InvoiceFontHeight + 8;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);



            FieldValue = "Адрес: " + SallerAddress;

            CurrentY += InvoiceFontHeight + 8;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);



            FieldValue = "МОЛ: " + SallerMOL;

            CurrentY += InvoiceFontHeight + 8;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);



            CurrentY += InvoiceFontHeight + 8;



            //////////////////

            /// Left Rectangle

            g.DrawRectangle(new Pen(Brushes.Black), leftMargin, topMargin, WidthRectangle, CurrentY - topMargin);

            /// Right Rectangle

            g.DrawRectangle(new Pen(Brushes.Black), xRightRectangle, topMargin, WidthRectangle, CurrentY - topMargin);

        }



        private void SetInvoiceData(Graphics g, System.Drawing.Printing.PrintPageEventArgs e)

        {

            // Set Invoice Table:

            string FieldValue;

            int CurrentRecord = 0;



            double edCena;

            double dQuantity;

            double dSumm;

            double coeff = rightMargin - 750; //коефициент за корекция на разстоянието между колонките

            // Set Table Head:

            int xID = leftMargin + 4;



            //// Draw line:



            CurrentY += +8;

            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);



            CurrentY += 8;



            string id = "№";

            g.DrawString(id, InvoiceFontBold, BlackBrush, xID, CurrentY);

            int xProductID = xID + (int)(g.MeasureString(id, InvoiceFont).Width + 3 + 0.02 * coeff);//3



            string prodID = "Код";

            g.DrawString(prodID, InvoiceFontBold, BlackBrush, xProductID, CurrentY);



            int xProductName = xProductID + (int)(g.MeasureString(prodID, InvoiceFont).Width + 10 + 0.07 * coeff);//10

            string prodName = "Наименование на стоката/услугата";

            g.DrawString(prodName, InvoiceFontBold, BlackBrush, xProductName, CurrentY);



            int xMeasure = xProductName + (int)(g.MeasureString(prodName, InvoiceFont).Width + 60 + 0.4 * coeff);//60

            string measure = "Мярка";

            g.DrawString(measure, InvoiceFontBold, BlackBrush, xMeasure, CurrentY);



            int xQuantity = xMeasure + (int)(g.MeasureString(measure, InvoiceFont).Width + 20 + 0.13 * coeff);//20

            string quantity = "Колич.";

            g.DrawString(quantity, InvoiceFontBold, BlackBrush, xQuantity, CurrentY);



            int xUnitPrice = xQuantity + (int)(g.MeasureString(quantity, InvoiceFont).Width + 25 + 0.17 * coeff);//25

            string unitPrice = "Ед.цена";

            g.DrawString(unitPrice, InvoiceFontBold, BlackBrush, xUnitPrice, CurrentY);



            int xSumm = xUnitPrice + (int)(g.MeasureString(unitPrice, InvoiceFont).Width + 32 + 0.21 * coeff);//32

            string sSumm = "Сума";

            g.DrawString(sSumm, InvoiceFontBold, BlackBrush, xSumm, CurrentY);



            //int xDiscount = xQuantity + (int)g.MeasureString(quantity, InvoiceFont).Width + 4;

            //string discount = "ТО(%/лв)";

            //g.DrawString(discount, InvoiceFont, BlueBrush, xDiscount, CurrentY);



            //AmountPosition = xDiscount + (int)g.MeasureString(quantity, InvoiceFont).Width + 4;

            //g.DrawString("Дан.основа", InvoiceFont, BlueBrush, AmountPosition, CurrentY);



            // Draw Line

            CurrentY += InvoiceFontHeight + 8;

            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);



            // Set Invoice Table:

            CurrentY += 8;

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            // Внимание трябва да се коригира при повече от 20 реда във фактурата

            // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //RecordsPerPage

            while (CurrentRecord < this.dataGridViewAddedProduct.Rows.Count - 1)

            {

                // № по ред

                g.DrawString((CurrentRecord + 1).ToString(), InvoiceFont, BlackBrush, xID, CurrentY);



                // ProductID

                FieldValue = this.dataGridViewAddedProduct.Rows[CurrentRecord].Cells[0].Value.ToString();

                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductID, CurrentY);



                // ProductName

                FieldValue = this.dataGridViewAddedProduct.Rows[CurrentRecord].Cells[1].Value.ToString();



                // if Length of (Product Name) > 50, Draw 50 character only

                if (FieldValue.Length > 50)

                    FieldValue = FieldValue.Remove(50, FieldValue.Length - 30);

                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductName, CurrentY);



                FieldValue = this.dataGridViewAddedProduct.Rows[CurrentRecord].Cells[2].Value.ToString();

                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xMeasure + 15, CurrentY);



                dQuantity = Convert.ToDouble(this.dataGridViewAddedProduct.Rows[CurrentRecord].Cells[3].Value);

                FieldValue = String.Format("{0:0.00}", this.dataGridViewAddedProduct.Rows[CurrentRecord].Cells[3].Value.ToString());

                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xQuantity + 20, CurrentY);



                edCena = Convert.ToDouble(this.dataGridViewAddedProduct.Rows[CurrentRecord].Cells[4].Value.ToString());

                // Format Extended Price and Align to Right:

                FieldValue = String.Format("{0:0.00}", edCena);

                int xEdCena = xUnitPrice + (int)g.MeasureString(unitPrice, InvoiceFont).Width;

                xEdCena += -(int)g.MeasureString(FieldValue, InvoiceFont).Width;

                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xEdCena, CurrentY);



                dSumm = dQuantity * edCena;

                // Format Summ Price and Align to Right:

                FieldValue = String.Format("{0:0.00}", dSumm);

                int xxSumm = xSumm + (int)g.MeasureString(sSumm, InvoiceFont).Width;//xSumm

                xxSumm += -(int)g.MeasureString(FieldValue, InvoiceFont).Width + 5;

                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xxSumm, CurrentY);

                AmountPosition = xxSumm - 40;//xEdCena



                CurrentY += InvoiceFontHeight + 8;

                CurrentRecord++;

            }



            SetInvoiceTotal(g);

            g.Dispose();

        }



        private void SetInvoiceTotal(Graphics g)

        {

            // Set Invoice Total:

            // Draw line:

            InvoiceTotalY = CurrentY;

            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);



            // Get Right Edge of Invoice:

            //string sSubTotal = "Данъчна основа:";

            //int xRightEdg = AmountPosition + (int)g.MeasureString(sSubTotal, InvoiceFont).Width;

            int xRightEdg = rightMargin - 15;

            // Write Sub Total:

            string sSubTotal = "Данъчна основа:";

            int xSubTotal = AmountPosition - (int)g.MeasureString(sSubTotal, InvoiceFont).Width;

            CurrentY += 8;

            g.DrawString(sSubTotal, InvoiceFontBold, BlackBrush, xSubTotal, CurrentY);

            decimal SubTotal = Convert.ToDecimal(this.textBoxDanuchnaOsnova.Text);

            string TotalValue = String.Format("{0:0.00}", SubTotal);

            int xTotalValue = xRightEdg - (int)g.MeasureString(TotalValue, InvoiceFont).Width;

            g.DrawString(TotalValue, InvoiceFontBold, BlackBrush, xTotalValue, CurrentY);



            // Write Order Freight:

            string sOrderFreight = "Данъчна ставка " + TaxRate + "%:";

            int xOrderFreight = AmountPosition - (int)g.MeasureString(sOrderFreight, InvoiceFont).Width;

            CurrentY += InvoiceFontHeight + 8;

            g.DrawString(sOrderFreight, InvoiceFontBold, BlackBrush, xOrderFreight, CurrentY);

            decimal SaleFreight = Convert.ToDecimal(this.textBoxDDS.Text);

            string FreightValue = String.Format("{0:0.00}", SaleFreight);

            int xFreight = xRightEdg - (int)g.MeasureString(FreightValue, InvoiceFont).Width;

            g.DrawString(FreightValue, InvoiceFontBold, BlackBrush, xFreight, CurrentY);



            // Write Invoice Total:

            string sInvoiceTotal = "Сума за плащане:";

            int xInvoiceTotal = AmountPosition - (int)g.MeasureString(sInvoiceTotal, InvoiceFont).Width;

            CurrentY += InvoiceFontHeight + 8;

            g.DrawString(sInvoiceTotal, InvoiceFontBold, BlackBrush, xInvoiceTotal, CurrentY);

            decimal InvoiceTotal = Convert.ToDecimal(this.textBoxSumaZaPlashtane.Text);

            string InvoiceValue = String.Format("{0:0.00}", InvoiceTotal);

            int xInvoiceValue = xRightEdg - (int)g.MeasureString(InvoiceValue, InvoiceFont).Width;

            g.DrawString(InvoiceValue, InvoiceFontBold, BlackBrush, xInvoiceValue, CurrentY);

            //

            CurrentY += InvoiceFontHeight + 8;

            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);

            InvoiceInAWordY = CurrentY;

            // BANK, 

            DisplayBank(g);

            //

            DisplayInAWord(InvoiceValue, g);

        }



        private void DisplayInvoiceAttributes(Graphics g)

        {

            // InvoiceAttributesY е Y координатата на карето за изобразяване на атрибутите на фактурата

            InvoiceAttributesY = CurrentY + 20;



            string FieldValue = "ФАКТУРА  № " + this.textBoxNumberInvoice.Text;//+ SaleInvoiceNumber;

            int x = leftMargin + (rightMargin - leftMargin) / 2 - (int)(g.MeasureString(FieldValue, InvTitleFont).Width / 2);

            g.DrawString(FieldValue, InvTitleFont, BlackBrush, x, InvoiceAttributesY);



            if (checkBoxOriginal.Checked)

            {

                FieldValue = "ОРИГИНАЛ";

                x = rightMargin - (int)g.MeasureString(FieldValue, InvTitleFont).Width - 10;

                g.DrawString(FieldValue, InvSubTitleFont, BlackBrush, x, InvoiceAttributesY);

            }



            int h = (int)(InvTitleFont.GetHeight(g));



            CurrentY = InvoiceAttributesY + h + 15;



            // Line

            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);





            h = (int)(InvoiceFont.GetHeight(g));

            CurrentY += h - 8;



            FieldValue = "Дата на издаване:  ";

            //x = leftMargin + 200;

            x = leftMargin + (rightMargin - leftMargin) / 2 - (int)(g.MeasureString(FieldValue, InvTitleFont).Width) / 2;

            int x2 = x + (int)g.MeasureString(FieldValue, InvoiceFont).Width + 10;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, x, CurrentY);

            g.DrawString(SaleDate, InvoiceFont, BlackBrush, x2, CurrentY);



            CurrentY += h + 8;

            FieldValue = "Данъчно събитие:   ";

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, x, CurrentY);

            g.DrawString(SaleDate, InvoiceFont, BlackBrush, x2, CurrentY);



            CurrentY += h + 8;

            FieldValue = "Място на издаване: ";

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, x, CurrentY);

            g.DrawString(SallerCity, InvoiceFont, BlackBrush, x2, CurrentY);



            // InvoiceRowsY Това е Y координатата на първата линия 

            // за отпечатване на редовете от фактурата

            InvoiceRowsY = CurrentY + h;

            CurrentY = InvoiceRowsY;



        }



        private void DisplayBank(Graphics g)

        {

            int y = InvoiceTotalY + 8;

            // Banka

            int x = leftMargin + 4;

            string FieldValue = "БАНКА: ";

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, x, y);

            int x2 = x + (int)g.MeasureString(FieldValue, InvoiceFont).Width + 10;

            g.DrawString(SallerBank, InvoiceFont, BlackBrush, x2, y);

            y += InvoiceFontHeight + 8;



            // IBAN

            FieldValue = "IBAN: ";

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, x, y);

            g.DrawString(SallerIBAN, InvoiceFont, BlackBrush, x2, y);

            y += InvoiceFontHeight + 8;

            // BIC 

            FieldValue = "BIC: ";

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, x, y);

            g.DrawString(SallerBIC, InvoiceFont, BlackBrush, x2, y);

        }



        private void DisplayInAWord(string InvoiceValue, Graphics g)

        {



            //iti Total in words

            int y = InvoiceInAWordY + 8;

            int x = leftMargin + WidthRectangle + 14;

            string FieldValue = "Словом: " + NumberToWords(int.Parse(this.textBoxSumaZaPlashtane.Text));

            g.DrawString(FieldValue, InvoiceFontBold, BlackBrush, x, y);

            int xNumsToWord = x + 2 + (int)g.MeasureString(FieldValue, InvoiceFont).Width;

            //InvoiceValueToWords това е InvoiceValue с думи 

            // string InvoiceValueToWords = nw.ConvertNumToWord(InvoiceValue);

            //string newSubs = InvoiceValueToWords;



            //g.DrawString(nw.SubsNumsToWordTotal(newSubs, out string outS), InvoiceFontBold, BlackBrush, xNumsToWord, y);

            // outS e декларирана в извикването на метода (newSubs, out string outS)

            //if (outS.Length > 0)

            //{

            //    y = y + InvoiceFontHeight + 8;

            //    // Отпечатва всичкия останал текст от "словом"

            //    g.DrawString(outS, InvoiceFontBold, BlackBrush, x, y);

            //}



            // 



            InvoiceSignaturesY = y + InvoiceFontHeight;

            y = InvoiceInAWordY + 8;



            FieldValue = $"Начин на плащане: {this.comboBoxNachinNaPlashtane.SelectedItem}";

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, leftMargin + 4, y);



            y = InvoiceSignaturesY + 8;

            g.DrawLine(new Pen(Brushes.Black), leftMargin, y, rightMargin, y);





            /// Тук се отпечатват подписите

            y += 28;

            if (radioButtonMOL.Checked)

            {

                FieldValue = "Получател: " + customersMOL;

            }

            else

            {

                FieldValue = "Получател: ............................."; //+ customersMOL;           

            }



            g.DrawString(FieldValue, InvoiceFont, BlackBrush, leftMargin + 4, y);

            FieldValue = "Съставил: " + SallerMOL;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, x, y);

            y = y + InvoiceFontHeight + 8;

            FieldValue = "Подпис: .............................";

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, leftMargin + 4, y);



            FieldValue = "Подпис / Идентификационен шифър: " + SallerIdentificationCode;

            g.DrawString(FieldValue, InvoiceFont, BlackBrush, x, y);

            y = y + InvoiceFontHeight + 28;



            g.DrawLine(new Pen(Brushes.Black), leftMargin, y, rightMargin, y);



            // Тук се отпечатва извадка от Закона 

            y += 8;

            string withoutSignature = "Съгласно чл. 6, ал. 1 от Закона за счетоводството, чл. 114 от ЗДДС и чл. 78 от ППЗДДС печатът ";

            g.DrawString(withoutSignature, InvoiceFont9, BlackBrush, leftMargin + 4, y);

            withoutSignature = "не е задължителен реквизит на фактурата, а подписите са заменени с идентификационни шифри.";

            y += 20;

            g.DrawString(withoutSignature, InvoiceFont9, BlackBrush, leftMargin + 4, y);

            //iti 

            y += 28;

            g.DrawLine(new Pen(Brushes.Black), leftMargin, y, rightMargin, y);

        }



        private void DisplayDialog()

        {

            try

            {

                prnDialog.Document = this.prnDocument;



                DialogResult ButtonPressed = prnDialog.ShowDialog();

                // If user Click 'OK', Print Invoice

                if (ButtonPressed == DialogResult.OK)

                    prnDocument.Print();

            }

            catch (Exception e)

            {

                MessageBox.Show(e.ToString());

            }

        }



        private void SavePdfFile()

        {

            try

            {

                prnDialog.Document = this.prnDocument;

                ///////////////////////////////////////////////////////////////////////////////////////

                prnDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";

                prnDocument.PrinterSettings.PrintToFile = true;

                prnDocument.DefaultPageSettings.PaperSize = prnDocument.PrinterSettings.PaperSizes[6];



                string fileName;

                if (checkBoxOriginal.Checked)

                {

                    fileName = "..\\docs\\Invoice-Original-" + SaleNOMERFAKT + ".pdf";

                }

                else

                {

                    fileName = "..\\docs\\Invoice-" + SaleNOMERFAKT + ".pdf";

                }

                prnDocument.PrinterSettings.PrintFileName = fileName;

                prnDocument.Print();

                System.Threading.Thread.Sleep(10);



                MessageBox.Show("Файлът [" + fileName + "] е записан успешно!", "Message info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //



                //////////////////////////////////////////////////////////////////////////////////////

                // Това са допълнителни настройки на файла и папката за записване

                // generate a file name as the current date/time in unix timestamp format

                // string file = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();

                // the directory to store the output.

                // string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // set the filename to whatever you like (full path)

                // prnDocument.PrintFileName = Path.Combine(directory, file + ".pdf");



            }

            catch (Exception e)

            {

                MessageBox.Show(e.ToString());

            }

        }

        private void DisplayInvoice()

        {

            prnPreview.Document = this.prnDocument;

            prnDocument.DocumentName = "Invoice №" + SaleInvoiceNumber;

            (prnPreview as Form).WindowState = FormWindowState.Maximized;

            try

            {

                prnPreview.ShowDialog();

            }

            catch (Exception e)

            {

                MessageBox.Show(e.ToString());

            }

        }



        private void PrintReport()

        {

            try

            {

                prnDocument.Print();

            }

            catch (Exception e)

            {

                MessageBox.Show(e.ToString());

            }

        }

        private string NumberToWords(int number) //fix the 100 number, it should say "sto i..."
        {
            if (number == 0)
                return "нула";

            if (number < 0)
                return "minus" + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += NumberToWords(number / 1000000000) + " милиард ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " милиона ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " хиляда ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                if (number >= 200 && number < 400)
                {
                    words += NumberToWords(number / 100) + "ста ";
                    number %= 100;
                }
                else if (number >= 100 && number < 200)
                {
                    words += "сто и " + NumberToWords(number / 100);
                    number %= 10;
                }
                else
                {
                    words += NumberToWords(number / 10) + " стотин ";
                    number %= 100;
                }
            }

            if (number > 0)
            {
                if (words != "")
                    words += "и ";

                var unitsMap = new[] { "нула", "едно", "две", "три", "четири", "пет", "шест", "седем", "осем", "девет", "десет", "единадесет", "дванадесет", "тринадесет", "четиринадесет", "петнадесет", "шестнадесет", "седемнадесет", "осемнадесет", "деветнадесет" };
                var tensMap = new[] { "нула", "десет", "двадесет", "тридесет", "четиридесет", "петдесет", "шейсет", "седемдесет", "осемдесет", "деветдесет" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }

            return words;
        }

        private void BtnPrintPrev_Click()

        {

            DisplayInvoice(); // Print Preview

        }

        private void BtnPrint_Click()

        {

            PrintReport(); // Print Invoice

        }

        private void BtnPrintDialog_Click()

        {

            DisplayDialog(); // Print Dialog

        }

    }
}
