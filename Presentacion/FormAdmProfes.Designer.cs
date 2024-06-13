namespace Presentacion
{
    partial class FormAdmProfes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGrab = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.dgvProfesionales = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(142, 60);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 26);
            this.txtCod.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(142, 109);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 26);
            this.txtNom.TabIndex = 1;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(41, 63);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(59, 20);
            this.lblCod.TabIndex = 2;
            this.lblCod.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 115);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // btnGrab
            // 
            this.btnGrab.Location = new System.Drawing.Point(93, 199);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(75, 34);
            this.btnGrab.TabIndex = 4;
            this.btnGrab.Text = "Grabar";
            this.btnGrab.UseVisualStyleBackColor = true;
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(192, 199);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(94, 34);
            this.btnModif.TabIndex = 5;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // dgvProfesionales
            // 
            this.dgvProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesionales.Location = new System.Drawing.Point(344, 63);
            this.dgvProfesionales.Name = "dgvProfesionales";
            this.dgvProfesionales.RowHeadersWidth = 62;
            this.dgvProfesionales.RowTemplate.Height = 28;
            this.dgvProfesionales.Size = new System.Drawing.Size(363, 219);
            this.dgvProfesionales.TabIndex = 6;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(49, 313);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(51, 20);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "label1";
            // 
            // FormAdmProfes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvProfesionales);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnGrab);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCod);
            this.Name = "FormAdmProfes";
            this.Text = "FormAdmProfes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGrab;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.DataGridView dgvProfesionales;
        private System.Windows.Forms.Label lblInfo;
    }
}