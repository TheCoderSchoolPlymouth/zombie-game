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
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.Find("human 3.0");
        canvas=GameObject.Find("david").GetComponent<Canvas>();
        canvas.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        var Distance=Vector3.Distance(gameObject.transform.position,player.transform.position);
        if (Distance<3550){
            canvas.enabled=true;

        }
    }
}
