using System.Diagnostics;

namespace Gravitasjonsimulering
{
    public class Planet
    {
        public string name;
        public int masse;
        public float[] pos;
        public float fart;
        public float fartVinkel;
        public float[][] tyngde;
        public float tyngdeX = 23;
        public float tyngdeY;


        public Planet(string inpName, int inpMasse, float[] inpPos, float inpFart, float inpFartVinkel)
        {
            name = inpName;
            pos = inpPos;
            fart = inpFart;
            fartVinkel = inpFartVinkel;
            masse = inpMasse;

        }
        public int massMethod()
        {
            return masse;
        }
    }



    public partial class Gravitasjonssimulering : Form
    {
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
            Planet jorda = new Planet("Jorda", 10, new float[] { 100, 10 }, 10, 90);
            Planet mars = new Planet("mars", 10, new float[] {200, 10}, 10, 90);
            Planet sola = new Planet("sola", 10, new float[] {300, 10}, 10, 90);
            Planet månen = new Planet("månen", 10, new float[] { 410, 10}, 10, 90);
            //object[] planetListRaw = {jorda, mars, sola, månen};
            List<object> planetList = new List<object>();
            planetList.Add(jorda);
            planetList.Add(mars);
            planetList.Add(månen);
            planetList.Add(sola);

            foreach (Planet planet in planetList)
            {
                Console.WriteLine(planet);
                Debug.WriteLine(planet);
            }
            jorda.pos = new float[] { 350, 400 };
            jorda.pos[0] = 500;

            int numOfPlanets = Convert.ToInt32(planetNumInput.Text);
            Debug.WriteLine(numOfPlanets);
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