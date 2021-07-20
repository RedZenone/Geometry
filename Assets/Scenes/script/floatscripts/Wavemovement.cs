using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class Wavemovement : MonoBehaviour
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
        vertices[i].y= Waves.instance.GetWaveHight(transform.position.x + vertices[i].x*Waves.instance.scale);
      }

      meshf.mesh.vertices = vertices;
      meshf.mesh.RecalculateNormals();
    }

}
