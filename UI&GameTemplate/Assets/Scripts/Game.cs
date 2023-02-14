using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    //referensi ke prefab kita
    public GameObject alienPrefab;
    public AppManager appManager;

    //referensi ke UI
    public Text scoreText;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //fungsi jika alien berhasil mencapai bawah
    public void OnAlienSuccess(Alien alien)
    {
        score++;
        scoreText.text = score.ToString();
    }

    //fungsi jika alien terkena
    public void OnAlienHit(Alien alien)
    {
        GameOver();
    }

    void GameOver()
    {
        appManager.OnGameover();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate prefab kita untuk di"cipta"kan dalam world
            var newAlien = Instantiate(alienPrefab);
            //pastikan ada referensi untuk ke game ini
            newAlien.GetComponent<Alien>().SetGame(this);

            //tentukan posisi x,y baru di world position
            var xSpawn = 0;
            var ySpawn = 5.0f;
            newAlien.transform.position = new Vector3(xSpawn, ySpawn, 0);
        }
    }
}
