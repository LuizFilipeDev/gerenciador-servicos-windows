using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaladorServicos
{
    public partial class InstaladorServicos : Form
    {
        //Status dos serviços
        public const string statusParado = " - (PARADO)";
        public const string statusEmExecucao = " - (EM EXECUÇÃO)";

        public InstaladorServicos()
        {
            InitializeComponent();

            AtualizarListaServicos();
            AtualizarListaProcessos();
        }

        private void InstalarServico_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DiretorioExecutavel.Text))
            {
                try
                {
                    InteragirAplicacao(false);

                    ProcessStartInfo informacoesProcesso = new ProcessStartInfo();
                    Process processoInstalar = new Process();
                    string caminhoExecutavel = $"\"{DiretorioExecutavel.Text}\"";

                    informacoesProcesso.FileName = "cmd.exe";
                    informacoesProcesso.Arguments = @$"/C cd C:\Windows\Microsoft.NET\Framework\v4.0.30319 & InstallUtil.exe {caminhoExecutavel} & pause";

                    processoInstalar = Process.Start(informacoesProcesso);
                    processoInstalar.WaitForExit();

                    InteragirAplicacao(true);
                    AtualizarListaServicos();
                }
                catch
                {
                    MessageBox.Show("Erro ao instalar os serviços, tente novamente!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o executável para instalar os serviços!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DesinstalarServico_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DiretorioExecutavel.Text))
            {
                try
                {
                    InteragirAplicacao(false);

                    ProcessStartInfo informacoesProcesso = new ProcessStartInfo();
                    Process processoDesinstalar = new Process();
                    string caminhoExecutavel = $"\"{DiretorioExecutavel.Text}\"";

                    informacoesProcesso.FileName = "cmd.exe";
                    informacoesProcesso.Arguments = @$"/C cd C:\Windows\Microsoft.NET\Framework\v4.0.30319 & InstallUtil.exe -u {caminhoExecutavel} & pause";

                    processoDesinstalar = Process.Start(informacoesProcesso);
                    processoDesinstalar.WaitForExit();

                    InteragirAplicacao(true);
                    AtualizarListaServicos();
                    AtualizarListaProcessos();
                }
                catch
                {
                    MessageBox.Show("Erro ao desinstalar serviços, confira o prompt de comando para mais detalhes", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o executável para desinstalar os serviços!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbrirExploradorArquivos_Click(object sender, EventArgs e)
        {
            if (BuscaArquivo.ShowDialog() == DialogResult.OK)
            {
                DiretorioExecutavel.Text = BuscaArquivo.FileName;
            }
        }

        private void IniciarServico_Click(object sender, EventArgs e)
        {
            if (ListaServicos.CheckedItems.Count != default(int))
            {
                ProcessStartInfo informacoesProcesso = new ProcessStartInfo();
                Process processoServico = new Process();

                InteragirAplicacao(false);

                foreach (string nomeServico in ListaServicos.CheckedItems)
                {
                    informacoesProcesso = new ProcessStartInfo();
                    processoServico = new Process();

                    string nomeFormatado = $"\"{FormatarNomeServico(nomeServico)}\"";
                    informacoesProcesso.FileName = "cmd.exe";
                    informacoesProcesso.Arguments = @$"/C net start {nomeFormatado}";

                    processoServico = Process.Start(informacoesProcesso);
                    processoServico.WaitForExit();
                }

                InteragirAplicacao(true);
                AtualizarListaServicos();
                AtualizarListaProcessos();
            }
            else
            {
                MessageBox.Show("Por favor, marque pelo menos um serviço a ser iniciado!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PararServico_Click(object sender, EventArgs e)
        {
            if (ListaServicos.CheckedItems.Count != default(int))
            {
                InteragirAplicacao(false);

                ProcessStartInfo informacoesProcesso = new ProcessStartInfo();
                Process processoServico = new Process();

                foreach (string nomeServico in ListaServicos.CheckedItems)
                {
                    informacoesProcesso = new ProcessStartInfo();
                    processoServico = new Process();

                    string nomeFormatado = $"\"{FormatarNomeServico(nomeServico)}\"";
                    informacoesProcesso.FileName = "cmd.exe";
                    informacoesProcesso.Arguments = @$"/C net stop {nomeFormatado}";

                    processoServico = Process.Start(informacoesProcesso);
                    processoServico.WaitForExit();
                }

                InteragirAplicacao(true);
                AtualizarListaServicos();
                AtualizarListaProcessos();
            }
            else
            {
                MessageBox.Show("Por favor, marque pelo menos um serviço a ser parado!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RemoverServico_Click(object sender, EventArgs e)
        {
            if (ListaServicos.CheckedItems.Count != default(int))
            {
                ProcessStartInfo informacoesProcesso = new ProcessStartInfo();
                Process processoServico = new Process();

                InteragirAplicacao(false);

                foreach (string nomeServico in ListaServicos.CheckedItems)
                {
                    informacoesProcesso = new ProcessStartInfo();
                    processoServico = new Process();

                    string nomeFormatado = $"\"{FormatarNomeServico(nomeServico)}\"";
                    informacoesProcesso.FileName = "cmd.exe";
                    informacoesProcesso.Arguments = @$"/C sc.exe delete {nomeFormatado}";

                    processoServico = Process.Start(informacoesProcesso);
                    processoServico.WaitForExit();
                }

                InteragirAplicacao(true);
                AtualizarListaServicos();
                AtualizarListaProcessos();
            }
            else
            {
                MessageBox.Show("Por favor, marque pelo menos um serviço a ser iniciado!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TaskKill_Click(object sender, EventArgs e)
        {
            if (ListaProcessos.CheckedItems.Count != default(int))
            {
                ProcessStartInfo informacoesProceso = new ProcessStartInfo();
                Process processo = new Process();

                InteragirAplicacao(false);

                foreach (string PID in ListaProcessos.CheckedItems)
                {
                    informacoesProceso = new ProcessStartInfo();
                    processo = new Process();

                    string nomeFormatado = FormatarNomeProcesso(PID);
                    informacoesProceso.FileName = "cmd.exe";
                    informacoesProceso.Arguments = @$"/C taskkill /f /pid {nomeFormatado}";

                    processo = Process.Start(informacoesProceso);
                    processo.WaitForExit();
                }

                InteragirAplicacao(true);
                AtualizarListaServicos();
                AtualizarListaProcessos();
            }
            else
            {
                MessageBox.Show("Por favor, selecione pelo menos um processo a ser interrompido pelo TaskKill!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarListaServicos()
        {
            ListaServicos.Items.Clear();
            ServiceController[] serviceController = ServiceController.GetServices();

            foreach (ServiceController service in serviceController.OrderBy(x => x.DisplayName))
            {
                string statusServico = service.Status.ToString().ToUpper() == "STOPPED" ? statusParado : statusEmExecucao;
                ListaServicos.Items.Add($"{service.ServiceName}{statusServico}");
            }
        }

        private void AtualizarListaProcessos()
        {
            ListaProcessos.Items.Clear();
            Process[] processos = Process.GetProcesses();

            foreach (Process processo in processos.OrderBy(x => x.ProcessName))
            {
                ListaProcessos.Items.Add($"{processo.ProcessName} - PID: {processo.Id}");
            }
        }

        private string FormatarNomeServico(string nomeServico)
        {
            string sFormatada = string.Empty;
            sFormatada = nomeServico.Replace(nomeServico.Contains(statusParado) ? statusParado : statusEmExecucao, "");
            return sFormatada;
        }

        private string FormatarNomeProcesso(string nomeProcesso)
        {
            string formatarString = string.Empty;
            string limparString = string.Empty;

            formatarString = nomeProcesso.Substring(nomeProcesso.IndexOf("PID:"), nomeProcesso.Length - nomeProcesso.IndexOf("PID:"));
            limparString = formatarString.Replace("PID: ", string.Empty);

            return limparString;
        }

        private void InteragirAplicacao(bool interagir)
        {
            Cursor.Current = interagir ? Cursors.Default : Cursors.AppStarting;

            boxProjeto.Enabled = interagir;
            boxServicos.Enabled = interagir;
            boxProcessos.Enabled = interagir;
        }

        private void DuvidaProjeto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Localize o arquivo executável do projeto com os serviços a serem instalados, clicando no botão com três pontos." +
                    " Após isso apenas instale ou desinstale os serviços referidos pelos botões.",
                    "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DuvidaServicos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor, selecione o serviço a ser iniciado, parado ou removido pela aplicação", "Serviços", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DuvidaTaskKill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Somente utilize esta alternativa se você tentou parar o serviço pelo box de serviços e não conseguiu," +
                " Selecione o processo em que deseja forçar a parada",
                "TaskKill - CUIDADO COM OS SERVIÇOS A SEREM INTERROMPIDOS ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
