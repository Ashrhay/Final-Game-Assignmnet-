using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlippingCard : MonoBehaviour
{
    [SerializeField]
    public float x, y, z;

    [SerializeField]
    public GameObject cardBack;

    [SerializeField]
    public bool cardBackIsActive;

    [SerializeField]
    public int timer;

    [SerializeField]
    public Button ShoreUp;

    public int flag = 2; // Initial value of the flag (2 for card front, 1 for card back)
    

    // Start is called before the first frame update
    void Start()
    {
        cardBackIsActive = false;
        UpdateCardState(); // Update the card state based on the initial flag value
    }

    public void StartFlip()
    {
        StartCoroutine(CalculateFlip());
    }

    public void Flip()
    {
        flag = (flag == 2) ? 1 : 2; // Toggle between 2 and 1
        UpdateCardState(); // Update the card state based on the new flag value
    }

    IEnumerator CalculateFlip()
    {
        for (int i = 0; i < 180; i++)
        {
            yield return new WaitForSeconds(0.01f);
            transform.Rotate(new Vector3(x, y, z));
            timer++;

            if (timer == 90 || timer == -90)
            {
                Flip();
            }
        }
        timer = 0;
    }

    private void UpdateCardState()
    {
        if (flag == 2)
        {
            cardBack.SetActive(false);
            cardBackIsActive = false;
        }
        else if (flag == 1)
        {
            cardBack.SetActive(true);
            cardBackIsActive = true;
            ShoreUp.interactable = false; 

        }

    }
    public void OnDisable()
    {
        if (flag == 1)
        {
            ShoreUp.interactable = false;
        }
    }
}
