using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boatstearing : MonoBehaviour
{
  public float speed;
  public float currentspeed;
  public float drag;
  public float topspeed;
  public double angolo=0;
  public Vector3 mPosition;
  private Rigidbody rb;
  public GameObject compass;
  public Text speedtext;
  public Text angletext;
  public Text speedtext2;
  public Text angletext2;

  public float steeringspeed;

  public void Start()
  {
      rb = GetComponent<Rigidbody>();
  }

  public void FixedUpdate()
  {
      if (speed>topspeed) {
        speed=topspeed;
      }
      bool accellera = Input.GetKeyDown(KeyCode.W);
      if (accellera)
      {
        if (speed<topspeed) {
          speed+=5;
        }
      }
      bool rallenta = Input.GetKeyDown(KeyCode.S);
      if (rallenta)
      {
        if (speed>0) {
          speed-=5;
        }
      }

      if (currentspeed<speed) {
        currentspeed+=0.005f;
      }
      if (currentspeed>speed) {
        currentspeed-=0.005f;
      }

      Quaternion _lookRotation = Quaternion.LookRotation(compass.transform.forward.normalized);

      transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * Min(currentspeed/10,steeringspeed));

    /*  Vector3 gravity = new Vector3(0f,rb.velocity.y,0f);
      rb.velocity = gravity + (transform.forward * speed);
      mPosition=transform.position;*/
      //transform.position=transform.position+ (transform.forward * (speed/drag));

      transform.Translate(Vector3.forward * Time.deltaTime * currentspeed);

      speedtext.text= currentspeed.ToString("F3");
      angletext.text=transform.rotation.y.ToString("F3");
      speedtext2.text= currentspeed.ToString("F3");
      angletext2.text=transform.rotation.y.ToString("F3");
  }

  private float Min(float a, float b)
  {
    if (a<b){return a;}else{return b;}
  }
}
