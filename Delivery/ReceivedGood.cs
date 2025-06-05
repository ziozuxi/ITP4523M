using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.Delivery
{
    public partial class ReceivedGood : Form
    {
        private List<ReceivedGoodRecord> receivedGoods;

        public ReceivedGood()
        {
            InitializeComponent();
            InitializeSampleData();
            PopulateDataGridView(receivedGoods);
        }

        private class ReceivedGoodRecord
        {
            public string ReceivedID { get; set; }
            public DateTime Date { get; set; }
            public string DeliveryID { get; set; }
            public string Status { get; set; }
            public string SupplierID { get; set; }
            public string Remarks { get; set; }
        }

        private void InitializeSampleData()
        {
            receivedGoods = new List<ReceivedGoodRecord>
            {
                new ReceivedGoodRecord { ReceivedID = "REC001", Date = new DateTime(2025, 5, 1), DeliveryID = "DEL001", Status = "Received", SupplierID = "SUP001", Remarks = "All items intact" },
                new ReceivedGoodRecord { ReceivedID = "REC002", Date = new DateTime(2025, 5, 2), DeliveryID = "DEL002", Status = "Partial", SupplierID = "SUP002", Remarks = "Missing 5 units" },
                new ReceivedGoodRecord { ReceivedID = "REC003", Date = new DateTime(2025, 5, 3), DeliveryID = "DEL003", Status = "Pending", SupplierID = "SUP001", Remarks = "Awaiting inspection" }
            };
        }

        private void PopulateDataGridView(List<ReceivedGoodRecord> records)
        {
            dataGridView1.Rows.Clear();
            foreach (var record in records)
            {
                dataGridView1.Rows.Add(record.ReceivedID, record.Date.ToShortDateString(), record.DeliveryID, record.Status, record.SupplierID, record.Remarks);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Original event handler (empty or placeholder)
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

        private void ReceivedGood_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowDeliveryPage();
        }

        private void ShowDeliveryPage()
        {
            this.Controls.Clear();
            Delivery deliveryForm = new Delivery();
            deliveryForm.TopLevel = false;
            deliveryForm.FormBorderStyle = FormBorderStyle.None;
            deliveryForm.Dock = DockStyle.Fill;
            this.Controls.Add(deliveryForm);
            deliveryForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRec_Good AddRec_GoodForm = new AddRec_Good();
            AddRec_GoodForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = SearchBar.Text.Trim().ToLower();
            DateTime selectedDate = DeliveryDatePicker.Value.Date;

            var filteredRecords = receivedGoods.FindAll(r =>
                (string.IsNullOrEmpty(searchText) ||
                 r.ReceivedID.ToLower().Contains(searchText) ||
                 r.DeliveryID.ToLower().Contains(searchText)) &&
                (r.Date.Date == selectedDate || DeliveryDatePicker.Value == DateTimePicker.MinimumDateTime));

            PopulateDataGridView(filteredRecords);
        }
    }
}