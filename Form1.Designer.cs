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
            this.textBox_link_do_youtube.Location = new System.Drawing.Point(11, 19);
            this.textBox_link_do_youtube.Name = "textBox_link_do_youtube";
            this.textBox_link_do_youtube.Size = new System.Drawing.Size(262, 20);
            this.textBox_link_do_youtube.TabIndex = 0;
            // 
            // Botao_baixar
            // 
            this.Botao_baixar.BackColor = System.Drawing.Color.SpringGreen;
            this.Botao_baixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_baixar.Location = new System.Drawing.Point(11, 74);
            this.Botao_baixar.Name = "Botao_baixar";
            this.Botao_baixar.Size = new System.Drawing.Size(56, 20);
            this.Botao_baixar.TabIndex = 1;
            this.Botao_baixar.Text = "BAIXAR";
            this.Botao_baixar.UseVisualStyleBackColor = false;
            this.Botao_baixar.Click += new System.EventHandler(this.Botao_baixar_async);
            // 
            // radioButton_audio
            // 
            this.radioButton_audio.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_audio.AutoSize = true;
            this.radioButton_audio.Checked = true;
            this.radioButton_audio.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton_audio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_audio.Location = new System.Drawing.Point(84, 45);
            this.radioButton_audio.Name = "radioButton_audio";
            this.radioButton_audio.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.radioButton_audio.Size = new System.Drawing.Size(92, 23);
            this.radioButton_audio.TabIndex = 2;
            this.radioButton_audio.TabStop = true;
            this.radioButton_audio.Text = "AUDIO (MP3)";
            this.radioButton_audio.UseVisualStyleBackColor = true;
            this.radioButton_audio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_video
            // 
            this.radioButton_video.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_video.AutoSize = true;
            this.radioButton_video.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton_video.Location = new System.Drawing.Point(182, 45);
            this.radioButton_video.Name = "radioButton_video";
            this.radioButton_video.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.radioButton_video.Size = new System.Drawing.Size(91, 23);
            this.radioButton_video.TabIndex = 3;
            this.radioButton_video.Text = "VÍDEO (MP4)";
            this.radioButton_video.UseVisualStyleBackColor = true;
            this.radioButton_video.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label_formatos
            // 
            this.label_formatos.AutoSize = true;
            this.label_formatos.Location = new System.Drawing.Point(8, 50);
            this.label_formatos.Name = "label_formatos";
            this.label_formatos.Size = new System.Drawing.Size(70, 13);
            this.label_formatos.TabIndex = 4;
            this.label_formatos.Text = "FORMATOS:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(84, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(189, 20);
            this.progressBar1.TabIndex = 5;
            // 
            // label_nomeDoVideo
            // 
            this.label_nomeDoVideo.AutoSize = true;
            this.label_nomeDoVideo.Location = new System.Drawing.Point(8, 97);
            this.label_nomeDoVideo.Name = "label_nomeDoVideo";
            this.label_nomeDoVideo.Size = new System.Drawing.Size(36, 13);
            this.label_nomeDoVideo.TabIndex = 6;
            this.label_nomeDoVideo.Text = "Titulo:";
            // 
            // pictureBox_botaoYoutube
            // 
            this.pictureBox_botaoYoutube.AccessibleDescription = "";
            this.pictureBox_botaoYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_botaoYoutube.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_botaoYoutube.Image")));
            this.pictureBox_botaoYoutube.Location = new System.Drawing.Point(279, 45);
            this.pictureBox_botaoYoutube.Name = "pictureBox_botaoYoutube";
            this.pictureBox_botaoYoutube.Size = new System.Drawing.Size(61, 49);
            this.pictureBox_botaoYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_botaoYoutube.TabIndex = 8;
            this.pictureBox_botaoYoutube.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_botaoYoutube, "Abrir o Youtube");
            this.pictureBox_botaoYoutube.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabel_colar
            // 
            this.linkLabel_colar.AutoSize = true;
            this.linkLabel_colar.Location = new System.Drawing.Point(276, 22);
            this.linkLabel_colar.Name = "linkLabel_colar";
            this.linkLabel_colar.Size = new System.Drawing.Size(31, 13);
            this.linkLabel_colar.TabIndex = 4;
            this.linkLabel_colar.TabStop = true;
            this.linkLabel_colar.Text = "Colar";
            this.toolTip1.SetToolTip(this.linkLabel_colar, "Colar link do vídeo");
            this.linkLabel_colar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // linkLabel_github
            // 
            this.linkLabel_github.AutoSize = true;
            this.linkLabel_github.Location = new System.Drawing.Point(6, 29);
            this.linkLabel_github.Name = "linkLabel_github";
            this.linkLabel_github.Size = new System.Drawing.Size(173, 13);
            this.linkLabel_github.TabIndex = 2;
            this.linkLabel_github.TabStop = true;
            this.linkLabel_github.Text = "https://github.com/DanielSvoboda";
            this.toolTip1.SetToolTip(this.linkLabel_github, "https://github.com/DanielSvoboda");
            this.linkLabel_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel_videolibrary
            // 
            this.linkLabel_videolibrary.AutoSize = true;
            this.linkLabel_videolibrary.Location = new System.Drawing.Point(256, 29);
            this.linkLabel_videolibrary.Name = "linkLabel_videolibrary";
            this.linkLabel_videolibrary.Size = new System.Drawing.Size(65, 13);
            this.linkLabel_videolibrary.TabIndex = 5;
            this.linkLabel_videolibrary.TabStop = true;
            this.linkLabel_videolibrary.Text = "VideoLibrary";
            this.toolTip1.SetToolTip(this.linkLabel_videolibrary, "https://www.nuget.org/packages/VideoLibrary");
            this.linkLabel_videolibrary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(256, 45);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Costura.Fody";
            this.toolTip1.SetToolTip(this.linkLabel1, "https://www.nuget.org/packages/VideoLibrary");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_2);
            // 
            // escolher_conv_input
            // 
            this.escolher_conv_input.Location = new System.Drawing.Point(17, 32);
            this.escolher_conv_input.Name = "escolher_conv_input";
            this.escolher_conv_input.Size = new System.Drawing.Size(134, 20);
            this.escolher_conv_input.TabIndex = 16;
            this.escolher_conv_input.Text = "ESCOLHER VÍDEO";
            this.escolher_conv_input.UseVisualStyleBackColor = true;
            this.escolher_conv_input.Click += new System.EventHandler(this.escolher_conv_input_Click);
            // 
            // GRUPO_DOWNLOAD
            // 
            this.GRUPO_DOWNLOAD.Controls.Add(this.pictureBox_botaoYoutube);
            this.GRUPO_DOWNLOAD.Controls.Add(this.linkLabel_colar);
            this.GRUPO_DOWNLOAD.Controls.Add(this.textBox_link_do_youtube);
            this.GRUPO_DOWNLOAD.Controls.Add(this.Botao_baixar);
            this.GRUPO_DOWNLOAD.Controls.Add(this.radioButton_audio);
            this.GRUPO_DOWNLOAD.Controls.Add(this.radioButton_video);
            this.GRUPO_DOWNLOAD.Controls.Add(this.label_formatos);
            this.GRUPO_DOWNLOAD.Controls.Add(this.progressBar1);
            this.GRUPO_DOWNLOAD.Controls.Add(this.label_nomeDoVideo);
            this.GRUPO_DOWNLOAD.Location = new System.Drawing.Point(12, 27);
            this.GRUPO_DOWNLOAD.Name = "GRUPO_DOWNLOAD";
            this.GRUPO_DOWNLOAD.Size = new System.Drawing.Size(346, 117);
            this.GRUPO_DOWNLOAD.TabIndex = 17;
            this.GRUPO_DOWNLOAD.TabStop = false;
            // 
            // GRUPO_CONVERTER
            // 
            this.GRUPO_CONVERTER.Controls.Add(this.MODO_AVANCADO);
            this.GRUPO_CONVERTER.Controls.Add(this.MODO_NORMAL);
            this.GRUPO_CONVERTER.Controls.Add(this.label_TITULO_CONV);
            this.GRUPO_CONVERTER.Controls.Add(this.botao_converter);
            this.GRUPO_CONVERTER.Controls.Add(this.escolher_conv_input);
            this.GRUPO_CONVERTER.Location = new System.Drawing.Point(6, 173);
            this.GRUPO_CONVERTER.Name = "GRUPO_CONVERTER";
            this.GRUPO_CONVERTER.Size = new System.Drawing.Size(346, 117);
            this.GRUPO_CONVERTER.TabIndex = 18;
            this.GRUPO_CONVERTER.TabStop = false;
            this.GRUPO_CONVERTER.Visible = false;
            // 
            // MODO_AVANCADO
            // 
            this.MODO_AVANCADO.Enabled = false;
            this.MODO_AVANCADO.Location = new System.Drawing.Point(266, 91);
            this.MODO_AVANCADO.Name = "MODO_AVANCADO";
            this.MODO_AVANCADO.Size = new System.Drawing.Size(74, 20);
            this.MODO_AVANCADO.TabIndex = 19;
            this.MODO_AVANCADO.Text = "AVANÇADO";
            this.MODO_AVANCADO.UseVisualStyleBackColor = true;
            this.MODO_AVANCADO.Click += new System.EventHandler(this.MODO_AVANCADO_Click);
            // 
            // MODO_NORMAL
            // 
            this.MODO_NORMAL.Enabled = false;
            this.MODO_NORMAL.Location = new System.Drawing.Point(193, 91);
            this.MODO_NORMAL.Name = "MODO_NORMAL";
            this.MODO_NORMAL.Size = new System.Drawing.Size(67, 20);
            this.MODO_NORMAL.TabIndex = 18;
            this.MODO_NORMAL.Text = "NORMAL";
            this.MODO_NORMAL.UseVisualStyleBackColor = true;
            this.MODO_NORMAL.Click += new System.EventHandler(this.MODO_NORMAL_Click);
            // 
            // label_TITULO_CONV
            // 
            this.label_TITULO_CONV.AutoSize = true;
            this.label_TITULO_CONV.Location = new System.Drawing.Point(32, 16);
            this.label_TITULO_CONV.Name = "label_TITULO_CONV";
            this.label_TITULO_CONV.Size = new System.Drawing.Size(287, 13);
            this.label_TITULO_CONV.TabIndex = 9;
            this.label_TITULO_CONV.Text = "CONVERTER UM ARQUIVO DE VÍDEO EM AUDIO (MP3)";
            // 
            // botao_converter
            // 
            this.botao_converter.BackColor = System.Drawing.Color.SpringGreen;
            this.botao_converter.Location = new System.Drawing.Point(206, 32);
            this.botao_converter.Name = "botao_converter";
            this.botao_converter.Size = new System.Drawing.Size(134, 20);
            this.botao_converter.TabIndex = 17;
            this.botao_converter.Text = "CONVERTER";
            this.botao_converter.UseVisualStyleBackColor = false;
            this.botao_converter.Click += new System.EventHandler(this.Botao_converter);
            // 
            // dOWNLOADToolStripMenuItem
            // 
            this.dOWNLOADToolStripMenuItem.Name = "dOWNLOADToolStripMenuItem";
            this.dOWNLOADToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // cONVERTERToolStripMenuItem
            // 
            this.cONVERTERToolStripMenuItem.Name = "cONVERTERToolStripMenuItem";
            this.cONVERTERToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // sOBREToolStripMenuItem
            // 
            this.sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            this.sOBREToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // GRUPO_SOBRE
            // 
            this.GRUPO_SOBRE.Controls.Add(this.linkLabel1);
            this.GRUPO_SOBRE.Controls.Add(this.linkLabel_videolibrary);
            this.GRUPO_SOBRE.Controls.Add(this.button_atualizar);
            this.GRUPO_SOBRE.Controls.Add(this.label_sobre2);
            this.GRUPO_SOBRE.Controls.Add(this.label_sobre1);
            this.GRUPO_SOBRE.Controls.Add(this.linkLabel_github);
            this.GRUPO_SOBRE.Location = new System.Drawing.Point(387, 27);
            this.GRUPO_SOBRE.Name = "GRUPO_SOBRE";
            this.GRUPO_SOBRE.Size = new System.Drawing.Size(346, 117);
            this.GRUPO_SOBRE.TabIndex = 21;
            this.GRUPO_SOBRE.TabStop = false;
            // 
            // button_atualizar
            // 
            this.button_atualizar.Location = new System.Drawing.Point(226, 87);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(114, 24);
            this.button_atualizar.TabIndex = 3;
            this.button_atualizar.Text = "Verificar Atualização";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // label_sobre2
            // 
            this.label_sobre2.AutoSize = true;
            this.label_sobre2.Location = new System.Drawing.Point(256, 16);
            this.label_sobre2.Name = "label_sobre2";
            this.label_sobre2.Size = new System.Drawing.Size(74, 13);
            this.label_sobre2.TabIndex = 4;
            this.label_sobre2.Text = "Dependência:";
            // 
            // label_sobre1
            // 
            this.label_sobre1.AutoSize = true;
            this.label_sobre1.Location = new System.Drawing.Point(6, 16);
            this.label_sobre1.Name = "label_sobre1";
            this.label_sobre1.Size = new System.Drawing.Size(137, 13);
            this.label_sobre1.TabIndex = 1;
            this.label_sobre1.Text = "Criado por: Daniel Svoboda\r\n";
            // 
            // label_sobre3
            // 
            this.label_sobre3.AutoSize = true;
            this.label_sobre3.Location = new System.Drawing.Point(401, 264);
            this.label_sobre3.Name = "label_sobre3";
            this.label_sobre3.Size = new System.Drawing.Size(135, 13);
            this.label_sobre3.TabIndex = 18;
            this.label_sobre3.Text = "LOCAL SALVAR FFMPEG:";
            // 
            // button_restaurar_padrao
            // 
            this.button_restaurar_padrao.Location = new System.Drawing.Point(636, 264);
            this.button_restaurar_padrao.Name = "button_restaurar_padrao";
            this.button_restaurar_padrao.Size = new System.Drawing.Size(97, 24);
            this.button_restaurar_padrao.TabIndex = 19;
            this.button_restaurar_padrao.Text = "Restaurar padrão";
            this.button_restaurar_padrao.UseVisualStyleBackColor = true;
            this.button_restaurar_padrao.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_local_ffmpeg
            // 
            this.button_local_ffmpeg.Location = new System.Drawing.Point(708, 242);
            this.button_local_ffmpeg.Name = "button_local_ffmpeg";
            this.button_local_ffmpeg.Size = new System.Drawing.Size(25, 20);
            this.button_local_ffmpeg.TabIndex = 20;
            this.button_local_ffmpeg.Text = "...";
            this.button_local_ffmpeg.UseVisualStyleBackColor = true;
            this.button_local_ffmpeg.Click += new System.EventHandler(this.button_local_ffmpeg_Click);
            // 
            // textBox_LocalFfmpeg
            // 
            this.textBox_LocalFfmpeg.Enabled = false;
            this.textBox_LocalFfmpeg.Location = new System.Drawing.Point(402, 242);
            this.textBox_LocalFfmpeg.Name = "textBox_LocalFfmpeg";
            this.textBox_LocalFfmpeg.Size = new System.Drawing.Size(300, 20);
            this.textBox_LocalFfmpeg.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOWNLOADToolStripMenuItem1,
            this.cONVERTERToolStripMenuItem1,
            this.sOBREToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dOWNLOADToolStripMenuItem1
            // 
            this.dOWNLOADToolStripMenuItem1.Name = "dOWNLOADToolStripMenuItem1";
            this.dOWNLOADToolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.dOWNLOADToolStripMenuItem1.Text = "DOWNLOAD";
            this.dOWNLOADToolStripMenuItem1.Click += new System.EventHandler(this.dOWNLOADToolStripMenuItem1_Click_1);
            // 
            // cONVERTERToolStripMenuItem1
            // 
            this.cONVERTERToolStripMenuItem1.Name = "cONVERTERToolStripMenuItem1";
            this.cONVERTERToolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.cONVERTERToolStripMenuItem1.Text = "CONVERTER";
            this.cONVERTERToolStripMenuItem1.Click += new System.EventHandler(this.cONVERTERToolStripMenuItem1_Click);
            // 
            // sOBREToolStripMenuItem1
            // 
            this.sOBREToolStripMenuItem1.Name = "sOBREToolStripMenuItem1";
            this.sOBREToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.sOBREToolStripMenuItem1.Text = "SOBRE";
            this.sOBREToolStripMenuItem1.Click += new System.EventHandler(this.sOBREToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(775, 329);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Download";
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

