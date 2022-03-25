using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_camera : MonoBehaviour
{
     // Start is called before the first frame update
    GameObject player;
    Vector3 offset;
    public float rotate_speed = 0.4f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
    }

    private void Update() {
        if(Input.GetKey("q")){

            offset = Quaternion.AngleAxis (-rotate_speed, Vector3.up) * offset;
        }
        if(Input.GetKey("e")){
            offset = Quaternion.AngleAxis (rotate_speed, Vector3.up) * offset;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        
        transform.LookAt(player.transform.position);
    }
}
