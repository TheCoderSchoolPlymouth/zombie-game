using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class treemining : MonoBehaviour
{
    public GameObject axe;
    public int layermask;
    // Start is called before the first frame update
    void Start()
    {
        layermask = LayerMask.GetMask("tree");
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            axe = transform.GetChild(0).gameObject;
            if (axe.tag.Contains("axe"))
            {
                if (Input.GetMouseButton(0))
                {
                    RaycastHit hit;
                    Debug.Log(" hot ");
                    if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward), out hit, 15f))
                    {
                        Debug.Log(" did hot  ");
                        var dmg = 0;
                        switch(axe.tag){
                            case "goldaxe":
                                dmg = 2;
                                break;
                            case "diamondaxe":
                                dmg = 6;
                                break;
                            case "woodaxe":
                                dmg = 1;
                                break;
                            case "rubyaxe":
                                dmg = 5;
                                break;
                            case "stoneaxe":
                                dmg = 3;
                                break;
                            case "irinaxe":
                                dmg = 4;
                                break;

                        }
                        var script = hit.transform.gameObject.GetComponent<treebreaker>();
                        Debug.Log(script.hp);
                        script.Break(1);

                    }
                }


            }

        }
        catch (Exception e){

        }
    }
}
