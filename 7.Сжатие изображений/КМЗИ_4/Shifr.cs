using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO.Compression;
using System.IO;

namespace КМЗИ_4
{
    class Shifr
    {

       

        public void run(Bitmap bmp1)
        {
            long g = 10;



            string path = @"E:\Поляков Максим Сергеевич\KMZI\7.Сжатие изображений\7.Сжатие изображений\11.jpg";

            Bitmap bmp = new Bitmap(path, true);


            byte[,,] b = this.BmpToBytes(bmp);


            byte[] o = this.Compress(b, bmp.Width, bmp.Height);
            Shi shi = new Shi();
            shi.sgtShi(bmp1,g);

            

        }


        private byte[] Compress(byte[,,] rgb, int cW, int cH)
        {
          
            int Y = 80, cr = 70, cb = 70;
            int id = 6; 
            double[,,] YCrCb = YCrCbC(rgb, cW, cH, Y, cr, cb, cW, cH);
           
            byte[] fl = doPack(YCrCb, cW, cH, id);
            return fl;

        }

        
        private byte[] doPack(double[,,] ImgData, int cW, int cH, int wDepth)
        {
            short Value;
            int lPos = 0;
            int size = cW * cH * 3;
            int intCount = 0;
            short[] shorts = new short[size];
            byte[] Ret = new byte[size];
            for (int d = wDepth - 1; d >= 0; d--)
            {
                int wSize = (int)Math.Pow(2f, Convert.ToDouble(d));
                int W = cW / wSize;
                int H = cH / wSize;
                int w2 = W / 2;
                int h2 = H / 2;

                if (d == wDepth - 1)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        for (int j = 0; j < h2; j++)
                        {
                            for (int i = 0; i < w2; i++)
                            {
                                Value = (short)Math.Round(ImgData[z, i, j]);
                                if ((Value >= -127) && (Value <= 127))
                                {
                                    Ret[lPos++] = Convert.ToByte(Value + 127);
                                }
                                else
                                {
                                    Ret[lPos++] = 255;
                                    shorts[intCount++] = Value;
                                }
                            }
                        }
                    }
                }

                for (int z = 0; z < 3; z++)
                {
                    for (int j = 0; j < H; j++)
                    {
                        for (int i = w2; i < W; i++)
                        {
                            Value = (short)Math.Round(ImgData[z, i, j]);
                            if ((Value >= -127) && (Value <= 127))
                            {
                                Ret[lPos++] = Convert.ToByte(Value + 127);
                            }
                            else
                            {
                                Ret[lPos++] = 255;
                                shorts[intCount++] = Value;
                            }
                        }
                    }
                }

                for (int z = 0; z < 3; z++)
                {
                    for (int j = h2; j < H; j++)
                    {
                        for (int i = 0; i < w2; i++)
                        {
                            Value = (short)Math.Round(ImgData[z, i, j]);
                            if ((Value >= -127) && (Value <= 127))
                            {
                                Ret[lPos++] = Convert.ToByte(Value + 127);
                            }
                            else
                            {
                                Ret[lPos++] = 255;
                                shorts[intCount++] = Value;
                            }
                        }
                    }
                }
            }

            int shortArraySize = intCount * 2;
            Array.Resize(ref Ret, Ret.Length + shortArraySize);
            Buffer.BlockCopy(shorts, 0, Ret, Ret.Length - shortArraySize, shortArraySize);

            return Ret;
        }



        //  перекодирования RGB в YCrCb
        private double[,,] YCrCbC(byte[,,] RGB, int cW, int cH, double Ydiv, double Udiv, double Vdiv, int oW, int oH)
        {
            double vr, vg, vb;
            double kr = 0.299, kg = 0.587, kb = 0.114, kr1 = -0.1687, kg1 = 0.3313, kb1 = 0.5, kr2 = 0.5, kg2 = 0.4187, kb2 = 0.0813;
            Ydiv = Ydiv / 100f;
            Udiv = Udiv / 100f;
            Vdiv = Vdiv / 100f;
            double[,,] YCrCb = new double[3, cW, cH];
            for (int j = 0; j < oH; j++)
            {
                for (int i = 0; i < oW; i++)
                {
                    vb = (double)RGB[0, i, j];
                    vg = (double)RGB[1, i, j];
                    vr = (double)RGB[2, i, j];
                    YCrCb[2, i, j] = (kr * vr + kg * vg + kb * vb) * Ydiv;
                    YCrCb[1, i, j] = (kr1 * vr - kg1 * vg + kb1 * vb + 128) * Udiv;
                    YCrCb[0, i, j] = (kr2 * vr - kg2 * vg - kb2 * vb + 128) * Udiv;
                }
            }
            return YCrCb;
        }

        private byte[,,] BmpToBytes(Bitmap bmp)
        {
            BitmapData bData = bmp.LockBits(new Rectangle(new Point(), bmp.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            int byteCount = bData.Stride * bmp.Height;
            byte[] bmpBytes = new byte[byteCount];
            Marshal.Copy(bData.Scan0, bmpBytes, 0, byteCount);

            bmp.UnlockBits(bData);
            byte[,,] ret = new byte[3, bmp.Width, bmp.Height];
            for (int z = 0; z < 3; z++)
            {
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        ret[z, i, j] = bmpBytes[j * bmp.Width * 3 + i * 3 + z];
                    }
                }
            }
            return ret;
        }

    }


}
