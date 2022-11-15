using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class deathtothehead : MonoBehaviour
{
    
    public GameObject knifee;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            knifee = transform.GetChild(0).gameObject;
                    if (knifee.tag.Contains("kknife")) {
                        knifee.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, gameObject.transform.position.z);
                        if (Input.GetKeyDown(KeyCode.Q))
                        {
                            var ponter = Camera.main.transform.localEulerAngles.x;
                            if (ponter > 180)
                            {
                                ponter = 360 - ponter;

                            }
                            else
                            {
                                ponter = -ponter;
                            }
                            var rotation = transform.parent.eulerAngles.y;
                            var x = Mathf.Cos(rotation / 180 * Mathf.PI);
                            var y = Mathf.Sin(rotation / 180 * Mathf.PI);
                            var newKnife = Instantiate(knifee, knifee.transform.position + new Vector3(x * -2f, 0f, y * 2f), Quaternion.Euler(0, transform.parent.eulerAngles.y, 90 + Camera.main.transform.eulerAngles.x));
                            newKnife.AddComponent<Rigidbody>();
                            newKnife.AddComponent<BoxCollider>();
                            newKnife.GetComponent<Rigidbody>().useGravity = true;
                            newKnife.AddComponent<byebyeknife>();

                            Debug.Log(ponter * 10f);
                            newKnife.GetComponent<Rigidbody>().AddForce(new Vector3(-2000f * x, 700f + (ponter * 15f), 2000f * y));
                        }
                    }
        }catch(Exception e)
        {

        }
        

    }
}
