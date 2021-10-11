namespace Youtube_Download_01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_link_do_youtube = new System.Windows.Forms.TextBox();
            this.Botao_baixar = new System.Windows.Forms.Button();
            this.radioButton_audio = new System.Windows.Forms.RadioButton();
            this.radioButton_video = new System.Windows.Forms.RadioButton();
            this.label_formatos = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_nomeDoVideo = new System.Windows.Forms.Label();
            this.pictureBox_botaoYoutube = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel_colar = new System.Windows.Forms.LinkLabel();
            this.linkLabel_github = new System.Windows.Forms.LinkLabel();
            this.linkLabel_videolibrary = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.escolher_conv_input = new System.Windows.Forms.Button();
            this.GRUPO_DOWNLOAD = new System.Windows.Forms.GroupBox();
            this.GRUPO_CONVERTER = new System.Windows.Forms.GroupBox();
            this.MODO_AVANCADO = new System.Windows.Forms.Button();
            this.MODO_NORMAL = new System.Windows.Forms.Button();
            this.label_TITULO_CONV = new System.Windows.Forms.Label();
            this.botao_converter = new System.Windows.Forms.Button();
            this.dOWNLOADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONVERTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GRUPO_SOBRE = new System.Windows.Forms.GroupBox();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.label_sobre2 = new System.Windows.Forms.Label();
            this.label_sobre1 = new System.Windows.Forms.Label();
            this.label_sobre3 = new System.Windows.Forms.Label();
            this.button_restaurar_padrao = new System.Windows.Forms.Button();
            this.button_local_ffmpeg = new System.Windows.Forms.Button();
            this.textBox_LocalFfmpeg = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOWNLOADToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cONVERTERToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_botaoYoutube)).BeginInit();
            this.GRUPO_DOWNLOAD.SuspendLayout();
            this.GRUPO_CONVERTER.SuspendLayout();
            this.GRUPO_SOBRE.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_link_do_youtube
            // 
            resources.ApplyResources(this.textBox_link_do_youtube, "textBox_link_do_youtube");
            this.textBox_link_do_youtube.Name = "textBox_link_do_youtube";
            this.toolTip1.SetToolTip(this.textBox_link_do_youtube, resources.GetString("textBox_link_do_youtube.ToolTip"));
            // 
            // Botao_baixar
            // 
            resources.ApplyResources(this.Botao_baixar, "Botao_baixar");
            this.Botao_baixar.BackColor = System.Drawing.Color.SpringGreen;
            this.Botao_baixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_baixar.Name = "Botao_baixar";
            this.toolTip1.SetToolTip(this.Botao_baixar, resources.GetString("Botao_baixar.ToolTip"));
            this.Botao_baixar.UseVisualStyleBackColor = false;
            this.Botao_baixar.Click += new System.EventHandler(this.Botao_baixar_async);
            // 
            // radioButton_audio
            // 
            resources.ApplyResources(this.radioButton_audio, "radioButton_audio");
            this.radioButton_audio.Checked = true;
            this.radioButton_audio.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton_audio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_audio.Name = "radioButton_audio";
            this.radioButton_audio.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButton_audio, resources.GetString("radioButton_audio.ToolTip"));
            this.radioButton_audio.UseVisualStyleBackColor = true;
            this.radioButton_audio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_video
            // 
            resources.ApplyResources(this.radioButton_video, "radioButton_video");
            this.radioButton_video.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton_video.Name = "radioButton_video";
            this.toolTip1.SetToolTip(this.radioButton_video, resources.GetString("radioButton_video.ToolTip"));
            this.radioButton_video.UseVisualStyleBackColor = true;
            this.radioButton_video.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label_formatos
            // 
            resources.ApplyResources(this.label_formatos, "label_formatos");
            this.label_formatos.Name = "label_formatos";
            this.toolTip1.SetToolTip(this.label_formatos, resources.GetString("label_formatos.ToolTip"));
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            this.toolTip1.SetToolTip(this.progressBar1, resources.GetString("progressBar1.ToolTip"));
            // 
            // label_nomeDoVideo
            // 
            resources.ApplyResources(this.label_nomeDoVideo, "label_nomeDoVideo");
            this.label_nomeDoVideo.Name = "label_nomeDoVideo";
            this.toolTip1.SetToolTip(this.label_nomeDoVideo, resources.GetString("label_nomeDoVideo.ToolTip"));
            // 
            // pictureBox_botaoYoutube
            // 
            resources.ApplyResources(this.pictureBox_botaoYoutube, "pictureBox_botaoYoutube");
            this.pictureBox_botaoYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_botaoYoutube.Name = "pictureBox_botaoYoutube";
            this.pictureBox_botaoYoutube.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_botaoYoutube, resources.GetString("pictureBox_botaoYoutube.ToolTip"));
            this.pictureBox_botaoYoutube.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabel_colar
            // 
            resources.ApplyResources(this.linkLabel_colar, "linkLabel_colar");
            this.linkLabel_colar.Name = "linkLabel_colar";
            this.linkLabel_colar.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel_colar, resources.GetString("linkLabel_colar.ToolTip"));
            this.linkLabel_colar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // linkLabel_github
            // 
            resources.ApplyResources(this.linkLabel_github, "linkLabel_github");
            this.linkLabel_github.Name = "linkLabel_github";
            this.linkLabel_github.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel_github, resources.GetString("linkLabel_github.ToolTip"));
            this.linkLabel_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel_videolibrary
            // 
            resources.ApplyResources(this.linkLabel_videolibrary, "linkLabel_videolibrary");
            this.linkLabel_videolibrary.Name = "linkLabel_videolibrary";
            this.linkLabel_videolibrary.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel_videolibrary, resources.GetString("linkLabel_videolibrary.ToolTip"));
            this.linkLabel_videolibrary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel1, resources.GetString("linkLabel1.ToolTip"));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_2);
            // 
            // escolher_conv_input
            // 
            resources.ApplyResources(this.escolher_conv_input, "escolher_conv_input");
            this.escolher_conv_input.Name = "escolher_conv_input";
            this.toolTip1.SetToolTip(this.escolher_conv_input, resources.GetString("escolher_conv_input.ToolTip"));
            this.escolher_conv_input.UseVisualStyleBackColor = true;
            this.escolher_conv_input.Click += new System.EventHandler(this.escolher_conv_input_Click);
            // 
            // GRUPO_DOWNLOAD
            // 
            resources.ApplyResources(this.GRUPO_DOWNLOAD, "GRUPO_DOWNLOAD");
            this.GRUPO_DOWNLOAD.Controls.Add(this.pictureBox_botaoYoutube);
            this.GRUPO_DOWNLOAD.Controls.Add(this.linkLabel_colar);
            this.GRUPO_DOWNLOAD.Controls.Add(this.textBox_link_do_youtube);
            this.GRUPO_DOWNLOAD.Controls.Add(this.Botao_baixar);
            this.GRUPO_DOWNLOAD.Controls.Add(this.radioButton_audio);
            this.GRUPO_DOWNLOAD.Controls.Add(this.radioButton_video);
            this.GRUPO_DOWNLOAD.Controls.Add(this.label_formatos);
            this.GRUPO_DOWNLOAD.Controls.Add(this.progressBar1);
            this.GRUPO_DOWNLOAD.Controls.Add(this.label_nomeDoVideo);
            this.GRUPO_DOWNLOAD.Name = "GRUPO_DOWNLOAD";
            this.GRUPO_DOWNLOAD.TabStop = false;
            this.toolTip1.SetToolTip(this.GRUPO_DOWNLOAD, resources.GetString("GRUPO_DOWNLOAD.ToolTip"));
            // 
            // GRUPO_CONVERTER
            // 
            resources.ApplyResources(this.GRUPO_CONVERTER, "GRUPO_CONVERTER");
            this.GRUPO_CONVERTER.Controls.Add(this.MODO_AVANCADO);
            this.GRUPO_CONVERTER.Controls.Add(this.MODO_NORMAL);
            this.GRUPO_CONVERTER.Controls.Add(this.label_TITULO_CONV);
            this.GRUPO_CONVERTER.Controls.Add(this.botao_converter);
            this.GRUPO_CONVERTER.Controls.Add(this.escolher_conv_input);
            this.GRUPO_CONVERTER.Name = "GRUPO_CONVERTER";
            this.GRUPO_CONVERTER.TabStop = false;
            this.toolTip1.SetToolTip(this.GRUPO_CONVERTER, resources.GetString("GRUPO_CONVERTER.ToolTip"));
            // 
            // MODO_AVANCADO
            // 
            resources.ApplyResources(this.MODO_AVANCADO, "MODO_AVANCADO");
            this.MODO_AVANCADO.Name = "MODO_AVANCADO";
            this.toolTip1.SetToolTip(this.MODO_AVANCADO, resources.GetString("MODO_AVANCADO.ToolTip"));
            this.MODO_AVANCADO.UseVisualStyleBackColor = true;
            this.MODO_AVANCADO.Click += new System.EventHandler(this.MODO_AVANCADO_Click);
            // 
            // MODO_NORMAL
            // 
            resources.ApplyResources(this.MODO_NORMAL, "MODO_NORMAL");
            this.MODO_NORMAL.Name = "MODO_NORMAL";
            this.toolTip1.SetToolTip(this.MODO_NORMAL, resources.GetString("MODO_NORMAL.ToolTip"));
            this.MODO_NORMAL.UseVisualStyleBackColor = true;
            this.MODO_NORMAL.Click += new System.EventHandler(this.MODO_NORMAL_Click);
            // 
            // label_TITULO_CONV
            // 
            resources.ApplyResources(this.label_TITULO_CONV, "label_TITULO_CONV");
            this.label_TITULO_CONV.Name = "label_TITULO_CONV";
            this.toolTip1.SetToolTip(this.label_TITULO_CONV, resources.GetString("label_TITULO_CONV.ToolTip"));
            // 
            // botao_converter
            // 
            resources.ApplyResources(this.botao_converter, "botao_converter");
            this.botao_converter.BackColor = System.Drawing.Color.SpringGreen;
            this.botao_converter.Name = "botao_converter";
            this.toolTip1.SetToolTip(this.botao_converter, resources.GetString("botao_converter.ToolTip"));
            this.botao_converter.UseVisualStyleBackColor = false;
            this.botao_converter.Click += new System.EventHandler(this.Botao_converter);
            // 
            // dOWNLOADToolStripMenuItem
            // 
            resources.ApplyResources(this.dOWNLOADToolStripMenuItem, "dOWNLOADToolStripMenuItem");
            this.dOWNLOADToolStripMenuItem.Name = "dOWNLOADToolStripMenuItem";
            // 
            // cONVERTERToolStripMenuItem
            // 
            resources.ApplyResources(this.cONVERTERToolStripMenuItem, "cONVERTERToolStripMenuItem");
            this.cONVERTERToolStripMenuItem.Name = "cONVERTERToolStripMenuItem";
            // 
            // sOBREToolStripMenuItem
            // 
            resources.ApplyResources(this.sOBREToolStripMenuItem, "sOBREToolStripMenuItem");
            this.sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            // 
            // GRUPO_SOBRE
            // 
            resources.ApplyResources(this.GRUPO_SOBRE, "GRUPO_SOBRE");
            this.GRUPO_SOBRE.Controls.Add(this.linkLabel1);
            this.GRUPO_SOBRE.Controls.Add(this.linkLabel_videolibrary);
            this.GRUPO_SOBRE.Controls.Add(this.button_atualizar);
            this.GRUPO_SOBRE.Controls.Add(this.label_sobre2);
            this.GRUPO_SOBRE.Controls.Add(this.label_sobre1);
            this.GRUPO_SOBRE.Controls.Add(this.linkLabel_github);
            this.GRUPO_SOBRE.Name = "GRUPO_SOBRE";
            this.GRUPO_SOBRE.TabStop = false;
            this.toolTip1.SetToolTip(this.GRUPO_SOBRE, resources.GetString("GRUPO_SOBRE.ToolTip"));
            // 
            // button_atualizar
            // 
            resources.ApplyResources(this.button_atualizar, "button_atualizar");
            this.button_atualizar.Name = "button_atualizar";
            this.toolTip1.SetToolTip(this.button_atualizar, resources.GetString("button_atualizar.ToolTip"));
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // label_sobre2
            // 
            resources.ApplyResources(this.label_sobre2, "label_sobre2");
            this.label_sobre2.Name = "label_sobre2";
            this.toolTip1.SetToolTip(this.label_sobre2, resources.GetString("label_sobre2.ToolTip"));
            // 
            // label_sobre1
            // 
            resources.ApplyResources(this.label_sobre1, "label_sobre1");
            this.label_sobre1.Name = "label_sobre1";
            this.toolTip1.SetToolTip(this.label_sobre1, resources.GetString("label_sobre1.ToolTip"));
            // 
            // label_sobre3
            // 
            resources.ApplyResources(this.label_sobre3, "label_sobre3");
            this.label_sobre3.Name = "label_sobre3";
            this.toolTip1.SetToolTip(this.label_sobre3, resources.GetString("label_sobre3.ToolTip"));
            // 
            // button_restaurar_padrao
            // 
            resources.ApplyResources(this.button_restaurar_padrao, "button_restaurar_padrao");
            this.button_restaurar_padrao.Name = "button_restaurar_padrao";
            this.toolTip1.SetToolTip(this.button_restaurar_padrao, resources.GetString("button_restaurar_padrao.ToolTip"));
            this.button_restaurar_padrao.UseVisualStyleBackColor = true;
            this.button_restaurar_padrao.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_local_ffmpeg
            // 
            resources.ApplyResources(this.button_local_ffmpeg, "button_local_ffmpeg");
            this.button_local_ffmpeg.Name = "button_local_ffmpeg";
            this.toolTip1.SetToolTip(this.button_local_ffmpeg, resources.GetString("button_local_ffmpeg.ToolTip"));
            this.button_local_ffmpeg.UseVisualStyleBackColor = true;
            this.button_local_ffmpeg.Click += new System.EventHandler(this.button_local_ffmpeg_Click);
            // 
            // textBox_LocalFfmpeg
            // 
            resources.ApplyResources(this.textBox_LocalFfmpeg, "textBox_LocalFfmpeg");
            this.textBox_LocalFfmpeg.Name = "textBox_LocalFfmpeg";
            this.toolTip1.SetToolTip(this.textBox_LocalFfmpeg, resources.GetString("textBox_LocalFfmpeg.ToolTip"));
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOWNLOADToolStripMenuItem1,
            this.cONVERTERToolStripMenuItem1,
            this.sOBREToolStripMenuItem1});
            this.menuStrip1.Name = "menuStrip1";
            this.toolTip1.SetToolTip(this.menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // dOWNLOADToolStripMenuItem1
            // 
            resources.ApplyResources(this.dOWNLOADToolStripMenuItem1, "dOWNLOADToolStripMenuItem1");
            this.dOWNLOADToolStripMenuItem1.Name = "dOWNLOADToolStripMenuItem1";
            this.dOWNLOADToolStripMenuItem1.Click += new System.EventHandler(this.dOWNLOADToolStripMenuItem1_Click_1);
            // 
            // cONVERTERToolStripMenuItem1
            // 
            resources.ApplyResources(this.cONVERTERToolStripMenuItem1, "cONVERTERToolStripMenuItem1");
            this.cONVERTERToolStripMenuItem1.Name = "cONVERTERToolStripMenuItem1";
            this.cONVERTERToolStripMenuItem1.Click += new System.EventHandler(this.cONVERTERToolStripMenuItem1_Click);
            // 
            // sOBREToolStripMenuItem1
            // 
            resources.ApplyResources(this.sOBREToolStripMenuItem1, "sOBREToolStripMenuItem1");
            this.sOBREToolStripMenuItem1.Name = "sOBREToolStripMenuItem1";
            this.sOBREToolStripMenuItem1.Click += new System.EventHandler(this.sOBREToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label_sobre3);
            this.Controls.Add(this.GRUPO_SOBRE);
            this.Controls.Add(this.button_restaurar_padrao);
            this.Controls.Add(this.GRUPO_CONVERTER);
            this.Controls.Add(this.button_local_ffmpeg);
            this.Controls.Add(this.GRUPO_DOWNLOAD);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox_LocalFfmpeg);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_botaoYoutube)).EndInit();
            this.GRUPO_DOWNLOAD.ResumeLayout(false);
            this.GRUPO_DOWNLOAD.PerformLayout();
            this.GRUPO_CONVERTER.ResumeLayout(false);
            this.GRUPO_CONVERTER.PerformLayout();
            this.GRUPO_SOBRE.ResumeLayout(false);
            this.GRUPO_SOBRE.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_link_do_youtube;
        private System.Windows.Forms.Button Botao_baixar;
        private System.Windows.Forms.RadioButton radioButton_audio;
        private System.Windows.Forms.RadioButton radioButton_video;
        private System.Windows.Forms.Label label_formatos;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_nomeDoVideo;
        private System.Windows.Forms.PictureBox pictureBox_botaoYoutube;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button escolher_conv_input;
        private System.Windows.Forms.GroupBox GRUPO_DOWNLOAD;
        private System.Windows.Forms.GroupBox GRUPO_CONVERTER;
        private System.Windows.Forms.ToolStripMenuItem dOWNLOADToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONVERTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOBREToolStripMenuItem;
        private System.Windows.Forms.Button botao_converter;
        private System.Windows.Forms.GroupBox GRUPO_SOBRE;
        private System.Windows.Forms.LinkLabel linkLabel_github;
        private System.Windows.Forms.Label label_sobre1;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOWNLOADToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cONVERTERToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sOBREToolStripMenuItem1;
        private System.Windows.Forms.LinkLabel linkLabel_colar;
        private System.Windows.Forms.Label label_TITULO_CONV;
        private System.Windows.Forms.TextBox textBox_LocalFfmpeg;
        private System.Windows.Forms.Label label_sobre3;
        private System.Windows.Forms.Button button_restaurar_padrao;
        private System.Windows.Forms.Label label_sobre2;
        private System.Windows.Forms.LinkLabel linkLabel_videolibrary;
        private System.Windows.Forms.Button button_local_ffmpeg;
        private System.Windows.Forms.Button MODO_AVANCADO;
        private System.Windows.Forms.Button MODO_NORMAL;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

