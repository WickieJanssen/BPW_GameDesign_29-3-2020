using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bladblazer : MonoBehaviour
{
    public MeshRenderer mr;
    public ParticleSystem ps;
    public bool dash = false;

    void Start()
    {
        FindObjectOfType<PlayerController>().Dash(dash);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            dash = true;
            mr.enabled = false;
            FindObjectOfType<PlayerController>().Dash(dash);
        }
    }
    void Update()
    {
        if (dash)
        {
            ps.Emit(0);
        }
        else
        {
            ps.Emit(1);
        }
    }
}
