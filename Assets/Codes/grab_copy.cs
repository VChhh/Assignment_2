// copy of the grab code
// incomplete
// required change:
// 1. change to comparing tag when checking if the object is grabbale
// 2. adjust for gameplay

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab_copy : MonoBehaviour
{
    public Transform holdPoint;
    public Camera maincam;
    public LayerMask grabbable;
    private int ignorePlayerLayer; //This layer does not collide with the player
    private int originalLayer; //Here we can save the original layer the object was on that was picked up
    private Transform heldObject = null; // The held object's transform if a object is held
    private Rigidbody heldRigidbody = null; // The held object's Rigidbody

    void Start()
    {
        ignorePlayerLayer = LayerMask.NameToLayer("IgnorePlayer");
        maincam = Camera.main;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            grab_check();
        }
    }

    void grab_check(){
        RaycastHit grab_hit;
        if(Physics.Raycast(maincam.ScreenPointToRay(Input.mousePosition), out grab_hit, 200, grabbable)){
            StartCoroutine(pick_up(grab_hit.transform));
        }
    }

    IEnumerator pick_up(Transform _tr){
        heldObject = _tr;
        originalLayer = heldObject.gameObject.layer; // save the original layer
        heldObject.gameObject.layer = ignorePlayerLayer; // ignore player layer - keeps held objects from hitting the players collider
        heldRigidbody = heldObject.GetComponent<Rigidbody>();
        heldRigidbody.isKinematic = true; //ignore gravity and other physics while held

        float t = 0;
        while (t < .4f)
        {
            //lerp the position of the object to the held position for .4 sec
            heldRigidbody.position = Vector3.Lerp(heldRigidbody.position, holdPoint.position, t);
            t += Time.deltaTime;
            yield return null;
        }
        SnapToHand(); //When it is close snap it into place
    }
    
    void SnapToHand()
    {
        heldObject.position = holdPoint.position;
        heldObject.parent = holdPoint; // make it a child of the hold position so it inharits the position and rotation
    }
}
