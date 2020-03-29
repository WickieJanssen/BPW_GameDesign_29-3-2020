using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public ParticleSystem particleLauncher;
    public MeshRenderer mr;
    public GameObject go;

    public float coolDown = 1;
    public float coolDownTimer;

    void Update()
    {
        if (coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }

        if(coolDownTimer < 0)
        {
            coolDownTimer = 0;
        }

        if(mr.enabled)
        {
            if (coolDownTimer == 0)
            {
                if (Input.GetButton("Fire1"))
                {
                    particleLauncher.Emit(1);
                    coolDownTimer = coolDown;
                }
            }
        }
    }

    void OnParticleTrigger()
    {
        Debug.Log("w");
    }
}
