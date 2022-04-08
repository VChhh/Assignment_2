using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class houseMang : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gate;
    private bool readyToGo = false;

    public GameObject key;

    public GameObject clue;

    public TextMeshProUGUI scoreUI;
    void Start()
    {
        PublicVars.keys_in_world = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if(!readyToGo && key == null){
            readyToGo = true;
            PublicVars.keys_on_player = 1;
            PublicVars.score += 1;
            scoreUI.text = "Clues: " + PublicVars.score + "/8";
        }

        if(readyToGo){
            gate.SetActive(true);
            clue.SetActive(true);
        }
    }
}
