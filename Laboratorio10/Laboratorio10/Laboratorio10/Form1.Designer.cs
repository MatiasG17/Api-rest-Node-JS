namespace Laboratorio10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cboSabor = new ComboBox();
            groupBox1 = new GroupBox();
            rbVaso = new RadioButton();
            rbCopa = new RadioButton();
            label3 = new Label();
            nudCantidad = new NumericUpDown();
            groupBox2 = new GroupBox();
            chkFudge = new CheckBox();
            chkDulces = new CheckBox();
            chkWafer = new CheckBox();
            btnCalcular = new Button();
            txtTotal = new TextBox();
            txtTipo = new TextBox();
            txtWafer = new TextBox();
            txtDulces = new TextBox();
            txtFudge = new TextBox();
            txtCantidad = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 25);
            label1.TabIndex = 0;
            label1.Text = "HELADERIA DONFRIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 59);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 1;
            label2.Text = "Sabor";
            // 
            // cboSabor
            // 
            cboSabor.FormattingEnabled = true;
            cboSabor.Items.AddRange(new object[] { "Chocolate", "Fresa", "Lucuma", "Vainilla" });
            cboSabor.Location = new Point(131, 59);
            cboSabor.Name = "cboSabor";
            cboSabor.Size = new Size(125, 23);
            cboSabor.TabIndex = 2;
            cboSabor.SelectedIndexChanged += cboSabor_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbVaso);
            groupBox1.Controls.Add(rbCopa);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 58);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // rbVaso
            // 
            rbVaso.AutoSize = true;
            rbVaso.Location = new Point(102, 24);
            rbVaso.Name = "rbVaso";
            rbVaso.Size = new Size(64, 25);
            rbVaso.TabIndex = 1;
            rbVaso.TabStop = true;
            rbVaso.Text = "Vaso";
            rbVaso.UseVisualStyleBackColor = true;
            rbVaso.CheckedChanged += rbVaso_CheckedChanged;
            // 
            // rbCopa
            // 
            rbCopa.AutoSize = true;
            rbCopa.Location = new Point(10, 24);
            rbCopa.Name = "rbCopa";
            rbCopa.Size = new Size(67, 25);
            rbCopa.TabIndex = 0;
            rbCopa.TabStop = true;
            rbCopa.Text = "Copa";
            rbCopa.UseVisualStyleBackColor = true;
            rbCopa.CheckedChanged += rbCopa_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 108);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(136, 108);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 5;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkFudge);
            groupBox2.Controls.Add(chkDulces);
            groupBox2.Controls.Add(chkWafer);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 109);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opciones";
            // 
            // chkFudge
            // 
            chkFudge.AutoSize = true;
            chkFudge.Location = new Point(43, 71);
            chkFudge.Name = "chkFudge";
            chkFudge.Size = new Size(60, 19);
            chkFudge.TabIndex = 2;
            chkFudge.Text = "Fudge";
            chkFudge.UseVisualStyleBackColor = true;
            chkFudge.CheckedChanged += chkFudge_CheckedChanged;
            // 
            // chkDulces
            // 
            chkDulces.AutoSize = true;
            chkDulces.Location = new Point(43, 46);
            chkDulces.Name = "chkDulces";
            chkDulces.Size = new Size(123, 19);
            chkDulces.TabIndex = 1;
            chkDulces.Text = "Dulces de colores";
            chkDulces.UseVisualStyleBackColor = true;
            chkDulces.CheckedChanged += chkDulces_CheckedChanged;
            // 
            // chkWafer
            // 
            chkWafer.AutoSize = true;
            chkWafer.Location = new Point(43, 21);
            chkWafer.Name = "chkWafer";
            chkWafer.Size = new Size(61, 19);
            chkWafer.TabIndex = 0;
            chkWafer.Text = "Wafer";
            chkWafer.UseVisualStyleBackColor = true;
            chkWafer.CheckedChanged += chkWafer_CheckedChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(78, 325);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(136, 28);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular  Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(272, 329);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 8;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(272, 172);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 9;
            // 
            // txtWafer
            // 
            txtWafer.Location = new Point(272, 227);
            txtWafer.Name = "txtWafer";
            txtWafer.Size = new Size(100, 23);
            txtWafer.TabIndex = 10;
            // 
            // txtDulces
            // 
            txtDulces.Location = new Point(272, 252);
            txtDulces.Name = "txtDulces";
            txtDulces.Size = new Size(100, 23);
            txtDulces.TabIndex = 11;
            // 
            // txtFudge
            // 
            txtFudge.Location = new Point(273, 279);
            txtFudge.Name = "txtFudge";
            txtFudge.Size = new Size(100, 23);
            txtFudge.TabIndex = 12;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(272, 110);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 13;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 361);
            Controls.Add(txtCantidad);
            Controls.Add(txtFudge);
            Controls.Add(txtDulces);
            Controls.Add(txtWafer);
            Controls.Add(txtTipo);
            Controls.Add(txtTotal);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox2);
            Controls.Add(nudCantidad);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(cboSabor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboSabor;
        private GroupBox groupBox1;
        private RadioButton rbVaso;
        private RadioButton rbCopa;
        private Label label3;
        private NumericUpDown nudCantidad;
        private GroupBox groupBox2;
        private CheckBox chkFudge;
        private CheckBox chkDulces;
        private CheckBox chkWafer;
        private Button btnCalcular;
        private TextBox txtTotal;
        private TextBox txtTipo;
        private TextBox txtWafer;
        private TextBox txtDulces;
        private TextBox txtFudge;
        private TextBox txtCantidad;
    }
}
