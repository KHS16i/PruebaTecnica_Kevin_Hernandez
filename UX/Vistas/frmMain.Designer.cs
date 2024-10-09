namespace UX.Vistas
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSaldos = new System.Windows.Forms.TextBox();
            this.btnAsignarSaldos = new System.Windows.Forms.Button();
            this.dgvSaldosAsignados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldosAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSaldos);
            this.groupBox1.Controls.Add(this.btnAsignarSaldos);
            this.groupBox1.Controls.Add(this.dgvSaldosAsignados);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 615);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtSaldos
            // 
            this.txtSaldos.Location = new System.Drawing.Point(6, 47);
            this.txtSaldos.Multiline = true;
            this.txtSaldos.Name = "txtSaldos";
            this.txtSaldos.ReadOnly = true;
            this.txtSaldos.Size = new System.Drawing.Size(509, 90);
            this.txtSaldos.TabIndex = 2;
            // 
            // btnAsignarSaldos
            // 
            this.btnAsignarSaldos.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarSaldos.Location = new System.Drawing.Point(197, 171);
            this.btnAsignarSaldos.Name = "btnAsignarSaldos";
            this.btnAsignarSaldos.Size = new System.Drawing.Size(131, 42);
            this.btnAsignarSaldos.TabIndex = 1;
            this.btnAsignarSaldos.Text = "Asignar Saldos";
            this.btnAsignarSaldos.UseVisualStyleBackColor = true;
            this.btnAsignarSaldos.Click += new System.EventHandler(this.btnAsignarSaldos_Click);
            // 
            // dgvSaldosAsignados
            // 
            this.dgvSaldosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaldosAsignados.Location = new System.Drawing.Point(73, 242);
            this.dgvSaldosAsignados.Name = "dgvSaldosAsignados";
            this.dgvSaldosAsignados.RowHeadersWidth = 51;
            this.dgvSaldosAsignados.RowTemplate.Height = 24;
            this.dgvSaldosAsignados.Size = new System.Drawing.Size(378, 348);
            this.dgvSaldosAsignados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldos sin Asignar";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(545, 639);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba Tecnica Netforemost | Kevin Hernández Sandi";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldosAsignados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSaldosAsignados;
        private System.Windows.Forms.Button btnAsignarSaldos;
        private System.Windows.Forms.TextBox txtSaldos;
        private System.Windows.Forms.Label label1;
    }
}