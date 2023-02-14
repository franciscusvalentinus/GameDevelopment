using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstance : MonoBehaviour
{
    public Game game;
    // Start is called before the first frame update
    public void SetGameReference(Game game_)
    {
        game = game_;
    }
}
