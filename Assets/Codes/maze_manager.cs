using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class maze_manager : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    void Start()
    {
        PublicVars.score += 1;
        scoreUI.text = "Clues: " + PublicVars.score + "/8";
        PublicVars.keys_in_world = 2;
    }
}
