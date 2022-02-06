using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAnimTime : MonoBehaviour {

    public string _name;
    public float time;

    [Space]

    public bool showTime;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    bool _time = true;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start() => Debug.Log( "Timer start" );

    void Update(){

        if ( _time ){ time += Time.deltaTime; }

        if ( showTime ){

            showTime = false;
            Debug.Log( $"Time: {time}" );

        }

    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void StopTimer() => Debug.Log( $"Time: {time}" );

    private void OnApplicationQuit() => Debug.Log( $"Stop on: {time}" );

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void OnTriggerEnter( Collider other ){

        if ( other.gameObject.name == _name ){

            _time = false;
            StopTimer();

        }
        
    }

}