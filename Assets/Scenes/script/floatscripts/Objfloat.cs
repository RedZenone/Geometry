using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objfloat : MonoBehaviour
{

    public Rigidbody rigidbody;
    public bool debug = false;
    public float depthtreshold = 1f;
    public float displacement = 3f;
    public int buoynumber = 4;

    public float waterDrag = 0.99f;
    public float waterAngularDrag = 0.5f;

    private void FixedUpdate()
    {
      if (!debug)
      {


        rigidbody.AddForceAtPosition(Physics.gravity / buoynumber, transform.position, ForceMode.Acceleration);
        float waveHeight = Waves.instance.GetWaveHight(transform.position.x);

        if (transform.position.y < waveHeight) {
          float mutiplier = Mathf.Clamp01((waveHeight-transform.position.y) / depthtreshold) * displacement;
          rigidbody.AddForceAtPosition(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * mutiplier, 0f), transform.position, ForceMode.Acceleration);
          rigidbody.AddForce(mutiplier * -rigidbody.velocity * waterDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
          rigidbody.AddTorque(mutiplier * -rigidbody.angularVelocity * waterAngularDrag * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }




      }else{
        float waveHeight = Waves.instance.GetWaveHight(transform.position.x);
        transform.position = new Vector3 (transform.position.x,waveHeight,transform.position.z);
      }

    }
}
