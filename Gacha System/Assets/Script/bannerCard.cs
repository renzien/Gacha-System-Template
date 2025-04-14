using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bannerCard : MonoBehaviour
{
    public cardName card;
    [SerializeField] private Image img;
    [SerializeField] private TextMeshProUGUI name;
    
    void Start()
    {
        if (card != null)
        {
            img.sprite = card.image;
            name.text = card.name;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
