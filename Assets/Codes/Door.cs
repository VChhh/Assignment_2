using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string levelToLoad = "Level_1";
    public GameObject interactable_part;
    public void Interact(){
        if(Input.GetKey("f")) {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
