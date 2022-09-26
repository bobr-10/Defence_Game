using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    private static bool gameEnded;

    public GameObject gameOverUI;

    void Start()
    {
        gameEnded = false;
    }

    void Update()
    {
        if (gameEnded)
            return; 

        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;
        gameOverUI.SetActive(true);
    }
}
