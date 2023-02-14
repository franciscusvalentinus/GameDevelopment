using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float speed = 0.3f;
    Vector3 vecTranslasi;
    float dir = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        //tentukan speed dan vector pergerakan sumbu X (geser horizontal)
        speed = UnityEngine.Random.Range(0.3f, 0.8f);
        vecTranslasi = new Vector3(speed * dir, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //translasi posisi 
        transform.Translate(vecTranslasi);

        var posOnScreen = Camera.main.WorldToViewportPoint(transform.position);

        //apakah keluar layar?
        if ((posOnScreen.x < -0.1f) || (posOnScreen.x > 1.1f))
        {
            posOnScreen.x = (posOnScreen.x <= 0 ?  -0.1f : 1.1f);

            //ubah arah dan tentukan speed dan vector pergerakan lagi
            dir = -dir;
            speed = UnityEngine.Random.Range(0.3f, 0.8f);
            vecTranslasi = new Vector3(speed * dir, 0, 0);

            var x = Camera.main.ViewportToWorldPoint(posOnScreen).x;       
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
    }
}
