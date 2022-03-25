using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cabinet : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) 
    {
        print("hi");
        if (other.gameObject.CompareTag("Player")) 
        {
            print("hi2");
        }
    }
}
