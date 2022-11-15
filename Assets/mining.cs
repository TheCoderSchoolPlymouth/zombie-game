using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class mining : MonoBehaviour
{
    public GameObject picaxe;
    public int layermask;
    // Start is called before the first frame update
    void Start()
    {
        layermask = LayerMask.GetMask("ore");
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            picaxe = transform.GetChild(0).gameObject;
            if (picaxe.tag.Contains("pic")) {
                if (Input.GetMouseButton(0)) {
                    RaycastHit hit;
                    Debug.Log(" hit ");
                    if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward), out hit, 15f)) {
                        Debug.Log(" did hit ");
                        var damage = 0;
                        switch(picaxe.tag){
                            case "goldpic":
                                damage = 2;
                                break;
                            case "diamondpic":
                                damage = 6;
                                break;
                            case "woodpic":
                                damage = 1;
                                break;
                            case "rubypic":
                                damage = 5;
                                break;
                            case "stonepic":
                                damage = 3;
                                break;
                            case "irinpic":
                                damage = 4;
                                break;

                        }
                        var script = hit.transform.gameObject.GetComponent<orebreaker>();
                        Debug.Log(script.hp);
                        script.Break(damage);

                    }
                }
            
            
            }

        }
        catch (Exception e) { 
        
        }
    }
}

//