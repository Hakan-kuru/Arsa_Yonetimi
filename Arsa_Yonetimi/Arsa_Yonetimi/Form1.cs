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
            
             // Yeni arsa eklemek i�in form a�
             FieldForm fieldForm = new FieldForm();

             // Kullan�c� formu ba�ar�yla kapat�rsa (DialogResult.OK)
             if (fieldForm.ShowDialog() == DialogResult.OK)
             {
                 // Listeyi g�ncelle
                 RefreshFieldList();
             }
             MessageBox.Show($"T�klanan sat�r: {e.RowIndex}, s�tun: {e.ColumnIndex}");
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Listeyi g�ncellemek i�in bir metot �a��r�yoruz
            RefreshFieldList();
        }

        private void RefreshFieldList()
        {
            // DataGridView'e veri ba�la
            dvgFields.DataSource = null; // �nce eski veri ba��n� temizle
            dvgFields.DataSource = DataStore.Fields; // Yeni veri ba�la
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

            // Form y�klendi�inde arsa listesini g�ncelle
            RefreshFieldList();
        }
    }
}
