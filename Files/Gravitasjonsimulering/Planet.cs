using System;


public class Planet
{

    public string name;
    public double masse;
    public float[] pos;
    public float fartX;
    public float fartY;
    public double[][] tyngde;
    public double tyngdeX = 0;
    public double tyngdeY = 0;
    public double text = 0;



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
        double gravity = (6.67 * Math.Pow(10, -11) * this.masse * planet.masse) / ((this.pos[0] - planet.pos[0]) * (this.pos[0] - planet.pos[0]) + (this.pos[1] - planet.pos[1])*(this.pos[1] - planet.pos[1]));

        
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
    }
    public void move(float t)
    {
        double ax = this.tyngdeX/this.masse ;
        double ay = this.tyngdeY/this.masse;
        
        
        this.pos[0] = (float) (1/2 * ax * (t*t) + this.fartX * t + this.pos[0]);
        this.pos[1] = (float) (1/2 * ay * (t*t) + this.fartY * t + this.pos[1]);
        this.fartX = (float) (ax * t  + this.fartX);
        this.fartY = (float) (ay * t + this.fartY);

    }


}


/*
  bevegelse
 massse som er bedre
avstand som er bedre
faktisk areal

kanskje sentrallegme
 
 */