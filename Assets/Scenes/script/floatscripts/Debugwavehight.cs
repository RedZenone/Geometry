using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugwavehight : MonoBehaviour
{
  public static Debugwavehight instance;
  public float amplitude = 1f;
  public float speed = 2f;
  public float lenght = 1f;
  public float offset = 0f;
  public float scale = 1f;

  private void Awake()
  {
    if (instance==null) {
      instance=this;
    }
    else if (instance != this) {
      Destroy(this);
    }
  }

  private void Update()
  {
    offset += Time.deltaTime * speed;
  }

  public float GetWaveHight (float _x)
  {
    return amplitude * Mathf.Sin(_x / lenght + offset);  //scale for the
  }
}
