using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereFall : MonoBehaviour {
   
    public float fallspeed = 8.0f;
    
    private void Update ()
    {
       transform.Translate(Vector3.down * fallspeed * Time.deltaTime, Space.World);
    }

}
