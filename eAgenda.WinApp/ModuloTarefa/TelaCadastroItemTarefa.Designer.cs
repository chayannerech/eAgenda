namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaCadastroItemTarefa
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
            label2 = new Label();
            txtTituloItem = new TextBox();
            btnAdicionar = new Button();
            listItensTarefa = new ListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            labelTituloTarefa = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Tarefa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 49);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Título:";
            // 
            // txtTituloItem
            // 
            txtTituloItem.Location = new Point(58, 46);
            txtTituloItem.Name = "txtTituloItem";
            txtTituloItem.Size = new Size(214, 23);
            txtTituloItem.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(278, 46);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button1_Click;
            // 
            // listItensTarefa
            // 
            listItensTarefa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listItensTarefa.FormattingEnabled = true;
            listItensTarefa.ItemHeight = 15;
            listItensTarefa.Location = new Point(12, 87);
            listItensTarefa.Name = "listItensTarefa";
            listItensTarefa.Size = new Size(341, 124);
            listItensTarefa.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(195, 242);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(276, 242);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // labelTituloTarefa
            // 
            labelTituloTarefa.AutoSize = true;
            labelTituloTarefa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloTarefa.Location = new Point(58, 24);
            labelTituloTarefa.Name = "labelTituloTarefa";
            labelTituloTarefa.Size = new Size(85, 15);
            labelTituloTarefa.TabIndex = 13;
            labelTituloTarefa.Text = "[Título Tarefa]";
            // 
            // TelaCadastroItemTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 277);
            Controls.Add(labelTituloTarefa);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(listItensTarefa);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTituloItem);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroItemTarefa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Itens da Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTituloItem;
        private Button btnAdicionar;
        private ListBox listItensTarefa;
        private Button btnCancelar;
        private Button btnGravar;
        private Label labelTituloTarefa;
    }
}