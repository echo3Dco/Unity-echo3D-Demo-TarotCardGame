using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public bool hasBeenPlayed;
    public int handIndex;
    private GameManager gm;

    private void Start()
    {
        // References Game Manager script
        gm = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
          // Moves card up if card has been played
          if(hasBeenPlayed == false)
          {
                transform.position += Vector3.up * 2;
                // Changes bool if played
                hasBeenPlayed = true;
                // References GameManager script and flips bool afte rpassing through handIndex int;
                gm.availableCardSlots[handIndex] = true;
                // Moves card after used after 2 seconds
                Invoke("MoveToDiscardPile", 2f);
                print("Invoking");
          }
    }

    void MoveToDiscardPile()
    {
        // Adds card to discard pile and makes it inactive
        gm.discardPile.Add(this);
        gameObject.SetActive(false);
        print("Setting inactive");
    }
}
