using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public string levelToLoad = "Level1";

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
