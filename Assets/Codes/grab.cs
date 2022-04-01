using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class grab : MonoBehaviour
{
    //public Transform holdPoint;
    public Camera maincam;
    private int the_layer;

    
    public TextMeshProUGUI scoreUI;

    public Material yellow;
    public Material blue;
    public Material red;
    private Material[] colors = new Material[3];


    void Start()
    {
        maincam = Camera.main;
        the_layer = LayerMask.GetMask("key");
        colors[0] = yellow;
        colors[1] = blue;
        colors[2] = red;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            grab_check();
        }
    }
    
    IEnumerator ShowMessage(string message, float delay) {
        scoreUI.text = "Score: " + PublicVars.score + message;
        yield return new WaitForSeconds(delay);
        scoreUI.text = "Score: " + PublicVars.score;
    }
    void grab_check(){
        RaycastHit grab_hit;
        if(Physics.Raycast(maincam.ScreenPointToRay(Input.mousePosition), out grab_hit, 200)){
            if(grab_hit.transform.CompareTag("grab") || grab_hit.transform.CompareTag("Item")){
                // do something
                // PublicVars.score++;
                scoreUI.text = "Score: " + PublicVars.score;
                if(PublicVars.score >= 0){
                    StartCoroutine(ShowMessage("  Hint: The Key is located in the cabinet", 3f));
                }
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
