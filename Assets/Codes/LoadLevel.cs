using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string levelToLoad = "Level1";
    public int num_of_keys_required = 1;

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.CompareTag("Player") && num_of_keys_required == PublicVars.keys_on_player) 
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
