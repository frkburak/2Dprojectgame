using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
   public static ScoreManager instance;
    #region Singleton
    private void Awake()
    {
        if (instance!= null) 
        {
            Destroy(gameObject);
        }
        else 
        {
            instance = this;
        }
    }
    #endregion
    public TextMeshProUGUI scoreText;
    public static int score;
    public static int highScore;
    void Start()
    {
        scoreText.text = "Score:" + score.ToString();
    }

    void Update()
    {
        
    }
    public void AddPoint(int value) 
    {
        score += value;
        scoreText.text = "Score:" + score.ToString();
    }
}
