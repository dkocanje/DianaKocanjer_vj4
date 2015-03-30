namespace loto
{
    partial class FrmLoto
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
            this.groupBoxUplaceni = new System.Windows.Forms.GroupBox();
            this.txtUplaceniBrojX = new System.Windows.Forms.TextBox();
            this.btnUplati = new System.Windows.Forms.Button();
            this.groupBoxDobitni = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOdigraj = new System.Windows.Forms.Button();
            this.lblNatipis = new System.Windows.Forms.Label();
            this.lblBrojPogodaka = new System.Windows.Forms.Label();
            this.txtDobitniBrojX = new System.Windows.Forms.TextBox();
            this.groupBoxUplaceni.SuspendLayout();
            this.groupBoxDobitni.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUplaceni
            // 
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBrojX);
            this.groupBoxUplaceni.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUplaceni.Name = "groupBoxUplaceni";
            this.groupBoxUplaceni.Size = new System.Drawing.Size(344, 68);
            this.groupBoxUplaceni.TabIndex = 0;
            this.groupBoxUplaceni.TabStop = false;
            this.groupBoxUplaceni.Text = "Uplacena kombinacija";
            // 
            // txtUplaceniBrojX
            // 
            this.txtUplaceniBrojX.Location = new System.Drawing.Point(12, 28);
            this.txtUplaceniBrojX.Name = "txtUplaceniBrojX";
            this.txtUplaceniBrojX.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBrojX.TabIndex = 0;
            this.txtUplaceniBrojX.TextChanged += new System.EventHandler(this.txtUplaceniBrojX_TextChanged);
            // 
            // btnUplati
            // 
            this.btnUplati.Location = new System.Drawing.Point(269, 74);
            this.btnUplati.Name = "btnUplati";
            this.btnUplati.Size = new System.Drawing.Size(75, 23);
            this.btnUplati.TabIndex = 1;
            this.btnUplati.Text = "Uplati";
            this.btnUplati.UseVisualStyleBackColor = true;
            // 
            // groupBoxDobitni
            // 
            this.groupBoxDobitni.Controls.Add(this.txtDobitniBrojX);
            this.groupBoxDobitni.Location = new System.Drawing.Point(12, 113);
            this.groupBoxDobitni.Name = "groupBoxDobitni";
            this.groupBoxDobitni.Size = new System.Drawing.Size(332, 70);
            this.groupBoxDobitni.TabIndex = 2;
            this.groupBoxDobitni.TabStop = false;
            this.groupBoxDobitni.Text = "Dobitna kombinacija";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 309);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnOdigraj
            // 
            this.btnOdigraj.Location = new System.Drawing.Point(269, 187);
            this.btnOdigraj.Name = "btnOdigraj";
            this.btnOdigraj.Size = new System.Drawing.Size(75, 23);
            this.btnOdigraj.TabIndex = 4;
            this.btnOdigraj.Text = "Odigraj";
            this.btnOdigraj.UseVisualStyleBackColor = true;
            // 
            // lblNatipis
            // 
            this.lblNatipis.AutoSize = true;
            this.lblNatipis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNatipis.Location = new System.Drawing.Point(12, 235);
            this.lblNatipis.Name = "lblNatipis";
            this.lblNatipis.Size = new System.Drawing.Size(89, 13);
            this.lblNatipis.TabIndex = 5;
            this.lblNatipis.Text = "Broj pogodaka";
            // 
            // lblBrojPogodaka
            // 
            this.lblBrojPogodaka.AutoSize = true;
            this.lblBrojPogodaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojPogodaka.Location = new System.Drawing.Point(107, 235);
            this.lblBrojPogodaka.Name = "lblBrojPogodaka";
            this.lblBrojPogodaka.Size = new System.Drawing.Size(14, 13);
            this.lblBrojPogodaka.TabIndex = 6;
            this.lblBrojPogodaka.Text = "0";
            // 
            // txtDobitniBrojX
            // 
            this.txtDobitniBrojX.Location = new System.Drawing.Point(6, 32);
            this.txtDobitniBrojX.Name = "txtDobitniBrojX";
            this.txtDobitniBrojX.ReadOnly = true;
            this.txtDobitniBrojX.Size = new System.Drawing.Size(40, 20);
            this.txtDobitniBrojX.TabIndex = 7;
            // 
            // FrmLoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 282);
            this.Controls.Add(this.lblBrojPogodaka);
            this.Controls.Add(this.lblNatipis);
            this.Controls.Add(this.btnOdigraj);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBoxDobitni);
            this.Controls.Add(this.btnUplati);
            this.Controls.Add(this.groupBoxUplaceni);
            this.Name = "FrmLoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOTO 7/39";
            this.groupBoxUplaceni.ResumeLayout(false);
            this.groupBoxUplaceni.PerformLayout();
            this.groupBoxDobitni.ResumeLayout(false);
            this.groupBoxDobitni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUplaceni;
        private System.Windows.Forms.TextBox txtUplaceniBrojX;
        private System.Windows.Forms.Button btnUplati;
        private System.Windows.Forms.GroupBox groupBoxDobitni;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOdigraj;
        private System.Windows.Forms.Label lblNatipis;
        private System.Windows.Forms.Label lblBrojPogodaka;
        private System.Windows.Forms.TextBox txtDobitniBrojX;

    }
}

