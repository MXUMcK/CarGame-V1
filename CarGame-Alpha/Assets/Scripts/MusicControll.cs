using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControll : MonoBehaviour
{
    public static MusicControll instance;

    private void Awake() 
    {
        // Don't destroy this gameObject when loading different scenes
        DontDestroyOnLoad(this.gameObject);

        if (instance == null) 
        {
            instance = this; 
        }
        else 
        
        {
            Destroy(gameObject); 
        }
    }
}
