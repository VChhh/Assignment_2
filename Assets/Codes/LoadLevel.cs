using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string levelToLoad = "Level_1";
    public int num_of_keys_required = 1; // keys num required to open the door
    public int num_key_in_world_left = 0;
    
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.CompareTag("Player") && 
            (num_of_keys_required == PublicVars.keys_on_player || PublicVars.keys_in_world == num_key_in_world_left)) 
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
