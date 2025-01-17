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
        // ������������, ��� ScoreManager ����� ������������ � ������������ ����������
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
        // ������������� ������ �����
        UpdateScoreText();
    }

    // ����� ��� ���������� �����
    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    // ���������� ������ �����
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
