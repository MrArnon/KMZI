using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO.Compression;
using System.IO;

namespace КМЗИ_4
{
    class Shi
    {



        public void sgtRas(Bitmap bmp1, long g)
        {
            try
            {

                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                System.Drawing.Imaging.Encoder myEncoder =
                    System.Drawing.Imaging.Encoder.Quality;

                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, g);
                myEncoderParameters.Param[0] = myEncoderParameter;

                bmp1.Save(@"C:\Users\Павел\Desktop\КМЗИ_4\PicRas.jpg", jpgEncoder, myEncoderParameters);

            }
            catch (System.NullReferenceException) { MessageBox.Show("Что-то пошло не так"); }

        }

        public void sgtShi(Bitmap bmp1, long g)
        {
            try
            {

                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                System.Drawing.Imaging.Encoder myEncoder =
                    System.Drawing.Imaging.Encoder.Quality;

                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, g);
                myEncoderParameters.Param[0] = myEncoderParameter;

                bmp1.Save(@"E:\Поляков Максим Сергеевич\KMZI\7.Сжатие изображений\7.Сжатие изображений\PicShi.jpg", jpgEncoder, myEncoderParameters);
            }
            catch (System.NullReferenceException) { MessageBox.Show("Что-то пошло не так"); }

        }


        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

    }
}
