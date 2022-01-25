using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotação : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0,0.1f));
        //transform.Translate(new Vector3(x,y,z));
       //transform.LocalScale += new Vector3(x,y,z);
    }
}