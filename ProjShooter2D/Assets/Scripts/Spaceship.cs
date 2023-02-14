using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : GameInstance
{
    public Peluru bulletPrefab;
    public GameObject explosionPrefab;

    private float bulletSpeed = 0.1f;
    private Vector3 translation;
    private float angle;
    private float speed = 0;
    private int health = 3;
    

    void Start()
    {

    }

    void Tembak()
    {
        var bullet = Instantiate(bulletPrefab);
        bullet.Shoot(transform.position, angle, bulletSpeed + speed);
        var bullet2 = Instantiate(bulletPrefab);
        bullet2.Shoot(transform.position, angle - 0.1f, bulletSpeed + speed);
        var bullet3 = Instantiate(bulletPrefab);
        bullet3.Shoot(transform.position, angle + 0.1f, bulletSpeed + speed);
    }

    // Update is called once per frame
    void Update()
    {
        //check for key inputs
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            angle += 0.1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            angle -= 0.1f;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            speed += 0.01f;
            if (speed > 1) speed = 1;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            speed -= 0.01f;
            if (speed < 0) speed = 0;
        }else if (Input.GetKeyDown(KeyCode.Space))
        {
            Tembak();
        }

        //Rotate translation vector according to the angle
        Vector3 translationVec = new Vector3(Mathf.Cos(angle),
                                                Mathf.Sin(angle),
                                                0);
        //move the ship based on the translation vector and speed
        transform.transform.position += (translationVec * speed);

        //rotate the ship based on the angle
        transform.rotation = Quaternion.Euler(0, 0, angle * (180 / Mathf.PI));


        var posOnScreen = Camera.main.WorldToViewportPoint(transform.position);

        if ((posOnScreen.x <= -0.1f) || (posOnScreen.x >= 1.1f))
        {
            posOnScreen.x = (posOnScreen.x <= 0 ? 1.1f : -0.1f);
            var x = Camera.main.ViewportToWorldPoint(posOnScreen).x;
            //if our ship is off screen
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
            

        if ((posOnScreen.y <= -0.1f) || (posOnScreen.y >= 1.1f))
        {
            //
            posOnScreen.y = (posOnScreen.y <= 0 ? 1.1f : -0.1f);
            var y = Camera.main.ViewportToWorldPoint(posOnScreen).y;
            //if our ship is off screen
            
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }
            


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Alien>() != null)
        {
            health--;
            if (health <= 0)
            {
                var exp = Instantiate(explosionPrefab);
                exp.transform.position = transform.position;
                game.EndGame();
            }
        }
            
    }

}
