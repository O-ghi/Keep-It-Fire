using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameOverScreen gameOverScreen;

    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PlayGame()
    {

        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        gameOverScreen.Setup();
        gameHasEnded = true;
    }

    public void Restart()
    {
        PlayGame();
        gameHasEnded = false;
    }

    public bool getGameHasEnded()
    {
        return this.gameHasEnded;
    }
}
