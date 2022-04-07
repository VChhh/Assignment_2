using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseMang : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gate;

    private bool readyToGo = false;
    void Start()
    {
        PublicVars.keys_in_world = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if(!readyToGo && PublicVars.score == 1){
            readyToGo = true;
            PublicVars.keys_on_player = 1;
        }

        if(readyToGo){
            gate.SetActive(true);
        }
    }
}
