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
    class SaveImg
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

                bmp1.Save(@"E:\Labs\7.Сжатие изображений\Img_Rashifr.jpg", jpgEncoder, myEncoderParameters);

            }
            catch (System.NullReferenceException) { MessageBox.Show("Ошибка"); }

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

                bmp1.Save(@"E:\Labs\7.Сжатие изображений\Img_Shifr.jpg", jpgEncoder, myEncoderParameters);
            }
            catch (System.NullReferenceException) { MessageBox.Show("Ошибка"); }

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
