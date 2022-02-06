using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

using NaughtyAttributes;

public class Enemy : MonoBehaviour {

    public Transform point;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    NavMeshAgent agent;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = true;
        agent.updateUpAxis = true;
        
    }

    void Update() => agent.SetDestination( point.position );

    private void OnTriggerEnter( Collider other ){

        if ( other.gameObject.name == point.name ){

            Destroy( this.gameObject );

        }
        
    }

    private void OnCollisionEnter( Collision collision ){

        if ( collision.gameObject.name == point.name ){

            Destroy( this.gameObject );

        }
        
    }

}