using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MegamusicAsistencia
{
    public partial class ucAddAsistente : UserControl
    {
        public ucAddAsistente()
        {
            InitializeComponent();
        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucAddAsistente_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            string Nombre_Col = comboBox1.SelectedItem.ToString();
            string Documento_Col = comboBox2.SelectedItem.ToString() ;
            Form1 parentform = (Form1)this.Parent.Parent;

            string tabla = parentform.tabla_asistentes;

            string query = "DELETE FROM " + tabla + ";";
            parentform.insertQuery(query);

            query = "ALTER TABLE " + tabla + " AUTO_INCREMENT = 1;";
            parentform.insertQuery(query);

            foreach (DataGridViewRow row in dgLista.Rows)
            {
                if (row.IsNewRow) continue;
                query = "INSERT INTO `" +tabla+"` (`nombre`,`documento`) VALUES ('" + row.Cells[Nombre_Col].Value+"','"+row.Cells[Documento_Col].Value+"');";
                parentform.insertQuery(query);
            }

            MessageBox.Show("Los datos se ingresaron correctamente");
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openFileDialog1.Dispose();
            DataTable dt = new DataTable();
            string[] data_col = null;
            int x = 0;


            string[] textocsv = System.IO.File.ReadAllLines(openFileDialog1.FileName,System.Text.Encoding.UTF8);
            foreach (string linea in textocsv)
            {
                data_col = linea.Split(';');
                if (x == 0)
                {
                    for (int i = 0; i < data_col.Count(); i++)
                    {
                        dt.Columns.Add(data_col[i]);
                        comboBox1.Items.Add(data_col[i]);
                        comboBox2.Items.Add(data_col[i]);
                    }
                    x++;
                }
                else
                {
                    dt.Rows.Add(data_col);
                }
            }
            dgLista.DataSource = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
