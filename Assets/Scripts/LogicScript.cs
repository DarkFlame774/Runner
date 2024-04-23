using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text[] scores;
    public GameObject[] screens;

    [ContextMenu("Increase Score")]
    public void scoring()
    {
        playerScore++;
        scores[0].text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        
        

    }

    public void gameOver()
    {
        screens[0].SetActive(true);
    }

    
    
}
