using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketku : MonoBehaviour
{
    float speed ;
    float angle ;
    public GameObject prefabPeluru;
    // Start is called before the first frame update
    void Start()
    {
        // variabel speed akan di random dari yang ada di dalam ()
      speed = Random.Range(0.01f, 0.05f);   
      angle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // apakah sudah diujung layar
        if (transform.localPosition.x > 10){
            // balikan posisi ke ujung layar
              transform.localPosition = new Vector3(-10, transform.localPosition.y, transform.localPosition.z);
        }
        if (transform.localPosition.x < -10){
            // balikan posisi ke ujung layar
              transform.localPosition = new Vector3(10, transform.localPosition.y, transform.localPosition.z);
        }
        if (transform.localPosition.y > 5){
            // balikan posisi ke ujung layar
              transform.localPosition = new Vector3(transform.localPosition.x,-5 , transform.localPosition.z);
        }
         if (transform.localPosition.y < -5){
            // balikan posisi ke ujung layar
              transform.localPosition = new Vector3(transform.localPosition.x, 5 , transform.localPosition.z);
        }
        // gerakan object 0.01f ke ke kanan
        transform.localPosition = new Vector3(transform.localPosition.x + speed, transform.localPosition.y, transform.localPosition.z);
         //Rotate translation vector according to the angle
         //
        Vector3 translationVec = new Vector3(Mathf.Cos(angle),
                                                Mathf.Sin(angle),
                                                0);
        transform.localPosition += translationVec * speed;
        // rotate ship berdasarkan angle
        transform.rotation =  Quaternion.Euler(0, 0, angle * (180 / Mathf.PI));
    
        //check for key inputs
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            angle += 0.05f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            angle -= 0.05f;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //block 2 akan masuk sekali sampai ada event ditekan lagi
            speed += 0.01f;
            if (speed > 1) speed = 1;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            speed -= 0.01f;
            if (speed < 0) speed = 0;
        }else if (Input.GetKeyDown(KeyCode.Space))
        {
            //Tembak();
            // 1.buat pelurunya
           var peluruBaru =  Instantiate(prefabPeluru);
           peluruBaru.GetComponent<GerakPeluru>().TembakDari(transform.localPosition, translationVec);
           peluruBaru.GetComponent<SpriteRenderer>().color = Color.red;
            //2. set awal arah dari peluru

        }

    }
        private void OnCollisionEnter (Collision collision)
        {
            if(collision.collider.tag == "Alien"){
            //1.mampus
            Destroy(this.gameObject);
                    
            //2.apa yang terjadi dengan monsternya
        }
    }
}
