/*
 *  WaveSim - Physically correct 2D-Wave simulation
 *  Author: Arthur Silber / arthur.silber@gmx.de
 *  
 */

using System;
using System.Drawing;

namespace WaveSimLib.Code.Visualisation
{
    class BlackWhiteVisualizer : IWaveVisualizer
    {
        private double _sPosMax = 3;
        private double _sPosMin = -3;

        private double _pixelMultiplier = 1;

        public BlackWhiteVisualizer()
        {
            CalculateMultiplier();
        }

        public Bitmap VisualizePositionMap(double[,] positionMap, bool[,] wallMap, double[,] massMap,int xMax, int yMax)
        {
            Bitmap bmp = new Bitmap(xMax, yMax);

            for (int x = 0; x < xMax; x++)
            {
                for (int y = 0; y < yMax; y++)
                {
                    if (!wallMap[x, y])
                    {
                        bool mass = false;
                        if (massMap[x, y] > 0.0)
                            mass = true;

                        double value = positionMap[x, y];
                        SetValuePixel(x, y, mass, bmp, value);
                    }
                    else
                    {
                        
                        bmp.SetPixel(x, y, Color.Red);
                    }
                }
            }

            return bmp;
        }

        private void SetValuePixel(int x, int y, bool mass, Bitmap bmp, double value)
        {
            /*if (value > _sPosMax)
            {
                _sPosMax = value;
                CalculateMultiplier();
            }
            else if (value < _sPosMin)
            {
                _sPosMin = value;
                CalculateMultiplier();
            }*/
            int rg = 125;

            if (value >= 0.0)
            {
                rg = (int) Math.Round(125 + value*_pixelMultiplier);
            }
            else
            {
                rg = (int) Math.Round(125 - value*_pixelMultiplier);
            }

            if (rg > 255)
                rg = 255;
            if (rg < 0)
                rg = 0;

            int r = rg - 75;
            if (r < 0)
                r = 75;

            if (rg < 20)
                rg = 20;

            if (!mass)
                bmp.SetPixel(x, y, Color.FromArgb(rg-20, rg-20, rg));
            else
                bmp.SetPixel(x, y, Color.FromArgb(rg-20, rg-20, r));
        }

        private void CalculateMultiplier()
        {
            _pixelMultiplier = 100/_sPosMax;
            if (100 / _sPosMin < _pixelMultiplier)
                _pixelMultiplier = 100/_sPosMin;
        }

        public Bitmap VisualizePositionMap(double[,] positionMap, bool[,] wallMap, bool[,] addonWallMap, double[,] massMap, double[,] addonMassMap, int xMax, int yMax)
        {
            throw new NotImplementedException();
        }
    }
}
