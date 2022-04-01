using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_manager : MonoBehaviour
{
    public GameObject button_to_yellow;
    public GameObject button_to_blue;
    public GameObject button_to_red;
    public Material r;
    public Material y;
    public Material b;
    public GameObject key;
    public GameObject gate;
    private bool ready_to_go = false;


    public Material[] materials = new Material[3];
    private void Start() {
        materials[0] = r;
        materials[1] = y;
        materials[2] = b;
        PublicVars.keys_in_world = 1;
    }

    void Update()
    {
        if(button_to_blue.GetComponent<puzzle_button>().index == 2 &&
            button_to_yellow.GetComponent<puzzle_button>().index == 1 &&
            button_to_red.GetComponent<puzzle_button>().index == 0 && !ready_to_go){
                // do something
                print("matched");
                key.SetActive(true);
                key.GetComponent<key>().is_collectable = true;
                ready_to_go = true;
        }
        if(ready_to_go){
            gate.SetActive(true);
        }
    }
}
