using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torch : MonoBehaviour
{
    private GameObject on;
    private void Start() {
        on = transform.GetChild(1).gameObject;
    }
    private void Update() {
        if(is_in && Input.GetKeyDown("f")){
            turn_on();
        }
    }
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

    public void turn_on(){
        this.on.SetActive(true);
        torch_manager.num_on++;
    }

    public void turn_off(){
        on.SetActive(false);
        torch_manager.num_on--;
    }
}
