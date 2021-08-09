using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public ChestData chestData;
    int minCoins;
    int maxCoins;
    int minGems;
    int maxGems;
    // Start is called before the first frame update
    void Start()
    {
        minCoins = chestData.minCoins;
        maxCoins = chestData.maxCoins;
        minGems = chestData.minGems;
        maxGems = chestData.maxGems;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
