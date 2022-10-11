using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotbarscoll : MonoBehaviour
{
    public static int unomas;
    // Start is called before the first frame update
    void Start()
    {
        unomas = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mouseScrollDelta.y);

        // Shiv, i set this to LOCALPOSITION as it was getting the position in terms of the 3D world, NOT the canvas originally
        if (Input.mouseScrollDelta.y > 0) {
            if (unomas < 10) {
                unomas += 1;
                var axis = -412.4f + (69 * unomas);
                Debug.Log(axis);
                transform.localPosition = new Vector3(axis,transform.localPosition.y, transform.localPosition.z);
            }
        }
        else if (Input.mouseScrollDelta.y < 0) {
            Debug.Log("DOWN");
            if (unomas > 1) {
                unomas -= 1;
                var axis = -412.4f + (69 * unomas);
                Debug.Log(axis);
                transform.localPosition = new Vector3(axis,transform.localPosition.y, transform.localPosition.z);
            }       
        }
    }
}
