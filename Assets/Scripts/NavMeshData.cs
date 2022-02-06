using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using NaughtyAttributes;

public class NavMeshData : MonoBehaviour {

    [BoxGroup("Settings")]
    public Transform point;

    [BoxGroup("Settings")]
    public int n;

}