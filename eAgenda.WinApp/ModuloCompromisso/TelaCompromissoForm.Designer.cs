namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            txtId = new TextBox();
            label1 = new Label();
            txtAssunto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpData = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            label4 = new Label();
            dtpTermino = new DateTimePicker();
            label5 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            checkMarcarContato = new CheckBox();
            rdbRemoto = new RadioButton();
            label6 = new Label();
            rdbPresencial = new RadioButton();
            txtLink = new TextBox();
            txtLocal = new TextBox();
            cmbContatos = new ComboBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(68, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(49, 23);
            txtId.TabIndex = 13;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 28);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 12;
            label1.Text = "Id:";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(68, 54);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(266, 23);
            txtAssunto.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 15;
            label2.Text = "Assunto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 86);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 17;
            label3.Text = "Data:";
            // 
            // dtpData
            // 
            dtpData.Checked = false;
            dtpData.CustomFormat = "dd/MM/yyyy";
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.Location = new Point(68, 83);
            dtpData.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpData.MinDate = new DateTime(2024, 5, 22, 0, 0, 0, 0);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(100, 23);
            dtpData.TabIndex = 1;
            dtpData.Value = new DateTime(2024, 5, 22, 0, 0, 0, 0);
            // 
            // dtpInicio
            // 
            dtpInicio.Checked = false;
            dtpInicio.CustomFormat = "HH:mm";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(68, 112);
            dtpInicio.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpInicio.MinDate = new DateTime(2024, 5, 22, 0, 0, 0, 0);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.ShowUpDown = true;
            dtpInicio.Size = new Size(100, 23);
            dtpInicio.TabIndex = 2;
            dtpInicio.Value = new DateTime(2024, 5, 22, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 116);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 19;
            label4.Text = "Início:";
            // 
            // dtpTermino
            // 
            dtpTermino.Checked = false;
            dtpTermino.CustomFormat = "HH:ss";
            dtpTermino.Format = DateTimePickerFormat.Custom;
            dtpTermino.Location = new Point(234, 113);
            dtpTermino.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTermino.MinDate = new DateTime(2024, 5, 22, 0, 0, 0, 0);
            dtpTermino.Name = "dtpTermino";
            dtpTermino.ShowUpDown = true;
            dtpTermino.Size = new Size(100, 23);
            dtpTermino.TabIndex = 3;
            dtpTermino.Value = new DateTime(2024, 5, 22, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 117);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 21;
            label5.Text = "Término:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(178, 309);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(259, 309);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // checkMarcarContato
            // 
            checkMarcarContato.AutoSize = true;
            checkMarcarContato.Location = new Point(45, 158);
            checkMarcarContato.Name = "checkMarcarContato";
            checkMarcarContato.Size = new Size(277, 19);
            checkMarcarContato.TabIndex = 4;
            checkMarcarContato.Text = "Deseja marcar um contato neste compromisso?";
            checkMarcarContato.UseVisualStyleBackColor = true;
            checkMarcarContato.CheckedChanged += checkMarcarContato_CheckedChanged;
            // 
            // rdbRemoto
            // 
            rdbRemoto.AutoSize = true;
            rdbRemoto.Checked = true;
            rdbRemoto.Location = new Point(51, 236);
            rdbRemoto.Name = "rdbRemoto";
            rdbRemoto.Size = new Size(70, 19);
            rdbRemoto.TabIndex = 5;
            rdbRemoto.TabStop = true;
            rdbRemoto.Text = "Remoto:";
            rdbRemoto.UseVisualStyleBackColor = true;
            rdbRemoto.CheckedChanged += rdbRemoto_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 218);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 27;
            label6.Text = "Localização:";
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Location = new Point(51, 261);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(81, 19);
            rdbPresencial.TabIndex = 6;
            rdbPresencial.TabStop = true;
            rdbPresencial.Text = "Presencial:";
            rdbPresencial.UseVisualStyleBackColor = true;
            rdbPresencial.CheckedChanged += rdbPresencial_CheckedChanged;
            // 
            // txtLink
            // 
            txtLink.Location = new Point(133, 235);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(201, 23);
            txtLink.TabIndex = 29;
            // 
            // txtLocal
            // 
            txtLocal.Enabled = false;
            txtLocal.Location = new Point(133, 260);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(201, 23);
            txtLocal.TabIndex = 30;
            // 
            // cmbContatos
            // 
            cmbContatos.Enabled = false;
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Location = new Point(45, 183);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(149, 23);
            cmbContatos.TabIndex = 31;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 344);
            Controls.Add(cmbContatos);
            Controls.Add(txtLocal);
            Controls.Add(txtLink);
            Controls.Add(rdbPresencial);
            Controls.Add(label6);
            Controls.Add(rdbRemoto);
            Controls.Add(checkMarcarContato);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(dtpTermino);
            Controls.Add(label5);
            Controls.Add(dtpInicio);
            Controls.Add(label4);
            Controls.Add(dtpData);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Compromisso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private TextBox txtAssunto;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpData;
        private DateTimePicker dtpInicio;
        private Label label4;
        private DateTimePicker dtpTermino;
        private Label label5;
        private Button btnCancelar;
        private Button btnGravar;
        private CheckBox checkMarcarContato;
        private RadioButton rdbRemoto;
        private Label label6;
        private RadioButton rdbPresencial;
        private TextBox txtLink;
        private TextBox txtLocal;
        private ComboBox cmbContatos;
    }
}