/*
 *  WaveSim - Physically correct 2D-Wave simulation
 *  Author: Arthur Silber / arthur.silber@gmx.de
 *  
 */

using System;
using System.Drawing;

//using WAveSim.Code.SampleGrabberNET;

namespace WaveSimLib.Code.Visualisation
{
    public class DynamicColorVisualizer : IWaveVisualizer
    {
        public Color ColorMin = Color.Orange;
        public Color ColorNull = Color.Black;
        public Color ColorMax = Color.Green;

        public Color ColorWall = Color.Red;
        public Color ColorMass = Color.FromArgb(0, 55, 0);
        
        private int _iterCount = 0;
        private double _max = 10;
        private double _min = -10;

        private double _RposMap = 0.0;
        private double _GposMap = 74.2;
        private double _BposMap = 0.0;

        private double _RnegMap = -2550;
        private double _GnegMap = -1650;
        private double _BnegMap = 0.0;

        private double[,] _lastPosMap;
        private int lastX, lastY;
        
        /// <summary>
        /// Visualizes the Simulation using an unsafe Bitmap - fast, but with the danger of memory leaks
        /// </summary>
        /// <param name="positionMap"></param>
        /// <param name="wallMap"></param>
        /// <param name="massMap"></param>
        /// <param name="xMax"></param>
        /// <param name="yMax"></param>
        /// <returns></returns>
        public Bitmap VisualizePositionMap(double[,] positionMap, bool[,] wallMap, bool[,] addonWallMap, double[,] massMap, double[,] addonMassMap, int xMax, int yMax)
        {
            Bitmap res = new Bitmap(xMax, yMax);

            UnsafeBitmap usb = new UnsafeBitmap(res);
            usb.LockBitmap();

            for (int ix = 0; ix < xMax; ix++)
            {
                for (int iy = 0; iy < yMax; iy++)
                {
                    try
                    { //Sometimes there are array bound exceptions (after resize)
                        Color c = GenerateColor(positionMap, wallMap, addonWallMap, massMap, addonMassMap, ix, iy);
                        //res.SetPixel(ix, iy, c);

                        PixelData d = new PixelData();
                        d.red = c.R;
                        d.green = c.G;
                        d.blue = c.B;
                        usb.SetPixel(ix, iy, d);
                    }
                    catch (Exception e)
                    {
                        return res;
                    }
                    
                }
            }

            _lastPosMap = positionMap;
            lastX = xMax;
            lastY = yMax;
            
            usb.UnlockBitmap();

            return usb.Bitmap;
            //return res;
        }

        /// <summary>
        /// Visualizes the Simulation using a safe bitmap - slower, but with less memory leaks
        /// </summary>
        /// <param name="positionMap"></param>
        /// <param name="wallMap"></param>
        /// <param name="massMap"></param>
        /// <param name="xMax"></param>
        /// <param name="yMax"></param>
        /// <returns></returns>
        public Bitmap VisualizePositionMapSafe(double[,] positionMap, bool[,] wallMap, bool[,] addonWallMap, double[,] massMap, double[,] addonMassMap, int xMax, int yMax)
        {
            Bitmap res = new Bitmap(xMax, yMax);

            //UnsafeBitmap usb = new UnsafeBitmap(res);
            //usb.LockBitmap();

            for (int ix = 0; ix < xMax; ix++)
            {
                for (int iy = 0; iy < yMax; iy++)
                {
                    try
                    { //Sometimes there are array bound exceptions (after resize)
                        Color c = GenerateColor(positionMap, wallMap, addonWallMap, massMap, addonMassMap, ix, iy);
                        res.SetPixel(ix, iy, c);

                        //PixelData d = new PixelData();
                        //d.red = c.R;
                        //d.green = c.G;
                        //d.blue = c.B;
                        //usb.SetPixel(ix, iy, d);
                    }
                    catch (Exception e)
                    {
                        return res;
                    }

                }
            }

            _lastPosMap = positionMap;
            lastX = xMax;
            lastY = yMax;

            //usb.UnlockBitmap();

            //return usb.Bitmap;
            return res;
        }

        private Color GenerateColor(double[,] positionMap, bool[,] wallMap, bool[,] addonWallMap, double[,] massMap, double[,] addonMassMap, int X, int Y)
        {
            if (wallMap[X, Y] || addonWallMap[X,Y])
                return ColorWall;

            int R, G, B;

            if (positionMap[X,Y] >= 0)
            {
                R = ColorNull.R + (int)Math.Round(positionMap[X, Y] * _RposMap);
                G = ColorNull.G + (int)Math.Round(positionMap[X, Y] * _GposMap);
                B = ColorNull.B + (int)Math.Round(positionMap[X, Y] * _BposMap);
            }
            else
            {
                R = ColorNull.R + (int)Math.Round(positionMap[X, Y] * _RnegMap);
                G = ColorNull.G + (int)Math.Round(positionMap[X, Y] * _GnegMap);
                B = ColorNull.B + (int)Math.Round(positionMap[X, Y] * _BnegMap);
            }

            if ((massMap[X,Y] > 0)||(addonMassMap[X,Y] > 0))
            {
                //add mass color
                R += ColorMass.R;
                G += ColorMass.G;
                B += ColorMass.B;
            }

            if (R > 255)
                R = 255;
            if (G > 255)
                G = 255;
            if (B > 255)
                B = 255;
            if (R < 0)
                R = 0;
            if (G < 0)
                G = 0;
            if (B < 0)
                B = 0;

            Color c = Color.FromArgb(R, G, B);
            return c;
        }

        void CalculateColorMapping(double[,] positionMap, int xMax, int yMax)
        {
            _max = 0.1;
            _min = -0.1;

            for (int ix = 0; ix < xMax; ix++)
            {
                for (int iy = 0; iy < yMax; iy++)
                {
                    if (positionMap[ix,iy] > 0)
                        if (positionMap[ix, iy] > _max)
                        {
                            _max = positionMap[ix, iy];
                        }
                    else if (positionMap[ix, iy] < _min)
                            {
                                _min = positionMap[ix, iy];
                            }
                }
            }

            double Rs = ColorMax.R - ColorNull.R;
            double Gs = ColorMax.G - ColorNull.G;
            double Bs = ColorMax.B - ColorNull.B;

            _RposMap = Rs / _max;
            _GposMap = Gs / _max;
            _BposMap = Bs / _max;

            Rs = ColorMin.R - ColorNull.R;
            Gs = ColorMin.G - ColorNull.G;
            Bs = ColorMin.B - ColorNull.B;

            _RnegMap = Rs  /_min;
            _GnegMap = Gs / _min;
            _BnegMap = Bs / _min;

            _iterCount++;
        }

        public void UpdateColorMapping(bool updateScale)
        {
            if (updateScale)
            {
                _max = 0.1;
                _min = -0.1;

                for (int ix = 0; ix < lastX; ix++)
                {
                    for (int iy = 0; iy < lastY; iy++)
                    {
                        if (_lastPosMap[ix, iy] > 0 || _lastPosMap[ix,iy] < 0)
                            if (_lastPosMap[ix, iy] > _max)
                            {
                                _max = _lastPosMap[ix, iy];
                            }
                            else if (_lastPosMap[ix, iy] < _min)
                            {
                                _min = _lastPosMap[ix, iy];
                            }
                    }
                }
            }

            double Rs = ColorMax.R - ColorNull.R;
            double Gs = ColorMax.G - ColorNull.G;
            double Bs = ColorMax.B - ColorNull.B;

            _RposMap = Rs / _max;
            _GposMap = Gs / _max;
            _BposMap = Bs / _max;

            Rs = ColorMin.R - ColorNull.R;
            Gs = ColorMin.G - ColorNull.G;
            Bs = ColorMin.B - ColorNull.B;

            _RnegMap = Rs / _min;
            _GnegMap = Gs / _min;
            _BnegMap = Bs / _min;
        }
    }
}
