using System;

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
