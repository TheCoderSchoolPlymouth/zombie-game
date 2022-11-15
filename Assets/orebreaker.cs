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
            var tag = transform.GetChild(0).gameObject.tag;
            Destroy(transform.GetChild(0).gameObject);

            switch (tag) {
                case "stoen":
                    hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem("stone", 1);
                    break;
                case "coal":
                    hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem("coal", 1);
                    break;
                case "dia":
                    hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem("diamond", 1);
                    break;
                case "gold":
                    hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem("gold", 1);
                    break;
                case "irin":
                    hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem("irin", 1);
                    break;
                case "ruby":
                    hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem("jacob", 1);
                    break;



            }
        }


    }
}
