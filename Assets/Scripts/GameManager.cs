using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score;
    public Text scoreText;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void ReStartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void gameScore(int ringScore)
    {
        score += ringScore;
        scoreText.text = score.ToString();

    }
}
