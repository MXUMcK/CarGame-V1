using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineCollider : MonoBehaviour
{
    public string sceneName;
  private void OnCollisionEnter(Collision collision)
  {
      SceneManager.LoadScene(sceneName);

  }
}
