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
        if (Input.GetMouseButton(1) && (DateTime.Now - Lastplace).TotalSeconds > 0f)
        {
            Instantiate(blocks[0], transform.position + (transform.right * -10) + (new Vector3(0, 10, 0)), Quaternion.identity);
            Lastplace = DateTime.Now;


        }
        else if (Input.GetMouseButton(0)) {
            var invert =Physics.OverlapSphere(transform.position + (transform.right * -20),10f);
            foreach (Collider jnhb in invert) {
                if (jnhb.transform.tag != "dead") { 
                 Destroy(jnhb.transform.gameObject);
                
                }
               
            }
        }
    }
}
