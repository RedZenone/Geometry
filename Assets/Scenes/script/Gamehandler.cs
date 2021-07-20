using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamehandler : MonoBehaviour
{
    //public Boat player;
    public GameObject waterprefab;

    void Start()
    {
      //PlaceProps();
      Placewater();
    }


// map creation
//______________________________________________________________________________
    private void Placewater()
    {
      for (int x=0; x<16; x++) {
        for (int z=0; z<16; z++) {
          //Instantiate(waterprefab, new Vector3(x*10-50, 0, z*10-50), Quaternion.identity);
          GameObject water = Instantiate(waterprefab, transform);

          Transform mtransform = water.GetComponent<Transform>();
          mtransform.position = new Vector3(x*100-700, 0, z*100-700);
        }
      }
    }

    public void PlaceProps()
    {
      int ntowers=8;
      int nrocks=8;
      int[,] places = new int[5,5];

      for (int i=0; i<5; i++) { //initialize at 0
        for (int l=0; l<5; l++) {
          places[i,l]=0;
        }
      }

      //populate
      while(ntowers>0 && nrocks>0)
      {
        for (int x=-2; x<3; x++) {
          for (int y=-2; y<3; y++) {
            if (places[x+2,y+2]==0) {//controll the place is empty
                if (x==0 && y==0) {
                  continue; //skipp the center
                }
                int random=Random.Range(0, 3); //0 tower, 1 rock, 2 void
                switch(random)
                {
                  case 0:
                    places[x+2,y+2]=1;
                    if (ntowers>0) { //controll if there are any more tower to place
                      PlaceTowers(x,y);
                      ntowers--;
                    }else{
                      if (nrocks>0) {
                        PlaceRock(x,y);
                        nrocks--;
                      }
                    }
                    break;

                  case 1:
                    places[x+2,y+2]=1;
                    if (nrocks>0) { //controll if there are any more tower to place
                      PlaceRock(x,y);
                      nrocks--;
                    }else{
                      if (ntowers>0) {
                        PlaceTowers(x,y);
                        ntowers--;
                      }
                    }
                    break;

                  case 2:
                    break;
                }
            }
          }
        }
      }
    }

    public GameObject Tower;
    public GameObject Rock;

    public void PlaceRock(int x, int y)
    {
      GameObject newRock = Instantiate(Rock, transform);

      Transform mtransform = newRock.GetComponent<Transform>();
      int randomx=Random.Range(-50, 51);
      int randomy=Random.Range(-50, 51);
      mtransform.position = new Vector3(200*x + randomx, -10, 200*y + randomy);
    }

    public void PlaceTowers(int x, int y)
    {
      GameObject newTower = Instantiate(Tower, transform);

      Transform mtransform = newTower.GetComponent<Transform>();
      int randomx=Random.Range(-50, 51);
      int randomy=Random.Range(-50, 51);
      mtransform.position = new Vector3(200*x + randomx, -10, 200*y + randomy);
    }

//______________________________________________________________________________



}
