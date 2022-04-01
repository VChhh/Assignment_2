using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_button : MonoBehaviour
{
    private int index;
    private Renderer _rd;
    public Material[] _materials = new Material[3];
    bool is_in = false;
    private void Start() {
        _rd = GetComponent<Renderer>();
        _materials = GameObject.FindGameObjectWithTag("Manager").GetComponent<puzzle_manager>().materials;
        for(int i = 0; i < 3; i++){
            if(_materials[i] == _rd.material){
                index = i;
                break;
            }
        }
    }
    private void Update() {
        if(is_in && Input.GetKeyDown("f")){

            index = (index + 1) % 3;

            _rd.material= _materials[index];
        }
    }

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
}
