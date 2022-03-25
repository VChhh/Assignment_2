using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cabinet : MonoBehaviour
{
    public GameObject interactable_part;
    private bool is_opended = false;
    public void Interact(){
        print("nice");
        if(!is_opended){
            interactable_part.transform.Rotate(0,-90,0);
        }
        is_opended = is_opended | true;
    }
}
