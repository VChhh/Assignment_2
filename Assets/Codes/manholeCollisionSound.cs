using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manholeCollisionSound : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other) {
        if(other.transform.CompareTag("Player")){
            print("collided");
            soundManagerScript.playSound("cabinetOpen");
        }
    }
}
