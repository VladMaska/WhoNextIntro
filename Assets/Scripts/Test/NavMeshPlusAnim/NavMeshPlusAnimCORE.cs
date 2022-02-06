using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class NavMeshPlusAnimCORE : MonoBehaviour {

    public NavMeshPlusAnim player;

    /*––––––––––––––––-–––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    public void Set( int animN, int agent = 0, Transform point = null ){

        player.animN = animN;
        player._agent = Convert.ToBoolean( Convert.ToInt32( agent ) );
        player.point = point;

    }


    public void SetAnimN( int n ) => player.animN = n;

    public void SetAgent( int agent ) => player._agent = Convert.ToBoolean( Convert.ToInt32( agent ) );

    public void SetPoint( string point ) => player.point = GameObject.Find( point ).transform;

}