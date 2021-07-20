using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugwavesmovement : MonoBehaviour
{
  private MeshFilter meshf;

  private void Awake()
  {
    meshf = GetComponent<MeshFilter>();

  }

  private void Update()
  {
    Vector3[] vertices = meshf.mesh.vertices;
    for (int i=0; i<vertices.Length; i++) {
      vertices[i].y= Debugwavehight.instance.GetWaveHight(transform.position.x + vertices[i].x);
    }

    meshf.mesh.vertices = vertices;
    meshf.mesh.RecalculateNormals();
  }
}
