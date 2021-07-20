using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boatshooter : MonoBehaviour
{

  public GameObject cannonballpref;

  public void Fire(Vector3 direction)
  {
    Vector3 cannonposition= new Vector3(transform.position.x, transform.position.y + 1.05f, transform.position.z);
    Transform cannonballtrasf = Instantiate(cannonballpref, cannonposition, Quaternion.identity).transform;
    cannonballtrasf.GetComponent<Cannonball>().Setup(direction);
  }

  /*
  public void Aim(Vector3 direction)
  {
    Vector3 steup = new Vector3(0f,10f,0f);
    Debug.DrawLine(transform.position+steup, direction, Color.green, 10f);
  }*/

  public void Update()
  {
    bool qdown = Input.GetKeyDown(KeyCode.Q);
    if (qdown)
    {
      Vector3 up = new Vector3(0f, 1f, 0f);
      Vector3 direction = Vector3.Cross(transform.forward.normalized, up.normalized);
      Fire(direction);
    }
    bool edown = Input.GetKeyDown(KeyCode.E);
    if (edown)
    {
      Vector3 up = new Vector3(0f, 1f, 0f);
      Vector3 direction = Vector3.Cross(transform.forward.normalized, up.normalized);
      Fire(-direction);
    }

  }
}
