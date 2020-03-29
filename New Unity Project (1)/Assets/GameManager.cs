using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float klok;
    public Text klokText;

    // Update is called once per frame
    void Update()
    {
        klok +=1 * Time.deltaTime;

        klokText.text = "Time"+klok;
    }
}
