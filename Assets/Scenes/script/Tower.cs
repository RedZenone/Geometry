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
    public GameObject alzata;
    public Vector3 alzatavec;

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

          /*float alzx= direction.x/2f;
          float alzz=direction.z/2f;
          float alzy=Mathf.Sqrt(alzx*alzx+alzz*alzz);
          alzatavec= new Vector3(alzx,alzy,alzz);
          alzata.transform.position=transform.position+alzatavec;*/
      }
    }

    public void Alzata()
    {
        float alzx= direction.x/2f;
        float alzz=direction.z/2f;
        float alzy=Mathf.Sqrt(alzx*alzx+alzz*alzz);
        alzatavec= new Vector3(alzx,alzy,alzz);
        alzata.transform.position=transform.position+alzatavec;
    }
}
