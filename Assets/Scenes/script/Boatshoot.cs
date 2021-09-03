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

    public float shootdelaye;
    public float shootdelayq;
    public float shoottimer;

    
    public AudioSource cannonsound;


    public void Fire(Vector3 direction, int leftright)
    {
      if (leftright==1) {
        GameObject cannonball = Instantiate(cannonballpref, startleft.transform.position, Quaternion.identity);
        cannonball.GetComponent<Cannonball>().Setup(direction);
      }else{
        GameObject cannonball = Instantiate(cannonballpref, startright.transform.position, Quaternion.identity);
        cannonball.GetComponent<Cannonball>().Setup(direction);
      }

    }


    public Material verde;
    public Material rosso;
    public GameObject sferaleft;
    public GameObject sferaright;

    public void FixedUpdate()
    {
      //Q SHOTING
      if(shootdelayq<=0)
      {

        bool qpress = Input.GetKey(KeyCode.Q);
        if (qpress)
        {
          altitudeleft.transform.position = new Vector3(altitudeleft.transform.position.x, altitudeleft.transform.position.y + 0.1f, altitudeleft.transform.position.z);
        }

        bool qup = Input.GetKeyUp(KeyCode.Q);
        if (qup)
        {
          Vector3 direction = altitudeleft.transform.position-startleft.transform.position;
          Fire(direction, 1); // 1 left 2 right
          altitudeleft.transform.position =  restleft.transform.position;
          shootdelayq=shoottimer;

          MeshRenderer meshRenderer = sferaleft.GetComponent<MeshRenderer>();
          meshRenderer.material = rosso;
          cannonsound.Play();
        }

      }else{
        shootdelayq -= Time.deltaTime;
        if(shootdelayq<=0)
        {
          MeshRenderer meshRenderer = sferaleft.GetComponent<MeshRenderer>();
          meshRenderer.material = verde;
        }
      }

      //E SHOTING
      if(shootdelaye<=0)
      {
        bool epress = Input.GetKey(KeyCode.E);
        if (epress)
        {
          altituderight.transform.position = new Vector3(altituderight.transform.position.x, altituderight.transform.position.y + 0.1f, altituderight.transform.position.z);
        }

        
        bool eup = Input.GetKeyUp(KeyCode.E);
        if (eup)
        {
          Vector3 direction = altituderight.transform.position-startright.transform.position;
          Fire(direction, 2); // 1 left 2 right
          altituderight.transform.position = restright.transform.position;
           shootdelaye=shoottimer;
          MeshRenderer meshRenderer = sferaright.GetComponent<MeshRenderer>();
          meshRenderer.material = rosso;
          cannonsound.Play();
        }

      }else{
        shootdelaye -= Time.deltaTime;
        if(shootdelaye<=0)
        {
          MeshRenderer meshRenderer = sferaright.GetComponent<MeshRenderer>();
          meshRenderer.material = verde;
        }
      }
    }



}
