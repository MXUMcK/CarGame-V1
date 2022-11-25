using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
  private float currentTime = 0f;
  private float startingTime = 3f;
  
  [SerializeField] Text countdownText;

   void Start()
  {
    currentTime = startingTime;
    Time.timeScale = 0;

    if (Input.GetKeyDown(KeyCode.W))
    {
        Time.timeScale = 1;

    }
   
    
  }

    void Update()
    {
        
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            Destroy(gameObject);
            
        }
    }
}
