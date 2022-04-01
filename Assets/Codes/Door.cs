using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string levelToLoad = "Level_1";

    bool is_in = false;

    private void OnCollisionEnter(Collision other) {
        if(other.transform.CompareTag("Player")){
            is_in = true;
        }
    }

    private void OnCollisionExit(Collision other) {
        if(other.transform.CompareTag("Player")){
            is_in = false;
        }
    }

    private void Update() {
        print("1");
        if(is_in) print("hi");
        if(is_in && Input.GetKey("f")) {
            SceneManager.LoadScene(levelToLoad);
        }
    }
    
    public void Interact(){
        if(Input.GetKey("f")) {
            //SceneManager.LoadScene(levelToLoad);
        }
    }
}
