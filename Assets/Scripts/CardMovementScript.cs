using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMovementScript : MonoBehaviour
{
    //Keeping track if the card has been played previously. 
    public bool hasBeenPlayed;

    public int handIndex;

    private GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
       //Checking first to see if the card hasn not been played yet.
       if(hasBeenPlayed == false)
        {
            transform.position += Vector3.up * 5;
            hasBeenPlayed = true;
            gm.availableCardSlots[handIndex] = true;

            //After the card has been played the card needs to move to the discard pile; 
            Invoke("MoveToDiscardPile", 2f) ; 
        }
    }

    void MoveToDiscardPile()
    {
        gm.discardPile.Add(this);

        //Deactivating the card after it is transferred into the discard pile. 
        gameObject.SetActive(false); 
    }
}
