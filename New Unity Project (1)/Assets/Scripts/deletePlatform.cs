using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletePlatform : MonoBehaviour
{
    public MeshRenderer mr;
    public BoxCollider bc;
    public CharacterController cc;

    private float timer;
    private float timer1;
    private bool hit;
    public float destroyTime;
    public float cooldownTime;

    // Start is called before the first frame update
    void Start()
    {
        mr.enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            hit = true;
        }
    }

    // Update is called once per frame
    void Update()
    {     
        if (hit)
        {
            timer += 1 * Time.deltaTime;
        }
        if(timer >= destroyTime)
        {
            bc.isTrigger = true;
            timer1 +=1 * Time.deltaTime;
        }
        if (timer1 > cooldownTime)
        {
            bc.isTrigger = false;
            timer = 0;
            hit = false;
            timer1 = 0;
        }
    }
}
