using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject sightangle;
    public float angle;
    public Vector3 boatposition;
    public Vector3 direction;
    public float aimingangle;

    private GameObject boat;

    void Start()
    {
        boat=GameObject.Find("Player");
    }

    public void Update()
    {
      boatposition = transform.InverseTransformPoint(boat.transform.position);
      Vector3 alanglezero = new Vector3((sightangle.transform.position.x-transform.position.x),0,(sightangle.transform.position.z-transform.position.z));  //resting angle, the tower can't pivo forther than 30° from this angle
      direction = new Vector3((boat.transform.position.x-transform.position.x),0,(boat.transform.position.z-transform.position.z));   //the angle toward the player

      angle = Vector3.Angle(alanglezero, direction);

      if (angle<aimingangle) {
          Quaternion _lookRotation = Quaternion.LookRotation(direction.normalized);
          transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * 2);
      }
    }

}
