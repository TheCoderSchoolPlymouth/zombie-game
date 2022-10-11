
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombiefollowingyouinyoursleepandkilliingyou : MonoBehaviour
{
    public GameObject rlm;
    public Rigidbody us;
    public Slider eb4;
    public int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        eb4= GameObject.Find("health").GetComponent<Slider>();

        us = gameObject.GetComponent<Rigidbody>(); 

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 I = transform.position;
        Vector3 Z = rlm.transform.position;
        float sfd = Vector3.Distance(I, Z);
        if (sfd < 50)
        {
            transform.LookAt(rlm.transform);
            transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y-90, 0f);
            us.AddForce(transform.right * 100f) ;
        }
    }
    public void OnCollisionEnter(Collision eb3) {
        if (eb3.gameObject.tag == "Player")
        {
            datascriptdotcomma.health -= 5;
            eb4.value = datascriptdotcomma.health;

        }
        else if (eb3.gameObject.tag == "kknife") {
            health -= 15;
            if (health <= 0) {
                Destroy(eb3.gameObject);
                Destroy(gameObject);
            }
        }
    }
}