using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bezier : MonoBehaviour
{

    public static Vector3 Curve(Vector3 start, Vector3 end,Vector3 alzata, float t)
    {
        Vector3 positiont= new Vector3(0,0,0);
        float tm= 1-t;
        positiont = 
            tm*tm*start
            +2*t*tm*alzata
            +t*t*end;

        return positiont;
    }

}
