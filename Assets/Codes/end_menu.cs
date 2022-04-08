using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_menu : MonoBehaviour
{
    public void RestartGame(){
        Time.timeScale = 1;
        SceneManager.LoadScene("title");
    }
    public void ExitGame(){
        print("Quit Game!");
        Application.Quit();
    }

}
