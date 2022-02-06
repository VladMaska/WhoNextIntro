using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PAmim : MonoBehaviour {

    public int animN;
    Animator anim;
    
    void Start() => anim = this.gameObject.GetComponent<Animator>();

    public void SetAnim( int n ){

        animN = n;

        if ( n == 1 ){
            anim.SetBool( n.ToString(), true );
        }
        else {
            anim.SetBool( (n-1).ToString(), false );
            anim.SetBool( n.ToString(), true );
        }

    }

}