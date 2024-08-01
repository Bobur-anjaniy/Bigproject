using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    private int score = 0;

    void Awake()
    {
        // ќбеспечиваем, что ScoreManager будет существовать в единственном экземпл€ре
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // »нициализаци€ текста счета
        UpdateScoreText();
    }

    // ћетод дл€ увеличени€ счета
    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    // ќбновление текста счета
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
