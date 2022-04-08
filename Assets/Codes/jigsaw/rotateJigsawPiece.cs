using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateJigsawPiece : MonoBehaviour
{
    // public Camera maincam;
    bool is_in = false;
    private Renderer _rd;

     private void Start() {
        _rd = GetComponent<Renderer>();
    }


    void Update()
    {
        // maincam = Camera.main;
        // if(Input.GetMouseButtonDown(1)){
        if(is_in && Input.GetKeyDown("f")){
            print('f');
            if (!jigsawManager.win) {
                soundManagerScript.playSound("rotateSound");
                rotate();
            }
        }
    }

    void rotate() {
        // RaycastHit hit;
        // if(Physics.Raycast(maincam.ScreenPointToRay(Input.mousePosition), out hit, 200))
        // {
        //     if(hit.transform.CompareTag("Jigsaw")) {
        //         hit.transform.Rotate(0f, 90f, 0f);
        //     }
        // }
        _rd.transform.Rotate(0f, 90f, 0f);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.transform.CompareTag("Player")){
            is_in = true;
            print("touch");
        }
    }
    private void OnCollisionExit(Collision other) {
        if(other.transform.CompareTag("Player")){
            is_in = false;
        }
    }
}
