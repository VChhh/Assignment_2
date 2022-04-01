using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_manager : MonoBehaviour
{
    public GameObject button_to_yellow;
    public GameObject button_to_blue;
    public GameObject button_to_red;

    void Update()
    {
        if(button_to_blue.GetComponent<Renderer>().material.color == PublicVars.my_blue &&
            button_to_yellow.GetComponent<Renderer>().material.color == PublicVars.my_yellow &&
            button_to_red.GetComponent<Renderer>().material.color == PublicVars.my_red ){
                // do something
                print("matched");
            }
    }
}
