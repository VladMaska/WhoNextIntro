using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using NaughtyAttributes;

public class NPC_Anim : MonoBehaviour {

    [ReadOnly]
    public int animN = 1;

    [ReadOnly]
    public bool _start, _core;


    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    Animator anim;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start() => anim = this.gameObject.GetComponent<Animator>();

    void Update(){

        _core = GameCore.npcAnim;

        if ( GameCore.npcAnim && !_start ){

            _start = true;
            anim.SetBool( animN.ToString(), true );

        }
        
    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    public void SetAnim( int n ){

        anim.SetBool( animN.ToString(), false );
        animN = n;
        anim.SetBool( animN.ToString(), true );

    }

    public void PlusAnim(){

        anim.SetBool( animN.ToString(), false );
        anim.SetBool( ( animN++ ).ToString(), true );

    }

}