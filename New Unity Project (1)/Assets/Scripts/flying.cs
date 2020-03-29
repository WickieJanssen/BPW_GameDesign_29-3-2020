using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flying : MonoBehaviour
{
    public Transform t;
    private float a;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a -= 0.2f;
        t.position = new Vector3(a, t.position.y, t.position.z);
    }
}
