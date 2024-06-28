using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungenGen : MonoBehaviour
{
    int DUNGEON_WIDTH = 20;
    int DUNGEON_HEIGHT = 20;

    // Start is called before the first frame update
    void Start()
    {
        bool[,] dungeonCollection = new bool[DUNGEON_WIDTH, DUNGEON_HEIGHT];
        for (int x = 0; x < DUNGEON_WIDTH; x++)
        {
            for (int y = 0; y < DUNGEON_HEIGHT; y++)
            {
                dungeonCollection[x, y] = true;
            }
        }
        //Debug.Log(dungeonCollection);
        Check(dungeonCollection);
    }


    private void Check(bool[,] checkCollection)
    {
        for(int x = 0; x < DUNGEON_WIDTH; x++){
            for(int y = 0; y < DUNGEON_WIDTH; y++){
                Debug.Log(checkCollection)[x][y]);
            }
            Debug.Log("/n");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
