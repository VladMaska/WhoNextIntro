using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControll : MonoBehaviour {

    public PAmim p;

    public void Set( int n = 1 ) => p.SetAnim( n );

}