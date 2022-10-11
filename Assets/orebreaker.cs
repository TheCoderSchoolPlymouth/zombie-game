using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orebreaker : MonoBehaviour
{
    public float hp;
    public int numnodes;
    public float maxhp;
    // Start is called before the first frame update
    void Start()
    {
        maxhp = hp;
        numnodes = transform.childCount;
    }
     public void Break(float toremove) {
        hp -= toremove;

    }
    // Update is called once per frame
    void Update()
    {
        float hpepernode = maxhp / numnodes;
        float staplehp = hpepernode * transform.childCount;
        if (hp <= 0) {
            Destroy(gameObject);
        }
        if (hp < staplehp) {
            Destroy(transform.GetChild(0).gameObject);
            hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem("stone", 1);
        }


    }
}
