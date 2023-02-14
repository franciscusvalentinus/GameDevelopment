using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    private Game game;


    public void SetGame(Game game_)
    {
        game = game_;
    }
    private void OnCollisionEnter(Collision collision)
    {
        game.OnAlienHit(this);
    }

    private void Update()
    {
        var posOnScreen = Camera.main.WorldToViewportPoint(transform.position);

        //apakah keluar layar?
        if ((posOnScreen.y < -0.1f) )
        {
            game.OnAlienSuccess(this);
            Destroy(gameObject);
        }
        
    }
}
