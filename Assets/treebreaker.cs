using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treebreaker : MonoBehaviour
{
    public float hp;
    public float maxhp;
    // Start is called before the first frame update
    void Start()
    {
        maxhp = hp;
    }

    public void Break(float toremove) {
        hp -= toremove;
    }
    // Update is called once per frame
    void Update()
    {
        if (hp <= 0) {
            var tag = gameObject.tag;
            var randon= Random.Range(4, 10);
            switch (tag)
            {
                case "oak":
                    hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem("oak", randon);
                    break;
                case "dark":
                    hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem("dark", randon);
                    break;
                case "bird":
                    hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem("bird", randon);
                    break;
                case "blood":
                    hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem("blood", randon);
                    break;
                case "deathlog":
                    hotbartimeotpickanitemtoattackbreakanddrop.inter.requestitem("deathlog", randon);
                    break;
            }
            Destroy(gameObject);
        }
    }
}
