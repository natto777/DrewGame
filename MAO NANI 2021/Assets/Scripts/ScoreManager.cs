using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score;
    
    void Awake()
    {
        score = 0;
    }
    // Update is called once per frame
    public void increaseScore()
    {

        score++;
        scoreText.text = score.ToString();
        
    }
}
