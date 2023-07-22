
using System.Drawing;
using System.IO.Pipes;
using System.Text;
using System.Text.RegularExpressions;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using SixLabors.ImageSharp;
//using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using OpenCvSharp;
using System.Collections;
using System.Windows;

//using System.Windows.Forms;







internal class Program
{
    private static void Main(string[] args)
    {



        var client = new NamedPipeClientStream("PipesOfPiece");

        client.Connect();

        Console.WriteLine("client connected");

        StreamReader reader = new StreamReader(client);




        while (true)
        {

            string frameToBase64 = reader.ReadLine();

            Console.WriteLine(frameToBase64);



            /*string[] arrayString = frameToBase64.Split(',');
            byte[] strringToByte = new byte[arrayString.Length-1]; 
            for (int i = 0; i < arrayString.Length-1; i++)
            {
                Console.WriteLine(arrayString[i] );
                // strringToByte[i] = arrayString[i];
            }
*/

            //Mat matObject = new Mat();


            //Image<Rgba32> image = ConvertBase64StringToImage(frameToBase64);

            //PictureBox pictureBox = new PictureBox;

            /*int width = image.Width;
            int height = image.Height;
            Mat mat = new Mat(height, width, DepthType.Cv8U, 3);
            mat = ConvertImageToMat(image);*/

            //matObject = ConvertImageToMat(image);




            /*byte[] byteArray = Convert.FromBase64String(frameToBase64);



            matObject.Create(720, 1280, DepthType.Cv8U, 3);


            System.Runtime.InteropServices.Marshal.Copy(byteArray, 0, matObject.DataPointer, byteArray.Length);

            String win2 = "Test Window (Press any key to close)"; //The name of the window

            CvInvoke.NamedWindow(win2); //Create the window using the specific name
            Capture capture = new Capture();
            VideoCapture capture = new VideoCapture();
            capture.Read(matObject);*/

        }


  /*      static Image<Bgr, byte> ConvertBase64StringToImage(string base64Frame)
    {
        byte[] imageBytes = Convert.FromBase64String(base64Frame);
        using (MemoryStream ms = new MemoryStream(imageBytes))
        {

                
            Image<Bgr, byte> image = new Image<Bgr, byte>(ms);
            return image;
        }
    }*/



    }



}