using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isometricfollow : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
      transform.position= new Vector3(player.transform.position.x,70f,player.transform.position.z-60f);

      Vector3 direction = new Vector3(player.transform.position.x-transform.position.x,player.transform.position.y-transform.position.y,player.transform.position.z-transform.position.z);
      Quaternion _lookRotation = Quaternion.LookRotation(direction.normalized);

      transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * 2);
    }
}
