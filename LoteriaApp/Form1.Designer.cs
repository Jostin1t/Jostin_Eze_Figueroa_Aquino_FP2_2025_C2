namespace LoteriaApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtGanado = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblGanado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(30, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);

            // txtMonto
            this.txtMonto.Location = new System.Drawing.Point(150, 30);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 22);

            // btnJugar
            this.btnJugar.Location = new System.Drawing.Point(270, 28);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 25);
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);

            // txtNum1
            this.txtNum1.Location = new System.Drawing.Point(30, 80);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.ReadOnly = true;
            this.txtNum1.Size = new System.Drawing.Size(75, 22);

            // txtNum2
            this.txtNum2.Location = new System.Drawing.Point(120, 80);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.ReadOnly = true;
            this.txtNum2.Size = new System.Drawing.Size(75, 22);

            // txtNum3
            this.txtNum3.Location = new System.Drawing.Point(210, 80);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.ReadOnly = true;
            this.txtNum3.Size = new System.Drawing.Size(75, 22);

            // txtGanado
            this.txtGanado.Location = new System.Drawing.Point(30, 130);
            this.txtGanado.Name = "txtGanado";
            this.txtGanado.ReadOnly = true;
            this.txtGanado.Size = new System.Drawing.Size(150, 22);

            // lblNumero
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(30, 10);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Text = "Número (0-100)";

            // lblMonto
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(150, 10);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Text = "Monto a jugar";

            // lblGanado
            this.lblGanado.AutoSize = true;
            this.lblGanado.Location = new System.Drawing.Point(30, 110);
            this.lblGanado.Name = "lblGanado";
            this.lblGanado.Text = "Monto ganado";

            // Form1
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtGanado);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblGanado);
            this.Name = "Form1";
            this.Text = "Lotería";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtGanado;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblGanado;
    }
}