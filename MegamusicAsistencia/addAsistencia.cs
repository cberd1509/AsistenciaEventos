using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegamusicAsistencia
{
    public partial class addAsistencia : UserControl
    {
        bool barcodeMode;
        Form1 parentform;

        public addAsistencia()
        {
            InitializeComponent();
                     

        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {

        }

        private void addAsistencia_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            Form1 parentform = (Form1)this.Parent.Parent;

            string nombre = parentform.tabla_asistencia_nombre;

            string query = "SELECT * FROM "+ nombre;

            DataTable datos = parentform.selectQuery(query);

            foreach (DataRow row in datos.Rows)
            {
                comboBox1.Items.Add(row["nombre"]);
            }
            comboBox1.SelectedIndex = 0;

            checkBox1.Checked = true;

            bunifuTextbox1.Select() ;
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            submitAsistencia(bunifuTextbox1.text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                bunifuFlatButton1.Enabled = false;
                barcodeMode = true;
            }
            else
            {
                bunifuFlatButton1.Enabled = true;
                barcodeMode = false;
            }
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            if (barcodeMode && bunifuTextbox1.text != "")
            {
                submitAsistencia(bunifuTextbox1.text);
            }
        }

        private void submitAsistencia(string codigo)
        {
            //Obtener el ID de la asistencia
            parentform = (Form1)this.Parent.Parent;
            string tasistencia = parentform.tabla_asistencia_nombre;
            string query = "SELECT id FROM "+tasistencia+" WHERE nombre = '" + comboBox1.SelectedItem.ToString() + "';";
            
            DataTable datos = parentform.selectQuery(query);
            DataRow fila = datos.Rows[0];
            int id = int.Parse(fila[0].ToString());


            string asistencia_evento = parentform.tabla_asistencia;
            query = "INSERT INTO "+ asistencia_evento + " (id_asistencia,id_asistente) VALUES ('"+ id +"','"+ codigo +"')";

            parentform.insertQuery(query);

            bunifuTextbox1.text = "";
            

        }

        private void ClearField(object sender, EventArgs e)
        {
            bunifuTextbox1.text = "";
        }
    }
}
