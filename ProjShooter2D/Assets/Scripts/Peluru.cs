using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peluru : MonoBehaviour
{
    // Start is called before the first frame update
    float angle = 0;
    float speed = 0;
    Vector3 directionVector = new Vector3();
    Game game;

    void Start()
    {
        
    }

    public void Shoot(Vector3 initialPos, float angle_, float speed_)
    {
        speed = speed_;
        angle = angle_;
        transform.position = new Vector3(initialPos.x, initialPos.y, initialPos.z);

        directionVector = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0);
    }


    // Update is called once per frame
    void Update()
    {
        transform.position += directionVector * speed;

        var posOnScreen = Camera.main.WorldToViewportPoint(transform.position);

        if ((posOnScreen.x <= 0) || (posOnScreen.x >= 1))
            Destroy(this.gameObject);

        if ((posOnScreen.y <= 0) || (posOnScreen.y >= 1))
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Alien>() != null)
             Destroy(gameObject);
    }
}
