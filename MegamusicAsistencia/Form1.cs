using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;


namespace MegamusicAsistencia
{
    public partial class Form1 : Form
    {

        public MySqlConnection con;

        public Inicio inicio = new Inicio();
        public ucAddAsistente addAsistente = new ucAddAsistente();
        public addAsistencia addAsistencia = new addAsistencia();
        public refrigerioToma tomaRefrigerio = new refrigerioToma();
        public int eventid;

        public string tabla_asistencia { set; get; }
        public string tabla_asistencia_nombre { set; get; }
        public string tabla_asistentes { set; get; }
        public string tabla_horas_refrigerio { set; get; }
        public string tabla_refrigerio_toma { set; get; }




        public Form1()
        {
            InitializeComponent();
            btAddAsistentes.Visible = false;
            btAsistencia.Visible = false;
            btRefrigerios.Visible = false;
            bunifuImageButton1.Visible = false;

            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(inicio);

        }

        private void CargaFormulario(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new Size(w, h);

            
        }


        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

#region Botones Menu Principal

        public void toogle(object sender)
        {
            btAddAsistentes.selected = false;
            btAsistencia.selected = false;
            btRefrigerios.selected = false;
            btInicio.selected = false;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).selected = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            toogle(sender);
            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(inicio);
        }

        private void btAddAsistentes_Click(object sender, EventArgs e)
        {
            toogle(sender);
            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(addAsistente);
        }

        private void btAsistencia_Click(object sender, EventArgs e)
        {
            toogle(sender);
            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(addAsistencia);
        }

        private void btRefrigerios_Click(object sender, EventArgs e)
        {
            toogle(sender);
            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(tomaRefrigerio);
        }

        #endregion

        private void pnContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        public void makeCon(MySqlConnection connection, int id)
        {
          con = connection;
          eventid = id;
          iniciar();
        }

        private void iniciar()
        {
            btAddAsistentes.Visible = true;
            btAsistencia.Visible = true;
            btRefrigerios.Visible = true;
            bunifuImageButton1.Visible = true;

            System.Data.DataTable dt = selectQuery("SELECT * FROM eventos WHERE id="+eventid);

            DataRow Fila = dt.Rows[0];
            tabla_asistencia = Fila[2].ToString() ;
            tabla_asistencia_nombre = Fila[3].ToString();
            tabla_asistentes = Fila[4].ToString();
            tabla_horas_refrigerio = Fila[5].ToString();
            tabla_refrigerio_toma = Fila[6].ToString();
    }

        public void insertQuery(String query)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1062: MessageBox.Show("La asistencia que deseas registrar ya existe en la base de datos", "Error de registro"); break;
                    case 1452: MessageBox.Show("El codigo que intentas ingresar no existe en la lista de asistentes", "Error de registro"); break;
                    default:
                        MessageBox.Show("Error no controlado, la inserción no pudo realizarse. El codigo del error es "+ex.Number,"Error de registro");
                        break;
                } 
            }
            con.Close();
        }

        public System.Data.DataTable selectQuery(String query)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            cmd.ExecuteReader();
            con.Close();
            return dt;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();

            if(xlApp == null)
            {
                MessageBox.Show("Excel no se encuentra instalado en tu sistema. No se puede continuar", "Por favor instala Excel para continuar");
                return;
            }
            

            Excel.Workbook wb = xlApp.Workbooks.Add();

            Excel.Worksheet ws1 = (Excel.Worksheet)wb.Worksheets[1];
            ws1.Name = "Reporte de toma de refrigerios";
            Excel.Worksheet ws2 = (Excel.Worksheet)wb.Worksheets.Add(ws1);
            ws2.Name = "Reporte de asistencia";
            Excel.Worksheet ws3 = (Excel.Worksheet)wb.Worksheets.Add(ws2);
            ws3.Name = "Reporte de asistentes";
            
            #region Creacion de la hoja de asistentes
            ws3.Cells[1][1] = "ID";
            ws3.Cells[2][1] = "Nombre";
            ws3.Cells[3][1] = "Documento";

            DataTable dt1 = selectQuery("SELECT * FROM " + tabla_asistentes);

            int i = 1;
            foreach(DataRow row in dt1.Rows)
            {
                i++;
                ws3.Cells[1][i] = row[0];
                ws3.Cells[2][i] = row[1];
                ws3.Cells[3][i] = row[2];
            }

            #endregion

            #region Creacion de la hoja de asistencia al evento

            ws2.Cells[1][1] = "Nombre del Asistente";
            ws2.Cells[2][1] = "Documento";

            i = 2;

            DataTable dt2 = selectQuery("SELECT * FROM " + tabla_asistencia_nombre);
            DataTable dt3 = selectQuery("SELECT * FROM " + tabla_asistencia);

            foreach (DataRow row in dt2.Rows)
            {
                i++;
                ws2.Cells[i][1] = row[0];
            }

            i = 1;
            foreach (DataRow row1 in dt1.Rows)
            {
                i++;
                int id = int.Parse(row1[0].ToString());
                ws2.Cells[1][i] = row1[1];
                ws2.Cells[2][i] = row1[2];

                foreach(DataRow row2 in dt3.Rows)
                {
                    string idasistencia = row2[0].ToString();

                    if(int.Parse(row2[1].ToString())==id)
                    {
                        for(int k = 0; k<=dt2.Rows.Count; k++)
                        {
                            string idcelda = ws2.Cells[k + 2][1].Text;
                            if (idcelda==idasistencia)
                            {
                                ws2.Cells[k + 2][i] = "X";
                            }
                        }
                    }
                }
            }

            i = 2;
            foreach (DataRow row in dt2.Rows)
            {
                i++;
                ws2.Cells[i][1] = row[1];
            }

            #endregion

            #region Creacion de la hoja de refrigerios recibidos

            ws1.Cells[1][1] = "Nombre del Asistente";
            ws1.Cells[2][1] = "Documento";

            i = 2;

            DataTable dt4 = selectQuery("SELECT * FROM " + tabla_horas_refrigerio);
            DataTable dt5 = selectQuery("SELECT * FROM " + tabla_refrigerio_toma);

            foreach (DataRow row in dt4.Rows)
            {
                i++;
                ws1.Cells[i][1] = row[0];
            }

            i = 1;
            foreach (DataRow row1 in dt1.Rows)
            {
                i++;
                int id = int.Parse(row1[0].ToString());
                ws1.Cells[1][i] = row1[1];
                ws1.Cells[2][i] = row1[2];

                foreach (DataRow row2 in dt5.Rows)
                {
                    string idasistencia = row2[0].ToString();

                    if (int.Parse(row2[1].ToString()) == id)
                    {
                        for (int k = 0; k <= dt4.Rows.Count; k++)
                        {
                            string idcelda = ws1.Cells[k + 2][1].Text;
                            if (idcelda == idasistencia)
                            {
                                ws1.Cells[k + 2][i] = "X";
                            }
                        }
                    }
                }
            }

            i = 2;
            foreach (DataRow row in dt4.Rows)
            {
                i++;
                ws1.Cells[i][1] = row[1];
            }

            #endregion

            #region Adicion de estilo a las hojas de Excel

            Excel.Range rangeWs1 = ws1.UsedRange;
            Excel.Range rangeWs2 = ws2.UsedRange;
            Excel.Range rangeWs3 = ws3.UsedRange;

            Excel.Style textStyle = wb.Styles.Add("NewStyle");

            textStyle.Font.Name = "Segoe UI";
            textStyle.Font.Size = 14;
            textStyle.Font.Color = System.Drawing.ColorTranslator.FromHtml("#0D6076");
            textStyle.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            textStyle.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            rangeWs1.Style = textStyle;
            rangeWs2.Style = textStyle;
            rangeWs3.Style = textStyle;

            ws1.Columns.AutoFit();
            ws2.Columns.AutoFit();
            ws3.Columns.AutoFit();

            rangeWs1.Cells.Style.Font.Size = 12;
            rangeWs2.Cells.Style.Font.Size = 12;
            rangeWs3.Cells.Style.Font.Size = 12;

            ws1.Rows.RowHeight = 22;
            ws2.Rows.RowHeight = 22;
            ws3.Rows.RowHeight = 22;


            #endregion





            xlApp.Visible = true;


        }
    }

}
