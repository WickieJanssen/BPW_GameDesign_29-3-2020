using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyTekst : MonoBehaviour
{
    public Text jump;
    public Text doubleJump;
    public Text dash;
    public Text shoot;
    public Text aim;

    public CharacterController cc;

    private int a = 0;
    private int b = 0;
    private int c = 0;
    private int d = 0;
    private int e = 0;

    void Start()
    {
        doubleJump.enabled = false;
        dash.enabled = false;
        shoot.enabled = false;
        aim.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && a==0)
        {
            jump.enabled = false;
            doubleJump.enabled = true;
            a += 1;
        }
        if(Input.GetKeyDown(KeyCode.Space) && a > 0 && b==0)
        {
            doubleJump.enabled = false;
            dash.enabled = true;
            b += 1;
        }
        if (Input.GetKey(KeyCode.LeftShift) && c==0)
        {
            dash.enabled = false;
            shoot.enabled = true;
            c += 1;
        }
        if (Input.GetButtonUp("Fire1") && d == 0)
        {
            shoot.enabled = false;
            aim.enabled = true;
            d += 1;
        }
        if ((Input.GetAxis("Mouse X")<-0.5 || Input.GetAxis("Mouse X") > 0.5) && e == 0)
        {
            aim.enabled = false;
            e += 1;
        }
    }
}
