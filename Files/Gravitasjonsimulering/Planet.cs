using System;


public class Planet
{

    public string name;
    public int masse;
    public float[] pos;
    public float fart;
    public float fartVinkel;
    public double[][] tyngde;
    public double tyngdeX = 0;
    public double tyngdeY = 0;
    public double text = 0;



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
    public int tyngdeMet(Object planet2)
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
        return planet.masse;
    }

}
