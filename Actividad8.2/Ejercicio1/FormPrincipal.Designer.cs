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
            btnConfirmar = new Button();
            lsbVer = new ListBox();
            tbPatente = new TextBox();
            tbImporte = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnActualizar = new Button();
            btnImportar = new Button();
            btnExportar = new Button();
            dtpVencimiento = new DateTimePicker();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(305, 64);
            btnConfirmar.Margin = new Padding(4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(96, 64);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lsbVer
            // 
            lsbVer.FormattingEnabled = true;
            lsbVer.ItemHeight = 21;
            lsbVer.Location = new Point(13, 172);
            lsbVer.Margin = new Padding(4);
            lsbVer.Name = "lsbVer";
            lsbVer.Size = new Size(277, 214);
            lsbVer.TabIndex = 2;
            lsbVer.SelectedIndexChanged += lsbVer_SelectedIndexChanged;
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(132, 29);
            tbPatente.Margin = new Padding(4);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(147, 29);
            tbPatente.TabIndex = 3;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(132, 116);
            tbImporte.Margin = new Padding(4);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(147, 29);
            tbImporte.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 6;
            label1.Text = "Patente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 7;
            label2.Text = "Vencimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 8;
            label3.Text = "Importar";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(305, 172);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(96, 68);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(305, 248);
            btnImportar.Margin = new Padding(4);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(96, 68);
            btnImportar.TabIndex = 9;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(305, 324);
            btnExportar.Margin = new Padding(4);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(96, 68);
            btnExportar.TabIndex = 10;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.CustomFormat = "dd/MM/yyyy";
            dtpVencimiento.Format = DateTimePickerFormat.Custom;
            dtpVencimiento.Location = new Point(132, 71);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(147, 29);
            dtpVencimiento.TabIndex = 12;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 398);
            Controls.Add(dtpVencimiento);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbImporte);
            Controls.Add(tbPatente);
            Controls.Add(lsbVer);
            Controls.Add(btnActualizar);
            Controls.Add(btnConfirmar);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private ListBox lsbVer;
        private TextBox tbPatente;
        private TextBox tbImporte;
        private Label label1;
        private Label label2;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnActualizar;
        private Button btnImportar;
        private Button btnExportar;
        private DateTimePicker dtpVencimiento;
    }
}
