namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromisso
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
            groupBox1 = new GroupBox();
            rdbCompromissosFuturos = new RadioButton();
            rdbCompromissosPassados = new RadioButton();
            rdbTodosCompromissos = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(192, 172);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(285, 172);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(86, 31);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Selecionar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbCompromissosFuturos);
            groupBox1.Controls.Add(rdbCompromissosPassados);
            groupBox1.Controls.Add(rdbTodosCompromissos);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(251, 124);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione um filtro:";
            // 
            // rdbCompromissosFuturos
            // 
            rdbCompromissosFuturos.AutoSize = true;
            rdbCompromissosFuturos.Location = new Point(37, 87);
            rdbCompromissosFuturos.Name = "rdbCompromissosFuturos";
            rdbCompromissosFuturos.Size = new Size(175, 24);
            rdbCompromissosFuturos.TabIndex = 2;
            rdbCompromissosFuturos.TabStop = true;
            rdbCompromissosFuturos.Text = "Compromissos futuros";
            rdbCompromissosFuturos.UseVisualStyleBackColor = true;
            // 
            // rdbCompromissosPassados
            // 
            rdbCompromissosPassados.AutoSize = true;
            rdbCompromissosPassados.Location = new Point(37, 57);
            rdbCompromissosPassados.Name = "rdbCompromissosPassados";
            rdbCompromissosPassados.Size = new Size(190, 24);
            rdbCompromissosPassados.TabIndex = 1;
            rdbCompromissosPassados.TabStop = true;
            rdbCompromissosPassados.Text = "Compromissos passados";
            rdbCompromissosPassados.UseVisualStyleBackColor = true;
            // 
            // rdbTodosCompromissos
            // 
            rdbTodosCompromissos.AutoSize = true;
            rdbTodosCompromissos.Location = new Point(37, 27);
            rdbTodosCompromissos.Name = "rdbTodosCompromissos";
            rdbTodosCompromissos.Size = new Size(186, 24);
            rdbTodosCompromissos.TabIndex = 0;
            rdbTodosCompromissos.TabStop = true;
            rdbTodosCompromissos.Text = "Todos os compromissos";
            rdbTodosCompromissos.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroCompromisso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 216);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromisso";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Filtro de registros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private GroupBox groupBox1;
        private RadioButton rdbTodosCompromissos;
        private RadioButton rdbCompromissosFuturos;
        private RadioButton rdbCompromissosPassados;
    }
}