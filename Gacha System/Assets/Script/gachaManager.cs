using UnityEngine;
using System;

public class gachaManager : MonoBehaviour
{
    [SerializeField] private rateGacha[] gacha;
    [SerializeField] private Transform parent, pos;
    [SerializeField] private GameObject GOCard;

    GameObject characterCard;
    bannerCard card;

    public void Gacha()
    {
        if (characterCard == null)
        {
            characterCard = Instantiate(GOCard, pos.position, Quaternion.identity) as GameObject;
            characterCard.transform.SetParent(parent);
            characterCard.transform.localScale = new Vector3(1, 1, 1);
            card = characterCard.GetComponent<bannerCard>();

            int random = UnityEngine.Random.Range(1, 101);
            for (int i = 0; i < gacha.Length; i++)
            {
                if (random <= gacha[i].rate)
                {
                    card.card = Prize(gacha[i].rarity);
                    return;
                }
            }
        }
    }

    // Metode untuk mendapatkan hadiah / gacha
    cardName Prize(string rarity)
    {
        rateGacha rg = Array.Find(gacha, rt => rt.rarity == rarity); //Lamda expression untuk mencari rateGacha yang sesuai dengan rarity
        cardName[] reward = rg.reward;

        int random = UnityEngine.Random.Range(0, reward.Length); //Mengambil random reward dari array reward
        return reward[random];
    } 
}
