using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ProjetOOP_Hivers_2024.ChildForms.TemperatureConverter
{
    internal class Thermometer
    {
        //pens and brushes for the thermometer
        public Pen whitePen = new Pen(Color.White, 5);
        public Pen fineWhitePen = new Pen(Color.White, 1);
        public Brush celsiusBrush = new SolidBrush(Color.Crimson);
        public Brush fahrenheitBrush = new SolidBrush(Color.Aquamarine);
        public Brush kelvinBrush = new SolidBrush(Color.Yellow);
        Graphics graph;

        //usefull variables
        private int _x, _y;//position
        private int _mercuryHeight;
        private int _mercuryTop;
        private int _celsiusTemperature;

        private int[] _cGradation = new int[]
            { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 0, -10, -20, -30, -40, -50, -60, -70, -80, -90, -273 };
        private int[] _fGradation = new int[]
            { 212, 194, 176, 158, 140, 122, 104, 86, 68, 50, 32, 14, -4, -22, -40, -58, -76, -94, -112, -130, -459 };
        private int[] _kGradation = new int[]
            { 373, 363, 353, 343, 333, 323, 313, 303, 293, 283, 273, 263, 253, 243, 233, 223, 213, 203, 193, 183, 0 };
        


        public Thermometer(Graphics graph, int x, int y, int celsiusTemperature)
        {
            whitePen.Alignment = PenAlignment.Center;
            fineWhitePen.Alignment = PenAlignment.Center;
            this.graph = graph;
            _x = x;
            _y = y;
            _celsiusTemperature = celsiusTemperature;
            InitializeRatios();
            DrawThermometers();
            DrawMercury();
        }

        private void InitializeRatios()
        {
            // Calculate mercury height based on Celsius temperature
            _mercuryHeight = 425 - (int)((_celsiusTemperature + 100) * (350.0 / 200) + 17.5f);
            
            // Calculate mercury top based on mercury height
            _mercuryTop = (int)(425 - _mercuryHeight + 17.5f);
            

            
            

        }

        public void DrawThermometers()
        {
            for (int j = 0; j <= 400; j += 200)
            {
                //draw the thermometer
                graph.DrawArc(whitePen, new Rectangle(_x + 0 + j, _y + 400, 100, 100), -60, 300);
                graph.DrawArc(whitePen, new Rectangle(_x + 25 + j, _y + 0, 50, 50), -180, 180);
                graph.DrawLine(whitePen, 25 + _x + j, 25 + _y, 25 + _x + j, 409 + _y);
                graph.DrawLine(whitePen, 75 + _x + j, 25 + _y, 75 + _x + j, 409 + _y);

               
            }
            //graduation
            int index = 0;
            int c = 0;
            int f = 200;
            int k = 400;
            Font font = new Font("Arial", 10);
            for (float i = 0; i <= 350; i += 17.5f)
            {
                //special cases
                if (i == 0)
                {
                    graph.DrawString("°C", font, Brushes.DarkOrchid, _x - 20 + c, _y + i + 26.25f);
                    graph.DrawString("Boiling Point", font, Brushes.DarkSeaGreen, _x - 100 + c, _y + i + 26.25f);
                    graph.DrawString("°F", font, Brushes.DarkOrchid, _x - 20 + f, _y + i + 26.25f);
                    graph.DrawString("°K", font, Brushes.DarkOrchid, _x - 20 + k, _y + i + 26.25f);
                    
                }

                if (i == 350 / 2)
                    graph.DrawString("Freezing Point", font, Brushes.DarkSeaGreen, _x - 100 + c, _y + i + 26.25f);

                if (i == 350)
                    graph.DrawString("Absolute Zero", font, Brushes.DarkSeaGreen, _x - 100 + c, _y + i + 26.25f);

                
                //celsius
                graph.DrawLine(fineWhitePen, _x + 25 + c, 35 + _y + i, _x + 35 + c, 35 + _y + i);
                graph.DrawString(_cGradation[index].ToString().PadLeft(5), font, Brushes.White, _x - 10 + c, _y + i + 26.25f);
                //fahrenheit
                graph.DrawLine(fineWhitePen, _x + 25 + f, 35 + _y + i, _x + 35 + f, 35 + _y + i);
                graph.DrawString(_fGradation[index].ToString().PadLeft(5), font, Brushes.White, _x - 10 + f, _y + i + 26.25f);
                //kelvin
                graph.DrawLine(fineWhitePen, _x + 25 + k, 35 + _y + i, _x + 35 + k, 35 + _y + i);
                graph.DrawString(_kGradation[index].ToString().PadLeft(5), font, Brushes.White, _x - 10 + k, _y + i + 26.25f);
                index++;
            }




        }
        //draw the mercury
        public void DrawMercury()
        {
            // Draw Mercury for Celsius
            graph.FillEllipse(celsiusBrush, 25 + _x, 425 + _y, 50, 50);
            graph.FillRectangle(celsiusBrush, 45 + _x, _mercuryTop + _y, 12, _mercuryHeight);

            // Draw Mercury for Fahrenheit
            graph.FillEllipse(fahrenheitBrush, 225 + _x, 425 + _y, 50, 50);
            graph.FillRectangle(fahrenheitBrush, 245 + _x, _mercuryTop + _y, 12, _mercuryHeight);
            // Draw Mercury for Kelvin
            graph.FillEllipse(kelvinBrush, 425 + _x, 425 + _y, 50, 50);
            graph.FillRectangle(kelvinBrush, 445 + _x, _mercuryTop + _y, 12, _mercuryHeight);
        }
    }
}
