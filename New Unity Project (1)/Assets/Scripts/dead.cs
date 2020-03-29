using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dead : MonoBehaviour
{
    public CharacterController cc;
    public float deads;
    public Text deadCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.transform.position.y <= -40)
        {
            deads += 1;
            cc.Move(new Vector3((0 - cc.transform.position.x), (3 - cc.transform.position.y), (0 - cc.transform.position.z)));
        }
        deadCount.text = "deads:"+deads;
    }
}
