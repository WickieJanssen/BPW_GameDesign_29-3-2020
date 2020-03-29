using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCam : MonoBehaviour
{
    public Transform target;
    public int rotateSpeed;
    public bool cursor;

    public Vector3 offset;
    public Transform pivot;

    // Start is called before the first frame update
    void Start()
    {
        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;

        if(cursor){
            Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        pivot.Rotate(-vertical, 0, 0);

        float desiredYAngle = target.eulerAngles.y;
        float desiredXAngle = pivot.eulerAngles.x;
        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);

        transform.rotation = rotation;
    }
}
