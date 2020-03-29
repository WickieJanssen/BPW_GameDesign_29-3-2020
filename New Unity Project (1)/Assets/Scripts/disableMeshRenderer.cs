using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableMeshRenderer : MonoBehaviour
{
    public MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        mr.enabled = false;
    }
}
