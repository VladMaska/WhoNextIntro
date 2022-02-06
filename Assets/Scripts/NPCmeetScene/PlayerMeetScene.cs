using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMeetScene : MonoBehaviour {

    public GameObject meetPoint;

    [Range(0, 7)]
    public int animN;
    public bool coreAnim;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    Player player;
    Animator anim;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        anim = this.gameObject.GetComponent<Animator>();
        player = this.gameObject.GetComponent<Player>();

    }

    void Update() => coreAnim = GameCore.npcAnim;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void OnTriggerEnter( Collider other ){

        if ( other.gameObject.name == meetPoint.name ){

            this.transform.rotation = Quaternion.Euler( 0, 0, 0 );

            anim.SetBool( player.animN.ToString(), false );
            anim.Play( "None" );
            anim.SetBool( animN.ToString(), true );

            player.animN = animN;

            GameCore.npcAnim = true;

        }
        
    }

}