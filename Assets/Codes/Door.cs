using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string levelToLoad = "house";
    public void Interact(){
        SceneManager.LoadScene(levelToLoad);
    }
}
