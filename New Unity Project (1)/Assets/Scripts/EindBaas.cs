using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EindBaas : MonoBehaviour
{
    public Transform eindbaas;
    public Transform player;
    public CharacterController cc;

    private float a;
    private float b;
    private float c;
    private float timer;
    private float timer1;

    public float speed;
    private float d;

    public Transform t;
    public GameObject go;
    private GameObject i;
    void Start()
    { 
            
    }

    // Update is called once per frame
    void Update()
    {
        
        if (cc.transform.position.z > 0)
        {
            timer += 1 * Time.deltaTime;
            timer1 += 1 * Time.deltaTime;



            a = player.position.x;
            c = 25;

            if (timer >= 3)
            {
                b = Random.Range(0, 10f);
                timer = 0;
            }
            if (a <= -13)
            {
                a = -13;
            }
            if (a >= 13)
            {
                a = 13;
            }
            eindbaas.position = new Vector3(a, b, c);

            if (timer1 >= 3 && timer1 <= 4)
            {
                d += speed;
                i = Instantiate(go, new Vector3(player.position.x, player.position.y, ((25 - player.position.z) - d)), t.rotation);

                Destroy(i, 30f);
            }
            if (timer1 >= 4.5 && timer1 <= 5.5)
            {
                d = 0;
            }
            if (timer1 >= 6 && timer1 <= 7)
            {
                d += speed;
                i = Instantiate(go, new Vector3(player.position.x, player.position.y, ((25 - player.position.z) - d)), t.rotation);

                Destroy(i, 30f);
            }
            if (timer1 >= 7.5 && timer1 <= 8.5)
            {
                d = 0;
            }
            if (timer1 >= 9 && timer1 <= 10)
            {
                d += speed;
                i = Instantiate(go, new Vector3(player.position.x, player.position.y, ((25 - player.position.z) - d)), t.rotation);

                Destroy(i, 30f);
            }
            if (timer1 >= 10.5 && timer1 <= 11.5)
            {
                d = 0;
            }
            if (timer1 >= 12 && timer1 <= 13)
            {
                d += speed;
                i = Instantiate(go, new Vector3(player.position.x, player.position.y, ((25 - player.position.z) - d)), t.rotation);

                Destroy(i, 30f);
            }
            if (timer1 >= 13.5 && timer1 <= 14)
            {
                d = 0;
            }
            if (timer1 >= 15 && timer1 <= 16)
            {
                d += speed;
                i = Instantiate(go, new Vector3(player.position.x, player.position.y, ((25 - player.position.z) - d)), t.rotation);

                Destroy(i, 30f);
            }
            if (timer1 >= 16.5 && timer1 <= 17.5)
            {
                d = 0;
            }
            if (timer1 >= 18 && timer1 <= 19)
            {
                d += speed;
                i = Instantiate(go, new Vector3(player.position.x, player.position.y, ((25 - player.position.z) - d)), t.rotation);

                Destroy(i, 30f);
            }
            if (timer1 >= 19.5 && timer1 <= 20.5)
            {
                d = 0;
            }
            if (timer1 >= 21 && timer1 <= 22)
            {
                d += speed;
                i = Instantiate(go, new Vector3(player.position.x, player.position.y, ((25 - player.position.z) - d)), t.rotation);

                Destroy(i, 30f);
            }
            if (timer1 >= 22.5 && timer1 <= 23)
            {
                d = 0;
            }
            if (timer1 >= 24 && timer1 <= 25)
            {
                d += speed;
                i = Instantiate(go, new Vector3(player.position.x, player.position.y, ((25 - player.position.z) - d)), t.rotation);

                Destroy(i, 30f);
            }
            if (timer1 >= 25.5 && timer1 <= 26)
            {
                d = 0;
            }
            if (timer1 >= 27 && timer1 <= 28)
            {
                d += speed;
                i = Instantiate(go, new Vector3(player.position.x, player.position.y, ((25 - player.position.z) - d)), t.rotation);

                Destroy(i, 30f);
            }
            if (timer1 >= 30)
            {
                SceneManager.LoadScene("Level 3");
            }

        }
        Debug.Log(timer1);
    }
}
