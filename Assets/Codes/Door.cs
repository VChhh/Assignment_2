using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string levelToLoad = "house";
    public int houseNumber = 0;

    public void Interact(){
        print(PublicVars.house_index);
        if(PublicVars.houses_completed[houseNumber] == false && PublicVars.house_index == houseNumber){
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
