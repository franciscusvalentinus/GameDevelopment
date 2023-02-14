using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPrefabs : MonoBehaviour
{
    //referensi ke prefab kita
    public GameObject Prefab;


    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate prefab kita untuk di"cipta"kan dalam world
            var newPrefab = Instantiate(Prefab);

            //tentukan posisi x,y baru di world position
            var xSpawn = -1.0f + UnityEngine.Random.Range(0, 2f);
            var ySpawn = 5.0f;
            newPrefab.transform.position = new Vector3(xSpawn, ySpawn, 0);
        }    
    }
}
