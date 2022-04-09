using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class grab : MonoBehaviour
{
    //public Transform holdPoint;
    public Camera maincam;
    private int the_layer;

    Animator _an;

    
    public TextMeshProUGUI scoreUI;

    void Start()
    {
        maincam = Camera.main;
        the_layer = LayerMask.GetMask("key");
        _an = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            grab_check();
        }
    }
    
    IEnumerator ShowMessage(string message, float delay) {
        scoreUI.text = "Clues: " + PublicVars.score + "/8" + message;
        yield return new WaitForSeconds(delay);
        scoreUI.text = "Clues: " + PublicVars.score + "/8";
    }
    
    void grab_check(){
        RaycastHit grab_hit;
        if(Physics.Raycast(maincam.ScreenPointToRay(Input.mousePosition), out grab_hit, 200)){
            if(grab_hit.transform.CompareTag("grab") || grab_hit.transform.CompareTag("Item")){
                // do something
                // PublicVars.score++;
                scoreUI.text = "Clues: " + PublicVars.score + "/8";
                /*
                if(PublicVars.score >= 0){
                    StartCoroutine(ShowMessage("  Hint: The Key is located in the cabinet", 3f));
                }
                */
                if(SceneManager.GetActiveScene().name == "house"){
                    StartCoroutine(ShowMessage("  Hint: The Key is located in one of the boxes", 3f));
                }
                else if(SceneManager.GetActiveScene().name == "test_scene"){
                    StartCoroutine(ShowMessage("  Hint: The Key is located in cabinet", 3f));
                }
                else if(SceneManager.GetActiveScene().name == "puzzle"){
                    StartCoroutine(ShowMessage("  Hint: The button colors don't match the wall...", 3f));
                }
                else if(SceneManager.GetActiveScene().name == "puzzle2"){
                    StartCoroutine(ShowMessage("  Hint: Rotate...rotate...", 3f));
                }
                else if(SceneManager.GetActiveScene().name == "puzzle3"){
                    StartCoroutine(ShowMessage("  Hint: Dodge 1,2,3,4,5,6!", 3f));
                }
                else if(SceneManager.GetActiveScene().name == "puzzle4"){
                    StartCoroutine(ShowMessage("  Hint: 0/2 keys", 3f));
                }
                else if(SceneManager.GetActiveScene().name == "puzzle5"){
                    StartCoroutine(ShowMessage("  Hint: Buttons change themself and their neighbors...", 3f));
                }
                else if(SceneManager.GetActiveScene().name == "puzzle6"){
                    StartCoroutine(ShowMessage("  Hint: Lit all at once!", 3f));
                }
                else if(SceneManager.GetActiveScene().name == "puzzle_torch"){
                    StartCoroutine(ShowMessage("  Hint: Is that the right order?", 3f));
                }
            }            
        }
        
 
        // check only the key layer
        // destroy the key and update the key num if the key is_collectable
        if(Physics.Raycast(maincam.ScreenPointToRay(Input.mousePosition), out grab_hit, 200, the_layer) 
            && grab_hit.transform.GetComponent<key>().is_collectable 
            && Vector3.Distance(transform.position, grab_hit.transform.position) < 5){
            PublicVars.keys_in_world -- ;
            PublicVars.keys_on_player ++ ;
            StartCoroutine(wait_and_destory(grab_hit.transform.gameObject));
        }
    }

    IEnumerator wait_and_destory(GameObject g){
        _an.SetBool("grabbing", true);
        yield return new WaitForSeconds(1f);
        Destroy(g);
    }
}
