﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Frm_crystal
{
    public class Escriure
    {
        public List<char> misatge;
        public Label label;
        public PictureBox pictbox;
        public string path;
        public void EscriureFuncio()
        {
            Random rnd = new Random();
            label.Text = "";
       

            foreach (char lletra in misatge)
            {
                Thread.Sleep(50 * rnd.Next(1,4));
                label.Text += lletra;
                label.Refresh();
            }

        }
        public void canviImatge()
        {
            pictbox.ImageLocation = Application.StartupPath + "\\Planetes\\" + path;
            pictbox.Refresh();
        }
    }
}
