using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    L1Manager S;
    public GameObject[] frogIcons; 
    public int totalLives = 5;

    public TextMeshPro TimeCountDown;

    public float maxTime = 600f; 
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = maxTime;
        UpdateFrogIcons(RemainingLife.remainingLives);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        float progress = currentTime / maxTime;

        if (currentTime <= 0)
        {
            //Debug.Log("Time's up!");
            S.SetGameOver();
        }
        else
        {
            TimeCountDown.text = FormatTime(currentTime);
        }
    }
    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60F);
        int seconds = Mathf.FloorToInt(time - minutes * 60);
        return string.Format("{0:0}:{1:00}", minutes, seconds);
    }

    private void UpdateFrogIcons(int remainingLives)
    {
        for (int i = 0; i < totalLives; i++)
        {
            if (i < remainingLives)
            {
                frogIcons[i].SetActive(true);
            }
            else
            {
                frogIcons[i].SetActive(false);
            }
        }
    }

    public void AddTime(float amount)
    {
        currentTime += amount;
        if (currentTime > maxTime)
        {
            currentTime = maxTime; 
        }
    }
}
