using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakDiagonal : MonoBehaviour
{
    public float speed = 0.01f;
    float batas_kanan = 10f;
    float batas_kiri = -10f;
     float batas_atas = 5f;
    float batas_bawah = -5f;
    Vector3 translationVec;
    int directionX = 1,directionY = 1;

    // Start is called before the first frame update
    void Start()
    {
         // translationVec = new Vector3(x,y,0);
    }

    // Update is called once per frame
    void Update()
    {
        
       /* if (transform.localPosition.x > batas_kanan){
            //buat geraknya ke kiri
            //translationVec = new Vector3(-1,0,0);
           directionX = -1;
            
        }
        if (transform.localPosition.x <  batas_kiri){
            //buat geraknya ke kanan
           // translationVec = new Vector3(1,0,0);
          directionX = 1;
        }
         if (transform.localPosition.y > batas_atas){
            //buat geraknya ke bawah
           // translationVec.y = -1;
           // translationVec = new Vector3(0,-1,0);
          directionY = -1;
            
        }
        if (transform.localPosition.y <  batas_bawah){
            //buat geraknya ke atas
            // translationVec.y = 1;
           // translationVec = new Vector3(0,1,0);
         directionY = 1;
        }*/

        if (transform.localPosition.x > batas_kanan || transform.localPosition.x <  batas_kiri){
            //buat geraknya ke kiri
            //translationVec = new Vector3(-1,0,0);
           directionX = -directionX;
            
        }
         if (transform.localPosition.y > batas_atas || transform.localPosition.y <  batas_bawah){
            //buat geraknya ke bawah
           // translationVec.y = -1;
           // translationVec = new Vector3(0,-1,0);
          directionY = -directionY;
            
        }

        translationVec = new Vector3( directionX, directionY,0);
        transform.localPosition += translationVec * speed;
    }
}
