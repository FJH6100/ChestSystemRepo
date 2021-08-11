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

    public int rewardCoins()
    {
        return Random.Range(minCoins, maxCoins + 1);
    }
    public int rewardGems()
    {
        return Random.Range(minGems, maxGems + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
