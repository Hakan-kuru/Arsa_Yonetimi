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
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(641, 40);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 68);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(522, 40);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 68);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button1_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(419, 40);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(84, 68);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FieldsForm
            // 
            ClientSize = new Size(800, 496);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Name = "FieldsForm";
            Text = "FieldsForm";
            ResumeLayout(false);
        }

        private Button btnDelete;
        private Button btnClose;
        private Button btnUpdate;

    }
}
