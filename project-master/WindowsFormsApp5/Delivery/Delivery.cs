using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp5.Delivery
{
    public partial class Delivery : Form
    {

        public Delivery()
        {
            InitializeComponent();

            
        }
 
        
     
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedDeliveryID = dataGridView1.Rows[e.RowIndex].Cells["DeliveryID"].Value.ToString();
                DeliveryNote deliveryNote = new DeliveryNote(selectedDeliveryID);
                deliveryNote.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowReceivedGood();
        }


        private void ShowReceivedGood()
        {
            this.Controls.Clear();
            ReceivedGood receivedForm = new ReceivedGood();
            receivedForm.TopLevel = false;
            receivedForm.FormBorderStyle = FormBorderStyle.None;
            receivedForm.Dock = DockStyle.Fill;
            this.Controls.Add(receivedForm);
            receivedForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new confirmForm("Enter Delivery ID to export:"))
                {
                    if (dialog.ShowDialog(this) == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.InputText))
                    {
                        string deliveryId = dialog.InputText.Trim();

                        // Confirm Delivery ID exists in deliveryNote table
                        var exists = sstoy_dbDataSet.deliverynote
                            .AsEnumerable()
                            .Any(row => row.Field<string>("DeliveryID") == deliveryId);

                        if (!exists)
                        {
                            MessageBox.Show("Delivery ID not found in deliveryNote table.", "Error");
                            return;
                        }

                        string testingFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testing");
                        if (!System.IO.Directory.Exists(testingFolder))
                            System.IO.Directory.CreateDirectory(testingFolder);
                        string fileName = $"DeliveryNote_{deliveryId}_{DateTime.Now:yyyyMMdd}.pdf";
                        string filePath = System.IO.Path.Combine(testingFolder, fileName);

                        // Create the DeliveryNote form with data (do not show to user)
                        using (var note = new DeliveryNote(deliveryId))
                        {
                            note.Width = 800;
                            note.Height = 600;
                            note.StartPosition = FormStartPosition.Manual;
                            note.Location = new Point(-2000, -2000); // Hide off-screen
                            note.Show();
                            note.ExportToPdf(filePath);
                            note.Hide();
                        }

                        MessageBox.Show("Delivery note saved as PDF:\n" + filePath, "Export Successful");
                        var psi = new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = filePath,
                            UseShellExecute = true
                        };
                        System.Diagnostics.Process.Start(psi);
                    }
                    else
                    {
                        MessageBox.Show("No Delivery ID entered.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create Unsuccessful");
            }
        }

        private void PrintDeliveryNoteToPdf(string deliveryId, string pdfPath)
        {
            PrintDocument printDoc = new PrintDocument();

            // Set the printer to Microsoft Print to PDF
            printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDoc.PrinterSettings.PrintToFile = true;
            printDoc.PrinterSettings.PrintFileName = pdfPath;

            // Prepare the content to print
            printDoc.PrintPage += (s, e) =>
            {
                float y = 40;
                Font font = new Font("Segoe UI", 12);
                e.Graphics.DrawString("Delivery Note", font, Brushes.Black, 40, y);
                y += 30;
                e.Graphics.DrawString($"Delivery ID: {deliveryId}", font, Brushes.Black, 40, y);
                // Add more fields as needed, e.g., OrderID, Status, etc.
            };

            printDoc.Print();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sstoy_dbDataSet.deliverynote' table. You can move, or remove it, as needed.
            this.deliverynoteTableAdapter.Fill(this.sstoy_dbDataSet.deliverynote);

        }


    }
}