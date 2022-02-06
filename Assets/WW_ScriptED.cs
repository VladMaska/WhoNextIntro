using UnityEngine;
using System.Collections;

namespace WhiteWolf {

    public class WW_ScriptED : MonoBehaviour {

        static GameObject obj = null;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public WW_ScriptED( GameObject _obj ) => obj = _obj;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public static void eScript( string script ) => ( obj.GetComponent( script ) as MonoBehaviour ).enabled = true;
        public static void eScript( MonoBehaviour script ) => script.enabled = true;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public static void dScript( string script ) => ( obj.GetComponent( script ) as MonoBehaviour ).enabled = false;
        public static void dScript( MonoBehaviour script ) => script.enabled = false;

    }

}