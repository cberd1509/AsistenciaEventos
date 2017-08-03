namespace MegamusicAsistencia
{
    partial class ucAddAsistente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddAsistente));
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btEnviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.lbWelcome.Location = new System.Drawing.Point(194, 92);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(618, 90);
            this.lbWelcome.TabIndex = 1;
            this.lbWelcome.Text = "Haz click en el siguiente botón para cargar\r\nel archivo .CSV con los asistentes d" +
    "el evento.\r\nSi necesitas el modelo del archivo, haz click en el botón de ayuda";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbWelcome.Click += new System.EventHandler(this.lbWelcome_Click);
            // 
            // btEnviar
            // 
            this.btEnviar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.btEnviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.btEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEnviar.BorderRadius = 0;
            this.btEnviar.ButtonText = "Enviar Datos";
            this.btEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnviar.DisabledColor = System.Drawing.Color.Gray;
            this.btEnviar.Iconcolor = System.Drawing.Color.Transparent;
            this.btEnviar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btEnviar.Iconimage")));
            this.btEnviar.Iconimage_right = null;
            this.btEnviar.Iconimage_right_Selected = null;
            this.btEnviar.Iconimage_Selected = null;
            this.btEnviar.IconMarginLeft = 0;
            this.btEnviar.IconMarginRight = 0;
            this.btEnviar.IconRightVisible = false;
            this.btEnviar.IconRightZoom = 0D;
            this.btEnviar.IconVisible = false;
            this.btEnviar.IconZoom = 90D;
            this.btEnviar.IsTab = false;
            this.btEnviar.Location = new System.Drawing.Point(735, 480);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.btEnviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.btEnviar.OnHoverTextColor = System.Drawing.Color.White;
            this.btEnviar.selected = false;
            this.btEnviar.Size = new System.Drawing.Size(170, 44);
            this.btEnviar.TabIndex = 3;
            this.btEnviar.Text = "Enviar Datos";
            this.btEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btEnviar.Textcolor = System.Drawing.Color.White;
            this.btEnviar.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Cargar Excel";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(408, 194);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(170, 44);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "Cargar Excel";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos CSV | *.csv";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // dgLista
            // 
            this.dgLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Location = new System.Drawing.Point(106, 248);
            this.dgLista.Name = "dgLista";
            this.dgLista.Size = new System.Drawing.Size(799, 226);
            this.dgLista.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Columna de Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 487);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(518, 487);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Columna de Documento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::ControlAsistencia.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(302, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ucAddAsistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.lbWelcome);
            this.Name = "ucAddAsistente";
            this.Size = new System.Drawing.Size(1002, 548);
            this.Load += new System.EventHandler(this.ucAddAsistente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private Bunifu.Framework.UI.BunifuFlatButton btEnviar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
