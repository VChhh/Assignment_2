using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour
{
    //public Transform holdPoint;
    public Camera maincam;
    private int the_layer;



    void Start()
    {
        maincam = Camera.main;
        the_layer = LayerMask.GetMask("key");
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            grab_check();
        }
    }

    void grab_check(){
        RaycastHit grab_hit;
        if(Physics.Raycast(maincam.ScreenPointToRay(Input.mousePosition), out grab_hit, 200)){
            if(grab_hit.transform.CompareTag("grab") || grab_hit.transform.CompareTag("Item")){
                // do something
                print("Grabbed");
            }
            
        }
        // check only the key layer
        // destroy the key and update the key num if the key is_collectable
        if(Physics.Raycast(maincam.ScreenPointToRay(Input.mousePosition), out grab_hit, 200, the_layer) 
            && grab_hit.transform.GetComponent<key>().is_collectable){
            PublicVars.keys_in_world -- ;
            PublicVars.keys_on_player ++ ;
            Destroy(grab_hit.transform.gameObject);

            
        }

        
        
    }


}
