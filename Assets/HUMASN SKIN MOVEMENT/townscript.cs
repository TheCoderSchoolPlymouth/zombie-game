using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class townscript : MonoBehaviour
{
    public Terrain teria;
    public GameObject[] minitown;
    public int numhouse;
    public int numtowns;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<numtowns;i+=1){
            var axis = Random.Range(0,6174);
            var zzzz = Random.Range(0,6174);
            for (int j=0;j<numhouse;j+=1){
            var house = Random.Range(0,minitown.Length);
            var offsetX=Random.Range(40,60);
            var offsetZ=Random.Range(40,60);
            if (Random.Range(0,2)==1){
                offsetX *= -1;
            }
            if (Random.Range(0,2)==1){
                offsetZ *= -1;
            }
            var length = teria.terrainData.GetHeight(axis + offsetX, zzzz + offsetZ);
            Instantiate(minitown[house],new Vector3(axis + offsetX,length,zzzz + offsetZ),Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
