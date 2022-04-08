using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle6_torch : MonoBehaviour
{
    public bool is_on = false;
    public float time = 1;
    public Material target_color;
    Material original_color;
    Renderer _rd;
    bool is_in = false;
    
    private void Start() {
        _rd = GetComponent<Renderer>();
        original_color = _rd.material;
    }
    private void Update() {
        if(is_in && Input.GetKeyDown("f")){
            on();
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

    void on(){
        is_on = true;
        _rd.material = target_color;
        StartCoroutine(wait(time));
    }

    IEnumerator wait(float t){
        yield return new WaitForSeconds(t);
        _rd.material = original_color;
        is_on = false;
    }
}
