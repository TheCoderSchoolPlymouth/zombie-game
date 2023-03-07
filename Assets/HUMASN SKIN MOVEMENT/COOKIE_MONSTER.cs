using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class COOKIE_MONSTER : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public float slow;
    public bool yeeet;
    public Slider merunningoround;
    public float nomoretimeleft;
    // Update is called once per frame
    public void OnCollisionEnter(Collision yeeeeeeeeet)
    {
        yeeet = true;
        Debug.Log("space");
    }
    void Update()
    {
        if (!back_imagedotcomatcoders.paused) {
            float why = Input.GetAxis("Mouse X") * 4f;
            float axis = Input.GetAxis("Mouse Y") * 4f;
            bool wheat = false; 
            //Debug.Log(axis);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + why, 0);
            Camera.main.transform.eulerAngles = new Vector3(Camera.main.transform.eulerAngles.x - axis, transform.eulerAngles.y - 90, 0);
            float x = (float)Math.Cos(transform.eulerAngles.y * Math.PI / 180);
            float y = (float)Math.Sin(transform.eulerAngles.y * Math.PI / 180);
            float x2 = (float)Math.Cos((transform.eulerAngles.y + 90) * Math.PI / 180);
            float y2 = (float)Math.Sin((transform.eulerAngles.y + 90) * Math.PI / 180);
            Vector3 f = new Vector3(0f, 0f, 0f);
            if (Input.GetKey("w"))
            {
                f += new Vector3(x * -2000, 0, y * 2000);
                //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(x * -2000, 0, y * 2000));
                wheat = true;
                //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(gameObject.GetComponent<Rigidbody>().velocity.x, gameObject.GetComponent<Rigidbody>().velocity.y - 0f, gameObject.GetComponent<Rigidbody>().velocity.z);
            }
            if (Input.GetKey("s"))
            {
                f += new Vector3(x * 2000, 0, y * -2000);
                //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(x * 2000, 0, y * -2000));
                wheat = true;
                //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(gameObject.GetComponent<Rigidbody>().velocity.x, gameObject.GetComponent<Rigidbody>().velocity.y - 0f, gameObject.GetComponent<Rigidbody>().velocity.z);
            }
            if (Input.GetKey("a"))
            {
                f += new Vector3(x2 * 2000, 0, y2 * -2000);
               // gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(x2 * 2000, 0, y2 * -2000));
                wheat = true;
                //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(gameObject.GetComponent<Rigidbody>().velocity.x, gameObject.GetComponent<Rigidbody>().velocity.y - 0f, gameObject.GetComponent<Rigidbody>().velocity.z);
            }
            if (Input.GetKey("d"))
            {
                f += new Vector3(x2 * -2000, 0, y2 * 2000);
                //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(x2 * -2000, 0, y2 * 2000));
                wheat = true;
                //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(gameObject.GetComponent<Rigidbody>().velocity.x, gameObject.GetComponent<Rigidbody>().velocity.y - 0f, gameObject.GetComponent<Rigidbody>().velocity.z);
            }
            if (Input.GetKey(KeyCode.Space) && yeeet)
            {
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100000, 0));
                yeeet = false;
                Debug.Log("space");
            }
            if (wheat && Input.GetKey(KeyCode.LeftShift) && nomoretimeleft > 0)
            {
                f *= 22;
                nomoretimeleft -= Time.deltaTime;
                merunningoround.value = nomoretimeleft;
            }
            else {
                nomoretimeleft += Time.deltaTime/2;
                if (nomoretimeleft > 10) {
                    nomoretimeleft = 10;
                }
                merunningoround.value = nomoretimeleft;
            }
            gameObject.GetComponent<Rigidbody>().AddForce(f);
            if (Input.GetMouseButton(1)){
                Instantiate(hotbartimeotpickanitemtoattackbreakanddrop.inter.handitems[hotbartimeotpickanitemtoattackbreakanddrop.inter.prevunosmass]);
            }
        }
       
    }
}


// 