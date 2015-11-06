using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class AmericanNewGameStrategy : INewGameStrategy
    {
        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {

            Deck d = new Deck();

            d.GetCard(a_player, true);
            d.GetCard(a_dealer, true);
            d.GetCard(a_player, true);
            d.GetCard(a_dealer, false);


            //DealNewCards(a_player, a_deck, true);

            //DealNewCards(a_dealer, a_deck, true);

            //DealNewCards(a_player, a_deck, true);

            //DealNewCards(a_dealer, a_deck, false);

            return true;
        }
    }
}
