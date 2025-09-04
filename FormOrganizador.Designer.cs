namespace Organizador_Gama_Center
{
    partial class FormOrganizador
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
            this.components = new System.ComponentModel.Container();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoTreinamento = new System.Windows.Forms.ComboBox();
            this.panelAcoes = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCaminhoPreview = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.panelListaArquivos = new System.Windows.Forms.Panel();
            this.panelArquivos = new System.Windows.Forms.Panel();
            this.lvArquivos = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelFormulario.SuspendLayout();
            this.panelAcoes.SuspendLayout();
            this.panelListaArquivos.SuspendLayout();
            this.panelArquivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.cmbTipoTreinamento);
            this.panelFormulario.Controls.Add(this.label5);
            this.panelFormulario.Controls.Add(this.cmbMes);
            this.panelFormulario.Controls.Add(this.label4);
            this.panelFormulario.Controls.Add(this.cmbEmpresa);
            this.panelFormulario.Controls.Add(this.label3);
            this.panelFormulario.Controls.Add(this.cmbCategoria);
            this.panelFormulario.Controls.Add(this.label2);
            this.panelFormulario.Controls.Add(this.label1);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFormulario.Location = new System.Drawing.Point(0, 0);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(221, 626);
            this.panelFormulario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Classifique os arquivos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria Principal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(16, 77);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(16, 147);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpresa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mês de Referência";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(16, 213);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo de Treinamento:";
            // 
            // cmbTipoTreinamento
            // 
            this.cmbTipoTreinamento.FormattingEnabled = true;
            this.cmbTipoTreinamento.Location = new System.Drawing.Point(16, 284);
            this.cmbTipoTreinamento.Name = "cmbTipoTreinamento";
            this.cmbTipoTreinamento.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTreinamento.TabIndex = 1;
            // 
            // panelAcoes
            // 
            this.panelAcoes.Controls.Add(this.btnSalvar);
            this.panelAcoes.Controls.Add(this.txtCaminhoPreview);
            this.panelAcoes.Controls.Add(this.label6);
            this.panelAcoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAcoes.Location = new System.Drawing.Point(221, 526);
            this.panelAcoes.Name = "panelAcoes";
            this.panelAcoes.Size = new System.Drawing.Size(1013, 100);
            this.panelAcoes.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pasta de Destino";
            // 
            // txtCaminhoPreview
            // 
            this.txtCaminhoPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminhoPreview.Location = new System.Drawing.Point(762, 30);
            this.txtCaminhoPreview.Name = "txtCaminhoPreview";
            this.txtCaminhoPreview.ReadOnly = true;
            this.txtCaminhoPreview.Size = new System.Drawing.Size(100, 20);
            this.txtCaminhoPreview.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(882, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 55);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "SALVAR NO SERVIDOR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "2. Anexe os Arquivos";
            // 
            // panelListaArquivos
            // 
            this.panelListaArquivos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelListaArquivos.Controls.Add(this.lvArquivos);
            this.panelListaArquivos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListaArquivos.Location = new System.Drawing.Point(0, 42);
            this.panelListaArquivos.Name = "panelListaArquivos";
            this.panelListaArquivos.Size = new System.Drawing.Size(1013, 484);
            this.panelListaArquivos.TabIndex = 2;
            // 
            // panelArquivos
            // 
            this.panelArquivos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelArquivos.Controls.Add(this.label7);
            this.panelArquivos.Controls.Add(this.panelListaArquivos);
            this.panelArquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelArquivos.Location = new System.Drawing.Point(221, 0);
            this.panelArquivos.Name = "panelArquivos";
            this.panelArquivos.Size = new System.Drawing.Size(1013, 526);
            this.panelArquivos.TabIndex = 4;
            // 
            // lvArquivos
            // 
            this.lvArquivos.BackColor = System.Drawing.Color.White;
            this.lvArquivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvArquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvArquivos.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.lvArquivos.HideSelection = false;
            this.lvArquivos.LargeImageList = this.imageList1;
            this.lvArquivos.Location = new System.Drawing.Point(0, 0);
            this.lvArquivos.Name = "lvArquivos";
            this.lvArquivos.Size = new System.Drawing.Size(1013, 484);
            this.lvArquivos.SmallImageList = this.imageList1;
            this.lvArquivos.TabIndex = 0;
            this.lvArquivos.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 24);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormOrganizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1234, 626);
            this.Controls.Add(this.panelArquivos);
            this.Controls.Add(this.panelAcoes);
            this.Controls.Add(this.panelFormulario);
            this.Name = "FormOrganizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.panelAcoes.ResumeLayout(false);
            this.panelAcoes.PerformLayout();
            this.panelListaArquivos.ResumeLayout(false);
            this.panelArquivos.ResumeLayout(false);
            this.panelArquivos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbTipoTreinamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelAcoes;
        private System.Windows.Forms.TextBox txtCaminhoPreview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelListaArquivos;
        private System.Windows.Forms.Panel panelArquivos;
        private System.Windows.Forms.ListView lvArquivos;
        private System.Windows.Forms.ImageList imageList1;
    }
}