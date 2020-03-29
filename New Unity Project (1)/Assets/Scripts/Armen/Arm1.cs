using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm1 : MonoBehaviour
{
    private MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mr.enabled = false;
    }

    public void GetArm1(bool collision)
    {
        if (collision)
        {
            mr.enabled = true;
        }
    }
}
