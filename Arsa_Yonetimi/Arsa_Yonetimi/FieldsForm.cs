using Models;
using System;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Windows.Forms.MonthCalendar;

namespace Arsa_Yonetimi
{
    partial class FieldsForm : Form
    {

        private Field arsa;

        private int arsaID;

        public FieldsForm(Field field)
        {
            InitializeComponent();
            this.arsa = field;

            // Verileri doldur
        }

        //silme
        private void button1_Click(object sender, EventArgs e)
        {
            // Silme işlemi
            var result = MessageBox.Show($"Arsa ID: {arsaID} silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                arsa = null;
                MessageBox.Show($"Arsa ID: {arsaID} silindi.");
                this.Close();
            }
        }

        //kapat
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Formu kapat
            this.Close();
        }

        //güncelle
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            // Güncellenen verilerarsa.FieldName = txtFieldName.Text;
            arsa.FieldArea = double.Parse(txtArea.Text);
            arsa.FieldCrop = txtCrop.Text;
            arsa.PlantDate = dtpPlantDate.Value;

            MessageBox.Show("bilgiler güncellendi");

            this.Close();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // FieldsForm
            // 
            ClientSize = new Size(800, 496);
            Name = "FieldsForm";
            Text = "FieldsForm";
            ResumeLayout(false);
        }
    }
}
