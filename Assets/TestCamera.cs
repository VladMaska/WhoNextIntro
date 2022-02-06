using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using NaughtyAttributes;

[System.Serializable]
public class CameraPoints {

    public string name;

    [HorizontalLine]

    public Transform transform;
    public float moveSpeed;

    [HorizontalLine]

    public Quaternion rotation;
    public float rotationSpeed;

}

public class TestCamera : MonoBehaviour {

    public int cpn = 0;

    [Label("Camera Points")]
    public CameraPoints[] cp;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        
        
    }

    void Update(){

        for ( int i=0; i<cp.Length - 1; i++ ){
            //Debug.DrawRay( cp[ i ].transform.position, cp[ i+1 ].transform.position, Color.black );
            Debug.DrawLine( cp[ i ].transform.position, cp[ i+1 ].transform.position, Color.black );
        }

        if ( transform.position == cp[ cpn ].transform.position ){ cpn++; }
        if ( cpn >= cp.Length ){ cpn = 0; }

        transform.rotation = Quaternion.Slerp( transform.rotation, cp[ cpn ].rotation, cp[ cpn ].rotationSpeed );
        transform.position = Vector3.MoveTowards( transform.position, cp[ cpn ].transform.position, cp[ cpn ].moveSpeed );

    }

}