using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Gravitasjonsimulering
{
    


    public partial class Gravitasjonssimulering : Form
    {
        Random rdm = new Random();
        public Gravitasjonssimulering()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void DrawEllipseRectangle(int x, int y, int width, int height, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            Rectangle rect = new Rectangle(x, y, width, height);
            e.Graphics.FillEllipse(new SolidBrush(System.Drawing.Color.Red), rect);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int numOfPlanets = Convert.ToInt32(planetNumInput.Text);
            Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);
            skyBluePen.Width = 8.0F;
            skyBluePen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;


            List<Planet> planetList = new List<Planet>();
            for (int i = 0; i < numOfPlanets; i++)
			{
                int x = rdm.Next(100, 1201);
                int y = rdm.Next(100, 600);
                float[] randPos = {x,y};
                Planet temp = new Planet("her", 10, randPos, 10, 90);
                planetList.Add(temp);   
			}

            
            Planet jorda = new Planet("Jorda", 10, new float[] { 200, 410 }, 10, 90);
            Planet mars = new Planet("mars", 10, new float[] {500, 410}, 10, 90);
            Planet sola = new Planet("sola", 10, new float[] {600, 410}, 10, 90);
            Planet månen = new Planet("månen", 10, new float[] { 910, 410}, 10, 90);




            foreach (Planet inpPlanet in planetList)
            {
                Planet planet = (Planet) inpPlanet;
                DrawEllipseRectangle(planet.pos[0], planet.pos[1], planet.masse, planet.masse);
                
                //Button button = new Button();
                //button.Text = planet.name;
                //button.Height = 50;
                //button.AutoSize = true;
                //button.AutoSizeMode = AutosizeMode.GrowAndShrink;
               
                //Controls.Add(button);
                float[] pos = planet.pos;
                int x = Convert.ToInt32(pos[0]);
                int y = Convert.ToInt32(pos[1]);
                //button.Location = new System.Drawing.Point(x,y);


            }
            jorda.pos = new float[] { 350, 400 };
            jorda.pos[0] = 500;
            
            int text = jorda.tyngdeMet(mars);
            Button button3 = new Button();
            //button.Location(500, 100);
            Controls.Add(button3);
            string txt = Convert.ToString(text);
            button3.Text = txt;






            // Code graveyard

            //planetList[0].massMethod();

            //for (int i = 0; i < numOfPlanets; i++)
            //{

            //    Button button = new Button();
            //    Controls.Add(button);
            //    Object obj = planetList[i];
            //    float[] pos = obj.pos;
            //    obj.tyngdeX = 23;
            //    button.Location = new System.Drawing.Point(pos[0], pos[1]);
            //}



        }
        
    }

}