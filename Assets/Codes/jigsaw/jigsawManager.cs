using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class jigsawManager : MonoBehaviour
{
    private Transform[] pieces = new Transform[4];
    public Transform one;
    public Transform two;
    public Transform three;
    public Transform four;
    public static bool win;
    public GameObject key;
    private bool ready_to_go = false;
    public GameObject gate;
    public GameObject clue;
    public TextMeshProUGUI scoreUI;


    void Start()
    {
        win = false;
        pieces[0] = one;
        pieces[1] = two;
        pieces[2] = three;
        pieces[3] = four;
    }

    void Update()
    {
        if (!ready_to_go && Mathf.Abs(pieces[0].rotation.y) == 1 && Mathf.Abs(pieces[1].rotation.y) == 1 && 
        Mathf.Abs(pieces[2].rotation.y) == 1 && Mathf.Abs(pieces[3].rotation.y) == 1) 
        {
            win = true;
            key.SetActive(true);
            key.GetComponent<key>().is_collectable = true;
            ready_to_go = true;
            PublicVars.score += 1;
            scoreUI.text = "Clues: " + PublicVars.score + "/8";
        }

        if (ready_to_go){
            gate.SetActive(true);
            clue.SetActive(true);
        }
    }
}
