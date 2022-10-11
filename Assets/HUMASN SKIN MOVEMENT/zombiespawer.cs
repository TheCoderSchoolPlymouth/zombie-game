using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiespawer : MonoBehaviour
{
    public GameObject zombie;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 500; i++) {
            float x = Random.Range(-3073f, 3073f);
            float z = Random.Range(-3073f, 3073f);
            Vector3 pos = new Vector3(x, 1000f, z);
            Instantiate(zombie, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
