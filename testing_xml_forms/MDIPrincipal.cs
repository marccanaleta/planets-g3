using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SdSData;
using Frm_crystal;
using selectDDBB;
using Frm_crystal;

namespace testing_xml_forms
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
            
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void marcCanaleta_select_Click(object sender, EventArgs e)
        {
            marc_canaleta frm = new marc_canaleta();
            frm.MdiParent = this;
            frm.Show();
            pnl_fons.Controls.Add(frm);
            lbl_text_spain.Visible = false;
            
            
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            pnl_fons.BackColor = Color.FromArgb(24, 24, 24);
            //EscriureSpainWars();
            //Thread carrega = new Thread(new ThreadStart(carregaPunts));
            //carrega.Start();
            
        }

        private void adriaRojo_select_Click(object sender, EventArgs e)
        {
            adri_rojo frm = new adri_rojo();
            frm.MdiParent = this;
            frm.Show();
            lbl_text_spain.Visible = false;
            pnl_fons.Controls.Add(frm);
            
        }


        private void albertoMuñoz_select_Click(object sender, EventArgs e)
        {
            alberto_muñoz frm = new alberto_muñoz();
            frm.MdiParent = this;
            frm.Show();
            lbl_text_spain.Visible = false;
            pnl_fons.Controls.Add(frm);
           
        }

        private void EduMartínez_select_Click(object sender, EventArgs e)
        {
            edu_martinez frm = new edu_martinez();
            frm.MdiParent = this;
            frm.Show();
            lbl_text_spain.Visible = false;
            pnl_fons.Controls.Add(frm);
            
        }
        private void EscriureSpainWars()
        {
            char[] letras;
            letras = new char[] { 'S', 'p', 'a', 'i', 'n', ' ', 'W', 'a', 'r', 's', ' ' };
            
            foreach (char letra in letras)
            {
                Thread.Sleep(220);
                lbl_text_spain.Text += letra;
                lbl_text_spain.Refresh();
	        }
        }
            
        private void carregaPunts()
        {
            do{
                
                for(int i = 0; i < 3; i ++)
                {
                    Thread.Sleep(350);
                    lbl_text_spain.Text += '.';
                    lbl_text_spain.Refresh();
                }
	            for(int i = 0; i < 3; i ++)
                {
                    Thread.Sleep(350);
                    lbl_text_spain.Text = lbl_text_spain.Text.Substring(0, lbl_text_spain.Text.Length - 1);
                    lbl_text_spain.Refresh();
                }
            } while (lbl_text_spain.Visible == true);
            

        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrar_program_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void planetas_open_Click(object sender, EventArgs e)
        {
            Frm_crystal.Frm_dadesPlanetes frm;
            frm = new Frm_crystal.Frm_dadesPlanetes();
            frm.MdiParent = this;
            frm.Show();
            lbl_text_spain.Visible = false;
            pnl_fons.Controls.Add(frm);

        }

        private void regiones_open_Click(object sender, EventArgs e)
        {
            Frm_xmlRegions frm = new Frm_xmlRegions();
            frm.MdiParent = this;
            frm.Show();
            lbl_text_spain.Visible = false;
            pnl_fons.Controls.Add(frm);
        }


        private void ventas_open_Click(object sender, EventArgs e)
        {
            selectDDBB.Frm_ventas frm = new selectDDBB.Frm_ventas();
            
            frm.MdiParent = this;
            frm.Show();

            lbl_text_spain.Visible = false;

            pnl_fons.Controls.Add(frm);

        }

        private void crystalreports_open_Click(object sender, EventArgs e)
        {
            frm_crystal frm = new Frm_crystal.frm_crystal();
            frm.MdiParent = this;
            frm.Show();

            lbl_text_spain.Visible = false;

            pnl_fons.Controls.Add(frm);
        }
    }
}
