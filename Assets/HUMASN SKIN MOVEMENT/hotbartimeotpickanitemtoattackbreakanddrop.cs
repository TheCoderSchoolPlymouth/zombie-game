using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameitem {
    public string namesisdavid;
    public Sprite looksniceitem;
    public int stackofmyblock;
    public int maximunofmystack;
    public GameObject handitem;
}
public class hotbartimeotpickanitemtoattackbreakanddrop : MonoBehaviour
{
    public static gameitem[] hotburger = new gameitem[10];
    public GameObject inv;
    public List<gameitem> possiblieitems = new List<gameitem>();
    public Sprite[] gos;
    public GameObject[] handitems;
    public static GameObject[] globalslots;
    public GameObject[] slots;
    public int prevunosmass;
    public GameObject hand;
    public static hotbartimeotpickanitemtoattackbreakanddrop inter;
    // Start is called before the first frame update
    void Start()
    {
        globalslots=slots;
        possiblieitems.Add(new gameitem() { namesisdavid = "woodsword", maximunofmystack = 1, looksniceitem = gos[0],handitem=handitems[0] });
        possiblieitems.Add(new gameitem() { namesisdavid = "stonesword", maximunofmystack = 1, looksniceitem = gos[1], handitem = handitems[1] });
        possiblieitems.Add(new gameitem() { namesisdavid = "irinsword", maximunofmystack = 1, looksniceitem = gos[2],handitem = handitems[2] });
        possiblieitems.Add(new gameitem() { namesisdavid = "goldsword", maximunofmystack = 1, looksniceitem = gos[3],handitem = handitems[3] });
        possiblieitems.Add(new gameitem() { namesisdavid = "jacobsword", maximunofmystack = 1, looksniceitem = gos[4],handitem = handitems[4] });
        possiblieitems.Add(new gameitem() { namesisdavid = "diamondssword", maximunofmystack = 1, looksniceitem = gos[5],handitem = handitems[5] });
        possiblieitems.Add(new gameitem() { namesisdavid = "woodpic", maximunofmystack = 1, looksniceitem = gos[6],handitem = handitems[6] });
        possiblieitems.Add(new gameitem() { namesisdavid = "rockpic", maximunofmystack = 1, looksniceitem = gos[7],handitem = handitems[7] });
        possiblieitems.Add(new gameitem() { namesisdavid = "irinpic", maximunofmystack = 1, looksniceitem = gos[8],handitem = handitems[8] });
        possiblieitems.Add(new gameitem() { namesisdavid = "goldpic", maximunofmystack = 1, looksniceitem = gos[9],handitem = handitems[9] });
        possiblieitems.Add(new gameitem() { namesisdavid = "rubypic", maximunofmystack = 1, looksniceitem = gos[10],handitem = handitems[10] });
        possiblieitems.Add(new gameitem() { namesisdavid = "diamondayspic", maximunofmystack = 1, looksniceitem = gos[11],handitem = handitems[11] });
        possiblieitems.Add(new gameitem() { namesisdavid = "stone", maximunofmystack = 999, looksniceitem = gos[12],handitem = handitems[12] });
        possiblieitems.Add(new gameitem() { namesisdavid = "diamond", maximunofmystack = 999, looksniceitem = gos[13],handitem = handitems[13] });
        possiblieitems.Add(new gameitem() { namesisdavid = "jacob", maximunofmystack = 999, looksniceitem = gos[14],handitem = handitems[14] });
        possiblieitems.Add(new gameitem() { namesisdavid = "axe", maximunofmystack = 1, looksniceitem = gos[15],handitem = handitems[15] });
        possiblieitems.Add(new gameitem() { namesisdavid = "rockaxe", maximunofmystack = 1, looksniceitem = gos[16],handitem = handitems[16] });
        possiblieitems.Add(new gameitem() { namesisdavid = "irinaxe", maximunofmystack = 1, looksniceitem = gos[17],handitem = handitems[17] });
        possiblieitems.Add(new gameitem() { namesisdavid = "goldaxe", maximunofmystack = 1, looksniceitem = gos[18],handitem = handitems[18] });
        possiblieitems.Add(new gameitem() { namesisdavid = "jacobaxe", maximunofmystack = 1, looksniceitem = gos[19],handitem = handitems[19] });
        possiblieitems.Add(new gameitem() { namesisdavid = "shinyaxe", maximunofmystack = 1, looksniceitem = gos[20],handitem = handitems[20] });
        possiblieitems.Add(new gameitem() { namesisdavid = "coal", maximunofmystack = 999, looksniceitem = gos[21],handitem = handitems[21] });
        possiblieitems.Add(new gameitem() { namesisdavid = "irin", maximunofmystack = 999, looksniceitem = gos[22],handitem = handitems[22] });
        possiblieitems.Add(new gameitem() { namesisdavid = "gold", maximunofmystack = 999, looksniceitem = gos[23],handitem = handitems[23] });
        possiblieitems.Add(new gameitem() { namesisdavid = "oak", maximunofmystack = 999, looksniceitem = gos[24],handitem = handitems[24] });
        possiblieitems.Add(new gameitem() { namesisdavid = "dark", maximunofmystack = 999, looksniceitem = gos[25],handitem = handitems[25] });
        possiblieitems.Add(new gameitem() { namesisdavid = "bird", maximunofmystack = 999, looksniceitem = gos[26],handitem = handitems[26] });
        possiblieitems.Add(new gameitem() { namesisdavid = "blood", maximunofmystack = 999, looksniceitem = gos[27],handitem = handitems[27] });
        possiblieitems.Add(new gameitem() { namesisdavid = "deathlog", maximunofmystack = 999, looksniceitem = gos[28],handitem = handitems[28] });
        possiblieitems.Add(new gameitem() { namesisdavid = "goldcoin", maximunofmystack = 999, looksniceitem = gos[29],handitem = handitems[29] });
        requestitem("diamondssword", 1);
        requestitem("diamondayspic", 1);
        requestitem("shinyaxe", 1);
        requestitem("goldcoin",999);
        requestitem("stone",999);
        



        inter = this;


    }

    // Update is called once per frame
    void Update()
    {
        if (prevunosmass!=hotbarscoll.unomas)
        {
            prevunosmass = hotbarscoll.unomas;
            if(prevunosmass == 0)
            {
                prevunosmass = 1;
            }
            if (hand.transform.childCount > 0)
                Destroy(hand.transform.GetChild(0).gameObject);
            Debug.Log(prevunosmass);
            var res = Instantiate(hotburger[prevunosmass - 1].handitem,hand.transform);
            Debug.Log(res);
        } 
        if (Input.GetKeyDown("e"))
        {
            
            inv.SetActive(!inv.activeInHierarchy);
            if(inv.activeInHierarchy==true){
                Cursor.lockState = CursorLockMode.None;
            }
            else {
                Cursor.lockState = CursorLockMode.Locked;
            }


        }
        for (int i = 0; i < 10; i++) {
            if (hotburger[i] != null)
            {
                var image = slots[i].transform.GetChild(0);
                var text = slots[i].transform.GetChild(1);
                image.GetComponent<Image>().sprite = hotburger[i].looksniceitem;
               
                text.GetComponent<Text>().text = hotburger[i].stackofmyblock.ToString();
            }
            else {
                var text = slots[i].transform.GetChild(1);
                text.GetComponent<Text>().text = "0";
            }
             } 
        Debug.Log(hotburger[0]);
    }
    public void requestitem(string name,int num) {

        var res = possiblieitems.Find(k => k.namesisdavid == name);
        res.stackofmyblock = num;
        if (res != null) {
            addmeti(res);
        }
    }
    public void addmeti(gameitem fathertimeistheworst) {
        foreach (gameitem bob in hotburger) {
            if(bob != null)
            {
                if (bob.namesisdavid == fathertimeistheworst.namesisdavid)
                {

                    if (bob.stackofmyblock < bob.maximunofmystack)
                    {
                        bob.stackofmyblock += fathertimeistheworst.stackofmyblock;
                        return;
                    }
                }
            }
            

        }
        for (int i = 0;i<10;i+=1) {
            var bob = hotburger[i];
            if (bob == null)
            {
                bob = new gameitem() { namesisdavid = fathertimeistheworst.namesisdavid, stackofmyblock = fathertimeistheworst.stackofmyblock, maximunofmystack = fathertimeistheworst.maximunofmystack,looksniceitem=fathertimeistheworst.looksniceitem, handitem = fathertimeistheworst.handitem };
                hotburger[i] = bob;
                return;
            }
        }
    
    
    
    
    
    }
}


// make a work station to upgrade