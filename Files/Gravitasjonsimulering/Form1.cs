using System;
using System.Diagnostics;

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

        private void TestButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestButton2_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            //button.Location(500, 100);
            Controls.Add(button);
            button.Location = new System.Drawing.Point(500, 100);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int numOfPlanets = Convert.ToInt32(planetNumInput.Text);

            int randMass = rdm.Next(1,14);
            //object[] planetList = new object[numOfPlanets + 1];
            List<Planet> planetList = new List<Planet>();
            for (int i = 0; i < numOfPlanets; i++)
			{
                int x = rdm.Next(100,1201);
                int y = rdm.Next(100,120);
                float[] randPos = {x,y};
                Planet temp = new Planet("her", 10, randPos, 10, 90);
                planetList.Add(temp);   
			}

            
            Planet jorda = new Planet("Jorda", 10, new float[] { 200, 410 }, 10, 90);
            Planet mars = new Planet("mars", 10, new float[] {500, 410}, 10, 90);
            Planet sola = new Planet("sola", 10, new float[] {600, 410}, 10, 90);
            Planet månen = new Planet("månen", 10, new float[] { 910, 410}, 10, 90);
            //planetList[numOfPlanets] = jorda;
            //object[] planetList = {jorda, mars, sola, månen};
            //object[] planetList = { jorda, mars, sola, månen };
            //Console.WriteLine("her");
            //List<object> planetList = new List<object>();
            //planetList.Add(jorda);
            //planetList.Add(mars);
            //planetList.Add(månen);
            //planetList.Add(sola);

            Button button2 = new Button();
            //button.Location(500, 100);
            Controls.Add(button2);
            Planet plant = (Planet) planetList[0];
            button2.Text = plant.name;
            
            float[] t = plant.pos;
            int xx = Convert.ToInt32(t[0]);
            int yy = Convert.ToInt32(t[1]);
            button2.Location = new System.Drawing.Point(xx,yy );

            foreach (Planet planet2 in planetList)
            {
                Planet planet = (Planet) planet2;
                Button button = new Button();
                button.Text = planet.name;
                //button.Height = 50;
                button.AutoSize = true;
                //button.AutoSizeMode = AutosizeMode.GrowAndShrink;
               
                Controls.Add(button);
                float[] pos = planet.pos;
                int x = Convert.ToInt32(pos[0]);
                int y = Convert.ToInt32(pos[1]);
                button.Location = new System.Drawing.Point(x,y);
                //button.Location = new System.Drawing.Point(pos);
                //button.Location = new System.Drawing.Point(pos[0], pos[1]);

            }
            jorda.pos = new float[] { 350, 400 };
            jorda.pos[0] = 500;

            

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