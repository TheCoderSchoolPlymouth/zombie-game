using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class back_imagedotcomatcoders : MonoBehaviour
{
    public Image start;
    public Sprite bot;
    public Sprite bot2;
    public GameObject Puase;
    public static bool paused;
    public void UNplaused_play() {
        paused = (false);
        start.sprite = bot;
        Puase.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.BackQuote)){
            start.sprite = bot2;
            Puase.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            paused = (true);
        }
    }
}




// CURRECY
//building
//50% to drop gem or coin
//zombies Follow you anywhere
//
//
//
//
//
//