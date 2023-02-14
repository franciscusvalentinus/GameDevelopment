using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialColliders : MonoBehaviour
{
    //referensi ke prefab kita
    public GameObject Prefab;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate prefab kita untuk di"cipta"kan dalam world
            var newPrefabKiri = Instantiate(Prefab);

            //tentukan posisi x,y baru di world position
            newPrefabKiri.transform.position = new Vector3(-3, 5, 0);

            var newPrefabKanan = Instantiate(Prefab);

            //tentukan posisi x,y baru di world position
            newPrefabKanan.transform.position = new Vector3(3, 5, 0);
        }    
    }
}
