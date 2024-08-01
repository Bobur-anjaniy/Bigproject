using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class counet : MonoBehaviour
{
    public GameObject deadpanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("score"))
        {
            Debug.Log("Player intersected with Score object!");
            ScoreManager.instance.AddScore(1);
        }
        else if (other.CompareTag("dead"))
        {
            Debug.Log("Player intersected with Dead object!");
            PauseGame();
        }
    }

    // ����� ��� ���������� ���� �� �����
    void PauseGame()
    {
        deadpanel.SetActive(true);
        // ������ ����� � ���� �� �����
        Time.timeScale = 0;
        // �������� ������
      
    }
} 