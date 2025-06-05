using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WindowsFormsApp5.Delivery
{
    public partial class DeliveryNote : Form
    {
        // Example data properties, you can replace these with actual data fields
        public string WelcomeText { get; set; } = "Smile && Sunshine";
        public string CompanyText { get; set; } = "Toy Company";
        public string PrintDate { get; set; } = DateTime.Now.ToShortDateString();
        public string OrderId { get; set; } = "123456";
        public string CustomerInfo { get; set; } = "Customer Information";
        public string OrderDetail { get; set; } = "Order Detail";

        public DeliveryNote()
        {
            InitializeComponent();
        }

        public DeliveryNote(string data)
        {
            // You can parse and set properties here as needed
            InitializeComponent();
        }

        public void ExportToPdf(string pdfPath)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDoc.PrinterSettings.PrintToFile = true;
            printDoc.PrinterSettings.PrintFileName = pdfPath;
            printDoc.DefaultPageSettings.Landscape = false;
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);

            printDoc.PrintPage += PrintDoc_PrintPage;
            printDoc.Print();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Panel1 (Header)
            var headerRect = new Rectangle(0, 0, 1200, 120);
            g.FillRectangle(new SolidBrush(Color.FromArgb(41, 128, 255)), headerRect);

            // Logo
            Image logo = Properties.Resources.logo5;
            g.DrawImage(logo, new Rectangle(1, 1, 90, 91));

            // lblWelcome
            using (Font fontWelcome = new Font("Segoe UI", 14, FontStyle.Bold | FontStyle.Italic))
            using (SolidBrush brushWhite = new SolidBrush(Color.White))
            {
                g.DrawString(WelcomeText, fontWelcome, brushWhite, new PointF(130, 16));
            }

            // label1 (Company Name)
            using (Font fontCompany = new Font("Segoe UI", 14, FontStyle.Bold | FontStyle.Italic))
            using (SolidBrush brushWhite = new SolidBrush(Color.White))
            {
                g.DrawString(CompanyText, fontCompany, brushWhite, new PointF(143, 54));
            }

            // Panel2 (Info)
            // Delivery Note Title
            using (Font fontTitle = new Font("Segoe UI", 20, FontStyle.Bold))
            {
                g.DrawString("Delivery Note", fontTitle, Brushes.Black, new PointF(24, 153));
            }
            // Print Date
            using (Font fontLabel = new Font("Segoe UI", 12, FontStyle.Regular))
            {
                g.DrawString("Print Date :", fontLabel, Brushes.Black, new PointF(600, 170));
                g.DrawString(PrintDate, fontLabel, Brushes.Black, new PointF(700, 170));
                g.DrawString("Order ID :", fontLabel, Brushes.Black, new PointF(600, 210));
                g.DrawString(OrderId, fontLabel, Brushes.Black, new PointF(700, 210));
            }

            // Panel4 (Customer Information)
            var customerPanelRect = new Rectangle(12 - 20, 240, 1423, 200);
            g.DrawRectangle(Pens.White, customerPanelRect);
            using (Font fontCustomer = new Font("Segoe UI", 14, FontStyle.Bold))
            {
                g.DrawString(CustomerInfo, fontCustomer, Brushes.Black, new PointF(27, 251));
            }
            // You can add more customer details here

            // Panel3 (Order Detail)
            var orderPanelRect = new Rectangle(16 - 20, 444 - 20, 1419, 706);
            g.DrawRectangle(Pens.White, orderPanelRect);
            using (Font fontOrderDetail = new Font("Segoe UI", 14, FontStyle.Bold))
            {
                g.DrawString(OrderDetail, fontOrderDetail, Brushes.Black, new PointF(30, 458));
            }
            // You can add order table/details rendering here
        }
    }
}