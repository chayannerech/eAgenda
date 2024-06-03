namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaAtualizacaoDeItemTarefa
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
            labelTituloTarefa = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            label1 = new Label();
            listItensTarefa = new CheckedListBox();
            SuspendLayout();
            // 
            // labelTituloTarefa
            // 
            labelTituloTarefa.AutoSize = true;
            labelTituloTarefa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloTarefa.Location = new Point(54, 15);
            labelTituloTarefa.Name = "labelTituloTarefa";
            labelTituloTarefa.Size = new Size(85, 15);
            labelTituloTarefa.TabIndex = 21;
            labelTituloTarefa.Text = "[Título Tarefa]";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(193, 221);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(274, 221);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 20;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 15);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 14;
            label1.Text = "Tarefa:";
            // 
            // listItensTarefa
            // 
            listItensTarefa.FormattingEnabled = true;
            listItensTarefa.Location = new Point(12, 44);
            listItensTarefa.Name = "listItensTarefa";
            listItensTarefa.Size = new Size(337, 166);
            listItensTarefa.TabIndex = 22;
            // 
            // TelaAtualizacaoDeItemTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 255);
            Controls.Add(listItensTarefa);
            Controls.Add(labelTituloTarefa);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAtualizacaoDeItemTarefa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Atualizacao dos Itens da Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTituloTarefa;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label1;
        private CheckedListBox listItensTarefa;
    }
}