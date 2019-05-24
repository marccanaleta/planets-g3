namespace selectDDBB
{
    partial class Frm_ventas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ventas));
            this.dgv_select = new System.Windows.Forms.DataGridView();
            this.b_Show_data = new System.Windows.Forms.Button();
            this.tbx_limitofsales = new System.Windows.Forms.TextBox();
            this.cbx_regions = new System.Windows.Forms.ComboBox();
            this.lbl_limit = new System.Windows.Forms.Label();
            this.lbl_regions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_select)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_select
            // 
            this.dgv_select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_select.Location = new System.Drawing.Point(167, 12);
            this.dgv_select.Name = "dgv_select";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_select.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_select.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_select.Size = new System.Drawing.Size(369, 450);
            this.dgv_select.TabIndex = 0;
            // 
            // b_Show_data
            // 
            this.b_Show_data.ForeColor = System.Drawing.Color.Black;
            this.b_Show_data.Location = new System.Drawing.Point(43, 41);
            this.b_Show_data.Name = "b_Show_data";
            this.b_Show_data.Size = new System.Drawing.Size(75, 23);
            this.b_Show_data.TabIndex = 1;
            this.b_Show_data.Text = "Show data";
            this.b_Show_data.UseVisualStyleBackColor = true;
            this.b_Show_data.Click += new System.EventHandler(this.Btn_Showdata_click);
            // 
            // tbx_limitofsales
            // 
            this.tbx_limitofsales.ForeColor = System.Drawing.Color.Black;
            this.tbx_limitofsales.Location = new System.Drawing.Point(90, 154);
            this.tbx_limitofsales.Name = "tbx_limitofsales";
            this.tbx_limitofsales.Size = new System.Drawing.Size(46, 20);
            this.tbx_limitofsales.TabIndex = 2;
            // 
            // cbx_regions
            // 
            this.cbx_regions.FormattingEnabled = true;
            this.cbx_regions.Location = new System.Drawing.Point(17, 104);
            this.cbx_regions.Name = "cbx_regions";
            this.cbx_regions.Size = new System.Drawing.Size(121, 21);
            this.cbx_regions.TabIndex = 3;
            // 
            // lbl_limit
            // 
            this.lbl_limit.AutoSize = true;
            this.lbl_limit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_limit.ForeColor = System.Drawing.Color.White;
            this.lbl_limit.Location = new System.Drawing.Point(14, 157);
            this.lbl_limit.Name = "lbl_limit";
            this.lbl_limit.Size = new System.Drawing.Size(70, 13);
            this.lbl_limit.TabIndex = 4;
            this.lbl_limit.Text = "Limit of sales:";
            // 
            // lbl_regions
            // 
            this.lbl_regions.AutoSize = true;
            this.lbl_regions.BackColor = System.Drawing.Color.Transparent;
            this.lbl_regions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_regions.Location = new System.Drawing.Point(14, 88);
            this.lbl_regions.Name = "lbl_regions";
            this.lbl_regions.Size = new System.Drawing.Size(47, 13);
            this.lbl_regions.TabIndex = 5;
            this.lbl_regions.Text = "Region: ";
            // 
            // p_ventas
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Frm_ventas.Properties.Resources.trailstart;
            this.ClientSize = new System.Drawing.Size(548, 474);
            this.Controls.Add(this.lbl_regions);
            this.Controls.Add(this.lbl_limit);
            this.Controls.Add(this.cbx_regions);
            this.Controls.Add(this.tbx_limitofsales);
            this.Controls.Add(this.b_Show_data);
            this.Controls.Add(this.dgv_select);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "p_ventas";
            this.Text = "Ventas";
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.Load += new System.EventHandler(this.Frm_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_select)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.BindingSource regionsBindingSource;
        private System.Windows.Forms.DataGridView dgv_select;
        private System.Windows.Forms.Button b_Show_data;
        private System.Windows.Forms.TextBox tbx_limitofsales;
        private System.Windows.Forms.ComboBox cbx_regions;
        private System.Windows.Forms.Label lbl_limit;
        private System.Windows.Forms.Label lbl_regions;
    }
}

