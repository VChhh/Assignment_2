using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        }
        if (ready_to_go){
            gate.SetActive(true);
        }
    }
}
