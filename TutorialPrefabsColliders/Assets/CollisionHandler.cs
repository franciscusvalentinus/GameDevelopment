using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter (Collision collision){
        //jika pada waktu kena collision
        //Destroy(collision.gameObject);
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 10 ,0), ForceMode.Impulse);
    }

     private void OnTriggerEnter (Collider other){
        //jika pada waktu kena collision
        Destroy(other.gameObject);
    }

}
