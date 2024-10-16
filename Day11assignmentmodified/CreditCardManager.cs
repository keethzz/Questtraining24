using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11assignmentmodified
{
    internal class CreditCardManager
    {
        private List<CreditCard> creditCards = new List<CreditCard>();

        /// <summary>
        /// This method adds a credit card. If a credit card already exists, it will not be added.
        /// </summary>
        /// <param name="card">An instance of <see cref="CreditCard"/>>.</param>
        public void Add(CreditCard card)
        {
            // Check if the same card exists.
            foreach (var item in creditCards)
            {
                if (item.CardNumber == card.CardNumber)
                {
                    Console.WriteLine("Card already exists");
                    return;
                }
            }

            creditCards.Add(card);
            Console.WriteLine("Added successfully");
        }

        /// <summary>
        /// This method searches for a credit card based on the card number.
        /// </summary>
        /// <param name="cardNumber">The credit card number.</param>
        public void Search(string cardNumber)
        {
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    Console.WriteLine(card);
                }
            }
        }
        public void Update(string cardNumber, string cardholderName, string expiry, int securityCode)
        {
            // Retrieve the card by card number
            var card = GetCardByNumber(cardNumber);

            // Check if the card exists
            if (card == null)
            {
                Console.WriteLine("Card not found.");
                return;
            }

            // Update card details
            card.CardHolderName = cardholderName;
            card.Expiry = expiry;
            card.SecurityCode = securityCode;

            // Confirmation message
            Console.WriteLine("Updated successfully.");
        }


        public void Delete(string cardNumber)
        {
            // Retrieve the card by card number
            var card = GetCardByNumber(cardNumber);

            // Check if the card exists
            if (card == null)
            {
                Console.WriteLine("Card not found.");
                return;
            }

            // Remove the card from the list
            creditCards.Remove(card);

            // Confirmation message
            Console.WriteLine("Card deleted successfully.");
        }
        private CreditCard GetCardByNumber(string cardNumber)
        {
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    return card;
                }
            }
            return null;

        }

    }
}
