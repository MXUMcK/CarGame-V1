using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyCarOnColl : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject, 5f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
