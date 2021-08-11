
namespace InstaladorServicos
{
    partial class GerenciadorServicos
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
            this.boxProjeto = new System.Windows.Forms.GroupBox();
            this.DuvidaProjeto = new System.Windows.Forms.Button();
            this.DesinstalarServico = new System.Windows.Forms.Button();
            this.InstalarServico = new System.Windows.Forms.Button();
            this.AbrirExploradorArquivos = new System.Windows.Forms.Button();
            this.DiretorioExecutavel = new System.Windows.Forms.TextBox();
            this.BuscaArquivo = new System.Windows.Forms.OpenFileDialog();
            this.boxServicos = new System.Windows.Forms.GroupBox();
            this.RemoverServico = new System.Windows.Forms.Button();
            this.DuvidaServicos = new System.Windows.Forms.Button();
            this.PararServico = new System.Windows.Forms.Button();
            this.IniciarServico = new System.Windows.Forms.Button();
            this.ListaServicos = new System.Windows.Forms.CheckedListBox();
            this.boxProcessos = new System.Windows.Forms.GroupBox();
            this.DuvidaTaskKill = new System.Windows.Forms.Button();
            this.TaskKill = new System.Windows.Forms.Button();
            this.ListaProcessos = new System.Windows.Forms.CheckedListBox();
            this.boxProjeto.SuspendLayout();
            this.boxServicos.SuspendLayout();
            this.boxProcessos.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxProjeto
            // 
            this.boxProjeto.Controls.Add(this.DuvidaProjeto);
            this.boxProjeto.Controls.Add(this.DesinstalarServico);
            this.boxProjeto.Controls.Add(this.InstalarServico);
            this.boxProjeto.Controls.Add(this.AbrirExploradorArquivos);
            this.boxProjeto.Controls.Add(this.DiretorioExecutavel);
            this.boxProjeto.Location = new System.Drawing.Point(12, 12);
            this.boxProjeto.Name = "boxProjeto";
            this.boxProjeto.Size = new System.Drawing.Size(827, 95);
            this.boxProjeto.TabIndex = 0;
            this.boxProjeto.TabStop = false;
            this.boxProjeto.Text = "Projeto";
            // 
            // DuvidaProjeto
            // 
            this.DuvidaProjeto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DuvidaProjeto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DuvidaProjeto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DuvidaProjeto.Location = new System.Drawing.Point(783, 13);
            this.DuvidaProjeto.Name = "DuvidaProjeto";
            this.DuvidaProjeto.Size = new System.Drawing.Size(38, 30);
            this.DuvidaProjeto.TabIndex = 4;
            this.DuvidaProjeto.Text = "?";
            this.DuvidaProjeto.UseVisualStyleBackColor = false;
            this.DuvidaProjeto.Click += new System.EventHandler(this.DuvidaProjeto_Click);
            // 
            // DesinstalarServico
            // 
            this.DesinstalarServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DesinstalarServico.Location = new System.Drawing.Point(653, 29);
            this.DesinstalarServico.Name = "DesinstalarServico";
            this.DesinstalarServico.Size = new System.Drawing.Size(100, 35);
            this.DesinstalarServico.TabIndex = 3;
            this.DesinstalarServico.Text = "Desinstalar";
            this.DesinstalarServico.UseVisualStyleBackColor = true;
            this.DesinstalarServico.Click += new System.EventHandler(this.DesinstalarServico_Click);
            // 
            // InstalarServico
            // 
            this.InstalarServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstalarServico.Location = new System.Drawing.Point(535, 29);
            this.InstalarServico.Name = "InstalarServico";
            this.InstalarServico.Size = new System.Drawing.Size(100, 35);
            this.InstalarServico.TabIndex = 2;
            this.InstalarServico.Text = "Instalar";
            this.InstalarServico.UseVisualStyleBackColor = true;
            this.InstalarServico.Click += new System.EventHandler(this.InstalarServico_Click);
            // 
            // AbrirExploradorArquivos
            // 
            this.AbrirExploradorArquivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbrirExploradorArquivos.Location = new System.Drawing.Point(487, 36);
            this.AbrirExploradorArquivos.Name = "AbrirExploradorArquivos";
            this.AbrirExploradorArquivos.Size = new System.Drawing.Size(31, 23);
            this.AbrirExploradorArquivos.TabIndex = 1;
            this.AbrirExploradorArquivos.Text = "...";
            this.AbrirExploradorArquivos.UseVisualStyleBackColor = true;
            this.AbrirExploradorArquivos.Click += new System.EventHandler(this.AbrirExploradorArquivos_Click);
            // 
            // DiretorioExecutavel
            // 
            this.DiretorioExecutavel.Location = new System.Drawing.Point(7, 36);
            this.DiretorioExecutavel.Name = "DiretorioExecutavel";
            this.DiretorioExecutavel.ReadOnly = true;
            this.DiretorioExecutavel.Size = new System.Drawing.Size(474, 23);
            this.DiretorioExecutavel.TabIndex = 0;
            // 
            // BuscaArquivo
            // 
            this.BuscaArquivo.Filter = ".exe|*exe";
            // 
            // boxServicos
            // 
            this.boxServicos.BackColor = System.Drawing.Color.Silver;
            this.boxServicos.Controls.Add(this.RemoverServico);
            this.boxServicos.Controls.Add(this.DuvidaServicos);
            this.boxServicos.Controls.Add(this.PararServico);
            this.boxServicos.Controls.Add(this.IniciarServico);
            this.boxServicos.Controls.Add(this.ListaServicos);
            this.boxServicos.Location = new System.Drawing.Point(13, 114);
            this.boxServicos.Name = "boxServicos";
            this.boxServicos.Size = new System.Drawing.Size(404, 580);
            this.boxServicos.TabIndex = 1;
            this.boxServicos.TabStop = false;
            this.boxServicos.Text = "Serviços";
            // 
            // RemoverServico
            // 
            this.RemoverServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoverServico.Location = new System.Drawing.Point(237, 32);
            this.RemoverServico.Name = "RemoverServico";
            this.RemoverServico.Size = new System.Drawing.Size(100, 35);
            this.RemoverServico.TabIndex = 6;
            this.RemoverServico.Text = "Remover";
            this.RemoverServico.UseVisualStyleBackColor = true;
            this.RemoverServico.Click += new System.EventHandler(this.RemoverServico_Click);
            // 
            // DuvidaServicos
            // 
            this.DuvidaServicos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DuvidaServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DuvidaServicos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DuvidaServicos.Location = new System.Drawing.Point(360, 12);
            this.DuvidaServicos.Name = "DuvidaServicos";
            this.DuvidaServicos.Size = new System.Drawing.Size(38, 30);
            this.DuvidaServicos.TabIndex = 5;
            this.DuvidaServicos.Text = "?";
            this.DuvidaServicos.UseVisualStyleBackColor = false;
            this.DuvidaServicos.Click += new System.EventHandler(this.DuvidaServicos_Click);
            // 
            // PararServico
            // 
            this.PararServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PararServico.Location = new System.Drawing.Point(121, 32);
            this.PararServico.Name = "PararServico";
            this.PararServico.Size = new System.Drawing.Size(100, 35);
            this.PararServico.TabIndex = 5;
            this.PararServico.Text = "Parar";
            this.PararServico.UseVisualStyleBackColor = true;
            this.PararServico.Click += new System.EventHandler(this.PararServico_Click);
            // 
            // IniciarServico
            // 
            this.IniciarServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarServico.Location = new System.Drawing.Point(6, 32);
            this.IniciarServico.Name = "IniciarServico";
            this.IniciarServico.Size = new System.Drawing.Size(100, 35);
            this.IniciarServico.TabIndex = 4;
            this.IniciarServico.Text = "Iniciar";
            this.IniciarServico.UseVisualStyleBackColor = true;
            this.IniciarServico.Click += new System.EventHandler(this.IniciarServico_Click);
            // 
            // ListaServicos
            // 
            this.ListaServicos.FormattingEnabled = true;
            this.ListaServicos.HorizontalScrollbar = true;
            this.ListaServicos.Location = new System.Drawing.Point(6, 84);
            this.ListaServicos.Name = "ListaServicos";
            this.ListaServicos.Size = new System.Drawing.Size(387, 490);
            this.ListaServicos.TabIndex = 0;
            // 
            // boxProcessos
            // 
            this.boxProcessos.BackColor = System.Drawing.Color.Silver;
            this.boxProcessos.Controls.Add(this.DuvidaTaskKill);
            this.boxProcessos.Controls.Add(this.TaskKill);
            this.boxProcessos.Controls.Add(this.ListaProcessos);
            this.boxProcessos.Location = new System.Drawing.Point(435, 114);
            this.boxProcessos.Name = "boxProcessos";
            this.boxProcessos.Size = new System.Drawing.Size(406, 580);
            this.boxProcessos.TabIndex = 2;
            this.boxProcessos.TabStop = false;
            this.boxProcessos.Text = "Processos em execução- TaskKill";
            // 
            // DuvidaTaskKill
            // 
            this.DuvidaTaskKill.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DuvidaTaskKill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DuvidaTaskKill.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DuvidaTaskKill.Location = new System.Drawing.Point(362, 12);
            this.DuvidaTaskKill.Name = "DuvidaTaskKill";
            this.DuvidaTaskKill.Size = new System.Drawing.Size(38, 30);
            this.DuvidaTaskKill.TabIndex = 6;
            this.DuvidaTaskKill.Text = "?";
            this.DuvidaTaskKill.UseVisualStyleBackColor = false;
            this.DuvidaTaskKill.Click += new System.EventHandler(this.DuvidaTaskKill_Click);
            // 
            // TaskKill
            // 
            this.TaskKill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaskKill.Location = new System.Drawing.Point(30, 32);
            this.TaskKill.Name = "TaskKill";
            this.TaskKill.Size = new System.Drawing.Size(100, 35);
            this.TaskKill.TabIndex = 6;
            this.TaskKill.Text = "Parar";
            this.TaskKill.UseVisualStyleBackColor = true;
            this.TaskKill.Click += new System.EventHandler(this.TaskKill_Click);
            // 
            // ListaProcessos
            // 
            this.ListaProcessos.FormattingEnabled = true;
            this.ListaProcessos.HorizontalScrollbar = true;
            this.ListaProcessos.Location = new System.Drawing.Point(7, 84);
            this.ListaProcessos.Name = "ListaProcessos";
            this.ListaProcessos.Size = new System.Drawing.Size(391, 490);
            this.ListaProcessos.TabIndex = 0;
            // 
            // InstaladorServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 706);
            this.Controls.Add(this.boxProcessos);
            this.Controls.Add(this.boxServicos);
            this.Controls.Add(this.boxProjeto);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(869, 745);
            this.MinimumSize = new System.Drawing.Size(869, 745);
            this.Name = "InstaladorServicos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Serviços";
            this.boxProjeto.ResumeLayout(false);
            this.boxProjeto.PerformLayout();
            this.boxServicos.ResumeLayout(false);
            this.boxProcessos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxProjeto;
        private System.Windows.Forms.TextBox DiretorioExecutavel;
        private System.Windows.Forms.Button AbrirExploradorArquivos;
        private System.Windows.Forms.Button InstalarServico;
        private System.Windows.Forms.Button DesinstalarServico;
        private System.Windows.Forms.OpenFileDialog BuscaArquivo;
        private System.Windows.Forms.GroupBox boxServicos;
        private System.Windows.Forms.GroupBox boxProcessos;
        private System.Windows.Forms.CheckedListBox ListaServicos;
        private System.Windows.Forms.CheckedListBox ListaProcessos;
        private System.Windows.Forms.Button IniciarServico;
        private System.Windows.Forms.Button PararServico;
        private System.Windows.Forms.Button TaskKill;
        private System.Windows.Forms.Button DuvidaProjeto;
        private System.Windows.Forms.Button DuvidaServicos;
        private System.Windows.Forms.Button DuvidaTaskKill;
        private System.Windows.Forms.Button RemoverServico;
    }
}

