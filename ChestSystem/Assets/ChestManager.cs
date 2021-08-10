using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestManager : MonoBehaviour
{
    GameObject[] chestList;
    public GameObject commonChest;
    public GameObject rareChest;
    public GameObject epicChest;
    public GameObject legendaryChest;

    void Start()
    {
        chestList = new GameObject[4];
    }
    public void SpawnChests()
    {
        for (int i = 0; i < 4; i++)
        {
            int value = Random.Range(1, 51);
            if (value >= 1 && value <= 35)
                chestList[i] = commonChest;
            else if (value >= 36 && value <= 45)
                chestList[i] = rareChest;
            else if (value >= 46 && value <= 49)
                chestList[i] = epicChest;
            else
                chestList[i] = legendaryChest;
        }
        Instantiate(chestList[0], new Vector3(-9, 0, -1), Quaternion.identity);
        Instantiate(chestList[1], new Vector3(-3, 0, -1), Quaternion.identity);
        Instantiate(chestList[2], new Vector3(3, 0, -1), Quaternion.identity);
        Instantiate(chestList[3], new Vector3(9, 0, -1), Quaternion.identity);
    }
}

