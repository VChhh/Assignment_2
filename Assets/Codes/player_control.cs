using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
using UnityEngine.Animations;

public class player_control : MonoBehaviour
{
    NavMeshAgent _navAgent;
    public Camera maincam;
    public TextMeshProUGUI scoreUI;
    public GameObject hint_UI;
    Animator _am;
    Vector3 previous_position;

    private void Start() {
        scoreUI.text = "Clues: " + PublicVars.score + "/8";
        _navAgent = GetComponent<NavMeshAgent>();
        maincam = Camera.main;
        _am = GetComponent<Animator>();
        previous_position = transform.position;
    }   

    private void Update() {
        _am.SetBool("is_moving", previous_position!=transform.position);
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            if(Physics.Raycast(maincam.ScreenPointToRay(Input.mousePosition), out hit, 200)){
                _navAgent.destination = hit.point;
            }
        }   
    }

    IEnumerator ShowMessage(string message, float delay) {
        scoreUI.text = "Clues: " + PublicVars.score + "/8" + message;
        yield return new WaitForSeconds(delay);
        scoreUI.text = "Clues: " + "/8" + PublicVars.score;
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Interactable")){
            hint_UI.SetActive(true);
        }
        if (other.gameObject.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            // PublicVars.score++;
            scoreUI.text = "Clues: " + PublicVars.score + "/8";
        }

        if(other.gameObject.CompareTag("Key")){
            Destroy(other.gameObject);
            // PublicVars.score++;
            // scoreUI.text = "Clues: " + PublicVars.score + "/10";
        }
    }


    private void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("Interactable")){
            hint_UI.SetActive(false);
        }
    }
    private void OnCollisionStay(Collision other) {
        if(other.gameObject.CompareTag("Interactable")){
            print("in");
            // call every function named "Interact" that are attached on this gameobject
            other.transform.gameObject.BroadcastMessage("Interact"); 
        }
    }

    private void LateUpdate() {
        previous_position = transform.position;
    }
}
