using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tester : MonoBehaviour
{
    public List<Card> thisCard = new List<Card>();
    public int thisId;

    public int id;
    public string cardName;

    public Text nameText;

    public Image cardImage;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("i got the cards from the list");
        thisCard.Add(CardDatabase.Cards[thisId]);

        // Get the Image component from the GameObject
        cardImage = GetComponentInChildren<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (thisCard.Count > 0)
        {
            id = thisCard[0].id;
            cardName = thisCard[0].cardName;

            nameText.text = cardName;

            if (cardImage != null)
            {
                cardImage.sprite = thisCard[0].thisImage;
            }
        }
    }
}
