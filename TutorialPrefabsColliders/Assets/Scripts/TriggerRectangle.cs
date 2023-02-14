using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRectangle : MonoBehaviour
{
    SpriteRenderer mySprite;
    // Start is called before the first frame update
    void Start()
    {
        //dapatkan komponen Sprire Renderer dari gameobject kita
        mySprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        //Event ini terpanggil jika trigger tersentuh collider yang lain
        mySprite.color = new Color(UnityEngine.Random.Range(0, 1f),
                                    UnityEngine.Random.Range(0, 1f),
                                    UnityEngine.Random.Range(0, 1f), 1);
    }
}
