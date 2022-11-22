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
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            Size = new Size(width, height-50);
            Location = new Point(0, 0);
            panel1.Size = new Size(width-250, height - 250);
            panel1.Location = new Point(50, 75);
            textBox1.Location = new Point(width - 175, 50);
        }

        //public void drawellipserectangle(int x, int y, int width, int height, painteventargs e)
        //{
            //pen blackpen = new pen(color.black, 3);
            //rectangle rect = new rectangle(x, y, width, height);
            //e.graphics.fillellipse(new solidbrush(system.drawing.color.red), rect);
        //}


        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
            textBox1.Text = e + "\n";
            int numOfPlanets = Convert.ToInt32(planetNumInput.Text);
            Graphics g = this.panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            Brush brush = new SolidBrush(Color.Red);

            //Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);
            //skyBluePen.Width = 8.0F;
            //skyBluePen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;


            List<Planet> planetList = new List<Planet>();
            for (int i = 0; i < numOfPlanets; i++)
			{
                int x = rdm.Next(100, 1201);
                int y = rdm.Next(100, 600);
                float[] randPos = {x,y};
                Planet temp = new Planet("her", 10, randPos, 10, 90);
                planetList.Add(temp);   
			}
            
            Planet saturn = new Planet("Saturn", 10, new float[] {100, 100 }, 40, 90);
            Planet neptun = new Planet("neptun", 10, new float[] { 200, 200 }, 40, 90);
            Planet jorda = new Planet("Jorda", 50, new float[] { 200, 410 }, 40, 90);
            Planet mars = new Planet("mars", 10, new float[] {500, 410}, 10, 90);
            Planet sola = new Planet("sola", 10, new float[] {600, 410}, 10, 90);
            Planet månen = new Planet("månen", 10, new float[] { 910, 410}, 10, 90);/*
            planetList.Add(jorda);
            planetList.Add(mars);
            planetList.Add(månen);
            planetList.Add(sola);
            planetList.Add(saturn);
            planetList.Add(neptun);
            saturn.tyngdeMet(neptun);
            textBox1.Text += saturn.text + "k\n";
            textBox1.Text += neptun.text;
            */



            for (int i = 0; i < planetList.Count; i++)
            {
                Planet planet1 = (Planet) planetList[i];
                for (int j = i+1; j < planetList.Count; j++)
                {
                    Planet planet2 = (Planet) planetList[j];
                    planet1.tyngdeMet(planet2);
                }
                
               


            }




            foreach (Planet inpPlanet in planetList)
            {
                Planet planet = (Planet) inpPlanet;
                //DrawEllipseRectangle(planet.pos[0], planet.pos[1], planet.masse, planet.masse);
                
                //Button button = new Button();
                //button.Text = planet.name;
                //button.Height = 50;
                //button.AutoSize = true;
                //button.AutoSizeMode = AutosizeMode.GrowAndShrink;
               
               // Controls.Add(button);
                float[] pos = planet.pos;
                int x = Convert.ToInt32(pos[0]);
                int y = Convert.ToInt32(pos[1]);
                g.DrawEllipse(pen, x - planet.masse/2, y - planet.masse / 2, planet.masse, planet.masse);
                g.FillEllipse(brush, x - planet.masse / 2, y - planet.masse / 2 , planet.masse, planet.masse);
                //button.Location = new System.Drawing.Point(x,y);
                textBox1.Text += planet.name + ": " + planet.tyngdeX+ "x og " + planet.tyngdeY + "y\n";

            }
            jorda.pos = new float[] { 350, 400 };
            jorda.pos[0] = 500;
            
            int text = jorda.tyngdeMet(mars);
            //Button button3 = new Button();
            //button.Location(500, 100);
            //Controls.Add(button3);
            //string txt = Convert.ToString(text);
            //button3.Text = txt;


            
            





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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.AutoSize = true;
            //hei da
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen pen = new Pen(Color.Turquoise);
            Brush brush = new SolidBrush(Color.Turquoise);
            int r = 10000;
            g.DrawEllipse(pen, -r/2,-r/2,r,r);
            g.FillEllipse(brush, -r/2,-r/2,r,r);
        }
    }

}