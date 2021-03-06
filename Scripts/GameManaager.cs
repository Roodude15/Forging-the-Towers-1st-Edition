using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManaager : MonoBehaviour {

    public static bool GameIsOver = false;

    public GameObject gameOverUI;
    public GameObject completeLevelUI; 

    private void Start()
    {
        GameIsOver = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsOver)
            return;

        if (Input.GetKeyDown("e"))
        {
            EndGame(); 
        }

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true); 
    }

    public void WinLevel()
    {
        GameIsOver = true; 
        completeLevelUI.SetActive(true);
    }
}
