using System;


public class Planet
{

    public string name;
    public double masse;
    public float[] pos;
    public float fartX;
    public float fartY;
    public double tyngdeX = 0;
    public double tyngdeY = 0;
    public double text = 0;
    public float dx = 0;
    public float dy = 0;
    



    public Planet(string inpName, double inpMasse, float[] inpPos, float inpfartX, float inpfartY)
    {
        name = inpName;
        pos = inpPos;
        fartX = inpfartX;
        fartY = inpfartY;
        masse = inpMasse;

    }
    public double massMethod()
    {
        return masse;
    }
    public void tyngdeMet(Object planet2)
    {   
        Planet planet = (Planet) planet2;
        double gravity = (6.67 * Math.Pow(10, -11) * this.masse * planet.masse) / (  Math.Pow((this.pos[0] - planet.pos[0]), 2) + Math.Pow((this.pos[1] - planet.pos[1]), 2) );

        double dx = (this.pos[0] - planet.pos[0]);
        double dy = (this.pos[1] - planet.pos[1]);

        double r = Math.Sqrt( Math.Pow((this.pos[0] - planet.pos[0]), 2) + Math.Pow((this.pos[1] - planet.pos[1]), 2));
        double tyngdeX = Math.Abs((gravity * dx)/ r);
        double tyngdeY = Math.Abs((gravity * dy)/ r);

        if (this.pos[0] > planet.pos[0])
        {
            this.tyngdeX += -tyngdeX/this.masse;
            planet.tyngdeX += tyngdeX/planet.masse;
        }
        else
        {
            this.tyngdeX += tyngdeX/this.masse;
            planet.tyngdeX += -tyngdeX/planet.masse;
        }

        if (this.pos[1] > planet.pos[1])
        {
            this.tyngdeY += -tyngdeY/this.masse;
            planet.tyngdeY += tyngdeY/planet.masse;
        } else
        {
            this.tyngdeY += tyngdeY/this.masse;
            planet.tyngdeY += -tyngdeY/planet.masse;
        }



        /*
         
        
        
        double x = (this.pos[0] - planet.pos[0]);
        double y = (this.pos[1] - planet.pos[1]);
        double lengVec = Math.Sqrt(((this.pos[0] - planet.pos[0]) * (this.pos[0] - planet.pos[0]) + (this.pos[1] - planet.pos[1]) * (this.pos[1] - planet.pos[1])));
        double lengVecRelX = lengVec / x;
        double lengVecRelY = lengVec / y;
        this.text = gravity;
        planet.text = y;
        this.tyngdeX += -gravity / lengVecRelX;
        this.tyngdeY += -gravity / lengVecRelY;
        planet.tyngdeX += gravity / lengVecRelX;
        planet.tyngdeY += gravity / lengVecRelY;
        */
    }
    public void move(double t)
    {
        double ax = this.tyngdeX;
        double ay = this.tyngdeY;
        this.dx = (float) (1/2 * ax * (t*t) + this.fartX * t);
        this.dy = (float) (1/2 * ay * (t*t) + this.fartY * t);
        
        this.pos[0] = (float) (1/2 * ax * (t*t) + this.fartX * t + this.pos[0]);
        this.pos[1] = (float) (1/2 * ay * (t*t) + this.fartY * t + this.pos[1]);
        this.fartX = (float) (ax * t  + this.fartX);
        this.fartY = (float) (ay * t + this.fartY);
        this.tyngdeX = 0;
        this.tyngdeY = 0;

    }


}


/*
  bevegelse
 massse som er bedre
avstand som er bedre
faktisk areal

kanskje sentrallegme
 
 */