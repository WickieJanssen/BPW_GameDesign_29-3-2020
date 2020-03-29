using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetArm : MonoBehaviour
{
    private bool collision;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            collision = true;
            FindObjectOfType<Arm>().GetArm(collision);
            
            Destroy(gameObject);
        }
    }
}
