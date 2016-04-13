using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using live2d;
using live2d.framework;


public class touchController : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Debug.Log("hi test");

       LAppModel model = this.gameObject.GetComponent<LAppModelProxy>().GetModel();
        Debug.Log(model);

        model.SetExpression("f08");
    }
    
    // Update is called once per frame
    void Update () {
    
    }
}
