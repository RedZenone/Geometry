using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boatshoot : MonoBehaviour
{

    public GameObject cannonballpref;

    public GameObject altitudeleft;
    public GameObject restleft;
    public GameObject startleft;

    public GameObject altituderight;
    public GameObject restright;
    public GameObject startright;

    public Transform player;


    public void Fire(Vector3 direction, int leftright)
    {
      if (leftright==1) {
      /*  Vector3 cannonposition= new Vector3(startleft.transform.position.x, 1.85f, startleft.transform.position.z);
        Transform cannonballtrasf = Instantiate(cannonballpref, cannonposition, Quaternion.identity).transform;
        cannonballtrasf.GetComponent<Cannonball>(). Setup(direction);*/
        GameObject cannonball = Instantiate(cannonballpref, startleft.transform.position, Quaternion.identity);
        cannonball.GetComponent<Cannonball>().Setup(direction);
      }else{
        /*Vector3 cannonposition= new Vector3(startright.transform.position.x, 1.85f, startright.transform.position.z);
        Transform cannonballtrasf = Instantiate(cannonballpref, cannonposition, Quaternion.identity).transform;
        cannonballtrasf.GetComponent<Cannonball>(). Setup(direction);*/
        GameObject cannonball = Instantiate(cannonballpref, startright.transform.position, Quaternion.identity);
        cannonball.GetComponent<Cannonball>().Setup(direction);
      }

    }

/*
    public void Update()
    {
      bool qdown = Input.GetKeyDown(KeyCode.Q);
      if (qdown)
      {
        Vector3 up = new Vector3(0f, 1f, 0f);
        Vector3 direction = Vector3.Cross(player.transform.forward.normalized, up.normalized);
        Fire(direction);
      }
      bool edown = Input.GetKeyDown(KeyCode.E);
      if (edown)
      {
        Vector3 up = new Vector3(0f, 1f, 0f);
        Vector3 direction = Vector3.Cross(player.transform.forward.normalized, up.normalized);
        Fire(-direction);
      }

    }*/


    public void Update()
    {
      bool qpress = Input.GetKey(KeyCode.Q);
      if (qpress)
      {
        altitudeleft.transform.position = new Vector3(altitudeleft.transform.position.x, altitudeleft.transform.position.y + 0.1f, altitudeleft.transform.position.z);
      }
      bool epress = Input.GetKey(KeyCode.E);
      if (epress)
      {
        altituderight.transform.position = new Vector3(altituderight.transform.position.x, altituderight.transform.position.y + 0.1f, altituderight.transform.position.z);
      }

      bool qup = Input.GetKeyUp(KeyCode.Q);
      if (qup)
      {
        Vector3 direction = altitudeleft.transform.position-startleft.transform.position;
        Fire(direction, 1); // 1 left 2 right
        altitudeleft.transform.position =  restleft.transform.position;
      }
      bool eup = Input.GetKeyUp(KeyCode.E);
      if (eup)
      {
        Vector3 direction = altituderight.transform.position-startright.transform.position;
        Fire(direction, 2); // 1 left 2 right
        altituderight.transform.position = restright.transform.position;
      }
    }

}
