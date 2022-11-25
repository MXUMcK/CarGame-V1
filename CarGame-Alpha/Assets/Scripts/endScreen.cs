using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreen : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void ExitButton()
    {
        
    }
}
