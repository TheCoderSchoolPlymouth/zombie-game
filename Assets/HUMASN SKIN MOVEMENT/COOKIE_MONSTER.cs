using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class COOKIE_MONSTER : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public float slow;
    public bool yeeet;
    // Update is called once per frame
    public void OnCollisionEnter(Collision yeeeeeeeeet)
    {
        yeeet = true;
    }
    void Update()
    {
        float why = Input.GetAxis("Mouse X") * 4f;
        float axis = Input.GetAxis("Mouse Y") * 4f;
        Debug.Log(axis);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + why, 0);
        Camera.main.transform.eulerAngles = new Vector3(Camera.main.transform.eulerAngles.x - axis, transform.eulerAngles.y - 90, 0);
        float x = (float)Math.Cos(transform.eulerAngles.y * Math.PI / 180);
        float y = (float)Math.Sin(transform.eulerAngles.y * Math.PI / 180); 
        float x2 = (float)Math.Cos((transform.eulerAngles.y + 90) * Math.PI / 180);
        float y2 = (float)Math.Sin((transform.eulerAngles.y+90) * Math.PI / 180);
       
        if (Input.GetKey("w"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(x * -20, 0, y * 20));
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(gameObject.GetComponent<Rigidbody>().velocity.x, gameObject.GetComponent<Rigidbody>().velocity.y-0f, gameObject.GetComponent<Rigidbody>().velocity.z);
        }
        if (Input.GetKey("s")) {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(x*20, 0,y*-20));
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(gameObject.GetComponent<Rigidbody>().velocity.x, gameObject.GetComponent<Rigidbody>().velocity.y-0f, gameObject.GetComponent<Rigidbody>().velocity.z);
        }
        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(x2*20, 0,y2*-20 ));
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(gameObject.GetComponent<Rigidbody>().velocity.x, gameObject.GetComponent<Rigidbody>().velocity.y-0f, gameObject.GetComponent<Rigidbody>().velocity.z);
        }
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(x2*-20, 0, y2*20));
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(gameObject.GetComponent<Rigidbody>().velocity.x, gameObject.GetComponent<Rigidbody>().velocity.y-0f, gameObject.GetComponent<Rigidbody>().velocity.z);
        }
        if (Input.GetKey(KeyCode.Space)&&yeeet)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,550, 0));
            yeeet = false;
        }
    }
}


// 