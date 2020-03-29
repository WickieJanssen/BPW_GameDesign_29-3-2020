using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class particleCollision : MonoBehaviour
{
    public ParticleSystem ps;
    public CharacterController cc;

    public GameObject go;
    public GameObject go1;
    public GameObject go2;


    private float i;

    private void OnParticleTrigger()
    {
        // particles
        List<ParticleSystem.Particle> inside = new List<ParticleSystem.Particle>();
        List<ParticleSystem.Particle> outside = new List<ParticleSystem.Particle>();
        List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();
        List<ParticleSystem.Particle> exit = new List<ParticleSystem.Particle>();

        // get
        int numInside = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, inside);
        int numOutside = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Exit, outside);
        int numEnter = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
        int numExit = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Exit, exit);

        if(numExit == 1)
        {
            i += 1;
            if (i == 2)
            {
                Destroy(go);
            }
            if(i == 4)
            {
                Destroy(go1);
            }
            if (i == 6)
            {
                Destroy(go2);
            }
            if(i == 30)
            {
                SceneManager.LoadScene("End");
            }
        }
    }

    void Update()
    {
        if (cc.transform.position.z > 0)
        {
            i = 10;
        }
    }
}
