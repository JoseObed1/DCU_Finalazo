using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCU_PFinal
{
    public class BDACon
    {
        public int validada = 0;
        public string getName(VideoCaptureDevice imagen)
        {
            string nombre = "Ronald Cabrera González 2019-8467";
            return nombre;
        }

        public void ValidarClase(string nombredeclase)
        {
            if (validada == 0)
            {
                switch (nombredeclase)
                {
                    case "Diseño Centrado al Usuario":
                        System.Windows.Forms.MessageBox.Show("Asistencia validada de forma exitosa.");
                        validada = 1;
                        break;

                    case "Programación 2":
                        System.Windows.Forms.MessageBox.Show("Tu asistencia a Programación 2 fue validada a las: 8:15AM.");
                        break;

                    default:
                        System.Windows.Forms.MessageBox.Show("No hay una clase activa de: " + nombredeclase + " actualmente.");
                        break;
                }
            }

            else
            {
                switch (nombredeclase)
                {
                    case "Diseño Centrado al Usuario":
                        System.Windows.Forms.MessageBox.Show("Ya validaste tu asistencia!");
                        break;

                    case "Programación 2":
                        System.Windows.Forms.MessageBox.Show("Tu asistencia a Programación 2 fue validada a las: 8:15AM");
                        break;

                    default:
                        System.Windows.Forms.MessageBox.Show("No hay una clase activa de: " + nombredeclase + " actualmente.");
                        break;
                }
            }

        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

    }
}
