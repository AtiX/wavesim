/*
 *  WaveSim - Physically correct 2D-Wave simulation
 *  Author: Arthur Silber / arthur.silber@gmx.de
 *  
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace WaveSimLib.Code.Wave
{
    public class WaveEngine
    {
        private object lockvar = "";

        /// <summary>
        /// Elongation
        /// </summary>
        private double[,] _positionMap;

        /// <summary>
        /// Velocity
        /// </summary>
        private double[,] _velocityMap;

        /// <summary>
        /// Points that arent moving, because they are a wall or sth. else
        /// </summary>
        private bool[,] _clearPoints;

        /// <summary>
        /// Additional Clearpoints
        /// </summary>
        private bool[,] _addonClearPoints;

        /// <summary>
        /// Mass of the points, comparable to refraction indices
        /// </summary>
        private double[,] _massMap;

        /// <summary>
        /// Additional Mass Map
        /// </summary>
        private double[,] _addonMassMap;

        /// <summary>
        /// Width and Height of the simulation Space
        /// </summary>
        public int Width{ get { return _settings.Width; } }
        public int Height { get { return _settings.Height; } }


        private WaveSettings _settings = new WaveSettings();
        public WaveSettings Settings
        {
            get { PublishWaveSettings(); return _settings;}
            set { ImportWaveSettings(value); }
        }

        private void PublishWaveSettings()
        {
            _settings.ElongationMap = (double[,])_positionMap.Clone();
            _settings.MassMap = (double[,])_massMap.Clone();
            _settings.VelocityMap = (double[,])_velocityMap.Clone();
            _settings.WallMap = (bool[,])_clearPoints.Clone();
            _settings.WaveSources = _waveSources;
        }

        private void ImportWaveSettings(WaveSettings set)
        {
            _positionMap = (double[,])set.ElongationMap.Clone();
            _massMap = (double[,])set.MassMap.Clone();
            _clearPoints = (bool[,])set.WallMap.Clone();
            _velocityMap = (double[,])set.ElongationMap.Clone();
            _waveSources = set.WaveSources;
            _settings = set;
        }

        public void ImportAddonWallMap(bool[,] importmap)
        {
            lock(lockvar)
            {
                _addonClearPoints = importmap;
            }
        }

        public void ImportAddonMassMap(double[,] massmap)
        {
            lock (lockvar)
            {
                _addonMassMap = massmap;
            }
        }

        private List<WaveSource> _waveSources = new List<WaveSource>();

        public int NumThreads = 1;

        private Thread _simulationThread;
        private bool _simulationRunning;
        public bool SimulationRunning
        {
            get { return _simulationRunning; }
        }

        public delegate void NewSimulationFrameHandler(double[,] positionMap, bool[,] wallMap, bool[,] addonWallMap, double[,] massMap, double[,] addonMassMap, int fps);
        public event NewSimulationFrameHandler OnNewSimulationFrame;

        public WaveEngine()
        {
            Settings = new WaveSettings();
        }

        public void AddWaveSoucre(WaveSource e)
        {
            lock (lockvar)
            {
                _waveSources.Add(e);
            }
        }

        public void Start()
        {
            if (_simulationRunning)
                return;

            _simulationThread = new Thread(new ThreadStart(DoSimulationWork));
            _simulationThread.Name = "WaveEngine SimThread";
            _simulationRunning = true;
            _simulationThread.Start();
        }

        public void Init(int x, int y)
        {
            Stop();

            _settings.Width = x;
            _settings.Height = y;
            _positionMap = new double[x,y];
            _velocityMap = new double[x,y];
            _clearPoints = new bool[x,y];
            _addonClearPoints = new bool[x,y];
            _massMap = new double[x,y];
            _addonMassMap = new double[x,y];

            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    _positionMap[ix, iy] = 0.0;
                    _velocityMap[ix, iy] = 0.0;
                    _clearPoints[ix, iy] = false;
                    _massMap[ix, iy] = 0.0;
                }
            }

            _settings.Width = x;
            _settings.Height = y;

            _waveSources.Clear();
        }

        public void Stop()
        {
            if (_simulationThread != null)
            {
                if (_simulationThread.ThreadState == ThreadState.Running)
                {
                    //Wait for thread to stop
                    _simulationRunning = false;
                    while(_simulationThread.ThreadState == ThreadState.Running)
                    {
                    }
                }
                _simulationThread = null;
            }
            _simulationRunning = false;
        }

        public void Poke(int x, int y, double position, double velocity)
        {
            if (x >= _settings.Width || y >= _settings.Height || x < 0 || y < 0)
                return;

            lock(lockvar)
            {
                _velocityMap[x, y] = velocity;
                _positionMap[x, y] = position;
            }
        }

        public void SetWall(int x, int y, bool IsWall=true)
        {
            if (x >= _settings.Width - 1 || y >= _settings.Height - 1 || x < 1 || y < 1)
                return;
            lock (lockvar)
            {
                _clearPoints[x, y] = IsWall;
                _positionMap[x, y] = 0.0;
            }
        }

        /// <summary>
        /// Sets specific mass. 0 makes the engine use the default value
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="mass"></param>
        public void SetMass(int x, int y, double mass)
        {
            if (x >= _settings.Width - 1 || y >= _settings.Height - 1 || x < 1 || y < 1)
                return;

            lock (lockvar)
            {
                _massMap[x, y] = mass;
            }
        }

        public double GetVelocity(int x, int y)
        {
            if (x >= _settings.Width - 1 || y >= _settings.Height - 1 || x < 1 || y < 1)
                return 0.0;

            double res = 0.0;
            lock(lockvar)
            {
                res = _velocityMap[x, y];
            }
            return res;
        }

        public double GetEnergy(int x, int y)
        {
            if (x >= _settings.Width - 1 || y >= _settings.Height - 1 || x < 1 || y < 1)
                return 0.0;

            double res = 0.0;
            lock (lockvar)
            {
                double Fg = -Settings.FederkonstanteTeilchen * _positionMap[x, y];
                double mass = 0.0;
                if (_massMap[x, y] > 0)
                    mass = _massMap[x, y];
                else
                    mass = Settings.Teilchenmasse;

                double Wpot = Math.Abs(_positionMap[x, y] * Fg);
                double Wkin = 0.5 * mass * _velocityMap[x, y] * _velocityMap[x, y];

                res = Wpot + Wkin;
            }
            return res;
            
        }
        public double GetPosition(int x, int y)
        {
            if (x >= _settings.Width - 1 || y >= _settings.Height - 1 || x < 1 || y < 1)
                return 0.0;

            double res = 0.0;
            lock (lockvar)
            {
                res = _positionMap[x, y];
            }
            return res;
        }

        public void ResetElongation()
        {
            lock (lockvar)
            {
                for (int ix = 0; ix < _settings.Width; ix++)
                {
                    for (int iy = 0; iy < _settings.Height; iy++)
                    {
                        _positionMap[ix, iy] = 0.0;
                        _velocityMap[ix, iy] = 0.0;
                    }
                }
            }

            foreach (WaveSource ws in _waveSources)
            {
                ws.Reset();
            }
        }

        public void ResetWalls()
        {
            lock (lockvar)
            {
                for (int ix = 0; ix < _settings.Width; ix++)
                {
                    for (int iy = 0; iy < _settings.Height; iy++)
                    {
                        _clearPoints[ix, iy] = false;
                    }
                }
            }
        }

        public void ResetMass()
        {
            lock (lockvar)
            {
                for (int ix = 0; ix < _settings.Width; ix++)
                {
                    for (int iy = 0; iy < _settings.Height; iy++)
                    {
                        _massMap[ix, iy] = 0.0;
                    }
                }
            }
        }


        public void ResetSources()
        {
            lock (lockvar){_waveSources.Clear();}
        }

        public void ManualStep()
        {
            if (_simulationRunning)
                Stop();

            lock (lockvar)
            {
                SimulationIteration();
                if (OnNewSimulationFrame != null)
                    OnNewSimulationFrame(_positionMap, _clearPoints, _addonClearPoints, _massMap, _addonMassMap, 0);
            }
        }

        private void DoSimulationWork()
        {
            while (_simulationRunning)
            {
                int fps = 0;

                lock (lockvar) {fps = SimulationIteration(); }

                if (OnNewSimulationFrame != null)
                    OnNewSimulationFrame(_positionMap, _clearPoints, _addonClearPoints, _massMap, _addonMassMap, fps);
            }
        }

        private int SimulationIteration()
        {
            DateTime start = DateTime.Now;

            //GetWaveSourceValues
            lock (lockvar)
            {
                foreach (WaveSource ws in _waveSources)
                {
                    _positionMap[ws.X, ws.Y] = ws.getElongation(Settings.DeltaT);
                }
            }

            //Simulate
            if (NumThreads > 1)
            {
                //use multiple threads
                ManualResetEvent[] resetEvents = new ManualResetEvent[NumThreads];

                int dy = _settings.Height / NumThreads;
                int ycount = 1;

                for (int i = 0; i< NumThreads; i++)
                {
                    Thread t = new Thread(new ParameterizedThreadStart(DoThreadWork));
                    resetEvents[i] = new ManualResetEvent(false);
                    int xStart = 1;
                    int xMax = _settings.Width - 1;
                    int yStart = ycount;
                    int yMax = (ycount += 2*dy);
                    if (yMax >= _settings.Height)
                        yMax = _settings.Height - 1;

                    object[] data = {xStart, yStart, xMax, yMax, resetEvents[i]};
                    t.Start((object) data);
                }

                WaitHandle.WaitAll(resetEvents);
            }
            else
            {
                //Just use this thread to calculate
                object[] data = {1, 1, _settings.Width - 1, _settings.Height - 1, null};
                DoThreadWork(data);
            }

            DateTime fin = DateTime.Now;
            TimeSpan duration = fin - start;
            if (duration.Milliseconds > 0)
                return 1000/duration.Milliseconds; //Return FPS
            return 0;
        }

        private void DoThreadWork(object o)
        {
            object[] obj = (object[]) o;
            int xStart = (int) obj[0];
            int yStart = (int) obj[1];
            int xMax = (int) obj[2];
            int yMax = (int) obj[3];
            ManualResetEvent re = (ManualResetEvent) obj[4];

            try
            {
                for (int y = yStart; y < yMax - 1; y = y + 2)
                {
                    for (int x = xStart; x < xMax - 1; x++)
                    {
                        CalculatePointValues(x, y);
                    }
                    for (int x = xMax - 1; x > xStart; x--)
                    {
                        CalculatePointValues(x, y + 1);
                    }
                }
            }
            catch (Exception e)
            {}

            if (re != null)
                re.Set();
        }

        private void CalculatePointValues(int x, int y)
        {
            //Berechnung der "gewichts"-Kräfte F = -D*s (bzw. Rückstellkraft)
            //Calculation of the force caused by the mass of the particle
            double Fg = -_settings.FederkonstanteTeilchen * _positionMap[x, y];

            //Berechnung der Kopplungskräfte
            //Elongation der Kopplungsfedern
            //Calculation of the elongation of the springs that connect the particles 
            double position = _positionMap[x, y];
            double DeltaSTop = position - _positionMap[x, y - 1];
            double DeltaSLeft = position - _positionMap[x - 1, y];
            double DeltaSRight = position - _positionMap[x + 1, y];
            double DeltaSDown = position - _positionMap[x, y + 1];

            double sTop = Math.Sqrt(DeltaSTop * DeltaSTop + _settings.TeilchenDistanz);
            double sLeft = Math.Sqrt(DeltaSLeft * DeltaSLeft + _settings.TeilchenDistanz);
            double sRight = Math.Sqrt(DeltaSRight * DeltaSRight + _settings.TeilchenDistanz);
            double sDown = Math.Sqrt(DeltaSDown * DeltaSDown + _settings.TeilchenDistanz);

            //Kräfte
            //Forces of the connecting springs
            //F = (-D*s) * (deltaS/s)
            double FTop = (-_settings.FederkonstanteKopplung * sTop) * (DeltaSTop / sTop);
            double FLeft = (-_settings.FederkonstanteKopplung * sLeft) * (DeltaSLeft / sLeft);
            double FRight = (-_settings.FederkonstanteKopplung * sRight) * (DeltaSRight / sRight);
            double FDown = (-_settings.FederkonstanteKopplung * sDown) * (DeltaSDown / sDown);

            //Ist ein Teilchen davon am rand? Wenn ja, ist die Geschwindigkeit 0 (um reflexionen zu vermeiden)
            //Is a particle at the border of the simulation, if yes, the resulting speed is 0 (no reflections)
            /*if ((x == _xMax - 2)||(x == 1)||(y == 1)||(y == _yMax - 2))
            {
                _velocityMap[x, y] = 0.0;
            }*/

            //Alle Kräfte werden addiert / gemittelt
            //Average all the forces!
            double Fres = (Fg + FTop + FLeft + FRight + FDown)*0.2;
            //double Fres = Fg + FTop + FLeft + FRight + FDown;

            //Neuberechnung - nur wenn teilchen keine wand ist (wand ist immer auf niveau 0)
            //only calculate if no border
            if (!(_clearPoints[x, y]||_addonClearPoints[x,y]))
            {
                //Masse, verwende standard wenn nicht spezifisch festgelegt
                //use standard mass if not specified
                double mass = 0.0;
                if (_massMap[x, y] > 0)
                    mass = _massMap[x, y];
                else if (_addonMassMap[x, y] > 0)
                    mass = _addonMassMap[x, y];
                else 
                    mass = _settings.Teilchenmasse;

                //Geschwindigkeit v1 = v0 + F/m * deltaT
                _velocityMap[x, y] = _velocityMap[x, y] + (Fres / mass) * _settings.DeltaT;
                //Position s1 = s0 + v1 * deltaT
                _positionMap[x, y] = _positionMap[x, y] + _velocityMap[x, y] * _settings.DeltaT;
                //Dämpfung - Damping
                _velocityMap[x, y] = _velocityMap[x, y] * _settings.Energieerhaltung;
            }
        }
    }
}
