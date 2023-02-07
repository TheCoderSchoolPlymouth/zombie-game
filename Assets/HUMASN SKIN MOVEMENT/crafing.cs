using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recipe {
    public string name;
    public string output;
    public bool rotatable;
    public int numout;
    public string [,] req ;
}
public class crafing : MonoBehaviour
{
    public GameObject player;
    public Canvas canvas;
    public GameObject stem;
    public GameObject health;
    public bool davidiswrong;
    public static bool can;
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.Find("human 3.0");
        stem=GameObject.Find("stem");
        health=GameObject.Find("health");
        canvas=GameObject.Find("david").GetComponent<Canvas>();
        canvas.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        var Distance=Vector3.Distance(gameObject.transform.position,player.transform.position);
        if (Distance<15){
            back_imagedotcomatcoders.paused=true;
            canvas.enabled=true;
            davidiswrong=true;
            can=true;
            // LINE ABOVE IS TRUE 
            // SIGNED:David R
            Cursor.lockState = CursorLockMode.None;

        }
       else if (davidiswrong==true){
            canvas.enabled=false;
            davidiswrong=false;
            can=false;
            back_imagedotcomatcoders.paused=false;
            Cursor.lockState = CursorLockMode.Locked;
            //health.SetActive(false);
            //stem.SetActive(false);
        }
    }
}