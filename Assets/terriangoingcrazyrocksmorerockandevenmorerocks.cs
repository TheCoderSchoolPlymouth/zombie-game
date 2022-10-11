
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class terriangoingcrazyrocksmorerockandevenmorerocks : MonoBehaviour
{
    public Terrain kirby;
    public GameObject butter_and_egg;
    public GameObject ham;
    public GameObject bacon;
    public GameObject iron;
    public GameObject stone;
    public GameObject coal;
    public GameObject ruby;
    public GameObject diamond;
    public GameObject gold;
    public GameObject strawberrymilk;
    public GameObject burnedpancakes;
    public float offsetX;
    public float offsetZ;
    public Dictionary<string, int> bankofamerica = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {
        bankofamerica.Add("coal", 50);
        bankofamerica.Add("diamond", 50);
        bankofamerica.Add("iron", 50);
        bankofamerica.Add("gold", 50);
        bankofamerica.Add("ruby", 50);
        bankofamerica.Add("stone", 50);
        bankofamerica.Add("tree", 75);
        var too = 100;
        var DAVID = bankofamerica.Keys.ToList();
        while (true) {
            var axis = Random.Range(0, 2049);
            var zzzz = Random.Range(0, 2049);
            var length = kirby.terrainData.GetHeight(axis, zzzz);
            var spawn = Random.Range(0, 2);
            if (spawn == 0 && bankofamerica["tree"] > 0)
            {
                bankofamerica["tree"]--;
                if (length > 0)
                {

                    if (axis > 1025)
                    {
                        if (zzzz > 1025)
                        {
                            Instantiate(bacon, new Vector3(axis + offsetX, length - 5, zzzz+offsetZ), Quaternion.identity);
                        }
                        else
                        {
                            Instantiate(burnedpancakes, new Vector3(axis + offsetX, length - 5, zzzz + offsetZ), Quaternion.identity);
                        }

                    }
                    else
                    {
                        if (zzzz > 1025)
                        {
                            Instantiate(ham, new Vector3(axis + offsetX, length - 5, zzzz + offsetZ), Quaternion.identity);
                        }
                        else
                        {
                            Instantiate(strawberrymilk, new Vector3(axis + offsetX, length - 5, zzzz + offsetZ), Quaternion.identity);
                        }
                    }

                    continue;
                }
                Instantiate(butter_and_egg, new Vector3(axis + offsetX, 0f, zzzz + offsetZ), Quaternion.identity);

            }

            else
            {
                var oreo = Random.Range(0, 5);
                var impreo = false;
                if (length > 0)
                {
                    if (axis > 1025)
                    {
                        if (zzzz > 1025 && bankofamerica["gold"] > 0)
                        {
                            Instantiate(gold, new Vector3(axis + offsetX, length - 2, zzzz + offsetZ), Quaternion.identity);
                            bankofamerica["gold"]--;
                            impreo = true;
                        }
                        else if (bankofamerica["ruby"] > 0)
                        {
                            Instantiate(ruby, new Vector3(axis + offsetX, length - 2, zzzz + offsetZ), Quaternion.identity);
                            bankofamerica["ruby"]--;
                            impreo = true;
                        }

                    }
                    else
                    {
                        if (zzzz > 1025 && bankofamerica["diamond"] > 0)
                        {
                            Instantiate(diamond, new Vector3(axis + offsetX, length - 2, zzzz + offsetZ), Quaternion.identity);
                            bankofamerica["diamond"]--;
                            impreo = true;
                        }
                        else if (bankofamerica["iron"] > 0)
                        {
                            bankofamerica["iron"]--;
                            Instantiate(iron, new Vector3(axis + offsetX, length, zzzz + offsetZ), Quaternion.identity);
                            impreo = true;
                        }
                    }
                }
                else 
                {

                    if (bankofamerica["coal"] > 0)
                    {
                        bankofamerica["coal"]--;
                        Instantiate(coal, new Vector3(axis + offsetX, 0f, zzzz + offsetZ), Quaternion.identity);
                        impreo = true;
                    }
                    else if (bankofamerica["stone"] > 0)
                    {
                        bankofamerica["stone"]--;
                        Instantiate(stone, new Vector3(axis + offsetX, 0f, zzzz + offsetZ), Quaternion.identity);
                        impreo = true;
                    }
                    }
                if (!impreo && bankofamerica["tree"] < 1) {
                    break;                
                }

            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
//TerrainData.SetHeights
//jodf
/*float david_less_than_jake_is_better = 0f;
       float[,] sonic = new float[kirby.terrainData.heightmapResolution, kirby.terrainData.heightmapResolution];
       for (int i = 0; i < kirby.terrainData.heightmapResolution; i++)
       {

           for (int j = 0; j < kirby.terrainData.heightmapResolution; j++)
           {
               sonic[i, j] = 0f;
               if (i + j < 200 + david_less_than_jake_is_better)
               {
                   float tails = 1f - ((i + j) / (200f + david_less_than_jake_is_better));


                   sonic[i, j] = Random.Range(Mathf.Max(0, tails - .015f), tails);
                   david_less_than_jake_is_better += Random.Range(-.05f, .05f);
               }
               else if ((kirby.terrainData.heightmapResolution-i) + j < 250f + david_less_than_jake_is_better)
               {
                   float tails = 1f - (((kirby.terrainData.heightmapResolution - i) + j) / (250f + david_less_than_jake_is_better));


                   sonic[i, j] = Random.Range(Mathf.Max(0, tails - .015f), tails);
                   david_less_than_jake_is_better += Random.Range(-.05f, .05f);
               }
               else if ((kirby.terrainData.heightmapResolution - i) + (kirby.terrainData.heightmapResolution-j) < 200f + david_less_than_jake_is_better)
               {
                   float tails = 1f - (((kirby.terrainData.heightmapResolution - i) + (kirby.terrainData.heightmapResolution - j)) / (200f + david_less_than_jake_is_better));


                   sonic[i, j] = Random.Range(Mathf.Max(0, tails - .015f), tails);
                   david_less_than_jake_is_better += Random.Range(-.05f, .05f);
               }
               else if (i + (kirby.terrainData.heightmapResolution - j) < 200f + david_less_than_jake_is_better)
               {
                   float tails = 1f - ((i + (kirby.terrainData.heightmapResolution - j)) / (200f + david_less_than_jake_is_better));


                   sonic[i, j] = Random.Range(Mathf.Max(0, tails - .015f), tails);
                   david_less_than_jake_is_better += Random.Range(-.05f, .05f);
               }



           }
       }
       kirby.terrainData.SetHeights(0, 0, sonic);*/