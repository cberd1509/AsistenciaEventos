namespace MegamusicAsistencia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btRefrigerios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btAsistencia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btAddAsistentes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btMinimizar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btCerrar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 47);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuFlatButton1);
            this.panel3.Controls.Add(this.btRefrigerios);
            this.panel3.Controls.Add(this.btAsistencia);
            this.panel3.Controls.Add(this.btAddAsistentes);
            this.panel3.Controls.Add(this.btInicio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 47);
            this.panel3.TabIndex = 3;
            // 
            // btRefrigerios
            // 
            this.btRefrigerios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.btRefrigerios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.btRefrigerios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRefrigerios.BorderRadius = 0;
            this.btRefrigerios.ButtonText = "Refrigerios";
            this.btRefrigerios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRefrigerios.DisabledColor = System.Drawing.Color.Gray;
            this.btRefrigerios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRefrigerios.Iconcolor = System.Drawing.Color.Transparent;
            this.btRefrigerios.Iconimage = null;
            this.btRefrigerios.Iconimage_right = null;
            this.btRefrigerios.Iconimage_right_Selected = null;
            this.btRefrigerios.Iconimage_Selected = null;
            this.btRefrigerios.IconMarginLeft = 0;
            this.btRefrigerios.IconMarginRight = 0;
            this.btRefrigerios.IconRightVisible = true;
            this.btRefrigerios.IconRightZoom = 0D;
            this.btRefrigerios.IconVisible = false;
            this.btRefrigerios.IconZoom = 90D;
            this.btRefrigerios.IsTab = true;
            this.btRefrigerios.Location = new System.Drawing.Point(581, 0);
            this.btRefrigerios.Name = "btRefrigerios";
            this.btRefrigerios.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.btRefrigerios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.btRefrigerios.OnHoverTextColor = System.Drawing.Color.White;
            this.btRefrigerios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btRefrigerios.selected = false;
            this.btRefrigerios.Size = new System.Drawing.Size(126, 47);
            this.btRefrigerios.TabIndex = 5;
            this.btRefrigerios.TabStop = false;
            this.btRefrigerios.Text = "Refrigerios";
            this.btRefrigerios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btRefrigerios.Textcolor = System.Drawing.Color.White;
            this.btRefrigerios.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefrigerios.Click += new System.EventHandler(this.btRefrigerios_Click);
            // 
            // btAsistencia
            // 
            this.btAsistencia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.btAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.btAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAsistencia.BorderRadius = 0;
            this.btAsistencia.ButtonText = "Asistencia";
            this.btAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAsistencia.DisabledColor = System.Drawing.Color.Gray;
            this.btAsistencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAsistencia.Iconcolor = System.Drawing.Color.Transparent;
            this.btAsistencia.Iconimage = null;
            this.btAsistencia.Iconimage_right = null;
            this.btAsistencia.Iconimage_right_Selected = null;
            this.btAsistencia.Iconimage_Selected = null;
            this.btAsistencia.IconMarginLeft = 0;
            this.btAsistencia.IconMarginRight = 0;
            this.btAsistencia.IconRightVisible = true;
            this.btAsistencia.IconRightZoom = 0D;
            this.btAsistencia.IconVisible = false;
            this.btAsistencia.IconZoom = 90D;
            this.btAsistencia.IsTab = true;
            this.btAsistencia.Location = new System.Drawing.Point(278, 0);
            this.btAsistencia.Name = "btAsistencia";
            this.btAsistencia.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.btAsistencia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.btAsistencia.OnHoverTextColor = System.Drawing.Color.White;
            this.btAsistencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAsistencia.selected = false;
            this.btAsistencia.Size = new System.Drawing.Size(121, 47);
            this.btAsistencia.TabIndex = 4;
            this.btAsistencia.TabStop = false;
            this.btAsistencia.Text = "Asistencia";
            this.btAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btAsistencia.Textcolor = System.Drawing.Color.White;
            this.btAsistencia.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAsistencia.Click += new System.EventHandler(this.btAsistencia_Click);
            // 
            // btAddAsistentes
            // 
            this.btAddAsistentes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.btAddAsistentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.btAddAsistentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddAsistentes.BorderRadius = 0;
            this.btAddAsistentes.ButtonText = "Añadir Asistentes";
            this.btAddAsistentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddAsistentes.DisabledColor = System.Drawing.Color.Gray;
            this.btAddAsistentes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAddAsistentes.Iconcolor = System.Drawing.Color.Transparent;
            this.btAddAsistentes.Iconimage = null;
            this.btAddAsistentes.Iconimage_right = null;
            this.btAddAsistentes.Iconimage_right_Selected = null;
            this.btAddAsistentes.Iconimage_Selected = null;
            this.btAddAsistentes.IconMarginLeft = 0;
            this.btAddAsistentes.IconMarginRight = 0;
            this.btAddAsistentes.IconRightVisible = true;
            this.btAddAsistentes.IconRightZoom = 0D;
            this.btAddAsistentes.IconVisible = false;
            this.btAddAsistentes.IconZoom = 90D;
            this.btAddAsistentes.IsTab = true;
            this.btAddAsistentes.Location = new System.Drawing.Point(94, 0);
            this.btAddAsistentes.Name = "btAddAsistentes";
            this.btAddAsistentes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.btAddAsistentes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.btAddAsistentes.OnHoverTextColor = System.Drawing.Color.White;
            this.btAddAsistentes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAddAsistentes.selected = false;
            this.btAddAsistentes.Size = new System.Drawing.Size(185, 47);
            this.btAddAsistentes.TabIndex = 3;
            this.btAddAsistentes.TabStop = false;
            this.btAddAsistentes.Text = "Añadir Asistentes";
            this.btAddAsistentes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btAddAsistentes.Textcolor = System.Drawing.Color.White;
            this.btAddAsistentes.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddAsistentes.Click += new System.EventHandler(this.btAddAsistentes_Click);
            // 
            // btInicio
            // 
            this.btInicio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.btInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.btInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInicio.BorderRadius = 0;
            this.btInicio.ButtonText = "Inicio";
            this.btInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btInicio.Iconimage = null;
            this.btInicio.Iconimage_right = null;
            this.btInicio.Iconimage_right_Selected = null;
            this.btInicio.Iconimage_Selected = null;
            this.btInicio.IconMarginLeft = 0;
            this.btInicio.IconMarginRight = 0;
            this.btInicio.IconRightVisible = true;
            this.btInicio.IconRightZoom = 0D;
            this.btInicio.IconVisible = false;
            this.btInicio.IconZoom = 90D;
            this.btInicio.IsTab = true;
            this.btInicio.Location = new System.Drawing.Point(0, 0);
            this.btInicio.Name = "btInicio";
            this.btInicio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.btInicio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.btInicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btInicio.selected = false;
            this.btInicio.Size = new System.Drawing.Size(95, 47);
            this.btInicio.TabIndex = 1;
            this.btInicio.TabStop = false;
            this.btInicio.Text = "Inicio";
            this.btInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btInicio.Textcolor = System.Drawing.Color.White;
            this.btInicio.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicio.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.btMinimizar);
            this.panel2.Controls.Add(this.btCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(878, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 47);
            this.panel2.TabIndex = 2;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::ControlAsistencia.Properties.Resources.iconExcel1;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(55, 47);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btMinimizar
            // 
            this.btMinimizar.AutoSize = true;
            this.btMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimizar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimizar.ForeColor = System.Drawing.Color.White;
            this.btMinimizar.Location = new System.Drawing.Point(62, 3);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(25, 32);
            this.btMinimizar.TabIndex = 2;
            this.btMinimizar.Text = "-";
            this.btMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMinimizar.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.AutoSize = true;
            this.btCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCerrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.ForeColor = System.Drawing.Color.White;
            this.btCerrar.Location = new System.Drawing.Point(93, 9);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(23, 25);
            this.btCerrar.TabIndex = 1;
            this.btCerrar.Text = "X";
            this.btCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCerrar.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // pnContainer
            // 
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 47);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1002, 450);
            this.pnContainer.TabIndex = 1;
            this.pnContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContainer_Paint);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Añadir por Cédula";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(397, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(117)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(185, 47);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.TabStop = false;
            this.bunifuFlatButton1.Text = "Añadir por Cédula";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1002, 497);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Event Manager";
            this.Load += new System.EventHandler(this.CargaFormulario);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btInicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel btCerrar;
        private Bunifu.Framework.UI.BunifuCustomLabel btMinimizar;
        private Bunifu.Framework.UI.BunifuFlatButton btAddAsistentes;
        private Bunifu.Framework.UI.BunifuFlatButton btRefrigerios;
        private Bunifu.Framework.UI.BunifuFlatButton btAsistencia;
        private System.Windows.Forms.Panel pnContainer;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

