namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            txtId = new TextBox();
            label1 = new Label();
            txtTitulo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbPrioridades = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(195, 134);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(276, 134);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(78, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(49, 23);
            txtId.TabIndex = 15;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 26);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 14;
            label1.Text = "Id:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(78, 52);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(266, 23);
            txtTitulo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 55);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 26;
            label2.Text = "Título:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 84);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 32;
            label3.Text = "Prioridade:";
            // 
            // cmbPrioridades
            // 
            cmbPrioridades.FormattingEnabled = true;
            cmbPrioridades.Location = new Point(77, 81);
            cmbPrioridades.Name = "cmbPrioridades";
            cmbPrioridades.Size = new Size(121, 23);
            cmbPrioridades.TabIndex = 37;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 169);
            Controls.Add(cmbPrioridades);
            Controls.Add(label3);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTarefaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtId;
        private Label label1;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpData;
        private TextBox txtTitulo;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label3;
        private ComboBox cmbPrioridades;
        private Label label6;
        private Button button1;
        private ListBox listBox1;
    }
}