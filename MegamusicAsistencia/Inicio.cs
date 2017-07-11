using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MegamusicAsistencia
{
    public partial class Inicio : UserControl
    {
        private MySqlConnection con;
        private string conString;

        public Form1 parentform;


        public Inicio()
        {
            InitializeComponent();

            Form1 parentform = (Form1)this.Parent;
        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }


        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            using (Form2 CrearEvento = new Form2(con))
            {
                if (CrearEvento.ShowDialog() == DialogResult.OK)
                {
                    bunifuFlatButton2.Enabled = true;
                    refreshCombo();
                }
            }
                
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string server = tbIP.Text;
            string database = "eventosdb";
            string user = tbUser.Text;
            string password= tbPass.Text;
            string port = tbPort.Text;

            conString = "SERVER="+server+";PORT="+port+";DATABASE="+database+";UID="+user+"; PASSWORD="+password+";";

            con = new MySqlConnection(conString);

            try
            {
                con.Open();
                MySqlCommand query = new MySqlCommand("SELECT nombre FROM eventos", con);
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                da.Fill(dt);
                query.ExecuteReader();
                con.Close();

                foreach (DataRow row in dt.Rows)
                {
                    comboBox1.Items.Add(row["nombre"]);
                }

                MessageBox.Show("La conexión se ha realizado correctamente. A continuación selecciona el evento en el que deseas trabajar o crea uno nuevo.","Conexión Correcta");
                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                    bunifuFlatButton4.Enabled = true;
                    bunifuFlatButton3.Enabled = true;
                }
                else
                {
                    bunifuFlatButton4.Enabled = false;
                    bunifuFlatButton3.Enabled = false;
                }


                comboBox1.Enabled = true;
                bunifuFlatButton2.Enabled = true;
            }
            catch(MySqlException ex)
            {
                switch (ex.Number)
                    {
                    
                    case 1042:
                        MessageBox.Show("Error ingresando a la base de datos. Comprueba los datos ingresados", "Error ingresando a la base de datos"); break;

                    default: MessageBox.Show("Error de conexión, comprueba que los datos ingresados sean correctos y que te encuentres conectado correctamente en red (ErrCode: "+ex.Number, "Error ingresando a la base de datos");break;                    
                    }
            }       

        }

        private void refreshCombo()
        {
            con.Open();

            MySqlCommand query = new MySqlCommand("SELECT nombre FROM eventos", con);
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            query.ExecuteReader();
            con.Close();

            comboBox1.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["nombre"]);
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
                bunifuFlatButton4.Enabled = true;
                bunifuFlatButton3.Enabled = true;
            }
            else
            {
                bunifuFlatButton4.Enabled = false;
                bunifuFlatButton3.Enabled = false;
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand query = new MySqlCommand("SELECT id FROM eventos WHERE nombre = '" + comboBox1.SelectedItem.ToString() + "';", con);
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            query.ExecuteReader();

            DataRow Fila = dt.Rows[0];
            int eventid = int.Parse(Fila[0].ToString());

            parentform = (Form1)this.Parent.Parent;
            con.Close();
            parentform.makeCon(con,eventid);
            MessageBox.Show("El evento se ha cargado correctamente", "Evento cargado correctamente");
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand query = new MySqlCommand("SELECT * FROM eventos WHERE nombre = '" + comboBox1.SelectedItem.ToString() + "';", con);
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            query.ExecuteReader();
            con.Close();

            DataRow Fila = dt.Rows[0];

            string tabla_asistencia = Fila[2].ToString();
            string tabla_asistencia_nombre = Fila[3].ToString();
            string tabla_asistentes = Fila[4].ToString();
            string tabla_horas_refrigerio = Fila[5].ToString();
            string tabla_refrigerio_toma = Fila[6].ToString();

            List<string> querylist = new List<string>();

            querylist.Add("DROP TABLE " + tabla_refrigerio_toma);
            querylist.Add("DROP TABLE " + tabla_horas_refrigerio);
            querylist.Add("DROP TABLE " + tabla_asistencia);
            querylist.Add("DROP TABLE " + tabla_asistencia_nombre);
            querylist.Add("DROP TABLE " + tabla_asistentes);              
            querylist.Add("DELETE FROM eventos WHERE id=" + Fila[0].ToString());
            
            con.Open();

            MySqlCommand com;

            foreach(string q in querylist)
            {
                com = new MySqlCommand(q, con);
                com.ExecuteNonQuery();
            }
            con.Close();

            refreshCombo();
        }
    }
}
