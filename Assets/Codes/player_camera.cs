using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_camera : MonoBehaviour
{
     // Start is called before the first frame update
    private float vertical_speed = .4f;
    GameObject player;
    Vector3 offset;
    float vertical_offset = 0f;
    public float rotate_speed = .8f; // camera rotation speed

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;

    }

    private void Update() {
        // rotate the camera with e and q
        if(Input.GetKey("q")){
            offset = Quaternion.AngleAxis (-rotate_speed, Vector3.up) * offset;
        }
        if(Input.GetKey("e")){
            offset = Quaternion.AngleAxis (rotate_speed, Vector3.up) * offset;
        }
        if(Input.GetKey("w")){
            if(vertical_offset<4.4f) vertical_offset += vertical_speed;
        }
        if(Input.GetKey("s")){
            if(vertical_offset>-4.4f) vertical_offset -= vertical_speed;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position+new Vector3(0,vertical_offset,0));
    }
}
