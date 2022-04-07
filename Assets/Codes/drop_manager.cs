using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop_manager : MonoBehaviour
{
    public GameObject drop_box;
    public GameObject player;
    public static int box_dropped = 0;
    public float difficulty_const = 5;
    public GameObject key;
    public GameObject gate;
    Vector3 initial_pos;
    Rigidbody db_rb;
    private void Start() {
        box_dropped = 0;
        initial_pos = drop_box.transform.position;
        db_rb = drop_box.GetComponent<Rigidbody>();
    }

    private void Update() {
        if(box_dropped > 5){
            complete();
        }
    }

    public void reset(){
        box_dropped = 0;
        drop_box.transform.position = initial_pos;
        drop_box.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    public void score(){
        box_dropped++;
        drop_box.transform.position = initial_pos-(new Vector3(0, box_dropped*difficulty_const, 0));
        if(box_dropped > 0){
            drop_box.transform.position = new Vector3(player.transform.position.x, drop_box.transform.position.y, player.transform.position.z);
        }
        db_rb.velocity = Vector3.zero;
        print(box_dropped);
        print(drop_box.transform.position);
    }

    void complete(){
        key.SetActive(true);
        key.GetComponent<key>().is_collectable = true;
        gate.SetActive(true);
        Destroy(drop_box);
    }
}
