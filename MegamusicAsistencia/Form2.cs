using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using MySql.Data.MySqlClient;
using System.IO;

namespace MegamusicAsistencia
{
    public partial class Form2 : Form
    {

        public MySqlConnection con;

        public Form2(MySqlConnection conn)
        {
            InitializeComponent();
            con = conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ChooseDate datepick = new ChooseDate())
            {
                if (datepick.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    listBox1.Items.Add(new HoraToma(datepick.NombreEvento, datepick.HoraFecha));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selected = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(selected);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ChooseDate datepick = new ChooseDate())
            {
                if (datepick.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    listBox2.Items.Add(new HoraToma(datepick.NombreEvento, datepick.HoraFecha));
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selected = listBox2.SelectedIndex;
            listBox2.Items.RemoveAt(selected);
        }
               
        
        // Creacion de la base de datos
        private void button5_Click(object sender, EventArgs e)
        {
            bool validate=true;

            if(listBox1.Items.Count<1)
            {
                MessageBox.Show("No se han definido horarios de toma de asistencia", "No se encontraron horarios de toma de asistencia");
                validate = false;
            };

            if (tbName.TextLength==0)
            {
                MessageBox.Show("No se ha definido el nombre del evento, recuerda hacerlo para poder continuar", "No olvides definir el nombre del evento.");
                validate = false;
            };

            if(validate)
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SHOW TABLE STATUS LIKE 'eventos'", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.ExecuteReader();


                DataRow row = dt.Rows[0];
                int i = int.Parse(row["Auto_increment"].ToString()); // Obtiene el siguiente index de autoincremento

                string nombreEvento = tbName.Text;
                string tablaAsistencia = i + "_asistencia";
                string asistenciaNombre = i + "_asistencia_nombre";
                string asistentes = i + "_asistentes";
                string horasRefrigerio = i + "_horas_refrigerio";
                string rToma = i + "_refrigerio_toma";

                #region Creacion de la base de datos

                List<string> querylist = new List<string>();

                querylist.Add("INSERT INTO `eventos` (`id`, `nombre`, `tabla_asistencia`, `tabla_asistencia_nombre`, `tabla_asistentes`, `tabla_horas_refrigerio`, `tabla_refrigerio_toma`) VALUES (NULL, '" + nombreEvento + "', '" + tablaAsistencia + "', '" + asistenciaNombre + "', '" + asistentes + "', '" + horasRefrigerio + "', '" + rToma + "');");

                querylist.Add("CREATE TABLE `" + tablaAsistencia + "` (`id_asistencia` int(11) NOT NULL,`id_asistente` int(11) NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1; ");

                querylist.Add("CREATE TABLE `" + asistenciaNombre + "` (`id` int(11) NOT NULL,`nombre` varchar(60) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1;");

                querylist.Add("CREATE TABLE `" + asistentes + "` (`id` int(11) NOT NULL,`nombre` varchar(50) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,`documento` varchar(15) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1;");

                querylist.Add("CREATE TABLE `" + horasRefrigerio + "` (`id` int(11) NOT NULL,`nombre` varchar(50) COLLATE utf8_spanish_ci NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_spanish_ci; ");

                querylist.Add("CREATE TABLE `" + rToma + "` (`idhrrefri` int(11) NOT NULL,`idasistente` int(11) NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_spanish_ci;");

                querylist.Add("ALTER TABLE `" + asistenciaNombre + "` ADD PRIMARY KEY(`id`); ");

                querylist.Add("ALTER TABLE `" + asistentes + "` ADD PRIMARY KEY(`id`,`documento`); ");

                querylist.Add("ALTER TABLE `" + horasRefrigerio + "` ADD PRIMARY KEY(`id`); ");

                querylist.Add("ALTER TABLE `" + asistenciaNombre + "` MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;");

                querylist.Add("ALTER TABLE `" + asistentes + "` MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;");

                querylist.Add("ALTER TABLE `" + horasRefrigerio + "` MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;");

                querylist.Add("ALTER TABLE `" + tablaAsistencia + "` ADD FOREIGN KEY (`id_asistencia`) REFERENCES `" + asistenciaNombre + "` (`id`) ON DELETE CASCADE ON UPDATE CASCADE; ALTER TABLE `" + tablaAsistencia + "` ADD FOREIGN KEY (`id_asistente`) REFERENCES `" + asistentes + "` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;");

                querylist.Add("ALTER TABLE `" + rToma + "` ADD FOREIGN KEY(`idhrrefri`) REFERENCES `" + horasRefrigerio + "`(`id`) ON DELETE CASCADE ON UPDATE CASCADE; ALTER TABLE `" + rToma + "` ADD FOREIGN KEY(`idasistente`) REFERENCES `" + asistentes + "`(`id`) ON DELETE CASCADE ON UPDATE CASCADE;");

                querylist.Add("ALTER TABLE `" + tablaAsistencia + "` ADD PRIMARY KEY( `id_asistencia`, `id_asistente`);");

                querylist.Add("ALTER TABLE `" + rToma + "` ADD PRIMARY KEY( `idhrrefri`, `idasistente`);");

                con.Close();

                con.Open();

                MySqlCommand acQuery;

                foreach (string q in querylist)
                {
                    acQuery = new MySqlCommand(q, con);
                    acQuery.ExecuteNonQuery();

                }
                #endregion

                #region Insercion de las horas

                foreach (HoraToma h in listBox1.Items)
                {
                    string nombrehora = h.texto;
                    acQuery = new MySqlCommand("INSERT INTO " + asistenciaNombre + " (nombre) VALUES ('" + nombrehora + "');", con);
                    acQuery.ExecuteNonQuery();
                }

                foreach (HoraToma h in listBox2.Items)
                {
                    string nombrehora = h.texto;
                    acQuery = new MySqlCommand("INSERT INTO " + horasRefrigerio + " (nombre) VALUES ('" + nombrehora + "');", con);
                    acQuery.ExecuteNonQuery();
                }

                #endregion

                con.Close();
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Se creo el evento");
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
           

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
