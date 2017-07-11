using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegamusicAsistencia
{
    public partial class ChooseDate : Form
    {
        public string NombreEvento{get; set;}
        public DateTime HoraFecha { get; set; }

        public ChooseDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NombreEvento = textBox1.Text;
            HoraFecha = dateTimePicker1.Value;
        }
    }
}
