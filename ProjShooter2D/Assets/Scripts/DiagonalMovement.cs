using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Vector3 direction;

    void Start()
    {
        var dirX = Random.Range(0, 2) == 0 ? 1 : -1;
        var dirY = Random.Range(0, 2) == 0 ? 1 : -1;
        direction = new Vector3(dirX, dirY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed;

        var posOnScreen = Camera.main.WorldToViewportPoint(transform.position);

        if ((posOnScreen.x <= 0) || (posOnScreen.x >= 1))
            direction.x = -direction.x;

        if ((posOnScreen.y <= 0) || (posOnScreen.y >= 1))
            direction.y = -direction.y;


    }
}
