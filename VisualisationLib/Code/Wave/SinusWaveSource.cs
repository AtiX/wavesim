/*
 *  WaveSim - Physically correct 2D-Wave simulation
 *  Author: Arthur Silber / arthur.silber@gmx.de
 *  
 */

using System;

namespace WaveSimLib.Code.Wave
{
    [Serializable()]
    public class SinusWaveSource : WaveSource
    {
        private double _time = 0.0;

        public double Frequency = 0.1;
        public double MaxElongation = 10.0;

        public override double getElongation(double deltaT)
        {
            _time += deltaT;
            double b = 2*Math.PI*Frequency;
            double elong = Math.Sin(b*_time)*MaxElongation;
            return elong;
        }

        public override void Reset()
        {
            _time = 0.0;
        }
    }
}
