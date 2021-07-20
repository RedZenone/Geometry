using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCannonball : MonoBehaviour
{
    public Vector3 start;
    public Vector3 end;
    public Vector3 current;
    protected float Animation;
    public float angle;
    public float speed;
    public float distance;

    public void Setup(Vector3 start, Vector3 end)
    {
      transform.position=start;
      this.start=start;
      this.end=end;
      Destroy(gameObject,10f);
      distance = (end-start).magnitude;
      //angle=(1/distance)*8;
      //angle=angle*0.8;
    }


    private void Update()
    {
        Animation+= Time.deltaTime;
        //Animation=Animation%5f;
        transform.position=MathParabola.Parabola(start, end, angle, Animation/speed);
        current=transform.position;
    }
}
