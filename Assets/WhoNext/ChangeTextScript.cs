using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using TMPro;

public class ChangeTextScript : MonoBehaviour {

    public void ChangeText(){

        TextMeshPro tm;

        tm = this.gameObject.GetComponent<TextMeshPro>();

        tm.text = "Either you are with us or against us";

    }

}