using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class TestP : MonoBehaviour {

    public Transform point;
    public bool _agent;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    NavMeshAgent agent;
    Animator anim;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        anim = this.gameObject.GetComponent<Animator>();

        agent = GetComponent<NavMeshAgent>();
        agent.speed = GameCore.playerSpeed;
        // Look to point
        agent.updateUpAxis = true;
        
    }

    void Update(){ if ( _agent ){ agent.SetDestination( point.position ); } }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    // Event for start animation and stop NavMesh )
    private void OnTriggerEnter( Collider other ){

        string _tag = other.gameObject.tag;

        if ( _tag == "Animation" ){

            _agent = false;

            NavMeshData navMeshData = other.gameObject.GetComponent<NavMeshData>();

            anim.StopPlayback();

            StartAnim( 2 );

            point = navMeshData.point;

        }
        
    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    // For Animation
    void SetAnim( int n ){

        _agent = true;
        anim.SetBool( ( n-1 ).ToString(), false );
        anim.SetBool( n.ToString(), true );

        anim.Play( "None" );

    }

    // For trigger and i hope that not only for him
    void StartAnim( int n ){

        anim.SetBool( ( n-1 ).ToString(), false );
        anim.SetBool( n.ToString(), true );

        anim.Play( "None" );

    }

}