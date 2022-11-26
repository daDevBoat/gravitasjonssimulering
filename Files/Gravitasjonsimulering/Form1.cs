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


        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
                textBox1.Text += "herjejkeves \n";
                      //Planet SentMasse = new Planet("sen", 45, new float[] {width/2, height/2}, 400, 900);
                Planet saturn = new Planet("Saturn", Math.Pow(10,1), new float[] {800, 250 }, 0  , -5);
                Planet neptun = new Planet("neptun", Math.Pow(10, 14), new float[] { 700, 150 }, 0, 2);
                //Planet neptun2 = new Planet("neptun", Math.Pow(10, 20), new float[] { 500, 350 }, 0, 0);
                //Planet jorda = new Planet("Jorda", 50, new float[] { 200, 410 }, 0, 0);
                //Planet mars = new Planet("mars", 10, new float[] {500, 410}, 10, 90);
                //Planet sola = new Planet("sola", 10, new float[] {600, 410}, 10, 90);
                //Planet månen = new Planet("månen", 10, new float[] { 910, 410}, 10, 90);
                                    Graphics g = this.panel1.CreateGraphics();
                    
                    int height = Screen.PrimaryScreen.Bounds.Height;
                    int width = Screen.PrimaryScreen.Bounds.Width;

                    List<Planet> planetList = new List<Planet>();
                    for (int i = 0; i < 20; i++)
			        {
                        long x = rdm.Next(0, width-250);
                        long y = rdm.Next(0, height -250);
                        float[] randPos = {x,y};
                        Planet temp = new Planet("her", 10, randPos, 10, 90);
                        //planetList.Add(temp);   
               
			        }
                    planetList.Add(saturn);
                    planetList.Add(neptun);
                for (int ik = 0; ik < 20000; ik++)
                {
                    this.textBox1.Text = e + "\n";
                    //int numOfPlanets = Convert.ToInt32(planetNumInput.Text);

                    //Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);
                    //skyBluePen.Width = 8.0F;
                    //skyBluePen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                    Pen pen = new Pen(Color.White);
                    Brush brush = new SolidBrush(Color.White);
                    if (ik%5==0)
                    {
                    pen = new Pen(Color.Red);
                    brush = new SolidBrush(Color.Red);
                    }
                    if (ik%5==1)
                    {
                    pen = new Pen(Color.Blue);
                    brush = new SolidBrush(Color.Blue);
                    }
                    if (ik%5==2)
                    {
                    pen = new Pen(Color.Yellow);
                    brush = new SolidBrush(Color.Yellow);
                    }
                    if (ik%5==3)
                    {
                        pen = new Pen(Color.Green);
                    brush = new SolidBrush(Color.Green);
                    }
                    if (ik%5==4)
                    {
                    pen = new Pen(Color.Black);
                    brush = new SolidBrush(Color.Black);
                    }

                    


                   /* if (ik==0)
                {
                    float[] posa = saturn.pos;
                    long x33 = Convert.ToInt64(posa[0]);
                    long y33 = Convert.ToInt64(posa[1]);
                    g.DrawEllipse(pen, x33 - 5, y33 - 5, 10, 10);
                    g.FillEllipse(brush, x33 - 5, y33 - 5 , 10, 10);
                }*/
                    /*planetList.Add(jorda);
                    planetList.Add(mars);
                    planetList.Add(månen);
                    planetList.Add(sola);*/

                    // planetList.Add(neptun2);
                //planetList.Add(jorda);
                    saturn.tyngdeMet(neptun);
                //saturn.tyngdeMet(neptun2);
                    //jorda.tyngdeMet(saturn);
                    //jorda.tyngdeMet(neptun);
                
                    
                    this.textBox1.Text += saturn.pos[0] + "x" + saturn.pos[1] + "y\n";
                    /*saturn.tyngdeMet(neptun);
                    textBox1.Text += saturn.text + "k\n";
                    textBox1.Text += neptun.text;*/
            /*
                    float[] pos = saturn.pos;
                    long x3 = Convert.ToInt64(pos[0]);
                    long y3 = Convert.ToInt64(pos[1]);
                    g.DrawEllipse(pen, x3 - 5, y3 - 5, 10, 10);
                    g.FillEllipse(brush, x3 - 5, y3 - 5 , 10, 10);
                */

                    /*
                    for (int i = 0; i < planetList.Count; i++)
                    {
                        Planet planet1 = (Planet) planetList[i];
                        for (int j = i+1; j < planetList.Count; j++)
                        {
                            Planet planet2 = (Planet) planetList[j];
                            planet1.tyngdeMet(planet2);
                        } 
                    }*/
                    foreach (Planet inpPlanet in planetList)
                    {
                        Planet planet = (Planet) inpPlanet;
                        planet.pos[0] -= neptun.dx;
                        planet.pos[1] -= neptun.dy;

                    }

                    foreach (Planet inpPlanet in planetList)
                    {
                        Planet planet = (Planet) inpPlanet;

                        float[] pos = planet.pos;
                        long x = Convert.ToInt64(pos[0]);
                        long y = Convert.ToInt64(pos[1]);
                        g.DrawEllipse(pen, x - 5, y - 5, 10, 10);
                        g.FillEllipse(brush, x - 5, y - 5 , 10, 10);

                        //textBox1.Text += planet.name + ": " + planet.tyngdeX+ "x og " + planet.tyngdeY + "y\n";

                    }
                    
                   
            
                    //Thread.Sleep(20);
                    foreach (Planet inpPlanet in planetList)
                    {
                        Planet planet = (Planet) inpPlanet;
                        planet.move(0.1);

                    }
                    
                    Pen pen2 = new Pen(Color.Turquoise);
                    Brush brush2 = new SolidBrush(Color.Turquoise);
                    int r = 10000;
                    //g.DrawEllipse(pen2, -r/2,-r/2,r,r);
                    //g.FillEllipse(brush2, -r/2,-r/2,r,r);




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
            if (e.KeyCode == Keys.Enter)
            {
      

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
            

        }
    }

}