using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateJigsawPiece : MonoBehaviour
{
    public Camera maincam;


    void Update()
    {
        maincam = Camera.main;
        if(Input.GetMouseButtonDown(1)){
            if (!jigsawManager.win) {
                soundManagerScript.playSound("rotateSound");
                rotate();
            }
        }
    }

    void rotate() {
        RaycastHit hit;
        if(Physics.Raycast(maincam.ScreenPointToRay(Input.mousePosition), out hit, 200))
        {
            if(hit.transform.CompareTag("Jigsaw")) {
                hit.transform.Rotate(0f, 90f, 0f);
            }
        }
    }
}
