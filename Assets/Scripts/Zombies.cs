using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using NaughtyAttributes;

public class Zombies : MonoBehaviour {

    public int n = 10;
    public Transform point;

    [ShowAssetPreview]
    public GameObject[] zombies;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    Vector3 tp;
    float _tp = 5;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    void Start(){

        tp = this.gameObject.transform.position;

        for ( int i=0; i<n; i++ ){

            int r = Random.Range( 0, zombies.Length - 1 );

            float _x = Random.Range( -_tp, _tp ),
                  _z = Random.Range( -_tp, _tp );

            GameObject zombie = Instantiate( zombies[ r ], new Vector3( tp.x + _x, 0, tp.z + _z ), Quaternion.identity, this.transform );
            zombie.name = $"{i}_{zombies[ r ].name}";
            zombie.GetComponent<Enemy>().point = this.point;

        }

    }

}