namespace Ejercicio1
{
    partial class FormPrincipal
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
            dtpVencimiento = new DateTimePicker();
            btnConfirmar = new Button();
            tbPatente = new TextBox();
            tbImporte = new TextBox();
            btnActualizar = new Button();
            lstVer = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnImporte = new Button();
            btnExportar = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.CustomFormat = "dd/MM/yyyy";
            dtpVencimiento.Format = DateTimePickerFormat.Custom;
            dtpVencimiento.Location = new Point(149, 69);
            dtpVencimiento.Margin = new Padding(4);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(127, 29);
            dtpVencimiento.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(464, 50);
            btnConfirmar.Margin = new Padding(4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(103, 47);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(149, 32);
            tbPatente.Margin = new Padding(4);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(127, 29);
            tbPatente.TabIndex = 4;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(149, 106);
            tbImporte.Margin = new Padding(4);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(127, 29);
            tbImporte.TabIndex = 5;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(464, 163);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(96, 48);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lstVer
            // 
            lstVer.FormattingEnabled = true;
            lstVer.ItemHeight = 21;
            lstVer.Location = new Point(23, 151);
            lstVer.Margin = new Padding(4);
            lstVer.Name = "lstVer";
            lstVer.Size = new Size(433, 193);
            lstVer.TabIndex = 7;
            lstVer.SelectedValueChanged += lstVer_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 8;
            label1.Text = "Patente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 9;
            label2.Text = "Vencimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 106);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 10;
            label3.Text = "Importe";
            // 
            // btnImporte
            // 
            btnImporte.Location = new Point(464, 219);
            btnImporte.Margin = new Padding(4);
            btnImporte.Name = "btnImporte";
            btnImporte.Size = new Size(96, 53);
            btnImporte.TabIndex = 11;
            btnImporte.Text = "Importar";
            btnImporte.UseVisualStyleBackColor = true;
            btnImporte.Click += btnImporte_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(464, 280);
            btnExportar.Margin = new Padding(4);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(96, 47);
            btnExportar.TabIndex = 12;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 353);
            Controls.Add(btnExportar);
            Controls.Add(btnImporte);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstVer);
            Controls.Add(btnActualizar);
            Controls.Add(tbImporte);
            Controls.Add(tbPatente);
            Controls.Add(btnConfirmar);
            Controls.Add(dtpVencimiento);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpVencimiento;
        private Button btnConfirmar;
        private TextBox tbPatente;
        private TextBox tbImporte;
        private Button btnActualizar;
        private ListBox lstVer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnImporte;
        private Button btnExportar;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
