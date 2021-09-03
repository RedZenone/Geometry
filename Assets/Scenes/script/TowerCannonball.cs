using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCannonball : MonoBehaviour
{
    public Vector3 start;
    public Vector3 end;
    public Vector3 alzata;
    public Vector3 current;
    protected float Animation;
    public float angle;
    public float speed;
    public float distance;
    public float t;

    public LineRenderer line;
    private int numPoints;
    private Vector3[] positions = new Vector3[50];

    public void Setup(Vector3 start, Vector3 end, Vector3 alzata)
    {
      transform.position=start;
      this.start=start;
      this.end=end;
      this.alzata=alzata;
      Destroy(gameObject,10f);
      distance = (end-start).magnitude;
      t=0;
    }

    void Start()
    {
      line.positionCount=numPoints;
      //Drawcurve();
    }

    private void Drawcurve()
    {
      for (int i = 0; i < numPoints; i++)
      {
          float t= i/(float)numPoints;
          positions[i-1]=Curve(start, end, alzata, t);
      }
      line.SetPositions(positions);
    }

    private void FixedUpdate()
    {
        //Animation+= Time.deltaTime;
        //Animation=Animation%5f;
        //transform.position=MathParabola.Parabola(start, end, angle, Animation/speed);
        t+=0.005f;
        transform.position=Curve(start, end, alzata, t);
        current=transform.position;
    }

    public Vector3 Curve(Vector3 start, Vector3 end,Vector3 alzata, float t)
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
