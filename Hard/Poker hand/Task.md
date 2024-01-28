<h1 align="center"><img src="https://github.com/ntkhang03/poker-cards/blob/main/cards/10_of_clubs.png" height="64"/><img src="https://github.com/ntkhang03/poker-cards/blob/main/cards/jack_of_clubs.png" height="64"/><img src="https://github.com/ntkhang03/poker-cards/blob/main/cards/queen_of_diamonds.png" height="64"/><img src="https://github.com/ntkhang03/poker-cards/blob/main/cards/king_of_hearts.png" height="64"/><img src="https://github.com/ntkhang03/poker-cards/blob/main/cards/ace_of_spades.png" height="64"/></h1>
<h1 align = "center"> Poker hand </h1>
You are playing poker with your friends and need to evaluate your hand. A hand consists of five cards and is ranked, from lowest to highest, in the following way:

// High Card: Highest value card (from 2 to Ace).

// One Pair: Two cards of the same value.

// Two Pairs: Two different pairs.

// Three of a Kind: Three cards of the same value.

// Straight: All cards are consecutive values.

// Flush: All cards of the same suit.

// Full House: Three of a kind and a pair.

// Four of a Kind: Four cards of the same value.

// Straight Flush: All cards are consecutive values of same suit.

// Royal Flush: 10, Jack, Queen, King, Ace, in same suit.

<h1 align = "left"> TasK </h1>
Output the rank of the give poker hand.
<h1> Input FormaT </h1>
A string, representing five cards, each indicating the value and suite of the card, separated by spaces. Possible card values are: 2 3 4 5 6 7 8 9 10 J Q K A Suites: H (Hearts), D (Diamonds), C (Clubs), S (Spades) For example, JD indicates Jack of Diamonds.
<h1> Output FormaT</h1>
A string, indicating the rank of the hand (in the format of the above description).
<h1> Sample InpuT</h1>
<b>JS 2H JC AC 2D </b>
<h1>Sample OutpuT</h1>
Two Pairs
<h1>ExplanatioN</h1>
The hand includes two Jacks and two 2s, resulting in Two Pairs.
