using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{
    public bool shoot;
    private MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mr.enabled = false;
    }

    public void GetArm(bool collision)
    {
        if (collision)
        {
            mr.enabled = true;
        }
    }
}
