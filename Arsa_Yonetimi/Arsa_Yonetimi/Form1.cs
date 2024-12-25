using Models;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Arsa_Yonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            add("arsa1", "123", 1234);
        }

        private List<Field> FieldList = new List<Field>();
        // Add
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DvgButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // T�klanan sat�rdaki verileri al

                int arsaId = Convert.ToInt32(dvg.Rows[e.RowIndex].Cells[0].Value);

                var secilenArsa = FieldList.FirstOrDefault(a => a.FieldId == arsaId);

                if (secilenArsa != null)
                {
                    // Detay formunu a� ve se�ilen arsa bilgisini g�nder
                    FieldsForm fieldsForm = new FieldsForm(secilenArsa);
                    fieldsForm.ShowDialog();

                    // D�zenlemelerden sonra listeyi yenile
                    dvg.Rows.Clear();
                    foreach (var arsa in FieldList)
                    {
                        dvg.Rows.Add(arsa.FieldId, arsa.FieldName, arsa.FieldArea, arsa.FieldCrop, arsa.PlantDate.ToShortDateString());
                    }
                }

                // Detay formunu a� ve verileri g�nder
                FieldsForm detailForm = new FieldsForm(arsaId);
                detailForm.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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
            this.btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg).BeginInit();
            SuspendLayout();
            // 
            // dvg
            // 
            dvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg.Location = new Point(28, 32);
            dvg.Name = "dvg";
            dvg.Size = new Size(599, 311);
            dvg.TabIndex = 0;
            dvg.CellContentClick += DvgButton_Click;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new Point(712, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(76, 66);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += this.btnAdd_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(833, 441);
            Controls.Add(this.btnAdd);
            Controls.Add(dvg);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvg).EndInit();
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
            {
                HeaderText = "��lemler",
                Text = "Detay",
                UseColumnTextForButtonValue = true,
                Name = "btnDetails"
            };

            dvg.Columns.Add(btnColumn);
            // Form y�klendi�inde arsa listesini g�ncelle
            RefreshFieldList();
        }

        public void add(string fieldName, string type, int s�ra)
        {

            var dvg = new DataGridView();
            dvg.Rows.Add(s�ra, fieldName, type);
            
        }
    }
}
