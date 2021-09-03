using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    public Vector3 direction;
    public int speed;

    public void Setup(Vector3 direction)
    {
      this.direction=direction.normalized;
      Destroy(gameObject,10f);
    }

    public void Setup(Vector3 direction, Vector3 position)
    {
      transform.position=position;
      this.direction=direction.normalized;
      Quaternion _lookRotation = Quaternion.LookRotation(direction.normalized);
      transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation,1f);
      Destroy(gameObject,10f);
    }


    private void FixedUpdate()
    {
      transform.position += direction * Time.deltaTime * speed;
      //transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

}
