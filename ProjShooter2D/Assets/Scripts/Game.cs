using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum AlienType
{
    GreenAlien,
    RedAlien
}

public class Game : MonoBehaviour
{
    public GameObject[] alienPrefab;
    public Spaceship spaceship;
    public Text scoreLabel;

    //jika dipublic maka akan muncul di unity
    // Start is called before the first frame update
    int Score = 0;
    int alienCount = 0; // how many aliens for each level/difficulty
    int alienExists = 0; // How many aliens currently exists in the game
    int alienKilledCount = 0;

    

    void Start()
    {
        ResetAndBeginGame();
        spaceship.SetGameReference(this);
    }

    void ResetAndBeginGame()
    {
        alienCount = 2;
        alienExists = 0;
        alienKilledCount = 0;
        Score = 0;

        //place the ship at the center of the screen
        spaceship.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.5f));
    }

    public void EndGame()
    {
        //automatically starts the game again ??
        
    }

    public void AlienKilled(Alien alien)
    {
        alienKilledCount++;
        alienExists--;

        if (alien.type == AlienType.GreenAlien)
        {
            Score += 1;
        }
        else if (alien.type == AlienType.RedAlien)
        {
            Score += 2;
        }

        //for 10 aliens killed increase the difficulty
        if (alienKilledCount % 10 == 0)
        {
            alienCount++;
        }

        scoreLabel.text = "Score :" + Score;
    }

    // Update is called once per frame
    void Update()
    {

        if (alienExists < alienCount)
        {
            //
            var idx = UnityEngine.Random.Range(0, 2);
            var newAlien = Instantiate(alienPrefab[idx]).GetComponent<Alien>();
            newAlien.SetGameReference(this);
            alienExists++;
        }
    }
}
