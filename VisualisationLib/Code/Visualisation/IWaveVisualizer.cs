/*
 *  WaveSim - Physically correct 2D-Wave simulation
 *  Author: Arthur Silber / arthur.silber@gmx.de
 *  
 */

using System.Drawing;

namespace WaveSimLib.Code.Visualisation
{
    public interface IWaveVisualizer
    {
        Bitmap VisualizePositionMap(double[,] positionMap, bool[,] wallMap, bool[,] addonWallMap, double[,] massMap, double[,] addonMassMap, int xMax, int yMax);
    }
}
