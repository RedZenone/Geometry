using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towershooting : MonoBehaviour
{
  public GameObject cannonballpref;
  public GameObject tower;
  public GameObject alzata;
  public float distanceof_shooting;
  public float distanceof_boat;
  public float shootdelay;
  public float shoottimer;
  public float aimvariant;
  public float aimingangle;
  public Vector3 boatposition;
  public AudioSource cannonsound;

  private GameObject boat;

  void Start()
  {
      boat=GameObject.Find("Player");
  }

  public void Update()
  {
    //boatposition = transform.InverseTransformPoint(boat.transform.position);
    boatposition = boat.transform.position;
    //Vector3 towerposition = transform.InverseTransformPoint(tower.transform.position);
    Vector3 direction = new Vector3((boatposition.x-tower.transform.position.x),0,(boatposition.z-tower.transform.position.z));   //the angle toward the player
    distanceof_boat= direction.magnitude;
    if (shootdelay > 0)
    {
        shootdelay -= Time.deltaTime;
    }
    
    if (tower.GetComponent<Tower>().angle<aimingangle && boat.GetComponent<Boathealth>().Health>0)
    {
      if (direction.magnitude<distanceof_shooting && shootdelay<=0)
      {
          tower.GetComponent<Tower>().Alzata();
          shootdelay=shoottimer;
          float x = Random.Range(-aimvariant, aimvariant);
          float z = Random.Range(-aimvariant*2, aimvariant*4);
          Vector3 newboatposition=  new Vector3(boat.transform.position.x+x,boat.transform.position.y,boat.transform.position.z+z);
          Debug.DrawLine(tower.transform.position, newboatposition, Color.green, 10f);
          Debug.Log("shoot");
          Shoot(newboatposition);
          aimvariant=aimvariant*0.9f;
      }
    }
  }

  private void Shoot(Vector3 newboatposition)
  {
    GameObject cannonball = Instantiate(cannonballpref, transform);
    cannonball.GetComponent<TowerCannonball>().Setup(tower.transform.position,newboatposition,alzata.transform.position);
    cannonsound.Play();
  }
}
