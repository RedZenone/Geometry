using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
      transform.position=player.transform.position;
    }

    void Update()
    {
      transform.position=player.transform.position;

      if (Input.GetKey(KeyCode.D))
      {
          //Rotate the sprite about the Y axis in the positive direction
          transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * 10, Space.World);
      }

      if (Input.GetKey(KeyCode.A))
      {
          //Rotate the sprite about the Y axis in the negative direction
          transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * 10, Space.World);
      }
    }
}
