using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakPeluru : MonoBehaviour
{
    public float speed =0.5f;
    Vector3 translationVec;
    float batas_kanan = 10f;
    float batas_kiri = -10f;
     float batas_atas = 5f;
    float batas_bawah = -5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += translationVec * speed;
         if (transform.localPosition.x > batas_kanan || transform.localPosition.x <  batas_kiri 
         || transform.localPosition.y > batas_atas || transform.localPosition.y <  batas_bawah){
            //buat geraknya ke kiri
            //translationVec = new Vector3(-1,0,0);
           Destroy(this.gameObject);
            
        }
    }

    public void TembakDari(Vector3 posAwal, Vector3 direction)
    {
        // taruh peluru di posisi awal
        transform.localPosition =new Vector3(posAwal.x, posAwal.y, posAwal.z);
        
        //set arah peluru
        translationVec = new Vector3(direction.x,direction.y,direction.z);
    }
}
