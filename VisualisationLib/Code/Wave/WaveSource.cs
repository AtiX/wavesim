/*
 *  WaveSim - Physically correct 2D-Wave simulation
 *  Author: Arthur Silber / arthur.silber@gmx.de
 *  
 */

using System;

namespace WaveSimLib.Code.Wave
{
    [Serializable()]
    public abstract class WaveSource
    {
        public int X;
        public int Y;

        public abstract double getElongation(double deltaT);

        public abstract void Reset();
    }
}
