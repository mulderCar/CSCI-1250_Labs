import random

def create_deck():
    # Create a standard deck of playing cards

    # List of face values on playing cards (numbers and face cards)
    face = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A']
    
    # List of card suits
    suits = ['Hearts', 'Diamonds', 'Clubs', 'Spades']
    
    # Generate all possible cards using list comprehension
    deck = [f + ' of ' + suit for suit in suits for f in face]
    
    # Return the deck of cards and the face values
    return deck, face

def shuffle_deck(deck):
    # Shuffle the deck randomly in-place using the Fisher-Yates algorithm
    random.shuffle(deck)

def deal_cards(deck, num_players, cards_per_player):
    # Check if there are enough cards in the deck for the players and cards per player

    if num_players * cards_per_player > len(deck):
        # Raise an error if there aren't enough cards
        raise ValueError("Not enough cards in the deck for the specified number of players and cards per player.")

    # Shuffle the deck before dealing to ensure randomness
    random.shuffle(deck)

    # Deal cards to players
    dealt_cards = [deck[i:i + cards_per_player] for i in range(0, num_players * cards_per_player, cards_per_player)]

    # Remove dealt cards from the deck
    for cards in dealt_cards:
        for card in cards:
            deck.remove(card)

    return dealt_cards

def print_players(players):
    # Print the cards held by each player

    # Iterate through players and their cards
    for i, player in enumerate(players):
        print(f"Player {i + 1}'s cards:", player)

def main():
    # Create an unshuffled deck and obtain the face values
    unshuffledDeck, face = create_deck()
    
    # Shuffle the deck to randomize the order of cards
    shuffle_deck(unshuffledDeck)

    # Print the shuffled deck
    print("Shuffled Deck:")
    for card in unshuffledDeck:
        print(card)

    # Get user input for the number of players and cards each player should have
    numOfPlayers = int(input("\nHow many players are there? "))
    numOfCards = int(input("How many cards should each player have? "))

    # Deal cards to players
    players = deal_cards(unshuffledDeck, numOfPlayers, numOfCards)

    # Sort the cards for each player by suit and then by number
    for player in players:
        player.sort(key=lambda x: (x.split()[-1], face.index(x.split()[0])))

    # Print the cards each player has
    print_players(players)

    # Display how many cards are left in the deck
    print(f"\nRemaining cards in the deck: {len(unshuffledDeck)}")

if __name__ == "__main__":
    main()
