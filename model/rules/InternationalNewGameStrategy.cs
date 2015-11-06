﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class InternationalNewGameStrategy : INewGameStrategy
    {

        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            a_dealer.DealCard(a_player, true);
            a_dealer.DealCard(a_dealer, true);
            a_dealer.DealCard(a_player, true);


            //DealNewCards(a_player, a_deck, true);

            //DealNewCards(a_dealer, a_deck, true);

            //DealNewCards(a_player, a_deck, true);


            return true;
        }
    }
}
