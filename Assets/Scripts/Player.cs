using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

using NaughtyAttributes;

public class Player : MonoBehaviour {

    public Transform point;
    public bool _agent;

    //[HorizontalLine]

    //public GameObject meetPoint;

    //[Range(0, 7)]
    //public int meetAnimN;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    NavMeshAgent agent;
    Animator anim;

    public int animN;

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

            if ( navMeshData.n != 0 ){ StartAnim( navMeshData.n );}

            if ( navMeshData.point != null ){

                point = navMeshData.point;

            }

            //if ( other.gameObject.name == meetPoint.name ){

            //    GameCore.npcAnim = true;

            //    anim.SetBool( animN.ToString(), false );
            //    anim.Play( "None" );
            //    anim.SetBool( meetAnimN.ToString(), true );

            //}

        }

    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    // For Animation
    void SetAnim( int n ){

        _agent = true;
        anim.SetBool( animN.ToString(), false );
        anim.SetBool( n.ToString(), true );

        animN = n;

        anim.Play( "None" );

    }

    // For trigger and i hope that not only for him
    void StartAnim( int n ){

        _agent = false;
        anim.SetBool( animN.ToString(), false );
        anim.SetBool( n.ToString(), true );

        animN = n;

        anim.Play( "None" );

    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    public void SetPlayerSpeed( float n ) => agent.speed = n;

}