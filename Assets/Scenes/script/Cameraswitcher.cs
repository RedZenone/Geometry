using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraswitcher : MonoBehaviour
{
    public Camera isometric;
    public Camera backcamera;
    public Camera leftcam;
    public Camera rightcam;
    public GameObject centalminimap;
    public GameObject lateralminimap;
    void Update()
    {
      bool one = Input.GetKeyDown(KeyCode.Alpha1); //both
      if (one)
      {
        backcamera.rect = new Rect(0.5f, 0f, 0.5f, 1f);
        isometric.rect = new Rect(0f, 0f, 0.5f, 1f);
        leftcam.rect = new Rect(0f, 0f, 0f, 0f);
        rightcam.rect = new Rect(0f, 0f, 0f, 0f);
        lateralminimap.active = false;
        centalminimap.active = true;
      }
      bool two = Input.GetKeyDown(KeyCode.Alpha2); //only isometric camera
      if (two)
      {
        isometric.rect = new Rect(0f, 0f, 1f, 1f);
        backcamera.rect = new Rect(0f, 0f, 0f, 0f);
        leftcam.rect = new Rect(0f, 0f, 0f, 0f);
        rightcam.rect = new Rect(0f, 0f, 0f, 0f);
        centalminimap.active = false;
        lateralminimap.active = true;
      }
      bool three = Input.GetKeyDown(KeyCode.Alpha3); //only back camera
      if (three)
      {
        backcamera.rect = new Rect(0f, 0f, 1f, 1f);
        isometric.rect = new Rect(0f, 0f, 0f, 0f);
        leftcam.rect = new Rect(0f, 0f, 0f, 0f);
        rightcam.rect = new Rect(0f, 0f, 0f, 0f);
        centalminimap.active = false;
        lateralminimap.active = true;
      }
      bool five = Input.GetKeyDown(KeyCode.Alpha5); //only isometric camera
      if (five)
      {
        isometric.rect = new Rect(0f, 0f, 0f, 0f);
        backcamera.rect = new Rect(0f, 0f, 0f, 0f);
        leftcam.rect = new Rect(0f, 0f, 0f, 0f);
        rightcam.rect = new Rect(0f, 0f, 1f, 1f);
        centalminimap.active = false;
        lateralminimap.active = true;
      }
      bool four = Input.GetKeyDown(KeyCode.Alpha4); //only back camera
      if (four)
      {
        backcamera.rect = new Rect(0f, 0f, 0f, 0f);
        isometric.rect = new Rect(0f, 0f, 0f, 0f);
        leftcam.rect = new Rect(0f, 0f, 1f, 1f);
        rightcam.rect = new Rect(0f, 0f, 0f, 0f);
        centalminimap.active = false;
        lateralminimap.active = true;
      }
    }
}
