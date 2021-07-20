using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towerhealth : MonoBehaviour
{
  public int Health = 1;
  public GameObject tower;
  public string tag;

  void OnCollisionEnter ( Collision collision )
  {
    if(collision.gameObject.tag == tag)
    {
        Health--;
        Destroy(collision.gameObject); //This destroys the colliding object.
        Debug.Log("hit_tower");

    }

    if(Health < 1){
        Destroy(tower);
        Destroy(gameObject);
    }

  }
}
