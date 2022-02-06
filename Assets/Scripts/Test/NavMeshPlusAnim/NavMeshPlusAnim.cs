using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;


public class NavMeshPlusAnim : MonoBehaviour {

    public int animN;

    public bool _agent;
    public Transform point;

    /*––––––––––––––––-–––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    Animator anim;
    NavMeshAgent agent;

    /*––––––––––––––––-–––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        anim = this.gameObject.GetComponent<Animator>();

        agent = GetComponent<NavMeshAgent>();
        agent.speed = GameCore.playerSpeed;
        // Look to point
        agent.updateUpAxis = true;

    }

    void Update(){

        if ( _agent ){

            agent.SetDestination( point.position );
            agent.updateRotation = _agent;

        }
        
    }

    /*––––––––––––––––-–––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

}