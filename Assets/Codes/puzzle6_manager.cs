using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puzzle6_manager : MonoBehaviour
{
    Material target;
    public GameObject torch1;
    public GameObject torch2;
    public GameObject torch3;
    Renderer _rd1;
    Renderer _rd2;
    Renderer _rd3;
    public GameObject key;
    public GameObject gate;

    private bool ready_to_go = false;
    public GameObject clue;
    public TextMeshProUGUI scoreUI;



    private void Start() {
        PublicVars.keys_in_world = 1;
        _rd1 = torch1.GetComponent<Renderer>();
        _rd2 = torch2.GetComponent<Renderer>();
        _rd3 = torch3.GetComponent<Renderer>();
        target = torch1.GetComponent<puzzle6_torch>().target_color;
    }

    private void Update() {


        if(torch1.GetComponent<puzzle6_torch>().is_on &&
            torch2.GetComponent<puzzle6_torch>().is_on &&
            torch3.GetComponent<puzzle6_torch>().is_on && !ready_to_go){
            key.SetActive(true);
            key.GetComponent<key>().is_collectable = true;
            gate.SetActive(true);
            PublicVars.score += 1;
            scoreUI.text = "Clues: " + PublicVars.score + "/8";
            clue.SetActive(true);
            ready_to_go = true;
        }
    }
}
