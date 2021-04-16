using PruebaListasString.ListaString;
using PruebaListasString.objListaOrdenada;
using ReproductorMP3.listacircularejemplo;
using ReproductorMP3.ListaDoble;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ReproductorMP3
{
   
    public partial class Form1 : Form
    {
       
      
      
        String[] RutaArchivosMP3;

        OpenFileDialog Buscar = new OpenFileDialog();
        clsListaDoble listaDB;
        ListaCircular listaC;
        public NodoC nuevo;

        public Form1()
        {
            InitializeComponent();
            picPause.Visible = true;
            macTrackVolume.Value = 50;
            label_volume.Text = "50%";
            pictureBox4.Visible = true;
            pictureBox4.Visible = false;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listaDB = new clsListaDoble();
            listaC = new ListaCircular();

            Buscar.Multiselect = true;



            if (Buscar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string dt;
                RutaArchivosMP3 = Buscar.FileNames;

                for (int i = 0; i < Buscar.FileNames.Length; i++)
                {
                    dt = RutaArchivosMP3[i];
                    listaDB.insertarCabezaLista(dt);
                    listaC.insertar(dt);

                }
                evCargardatos();

            }
            





        }

        private void evCargardatos() {


            string[] datos = listaDB.visualizar();
            foreach (string dato in datos)
            {
                int posi = dato.LastIndexOf("\\");
                int posi2 = dato.IndexOf(".mp3");
                int largo = posi2 - posi;

                ListaReproduccion.Items.Add(dato.Substring(posi + 1, largo - 1));
            }


            ListaReproduccion.SelectedIndex = 0;
            lbSonando.Text = Buscar.SafeFileNames[ListaReproduccion.SelectedIndex];
            picPlay.Visible = true;

        }

        public void recorrer()
        {

            if (nuevo != null)
            {
                nuevo = listaC.lc.enlace; // siguiente nodo al de acceso
                                                //
                while (nuevo == listaC.lc.enlace)
                {
                    if (ListaReproduccion.SelectedIndex < ListaReproduccion.Items.Count - 1)
                    {
                        ListaReproduccion.SelectedIndex += 1;
                        nuevo = nuevo.enlace;
                    }
                    else
                    {

                        WmpRepro.URL = Buscar.FileNames[0];
                        ListaReproduccion.SelectedIndex = 0;
                        nuevo = nuevo.enlace;
                    }

                    nuevo = nuevo.enlace;
                }
            }
            else
            {
                MessageBox.Show("\t Lista Circular vacía.");
            }
        }






        private void ListaReproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int select = ListaReproduccion.SelectedIndex;
            //   WmpRepro.URL = Buscar.FileNames[ListaReproduccion.SelectedIndex];
            //    WmpRepro.Ctlcontrols.play();
            //    picPlay.Visible = true;
            //    picPause.Visible = false;
            //    lbSonando.Text = Buscar.SafeFileNames[ListaReproduccion.SelectedIndex];
            //    nuevo = new NodoC(Buscar.FileNames[select]);





            //try
            //{
            //    var file = TagLib.File.Create(RutaArchivosMP3[ListaReproduccion.SelectedIndex]);
            //    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
            //    pictureCancion.Image = Image.FromStream(new MemoryStream(bin));
            //}
            //catch
            //{
            //    string rut = @"C:/Users/mynor/OneDrive/Escritorio/ArchivosReproductor/iconMp3.png";
            //    pictureCancion.ImageLocation = rut;
            //}


           

        }

        private void ReproductorMP3_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_PlaylistChange(object sender, AxWMPLib._WMPOCXEvents_PlaylistChangeEvent e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            WmpRepro.Ctlcontrols.stop();
            macTrackstatus.Value = 0;
            picPause.Visible = true;
            picPlay.Visible = false;
           

        }

        private void EliminarElemento_Click(object sender, EventArgs e)
        {
            
            
            string delete = ListaReproduccion.SelectedItem.ToString();
            int del = ListaReproduccion.SelectedIndex;
            listaDB.elimminar(delete);
            ListaReproduccion.Items.RemoveAt(del);
            WmpRepro.Ctlcontrols.stop();
            picPlay.Visible = false;
            picPause.Visible = true;
            ListaReproduccion.Items.Clear();
            evCargardatos();





        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            picPlay.Visible = false;
            picPause.Visible = true;
            Ev_Pause();
            Ev_SigueinteCancion();
           

        }

        public void Ev_SigueinteCancion() {
            if (ListaReproduccion.SelectedIndex < ListaReproduccion.Items.Count - 1)
            {
                ListaReproduccion.SelectedIndex = ListaReproduccion.SelectedIndex + 1;
            }

           
        }

        private void volver_Click(object sender, EventArgs e)
        {
            picPlay.Visible = false;
            picPause.Visible = true;
            Ev_VolverCancion();
        }

        public void Ev_VolverCancion() {
            if (ListaReproduccion.SelectedIndex > 0)
            {
                ListaReproduccion.SelectedIndex = ListaReproduccion.SelectedIndex - 1;
            }
            else
            {
                picPlay.Visible = true;

                MessageBox.Show("Esta es la primer cancion");
               
               
            }
        }



        private void picPlay_Click(object sender, EventArgs e)
        {
            EvPlay();
            


        }


        private void EvPlay() {
            picPlay.Visible = false;
            picPause.Visible = true;
            WmpRepro.Ctlcontrols.pause();

        }

        private void Ev_Pause() {

            picPause.Visible = false;
            picPlay.Visible = true;
            WmpRepro.Ctlcontrols.play();
        }

        private void picPause_Click(object sender, EventArgs e)
        {
            Ev_Pause();

            
        }
       
           
            
        

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WmpRepro.settings.volume = macTrackVolume.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (WmpRepro.playState == WMPLib.WMPPlayState.wmppsPlaying) {
                macTrackstatus.Maximum = (int)WmpRepro.Ctlcontrols.currentItem.duration;
                macTrackstatus.Value = (int)WmpRepro.Ctlcontrols.currentPosition;
                if (macTrackstatus.Maximum == macTrackstatus.Value)
                {
                    picPlay.Visible = false;
                    picPause.Visible=true;
                Ev_SigueinteCancion();
                  
                }

                if ((macTrackstatus.Maximum == macTrackstatus.Value) && pictureBox4.Visible == true)
                {
                    recorrer();

                }
                
               


                    macTrackVolume.Value = WmpRepro.settings.volume;
            }
            try
            {
                label_T_Inicio.Text = WmpRepro.Ctlcontrols.currentPositionString;
                label_T_Final.Text = WmpRepro.Ctlcontrols.currentItem.durationString.ToString();
               
            }
            catch { }
        }

        

        private void WmpRepro_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
           
        }

        private void macTrackVolume_ValueChanged(object sender, decimal value)
        {
            WmpRepro.settings.volume = macTrackVolume.Value;
            label_volume.Text = macTrackVolume.Value.ToString() + "%";
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            Ev_SigueinteCancion();
        }

        private void macTrackstatus_MouseDown(object sender, MouseEventArgs e)
        {
            WmpRepro.Ctlcontrols.currentPosition = WmpRepro.currentMedia.duration * e.X / macTrackstatus.Width;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;

           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
           

        }
    }
}
