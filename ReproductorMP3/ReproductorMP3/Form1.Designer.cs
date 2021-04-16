
namespace ReproductorMP3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListaReproduccion = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.EliminarElemento = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WmpRepro = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_volume = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbSonando = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.macTrackVolume = new XComponent.SliderBar.MACTrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picPause = new System.Windows.Forms.PictureBox();
            this.siguiente = new System.Windows.Forms.PictureBox();
            this.volver = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_T_Final = new System.Windows.Forms.Label();
            this.label_T_Inicio = new System.Windows.Forms.Label();
            this.macTrackstatus = new XComponent.SliderBar.MACTrackBar();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureCancion = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarElemento)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WmpRepro)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCancion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.ListaReproduccion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 689);
            this.panel1.TabIndex = 0;
            // 
            // ListaReproduccion
            // 
            this.ListaReproduccion.BackColor = System.Drawing.Color.Silver;
            this.ListaReproduccion.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListaReproduccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaReproduccion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ListaReproduccion.HorizontalScrollbar = true;
            this.ListaReproduccion.ItemHeight = 19;
            this.ListaReproduccion.Location = new System.Drawing.Point(0, 77);
            this.ListaReproduccion.Name = "ListaReproduccion";
            this.ListaReproduccion.Size = new System.Drawing.Size(250, 612);
            this.ListaReproduccion.Sorted = true;
            this.ListaReproduccion.TabIndex = 2;
            this.ListaReproduccion.SelectedIndexChanged += new System.EventHandler(this.ListaReproduccion_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 77);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.EliminarElemento);
            this.panel6.Location = new System.Drawing.Point(180, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(64, 65);
            this.panel6.TabIndex = 3;
            // 
            // EliminarElemento
            // 
            this.EliminarElemento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EliminarElemento.Image = ((System.Drawing.Image)(resources.GetObject("EliminarElemento.Image")));
            this.EliminarElemento.Location = new System.Drawing.Point(0, 0);
            this.EliminarElemento.Name = "EliminarElemento";
            this.EliminarElemento.Size = new System.Drawing.Size(64, 65);
            this.EliminarElemento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EliminarElemento.TabIndex = 1;
            this.EliminarElemento.TabStop = false;
            this.EliminarElemento.Click += new System.EventHandler(this.EliminarElemento_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(3, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(64, 65);
            this.panel5.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // WmpRepro
            // 
            this.WmpRepro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WmpRepro.Enabled = true;
            this.WmpRepro.Location = new System.Drawing.Point(138, 396);
            this.WmpRepro.Name = "WmpRepro";
            this.WmpRepro.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WmpRepro.OcxState")));
            this.WmpRepro.Size = new System.Drawing.Size(113, 54);
            this.WmpRepro.TabIndex = 0;
            this.WmpRepro.Visible = false;
            this.WmpRepro.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WmpRepro_PlayStateChange);
            this.WmpRepro.PlaylistChange += new AxWMPLib._WMPOCXEvents_PlaylistChangeEventHandler(this.axWindowsMediaPlayer1_PlaylistChange);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label_volume);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.macTrackVolume);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(250, 579);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 110);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(103, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(103, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_volume.Location = new System.Drawing.Point(579, 39);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(48, 17);
            this.label_volume.TabIndex = 13;
            this.label_volume.Text = "100%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vol.";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbSonando);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Location = new System.Drawing.Point(27, 80);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(587, 22);
            this.panel9.TabIndex = 9;
            // 
            // lbSonando
            // 
            this.lbSonando.AutoSize = true;
            this.lbSonando.Location = new System.Drawing.Point(129, 0);
            this.lbSonando.Name = "lbSonando";
            this.lbSonando.Size = new System.Drawing.Size(18, 17);
            this.lbSonando.TabIndex = 9;
            this.lbSonando.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reproduciendo;";
            // 
            // macTrackVolume
            // 
            this.macTrackVolume.BackColor = System.Drawing.Color.Transparent;
            this.macTrackVolume.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackVolume.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackVolume.IndentHeight = 6;
            this.macTrackVolume.Location = new System.Drawing.Point(493, 36);
            this.macTrackVolume.Maximum = 100;
            this.macTrackVolume.Minimum = 0;
            this.macTrackVolume.Name = "macTrackVolume";
            this.macTrackVolume.Size = new System.Drawing.Size(91, 20);
            this.macTrackVolume.TabIndex = 7;
            this.macTrackVolume.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackVolume.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackVolume.TickHeight = 4;
            this.macTrackVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackVolume.TrackerColor = System.Drawing.Color.Blue;
            this.macTrackVolume.TrackerSize = new System.Drawing.Size(8, 8);
            this.macTrackVolume.TrackLineColor = System.Drawing.Color.Gray;
            this.macTrackVolume.TrackLineHeight = 3;
            this.macTrackVolume.TrackLineSelectedColor = System.Drawing.Color.Navy;
            this.macTrackVolume.Value = 0;
            this.macTrackVolume.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackVolume_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(461, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.picPlay);
            this.panel7.Controls.Add(this.picPause);
            this.panel7.Controls.Add(this.siguiente);
            this.panel7.Controls.Add(this.volver);
            this.panel7.Controls.Add(this.btnStop);
            this.panel7.Location = new System.Drawing.Point(145, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(310, 68);
            this.panel7.TabIndex = 5;
            // 
            // picPlay
            // 
            this.picPlay.Image = ((System.Drawing.Image)(resources.GetObject("picPlay.Image")));
            this.picPlay.Location = new System.Drawing.Point(160, 7);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(47, 47);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlay.TabIndex = 6;
            this.picPlay.TabStop = false;
            this.picPlay.Visible = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // picPause
            // 
            this.picPause.Image = ((System.Drawing.Image)(resources.GetObject("picPause.Image")));
            this.picPause.Location = new System.Drawing.Point(160, 7);
            this.picPause.Name = "picPause";
            this.picPause.Size = new System.Drawing.Size(47, 47);
            this.picPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPause.TabIndex = 5;
            this.picPause.TabStop = false;
            this.picPause.Click += new System.EventHandler(this.picPause_Click);
            // 
            // siguiente
            // 
            this.siguiente.Image = ((System.Drawing.Image)(resources.GetObject("siguiente.Image")));
            this.siguiente.Location = new System.Drawing.Point(239, 7);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(47, 47);
            this.siguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.siguiente.TabIndex = 3;
            this.siguiente.TabStop = false;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // volver
            // 
            this.volver.Image = ((System.Drawing.Image)(resources.GetObject("volver.Image")));
            this.volver.Location = new System.Drawing.Point(26, 7);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(47, 47);
            this.volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.volver.TabIndex = 4;
            this.volver.TabStop = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(95, 7);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(47, 47);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnStop.TabIndex = 0;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.label_T_Final);
            this.panel4.Controls.Add(this.label_T_Inicio);
            this.panel4.Controls.Add(this.macTrackstatus);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(250, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(626, 579);
            this.panel4.TabIndex = 2;
            // 
            // label_T_Final
            // 
            this.label_T_Final.AutoSize = true;
            this.label_T_Final.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T_Final.Location = new System.Drawing.Point(545, 545);
            this.label_T_Final.Name = "label_T_Final";
            this.label_T_Final.Size = new System.Drawing.Size(55, 24);
            this.label_T_Final.TabIndex = 3;
            this.label_T_Final.Text = "00:00";
            // 
            // label_T_Inicio
            // 
            this.label_T_Inicio.AutoSize = true;
            this.label_T_Inicio.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T_Inicio.Location = new System.Drawing.Point(15, 545);
            this.label_T_Inicio.Name = "label_T_Inicio";
            this.label_T_Inicio.Size = new System.Drawing.Size(55, 24);
            this.label_T_Inicio.TabIndex = 2;
            this.label_T_Inicio.Text = "00:00";
            // 
            // macTrackstatus
            // 
            this.macTrackstatus.BackColor = System.Drawing.Color.Transparent;
            this.macTrackstatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackstatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackstatus.IndentHeight = 6;
            this.macTrackstatus.Location = new System.Drawing.Point(93, 545);
            this.macTrackstatus.Maximum = 100;
            this.macTrackstatus.Minimum = 0;
            this.macTrackstatus.Name = "macTrackstatus";
            this.macTrackstatus.Size = new System.Drawing.Size(435, 21);
            this.macTrackstatus.TabIndex = 1;
            this.macTrackstatus.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackstatus.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackstatus.TickHeight = 4;
            this.macTrackstatus.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackstatus.TrackerColor = System.Drawing.Color.Blue;
            this.macTrackstatus.TrackerSize = new System.Drawing.Size(9, 9);
            this.macTrackstatus.TrackLineColor = System.Drawing.Color.Gray;
            this.macTrackstatus.TrackLineHeight = 3;
            this.macTrackstatus.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.macTrackstatus.Value = 0;
            this.macTrackstatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.macTrackstatus_MouseDown);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pictureCancion);
            this.panel8.Controls.Add(this.WmpRepro);
            this.panel8.Location = new System.Drawing.Point(7, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(607, 521);
            this.panel8.TabIndex = 0;
            // 
            // pictureCancion
            // 
            this.pictureCancion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureCancion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureCancion.Image = ((System.Drawing.Image)(resources.GetObject("pictureCancion.Image")));
            this.pictureCancion.Location = new System.Drawing.Point(0, 0);
            this.pictureCancion.Name = "pictureCancion";
            this.pictureCancion.Size = new System.Drawing.Size(607, 521);
            this.pictureCancion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCancion.TabIndex = 0;
            this.pictureCancion.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 689);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Reproductor MP3";
            this.Load += new System.EventHandler(this.ReproductorMP3_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EliminarElemento)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WmpRepro)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCancion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private AxWMPLib.AxWindowsMediaPlayer WmpRepro;
        public System.Windows.Forms.ListBox ListaReproduccion;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox EliminarElemento;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.PictureBox siguiente;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picPause;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureCancion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private XComponent.SliderBar.MACTrackBar macTrackVolume;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbSonando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private XComponent.SliderBar.MACTrackBar macTrackstatus;
        private System.Windows.Forms.Label label_T_Final;
        private System.Windows.Forms.Label label_T_Inicio;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

