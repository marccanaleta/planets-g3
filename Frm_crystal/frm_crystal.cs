using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SdSData;

namespace Frm_crystal
{
    public partial class frm_crystal : Form
    {
        public string planeta;
        public frm_crystal()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SdSData.SQL db = new SQL();
            db.Conexion();
            DataTable dt = new DataTable();
            dt = db.PortarPerConsulta("SELECT DISTINCT \"Planets\".\"DescPlanet\", \"Planets\".\"idPlanet\"  FROM   (((\"StarWarsOrders\".\"dbo\".\"OrderDetails\" \"OrderDetails\" INNER JOIN \"StarWarsOrders\".\"dbo\".\"Products\" \"Products\" ON \"OrderDetails\".\"ProductID\"=\"Products\".\"ProductID\") INNER JOIN \"StarWarsOrders\".\"dbo\".\"Orders\" \"Orders\" ON \"OrderDetails\".\"OrderID\"=\"Orders\".\"OrderID\") INNER JOIN \"StarWarsOrders\".\"dbo\".\"Categories\" \"Categories\" ON \"Products\".\"CategoryID\"=\"Categories\".\"CategoryID\") INNER JOIN \"StarWarsOrders\".\"dbo\".\"Planets\" \"Planets\" ON \"Orders\".\"PlanetID\"=\"Planets\".\"idPlanet\" ORDER BY \"Planets\".\"DescPlanet\"");
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "DescPlanet";
            comboBox1.ValueMember = "idPlanet";
            Llista1.SetDatabaseLogon("sa","123456aA!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            planeta = comboBox1.Text;
            Console.WriteLine(planeta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Llista rpt = new Llista();
            rpt.RecordSelectionFormula = "{Planets.DescPlanet} = \"" + planeta + "\"";
            rpt.SetDatabaseLogon("sa", "123456aA!");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            Llista1.Refresh();
        }
    }
}
