using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainProgram : MonoBehaviour
{
    public GameObject prefabMonster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //jika spacebar ditekan akan membuat monster baru
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //create monster from prefab 
            Instantiate(prefabMonster);
           // prefabMonster.transform.position = new Vector (Random.Range (1))
        }
    }
}
