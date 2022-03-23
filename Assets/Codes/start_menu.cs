using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_menu : MonoBehaviour
{
    public void StartGame(){
        Time.timeScale = 1;
        SceneManager.LoadScene("level_1");
    }


    public void ExitGame(){
        print("Quit Game!");
        Application.Quit();
    }
}
