using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torch_manager : MonoBehaviour
{
    public GameObject[] torches = new GameObject[5];
    public static int num_on = 0;
    private int num_on_prev;
    public GameObject key;
    public GameObject gate;
    private bool ready_to_go = false;
    private void Start() {
        num_on = 0;
        num_on_prev = 0;
        PublicVars.keys_in_world = 1;
    }

    private void Update() {
        print(check_correctness(num_on));
        if(num_on!= 0 && check_correctness(num_on)){
            if(num_on == 5){
                // complete
                print("nice");
                key.SetActive(true);
                key.GetComponent<key>().is_collectable = true;
                ready_to_go = true;
            }
        }
        else{
            reset();
        }
        if(ready_to_go){
            gate.SetActive(true);
        }
    }

    bool check_correctness(int num_on){
        for(int i = 0; i < num_on; i++ ){
            if(torches[i].transform.GetChild(1).gameObject.activeSelf == false){
                return false;
            }
        }
        return true;
    }

    private void reset(){
        for(int i = 0; i < 5; i++){
            torches[i].GetComponent<torch>().turn_off();
        }
        num_on = 0;
    }

    private void LateUpdate() {
        num_on_prev = num_on;
    }
}
