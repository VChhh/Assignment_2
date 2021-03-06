using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cabinet : MonoBehaviour
{
    public GameObject interactable_part;
    public GameObject key;
    private bool is_opened = false; // to make sure opening the gate for once
    public void Interact(){
        if(Input.GetKey("f")) {
            if(!is_opened){
                soundManagerScript.playSound("cabinetOpen");

                interactable_part.transform.Rotate(0,-90,0); // open the cabinet gate
                key.GetComponent<key>().is_collectable = true;
            }
            is_opened = is_opened | true;
        }
    }
}
