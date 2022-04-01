using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_manager : MonoBehaviour
{
    public Renderer button_to_yellow;
    public Renderer button_to_blue;
    public Renderer button_to_red;
    public Material r;
    public Material y;
    public Material b;

    public Material[] materials = new Material[3];
    private void Start() {
        materials[0] = r;
        materials[1] = y;
        materials[2] = b;
    }

    void Update()
    {
        if(button_to_blue.GetComponent<Renderer>().material == materials[2]) print("BBB");
        if(button_to_red.GetComponent<Renderer>().material == materials[0]) print("RRR");
        if(button_to_yellow.GetComponent<Renderer>().material == materials[1]) print("YYY");



        if(button_to_blue.GetComponent<Renderer>().material == materials[2] &&
            button_to_yellow.GetComponent<Renderer>().material == materials[1] &&
            button_to_red.GetComponent<Renderer>().material == materials[0] ){
                // do something
                print("matched");
            }
    }
}
