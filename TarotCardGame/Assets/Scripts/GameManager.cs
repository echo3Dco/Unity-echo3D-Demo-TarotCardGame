using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Card> cardDeck = new List<Card>();
    public List<Card> discardPile = new List<Card>();
    public Transform[] cardSlots;
    public bool[] availableCardSlots;

    public Text deckSizeText;
    public Text discardPileText;

    public void DrawCard()
    {
        // If there are cards left in the pile, pick randomly
        if(cardDeck.Count >= 1)
        {
            // Assign random object from Card list within range
            Card randCard = cardDeck[Random.Range(0, cardDeck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                // If cards we are seeking are available, we will pull random card
                if(availableCardSlots[i] == true)
                {

                    // print("Available slots is true");
                    randCard.gameObject.SetActive(true);

                    // References Card script 'handIndex'
                    randCard.handIndex = i;

                    // Place card in position of that available slot
                    randCard.transform.position = cardSlots[i].position;
                    // If we draw a card in the discard pile, we have to reset it to false in order to reuse
                    randCard.hasBeenPlayed = false;

                    //Makes slot unavailable w/switching bool
                    availableCardSlots[i] = false;

                    cardDeck.Remove(randCard);
                    //Stops function after removing random card
                    return;
                }
            }
        }
    }

    public void Shuffle()
    {
        if(discardPile.Count >= 1)
        {
            foreach (Card card in discardPile)
            {
                cardDeck.Add(card);
            }
            discardPile.Clear();
        }
    }

    void Update()
    {
        deckSizeText.text = cardDeck.Count.ToString();
        discardPileText.text = discardPile.Count.ToString();
    }
}
