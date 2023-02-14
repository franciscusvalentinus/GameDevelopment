using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : GameInstance
{
    public int health = 1;
    public GameObject explosionPrefab;
    public AlienType type;

    private void Start()
    {
        var x = UnityEngine.Random.Range(0f, 1f);
        var y = UnityEngine.Random.Range(0f, 1f);
        transform.position = Camera.main.ViewportToWorldPoint(new Vector3(x, y, 0.5f));
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Peluru>() != null)
        {
            health--;
            if (health <= 0)
            {
                Dead();
            }
        }
    }

  
    void Dead()
    {
        if (game != null)
        {
            game.AlienKilled(this);
        }

        var exp = Instantiate(explosionPrefab);
        exp.transform.position = transform.position;
        Destroy(gameObject);

    }
}
