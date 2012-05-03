/*
 *  WaveSim - Physically correct 2D-Wave simulation
 *  Author: Arthur Silber / arthur.silber@gmx.de
 *  
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WaveSimLib.Code.Wave
{
    [Serializable()]
    public class WaveSettings
    {
        //General Simulation Values
        public double FederkonstanteKopplung = 2.0;
        public double TeilchenDistanz = 1.0;

        public double Teilchenmasse = 1.0;
        public double FederkonstanteTeilchen = 1.0;
        
        public double DeltaT = 0.2;
        public int DesiredFPS = 100;

        public double Energieerhaltung = 0.967;

        //Current Simulation Data
        public int Width  = 1280;
        public int Height = 768;

        public bool[,] WallMap = new bool[1280,768];
        public double[,] ElongationMap = new double[1280,768];
        public double[,] VelocityMap = new double[1280,768];
        public double[,] MassMap = new double[1280,768];
        public List<WaveSource> WaveSources = new List<WaveSource>();

        //Methods
        public WaveSettings()
        {
            
        }

        public WaveSettings(Size size)
        {
            WallMap = new bool[(int)size.Width,(int)size.Height];
            ElongationMap = new double[(int)size.Width,(int)size.Height];
            VelocityMap = new double[(int)size.Width,(int)size.Height];
            MassMap = new double[(int)size.Width,(int)size.Height];
            this.Width = size.Width;
            this.Height = size.Height;
        }

        public bool SaveToFile(string filename)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fstr = null;

            try
            {
                if (File.Exists(filename))
                    File.Delete(filename);

                fstr = new FileStream(filename, FileMode.Create,FileAccess.ReadWrite);
                bf.Serialize(fstr, this);
                fstr.Close();
            }
            catch (Exception)
            {
                if (fstr != null)
                {
                    fstr.Close();
                }
                return false;
            }
            return true;
        }

        public bool LoadFromFile(string filename)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fstr = null;

            if (!File.Exists(filename))
                return false;

            try
            {
                fstr = new FileStream(filename, FileMode.Open);
                WaveSettings set = (WaveSettings)bf.Deserialize(fstr);
                fstr.Close();

                this.DeltaT = set.DeltaT;
                this.DesiredFPS = set.DesiredFPS;
                this.ElongationMap = set.ElongationMap;
                this.Energieerhaltung = set.Energieerhaltung;
                this.FederkonstanteKopplung = set.FederkonstanteKopplung;
                this.FederkonstanteTeilchen = set.FederkonstanteTeilchen;
                this.Height = set.Height;
                this.MassMap = set.MassMap;
                this.TeilchenDistanz = set.TeilchenDistanz;
                this.Teilchenmasse = set.Teilchenmasse;
                this.VelocityMap = set.VelocityMap;
                this.WallMap = set.WallMap;
                this.Width = set.Width;
                this.WaveSources = set.WaveSources;
            }
            catch (Exception)
            {
                if (fstr!= null)
                {
                    fstr.Close();
                }
                return false;
            }
            return true;
        }
    }
}
