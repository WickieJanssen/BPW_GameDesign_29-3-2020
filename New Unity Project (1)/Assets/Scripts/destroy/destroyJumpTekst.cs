using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyJumpTekst : MonoBehaviour
{
    public MeshRenderer jump;
    public MeshRenderer doubleJump;
    public MeshRenderer dash;
    public MeshRenderer shoot;

    public CharacterController cc;

    public int a;
    public int b;
    public int c;
    public int d;

    void Start()
    {
        jump.enabled = true;
        doubleJump.enabled = false;
        dash.enabled = false;
        shoot.enabled = false;
    }

    void Update()
    {
        if (cc.transform.position.z > 10)
        {
            if (Input.GetKeyUp(KeyCode.Space) && a == 0)
            {
                jump.enabled = false;
                doubleJump.enabled = true;
                a += 1;
            }
            if (a > 0 && b == 0 && Input.GetKeyDown(KeyCode.Space) && cc.transform.position.y > 0)
            {
                doubleJump.enabled = false;
                dash.enabled = true;
                b += 1;
            }
            if (c == 0 && Input.GetKey(KeyCode.LeftShift))
            {
                dash.enabled = false;
                shoot.enabled = true;
                c += 1;
            }
            if (d == 0 && Input.GetButton("Fire1"))
            {
                shoot.enabled = false;
                Destroy(gameObject);
                d += 1;
            }
        }
    }
}
