using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terriangoingcrazyrocksmorerockandevenmorerocks : MonoBehaviour
{
    public Terrain kirby;

    // Start is called before the first frame update
    void Start()
    {
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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
//TerrainData.SetHeights
//jodf