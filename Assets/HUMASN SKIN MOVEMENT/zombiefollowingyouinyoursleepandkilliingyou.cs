
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiefollowingyouinyoursleepandkilliingyou : MonoBehaviour
{
    public GameObject rlm;
    // Start is called before the first frame update
    void Start()
    {
        rlm = GameObject.Find("HUAMANS");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 I = transform.position;
        Vector3 Z = rlm.transform.position;
        float sfd = Vector3.Distance(I, Z);
        if (sfd < 50)
        {
            transform.LookAt(rlm.transform);
            transform.position += transform.forward * .05f;
        }
    }
}
