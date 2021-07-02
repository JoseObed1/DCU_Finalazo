using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace DCU_PFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LbNombre.Text = "";
            SendMessage(this.CbClases.Handle, CB_SETCUEBANNER, 0, "Selecciona tu clase...");
        }

        FilterInfoCollection filtro;
        VideoCaptureDevice camara;
        BDACon datos = new BDACon();

        bool camaravalidada = false;
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        private void Form1_Load(object sender, EventArgs e)
        {
            filtro = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camara in filtro)
            {
                cboCamara.Items.Add(camara.Name);
            }
            cboCamara.SelectedIndex = 0;
            camara = new VideoCaptureDevice();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDetectar_Click(object sender, EventArgs e)
        {
            camara = new VideoCaptureDevice(filtro[cboCamara.SelectedIndex].MonikerString);
            camara.NewFrame += Camara_NuevoFrame;
            camara.Start();
            datos.wait(1500);

            LbNombre.Text = "Escaneando rostro.";
            datos.wait(500);

            LbNombre.Text = "Escaneando rostro..";
            datos.wait(1000);

            LbNombre.Text = "Escaneando rostro...";
            //LbNombre.ForeColor = Color.Green;
            datos.wait(5000);

            LbNombre.Text = datos.getName(camara);
            camaravalidada = true;
        }

        static readonly CascadeClassifier cascadeclassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        private void Camara_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            //Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            //Rectangle[] rectangles = cascadeclassifier.DetectMultiScale(grayImage, 1.2, 1);
            //foreach(Rectangle rectangulo in rectangles)
            //{
            //    using(Graphics graphics = Graphics.FromImage(bitmap))
            //    {
            //        using(Pen lapiz = new Pen(Color.Red, 5))
            //        {
            //            graphics.DrawRectangle(lapiz,rectangulo);
            //        }
            //    }
            //}
            pic.Image = bitmap;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camara.IsRunning)
            {
                camara.Stop();
            }
            Application.Exit();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (camara.IsRunning)
            {
                camara.Stop();
            }
            Application.Exit();
        }

        private void btAsistencia_Click(object sender, EventArgs e)
        {
            if (camaravalidada == true)
            {
                if (CbClases.SelectedItem == null)
                {
                    System.Windows.Forms.MessageBox.Show("Selecciona una opción!");
                }

                else
                {
                    string seleccion = CbClases.SelectedItem.ToString();
                    datos.ValidarClase(seleccion);
                }
            }

            else
            {
                System.Windows.Forms.MessageBox.Show("No has activado tu cámara!");
            }
        }
        /* 
        * DETECT FACES
        * Detects features from faces and IDs them.
        */
        public static async Task DetectFaceExtract(IFaceClient client, string url, string recognitionModel)
        {
            Console.WriteLine("========DETECT FACES========");
            Console.WriteLine();

            // Create a list of images
            List<string> imageFileNames = new List<string>
                    {
                        "detection1.jpg",    // single female with glasses
                        // "detection2.jpg", // (optional: single man)
                        // "detection3.jpg", // (optional: single male construction worker)
                        // "detection4.jpg", // (optional: 3 people at cafe, 1 is blurred)
                        "detection5.jpg",    // family, woman child man
                        "detection6.jpg"     // elderly couple, male female
                    };

            foreach (var imageFileName in imageFileNames)
            {
                IList<DetectedFace> detectedFaces;

                // Detect faces with all attributes from image url.
                detectedFaces = await client.Face.DetectWithUrlAsync($"{url}{imageFileName}",
                        returnFaceAttributes: new List<FaceAttributeType?> { FaceAttributeType.Accessories, FaceAttributeType.Age,
                FaceAttributeType.Blur, FaceAttributeType.Emotion, FaceAttributeType.Exposure, FaceAttributeType.FacialHair,
                FaceAttributeType.Gender, FaceAttributeType.Glasses, FaceAttributeType.Hair, FaceAttributeType.HeadPose,
                FaceAttributeType.Makeup, FaceAttributeType.Noise, FaceAttributeType.Occlusion, FaceAttributeType.Smile },
                        // We specify detection model 1 because we are retrieving attributes.
                        detectionModel: DetectionModel.Detection01,
                        recognitionModel: recognitionModel);

                Console.WriteLine($"{detectedFaces.Count} face(s) detected from image `{imageFileName}`.");
            }
        }
    }
}
