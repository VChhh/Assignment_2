using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class player_control : MonoBehaviour
{
    NavMeshAgent _navAgent;
    public Camera maincam;

    private void Start() {
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
}
