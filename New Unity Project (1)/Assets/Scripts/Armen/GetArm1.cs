using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetArm1 : MonoBehaviour
{
    private bool collision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            collision = true;
            FindObjectOfType<Arm1>().GetArm1(collision);
            Destroy(gameObject);
        }
    }
}
