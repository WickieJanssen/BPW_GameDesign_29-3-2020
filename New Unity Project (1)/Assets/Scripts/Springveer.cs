using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Springveer : MonoBehaviour
{
    public MeshRenderer mr;
    public bool jump = false;

    public ParticleSystem ps;

    void Start()
    {
        FindObjectOfType<PlayerController>().Jump(jump);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            mr.enabled = false;
            jump = true;
            FindObjectOfType<PlayerController>().Jump(jump);
        }
    }
    void Update()
    {
        if (jump)
        {
            ps.Emit(0);
        }
        else
        {
            ps.Emit(1);
        }

    }
}
