namespace parcialTEMA2form
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
            btnBorrar = new Button();
            btnCancelar = new Button();
            btnOK = new Button();
            dgvMedidas = new DataGridView();
            colAltura = new DataGridViewTextBoxColumn();
            colRadio = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colBase = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            txtRadio = new TextBox();
            label2 = new Label();
            txtAltura = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMedidas).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(350, 7);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 60);
            btnBorrar.TabIndex = 13;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(172, 87);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 60);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(15, 87);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(103, 60);
            btnOK.TabIndex = 11;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // dgvMedidas
            // 
            dgvMedidas.AllowUserToAddRows = false;
            dgvMedidas.AllowUserToDeleteRows = false;
            dgvMedidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedidas.Columns.AddRange(new DataGridViewColumn[] { colAltura, colRadio, colArea, colBase, colVolumen });
            dgvMedidas.Location = new Point(-57, 176);
            dgvMedidas.Name = "dgvMedidas";
            dgvMedidas.ReadOnly = true;
            dgvMedidas.RowHeadersWidth = 51;
            dgvMedidas.RowTemplate.Height = 29;
            dgvMedidas.Size = new Size(900, 296);
            dgvMedidas.TabIndex = 9;
            dgvMedidas.CellContentClick += dgvMedidas_CellContentClick;
            // 
            // colAltura
            // 
            colAltura.HeaderText = "Altura";
            colAltura.MinimumWidth = 6;
            colAltura.Name = "colAltura";
            colAltura.ReadOnly = true;
            colAltura.Width = 125;
            // 
            // colRadio
            // 
            colRadio.HeaderText = "Radio";
            colRadio.MinimumWidth = 6;
            colRadio.Name = "colRadio";
            colRadio.ReadOnly = true;
            colRadio.Width = 125;
            // 
            // colArea
            // 
            colArea.HeaderText = "Area";
            colArea.MinimumWidth = 6;
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            colArea.Width = 125;
            // 
            // colBase
            // 
            colBase.HeaderText = "Base";
            colBase.MinimumWidth = 6;
            colBase.Name = "colBase";
            colBase.ReadOnly = true;
            colBase.Width = 125;
            // 
            // colVolumen
            // 
            colVolumen.HeaderText = "Volumen";
            colVolumen.MinimumWidth = 6;
            colVolumen.Name = "colVolumen";
            colVolumen.ReadOnly = true;
            colVolumen.Width = 125;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(89, 24);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(125, 27);
            txtRadio.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1, 25);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 6;
            label2.Text = "Altura:";
            label2.Click += label2_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(89, -28);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, -27);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 7;
            label1.Text = "Altura:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrar);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(dgvMedidas);
            Controls.Add(txtRadio);
            Controls.Add(label2);
            Controls.Add(txtAltura);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMedidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrar;
        private Button btnCancelar;
        private Button btnOK;
        private DataGridView dgvMedidas;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn colRadio;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colBase;
        private DataGridViewTextBoxColumn colVolumen;
        private TextBox txtRadio;
        private Label label2;
        private TextBox txtAltura;
        private Label label1;
    }
}