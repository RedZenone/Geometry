﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boathealth : MonoBehaviour
{
  public int Health;
  public GameObject boat;
  public GameObject boyancy1;
  public GameObject boyancy2;
  public GameObject boyancy3;
  public GameObject boyancy4;
  public GameObject explosionpref;
  public string tag;
  public GameObject victory;
  private bool defeat=false;
  public Text healthtext;
  public Text health2text;
  
  void OnCollisionEnter ( Collision collision )
  {
    if(collision.gameObject.tag == tag && Health>0)
    {
        Health--;
        GameObject explosion = Instantiate(explosionpref, transform);
        explosion.transform.position=collision.gameObject.transform.position;
        Destroy(collision.gameObject); //This destroys the colliding object.
        Debug.Log("hit_boat");
        boyancy1.GetComponent<Objfloat>().depthtreshold+=1f;
        boyancy2.GetComponent<Objfloat>().depthtreshold+=1f;
        boyancy3.GetComponent<Objfloat>().depthtreshold+=1f;
        boyancy4.GetComponent<Objfloat>().depthtreshold+=1f;
        boat.GetComponent<Boatstearing>().topspeed-=5;
        healthtext.text=Health.ToString();
        health2text.text=Health.ToString();
    }

    if(Health < 1){
      boyancy1.GetComponent<Objfloat>().depthtreshold=1000f;
      boyancy2.GetComponent<Objfloat>().depthtreshold=1000f;
      boyancy3.GetComponent<Objfloat>().depthtreshold=1000f;
      boyancy4.GetComponent<Objfloat>().depthtreshold=1000f;
    }


    
  }

  void Update()
  {
    if(!defeat)
    {
      if(transform.position.x<100 && transform.position.x>0 && transform.position.z>70 && transform.position.z<170)
      {
        victory.active=true;
      }        
    }
  }
}
