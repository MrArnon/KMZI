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
    class Decript
    {
       

        public void run(Bitmap bmp1)
        {
            int g = 80;


            Bitmap bmp2 = bmp1;
            int Y = 80, cr = 70, cb = 70;
            byte[,,] b = this.BmpToBytes(bmp2);
            double[,,] YCrCb = YCrCbE(b, bmp2.Width, bmp2.Height, Y, cr, cb, bmp2.Width, bmp2.Height);
            byte[] com = doPack(YCrCb , bmp2.Width, bmp2.Height, 6);


            int z;
            int dwDepth = 6; 
            int w = 512;
            int h = 512;
            

            int[] dwDiv = { 48, 32, 16, 16, 24, 24, 1, 1 }, dwTop = { 24, 32, 24, 24, 24, 24, 32, 32 };
            int Sam = 2;

            double[,,] yuv = doUnPack(com, w, h, dwDepth);

            for (z = 0; z < 2; z++)
            {
                for (int dWave = dwDepth - 1; dWave >= 0; dWave--)
                {
                    int w2 = Convert.ToInt32(w / Math.Pow(2, dWave));
                    int h2 = Convert.ToInt32(h / Math.Pow(2, dWave));
                    UnPack(yuv, z, w2, h2, dwDiv[dWave] * Sam);
                }
            }
            SaveImg shi = new SaveImg();

            shi.sgtRas(bmp1, g);

            z = 2;
            for (int dWave = dwDepth - 1; dWave >= 0; dWave--)
            {
                int w2 = Convert.ToInt32(w / Math.Pow(2, dWave));
                int h2 = Convert.ToInt32(h / Math.Pow(2, dWave));
                UnPack(yuv, z, w2, h2, dwDiv[dWave]);
            }
            

            byte[] rgb_fl = this.YCrCbD(yuv, w, h, Y, cr, cb);
        }

        private static double[,,] doUnPack(byte[] Bytes, int cW, int cH, int dw)
        {
            int lPos = 0;
            byte Value;
            int intIndex = 0;
            int size = cW * cH * 3;
            double[,,] ImgData = new double[3, cW, cH];

            int shortsLength = Bytes.Length - size;
            short[] shorts = new short[shortsLength / 2];
            Buffer.BlockCopy(Bytes, size, shorts, 0, shortsLength);

            for (int d = dw - 1; d >= 0; d--)
            {
                int wSize = (int)Math.Pow(2, d);
                int W = cW / wSize;
                int H = cH / wSize;
                int w2 = W / 2;
                int h2 = H / 2;
                
                if (d == dw - 1)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        for (int j = 0; j < h2; j++)
                        {
                            for (int i = 0; i < w2; i++)
                            {
                                Value = Bytes[lPos++];
                                if (Value == 255)
                                {
                                    ImgData[z, i, j] = shorts[intIndex++];
                                }
                                else
                                {
                                    ImgData[z, i, j] = Value - 127;
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
                            Value = Bytes[lPos++];
                            if (Value == 255)
                            {
                                ImgData[z, i, j] = shorts[intIndex++];
                            }
                            else
                            {
                                ImgData[z, i, j] = Value - 127;
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
                            Value = Bytes[lPos++];
                            if (Value == 255)
                            {
                                ImgData[z, i, j] = shorts[intIndex++];
                            }
                            else
                            {
                                ImgData[z, i, j] = Value - 127;
                            }
                        }
                    }
                }
            }

            return ImgData;
        }

        private void UnPack(double[,,] ImgArray, int Com, int cW, int cH, int dw)
        {
            int cw2 = cW / 2, ch2 = cH / 2;
            double dbDiv = 1f / dw;

            for (int i = 0; i < cW; i++)
            {
                for (int j = 0; j < cH; j++)
                {
                    if ((i >= cw2) || (j >= ch2))
                    {
                        if (ImgArray[Com, i, j] != 0)
                        {
                            ImgArray[Com, i, j] /= dbDiv;
                        }
                    }
                }
            }

            for (int i = 0; i < cW; i++)
            {
                reWv(ref ImgArray, cH, Com, i, 0);
            }
            for (int j = 0; j < cH; j++)
            {
                reWv(ref ImgArray, cW, Com, j, 1);
            }
        }


        private double[,,] YCrCbE(byte[,,] BytesRGB, int cW, int cH, double Y, double U, double V, int oW, int oH)
        {
            double vr, vg, vb;
            double kr = 0.299, kg = 0.587, kb = 0.114, kr1 = -0.1687, kg1 = 0.3313, kb1 = 0.5, kr2 = 0.5, kg2 = 0.4187, kb2 = 0.0813;
            Y = Y / 100f;
            U = U / 100f;
            V = V / 100f;
            double[,,] YCrCb = new double[3, cW, cH];
            for (int j = 0; j < oH; j++)
            {
                for (int i = 0; i < oW; i++)
                {
                    vb = (double)BytesRGB[0, i, j];
                    vg = (double)BytesRGB[1, i, j];
                    vr = (double)BytesRGB[2, i, j];
                    YCrCb[2, i, j] = (kr * vr + kg * vg + kb * vb) * Y;
                    YCrCb[1, i, j] = (kr1 * vr - kg1 * vg + kb1 * vb + 128) * U;
                    YCrCb[0, i, j] = (kr2 * vr - kg2 * vg - kb2 * vb + 128) * U;
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


        private byte[] doPack(double[,,] ImgData, int cW, int cH, int wD)
        {
            short Value;
            int lPos = 0;
            int size = cW * cH * 3;
            int intCount = 0;
            short[] shorts = new short[size];
            byte[] Ret = new byte[size];
            for (int d = wD - 1; d >= 0; d--)
            {
                int wSize = (int)Math.Pow(2f, Convert.ToDouble(d));
                int W = cW / wSize;
                int H = cH / wSize;
                int w2 = W / 2;
                int h2 = H / 2;

                if (d == wD - 1)
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

            int iP = intCount * 2;
            Array.Resize(ref Ret, Ret.Length + iP);
            Buffer.BlockCopy(shorts, 0, Ret, Ret.Length - iP, iP);

            return Ret;
        }


        private void reWv(ref double[,,] shorts, int n, int z, int dw, int s)
        {

            double a;
            double[] mas = new double[n];
            double[] temp = new double[n];

            if (s == 0)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[j] = shorts[z, dw, j];
                }
            }
            else if (s == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    mas[i] = shorts[z, i, dw];
                }
            }

            for (int i = 0; i < n / 2; i++)
            {
                temp[i * 2] = mas[i];
                temp[i * 2 + 1] = mas[i + n / 2];
            }
            for (int i = 0; i < n; i++)
            {
                mas[i] = temp[i];
            }

            a = 1.149604398f;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    mas[i] = mas[i] * a;
                }
                else
                {
                    mas[i] = mas[i] / a;
                }
            }

            a = -0.4435068522f;
            for (int i = 2; i < n; i += 2)
            {
                mas[i] = mas[i] + a * (mas[i - 1] + mas[i + 1]);
            }
            mas[0] = mas[0] + 2 * a * mas[1];

            a = -0.8829110762f;
            for (int i = 1; i < n - 1; i += 2)
            {
                mas[i] = mas[i] + a * (mas[i - 1] + mas[i + 1]);
            }
            mas[n - 1] = mas[n - 1] + 2 * a * mas[n - 2];

            a = 0.05298011854f;
            for (int i = 2; i < n; i += 2)
            {
                mas[i] = mas[i] + a * (mas[i - 1] + mas[i + 1]);
            }
            mas[0] = mas[0] + 2 * a * mas[1];

            a = 1.586134342f;
            for (int i = 1; i < n - 1; i += 2)
            {
                mas[i] = mas[i] + a * (mas[i - 1] + mas[i + 1]);
            }
            mas[n - 1] = mas[n - 1] + 2 * a * mas[n - 2];

            if (s == 0)
            {
                for (int j = 0; j < n; j++)
                {
                    shorts[z, dw, j] = mas[j];
                }
            }
            else if (s == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    shorts[z, i, dw] = mas[i];
                }
            }
        }

        //  перекодирования YCrCb в RGB
        private byte[] YCrCbD(double[,,] mas, int w, int h, double Y, double U, double V)
        {
            byte[] flat = new byte[3 * w * h];
            double vr, vg, vb;
            double vY, vCb, vCr;
            Y = Y / 100f;
            U = U / 100f;
            V = V / 100f;
            for (int j = 0; j < h; j++)
            {
                for (int i = 0; i < w; i++)
                {
                    vCr = mas[0, i, j] / V;
                    vCb = mas[1, i, j] / U;
                    vY = mas[2, i, j] / Y;
                    vr = vY + 1.402f * (vCr - 128f);
                    vg = vY - 0.34414f * (vCb - 128f) - 0.71414f * (vCr - 128f);
                    vb = vY + 1.722f * (vCb - 128f);
                    if (vr > 255) { vr = 255; }
                    if (vg > 255) { vg = 255; }
                    if (vb > 255) { vb = 255; }
                    if (vr < 0) { vr = 0; }
                    if (vg < 0) { vg = 0; }
                    if (vb < 0) { vb = 0; }
                    flat[j * w * 3 + i * 3 + 0] = (byte)vb;
                    flat[j * w * 3 + i * 3 + 1] = (byte)vg;
                    flat[j * w * 3 + i * 3 + 2] = (byte)vr;
                }
            }
            return flat;
        }
    }
}
