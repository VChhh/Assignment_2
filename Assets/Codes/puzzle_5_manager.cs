using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_5_manager : MonoBehaviour
{
    public GameObject[] buttons = new GameObject[5];
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
        if(check_correctness()){
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

    bool check_correctness(){
        for(int i = 0; i < 5; ++i){
            if(buttons[i].GetComponent<puzzle5_button>().index != 2) return false;
        }
        return true;
    }

    public void change_color(GameObject curr){
        int index = 0;
        for(int i = 0; i < 5; ++i){
            if(buttons[i] == curr) index = i;
        }
        buttons[index].GetComponent<puzzle5_button>().change_color();
        if(index + 1 < 5) buttons[index + 1].GetComponent<puzzle5_button>().change_color();
        if(index - 1 >= 0) buttons[index - 1].GetComponent<puzzle5_button>().change_color();
    }
}
