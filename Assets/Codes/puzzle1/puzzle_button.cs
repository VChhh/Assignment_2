using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_button : MonoBehaviour
{
    public int index;
    private Renderer _rd;
    public Material[] _materials = new Material[3];
    bool is_in = false;
    private void Start() {
        _rd = GetComponent<Renderer>();
        //_materials = GameObject.FindGameObjectWithTag("Manager").GetComponent<puzzle_manager>().materials;
        //_rd.material = _materials[index];
    }
    private void Update() {
        if(is_in && Input.GetKeyDown("f")){

            index = (index + 1) % 3;

            soundManagerScript.playSound("clickButton");

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
