
namespace Youtube_Download
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_autor_view = new System.Windows.Forms.Label();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.linkLabel_colar = new System.Windows.Forms.LinkLabel();
            this.button_baixarAudio = new System.Windows.Forms.Button();
            this.button_baixarVideo = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonbaixarVIdeoComAudio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.linkLabel_github = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Location = new System.Drawing.Point(6, 16);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(38, 13);
            this.label_titulo.TabIndex = 2;
            this.label_titulo.Text = "Título:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label_autor_view
            // 
            this.label_autor_view.AutoSize = true;
            this.label_autor_view.Location = new System.Drawing.Point(6, 29);
            this.label_autor_view.Name = "label_autor_view";
            this.label_autor_view.Size = new System.Drawing.Size(38, 13);
            this.label_autor_view.TabIndex = 5;
            this.label_autor_view.Text = "Autor: ";
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(12, 12);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(299, 20);
            this.textBox_url.TabIndex = 6;
            // 
            // linkLabel_colar
            // 
            this.linkLabel_colar.AutoSize = true;
            this.linkLabel_colar.Location = new System.Drawing.Point(317, 15);
            this.linkLabel_colar.Name = "linkLabel_colar";
            this.linkLabel_colar.Size = new System.Drawing.Size(31, 13);
            this.linkLabel_colar.TabIndex = 8;
            this.linkLabel_colar.TabStop = true;
            this.linkLabel_colar.Text = "Colar";
            this.linkLabel_colar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_colar_LinkClicked);
            // 
            // button_baixarAudio
            // 
            this.button_baixarAudio.Location = new System.Drawing.Point(9, 19);
            this.button_baixarAudio.Name = "button_baixarAudio";
            this.button_baixarAudio.Size = new System.Drawing.Size(80, 23);
            this.button_baixarAudio.TabIndex = 12;
            this.button_baixarAudio.Text = "AUDIO";
            this.button_baixarAudio.UseVisualStyleBackColor = true;
            this.button_baixarAudio.Click += new System.EventHandler(this.button_baixarAudio_Click);
            // 
            // button_baixarVideo
            // 
            this.button_baixarVideo.Location = new System.Drawing.Point(223, 19);
            this.button_baixarVideo.Name = "button_baixarVideo";
            this.button_baixarVideo.Size = new System.Drawing.Size(107, 23);
            this.button_baixarVideo.TabIndex = 13;
            this.button_baixarVideo.Text = "SÓ O VIDEO";
            this.button_baixarVideo.UseVisualStyleBackColor = true;
            this.button_baixarVideo.Click += new System.EventHandler(this.button_baixarVideo_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 289);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(336, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 14;
            // 
            // buttonbaixarVIdeoComAudio
            // 
            this.buttonbaixarVIdeoComAudio.Location = new System.Drawing.Point(95, 19);
            this.buttonbaixarVIdeoComAudio.Name = "buttonbaixarVIdeoComAudio";
            this.buttonbaixarVIdeoComAudio.Size = new System.Drawing.Size(122, 23);
            this.buttonbaixarVIdeoComAudio.TabIndex = 15;
            this.buttonbaixarVIdeoComAudio.Text = "VIDEO / AUDIO";
            this.buttonbaixarVIdeoComAudio.UseVisualStyleBackColor = true;
            this.buttonbaixarVIdeoComAudio.Click += new System.EventHandler(this.buttonbaixarVIdeoComAudio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_titulo);
            this.groupBox1.Controls.Add(this.label_autor_view);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 51);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // button_atualizar
            // 
            this.button_atualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_atualizar.Location = new System.Drawing.Point(228, 386);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(114, 24);
            this.button_atualizar.TabIndex = 19;
            this.button_atualizar.Text = "Verificar Atualização";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // linkLabel_github
            // 
            this.linkLabel_github.AutoSize = true;
            this.linkLabel_github.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel_github.Location = new System.Drawing.Point(18, 397);
            this.linkLabel_github.Name = "linkLabel_github";
            this.linkLabel_github.Size = new System.Drawing.Size(173, 13);
            this.linkLabel_github.TabIndex = 20;
            this.linkLabel_github.TabStop = true;
            this.linkLabel_github.Text = "https://github.com/DanielSvoboda";
            this.linkLabel_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_github_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_baixarAudio);
            this.groupBox2.Controls.Add(this.buttonbaixarVIdeoComAudio);
            this.groupBox2.Controls.Add(this.button_baixarVideo);
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 51);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.linkLabel_github);
            this.Controls.Add(this.button_atualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.linkLabel_colar);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Download DSS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_autor_view;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.LinkLabel linkLabel_colar;
        private System.Windows.Forms.Button button_baixarAudio;
        private System.Windows.Forms.Button button_baixarVideo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonbaixarVIdeoComAudio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.LinkLabel linkLabel_github;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

