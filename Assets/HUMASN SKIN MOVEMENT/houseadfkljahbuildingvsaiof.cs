using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class houseadfkljahbuildingvsaiof : MonoBehaviour
{
    public GameObject[] blocks;
    public DateTime Lastplace;

    // Start is called before the first frame update
    void Start()
    {
        Lastplace = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && (DateTime.Now-Lastplace).TotalSeconds>1) {
            Instantiate(blocks[0], transform.position+(transform.right*-10) + (new Vector3(0,10,0)), Quaternion.identity);
            Lastplace = DateTime.Now;

        }  
    }
}
