using UnityEngine;

[System.Serializable]
public class rateGacha
{
    public string rarity;
    [Range(1, 100)]

    public int rate;
    public cardName[] reward;
}
