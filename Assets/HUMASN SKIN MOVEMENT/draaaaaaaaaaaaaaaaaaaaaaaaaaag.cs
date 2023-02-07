using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draaaaaaaaaaaaaaaaaaaaaaaaaaag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)&&crafing.can)
        {
            Vector3 mousePos = Input.mousePosition;
            Debug.LogWarning(mousePos.x);
            Debug.LogWarning(mousePos.y);
            foreach(var item in hotbartimeotpickanitemtoattackbreakanddrop.globalslots){
                collions(item.transform.position.x,item.transform.position.y,100,100,mousePos.x,mousePos.y);
            }
        } 
    }
    bool collions(float x1, float y1, float w1, float h1,float x2, float y2){
        if(x1 < x2 && x2 < x1 + w1 && y1 < y2 && y2 < y1 + h1){
            return true;
        
        }else{
            return false ;

        }
    }
}
