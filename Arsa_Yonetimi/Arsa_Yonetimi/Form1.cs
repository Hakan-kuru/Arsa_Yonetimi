using Models;

namespace Arsa_Yonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Add
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void DvgButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            
             // Yeni arsa eklemek için form aç
             FieldForm fieldForm = new FieldForm();

             // Kullanýcý formu baþarýyla kapatýrsa (DialogResult.OK)
             if (fieldForm.ShowDialog() == DialogResult.OK)
             {
                 // Listeyi güncelle
                 RefreshFieldList();
             }
             MessageBox.Show($"Týklanan satýr: {e.RowIndex}, sütun: {e.ColumnIndex}");
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Listeyi güncellemek için bir metot çaðýrýyoruz
            RefreshFieldList();
        }

        private void RefreshFieldList()
        {
            // DataGridView'e veri baðla
            dvgFields.DataSource = null; // Önce eski veri baðýný temizle
            dvgFields.DataSource = DataStore.Fields; // Yeni veri baðla
        }

        private void InitializeComponent()
        {
            dvg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvg).BeginInit();
            SuspendLayout();
            // 
            // dvg
            // 
            dvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg.Location = new Point(12, 42);
            dvg.Name = "dvg";
            dvg.Size = new Size(240, 150);
            dvg.TabIndex = 0;
            dvg.CellContentClick += DvgButton_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(833, 441);
            Controls.Add(dvg);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvg).EndInit();
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Form yüklendiðinde arsa listesini güncelle
            RefreshFieldList();
        }
    }
}
