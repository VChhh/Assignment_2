using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropping_box : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) {
        print("touched");
        if(other.transform.CompareTag("Player")){
            print("player");
            GameObject.FindGameObjectWithTag("Manager").GetComponent<drop_manager>().reset();
        }
        else if(other.transform.CompareTag("Ground")){
            GameObject.FindGameObjectWithTag("Manager").GetComponent<drop_manager>().score();
        }
    }
    /*
    private void OnCollisionEnter(Collision other) {
        print("1");
        if(other.transform.CompareTag("Player")){
            print("player");
            GetComponent<drop_manager>().reset();
        }
        else if(other.transform.CompareTag("Ground")){
            print("ground");
        }
    }
    */
}
