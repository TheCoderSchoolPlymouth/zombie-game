using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupandbendover : MonoBehaviour
{
    public string pickup;
    public bool enable;
    public void OnCollisionEnter (Collision collecter){
        if (collecter.gameObject.tag == "Player"&&enable){
            enable=false;
            hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem(pickup,1);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
