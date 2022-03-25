using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class player_control : MonoBehaviour
{
    NavMeshAgent _navAgent;
    public Camera maincam;
    public TextMeshProUGUI scoreUI;

    private void Start() {
        scoreUI.text = "Score: " + PublicVars.score;
        _navAgent = GetComponent<NavMeshAgent>();
        maincam = Camera.main;
        //StartCoroutine(Go());
    }   

    IEnumerator Go(){
        while(true){
            yield return new WaitForSeconds(1f);
            Vector3 point = new Vector3(Random.Range(-2,2), 0, Random.Range(-2,2));
            _navAgent.destination = point;
        }
    }

    private void Update() {
        
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            if(Physics.Raycast(maincam.ScreenPointToRay(Input.mousePosition), out hit, 200)){
                _navAgent.destination = hit.point;
            }
        }   
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            PublicVars.score++;
            scoreUI.text = "Score: " + PublicVars.score;
            if(PublicVars.score > 0){
                scoreUI.text = "Score: " + PublicVars.score + "  Hint: The Key is located in location XYZ";
            }
            
        }

        if(other.gameObject.CompareTag("Key")){
            Destroy(other.gameObject);
            PublicVars.score++;
            scoreUI.text = "Score: " + PublicVars.score;
        }
    }
    private void OnTriggerEnter(Collider other) {
        print("hi");
        if (other.gameObject.CompareTag("Interactable"))
        {
            print("hi2");
        }
    }
}
