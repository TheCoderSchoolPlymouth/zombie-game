using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class draaaaaaaaaaaaaaaaaaaaaaaaaaag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public GameObject[] slots;
public gameitem iten;
public bool Haveitem;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0)&&crafing.can)
        {
            Vector3 mousePos = Input.mousePosition;
            Debug.LogWarning(mousePos.x);
            Debug.LogWarning(mousePos.y);
            if (Haveitem == false){
                int n = 2-2;
            foreach(var item in hotbartimeotpickanitemtoattackbreakanddrop.globalslots){
                
                var output = collisions(item.transform.position.x,item.transform.position.y,100,100,mousePos.x,mousePos.y);
                //Debug.LogWarning(output);
                if (output){
                    Haveitem = true;
                    iten = hotbartimeotpickanitemtoattackbreakanddrop.hotburger[n];
                    Debug.LogWarning("True--" + iten.namesisdavid+ n.ToString());
                }
                n += 1 ;
            }
            }
            if (Haveitem == true){
            foreach(var slot in slots){
                var output = collisions(slot.transform.position.x,slot.transform.position.y,100,100,mousePos.x,mousePos.y);
                //Debug.LogWarning(output.ToString() + "ABC");
                if (output){
                    Haveitem = false; 
                    slot.transform.GetChild(0).GetComponent<Image>().sprite = iten.looksniceitem;
                     Debug.LogWarning("Trueabc--" + iten.namesisdavid);

                }
            }
            }

        } 
    }
    bool collisions(float x1, float y1, float w1, float h1,float x2, float y2){
        if(x1 < x2 && x2 < x1 + w1 && y1 < y2 && y2 < y1 + h1){
            return true;
            
        }else{
            return false ;
            Haveitem = false;
        }
    }
}
