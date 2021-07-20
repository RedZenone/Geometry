using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawAim : MonoBehaviour
{

    Boatshoot boatshoot;
    LineRenderer lineRenderer;

    public int points = 50;

    public float time = 0.1f;

    public LayerMask CollidableLayers;

    void Start()
    {
      boatshoot = GetComponent<Boatshoot>();
      lineRenderer = GetComponent<LineRenderer>();
    }
/*
    void Update()
    {
      lineRenderer.positionCount = (int)numPoints;
      List<Vector3> points = new List<Vector3>();
      Vector3 startingPosition = boatshoot.ShotPoint.position;
      Vector3 startingVelocity = boatshoot.ShotPoint.up * cannonController.BlastPower;
      for (float t = 0; t < numPoints; t += timeBetweenPoints)
      {
          Vector3 newPoint = startingPosition + t * startingVelocity;
          newPoint.y = startingPosition.y + startingVelocity.y * t + Physics.gravity.y/2f * t * t;
          points.Add(newPoint);

          if(Physics.OverlapSphere(newPoint, 2, CollidableLayers).Length > 0)
          {
              lineRenderer.positionCount = points.Count;
              break;
          }
      }

      lineRenderer.SetPositions(points.ToArray());

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
    }*/
}
