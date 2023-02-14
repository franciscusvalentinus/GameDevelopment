using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketDeath : MonoBehaviour
{
    private void OnCollisionEnter (Collision collision)
    {
        if(collision.collider.tag == "Alien"){
        //1.mampus
        Destroy(this.gameObject);
        
        //2.apa yang terjadi dengan monsternya
        }
    }
}
