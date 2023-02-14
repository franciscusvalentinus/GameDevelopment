using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private void OnCollisionEnter (Collision collision)
    {
        if(collision.collider.tag == "Peluru"){
        //1.mampus
        Destroy(this.gameObject);
        Destroy(collision.collider.gameObject);
        
        //2.apa yang terjadi dengan monsternya
        }
    }
}
