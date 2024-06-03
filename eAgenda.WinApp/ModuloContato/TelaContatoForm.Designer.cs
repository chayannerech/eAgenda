namespace eAgenda.WinApp.ModuloContato
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
            label1 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtTelefone = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtCargo = new TextBox();
            label5 = new Label();
            txtEmpresa = new TextBox();
            label6 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 49);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(76, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 11;
            txtId.Text = "0";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(76, 75);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(260, 23);
            txtNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 78);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(76, 104);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(260, 23);
            txtTelefone.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 107);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefone:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(76, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 23);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 136);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(76, 162);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 165);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "Cargo:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(236, 162);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(100, 23);
            txtEmpresa.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 165);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "Empresa:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(283, 239);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(202, 239);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 274);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtEmpresa);
            Controls.Add(label6);
            Controls.Add(txtCargo);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtTelefone;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtCargo;
        private Label label5;
        private TextBox txtEmpresa;
        private Label label6;
        private Button btnGravar;
        private Button btnCancelar;
    }
}