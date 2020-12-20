# The Royal Game of Ur
 A 3D Board Game Created on Unity3D

# Beta v0.1 Created By 
 Harsh Meena and Slok Aks for Hackademic 2020. Idea influenced by quill18's "Making a Board Game!" series on YouTube: https://www.youtube.com/watch?v=LHQ4ynQhPLY

# The Royal Game of Ur is one of the oldest games of all time, possibly THE oldest board game of all time. It is beleived to have originated in Ancient Mesopotamia.

# The rules of our version are simple:

 - There are two players with 6 pieces each. They take turns flipping 3 coins at a time, and moving any one of their pieces by a few spaces, equal to the number of heads rolled.
 - Gold always flips first and is "Player One" and brown flips second and is "Player Two".
 - No two pieces can lie on the same square, however if a piece lands on a square holding an enemy piece, the enemy piece is considered to be "checked" and must go back to the starting pile.
 - There is a Silver coloured "rest" square. If a piece lands on this square, it cannot be "checked" by an enemy piece as long as it stays on that square. All other squares have an orange colour
 - Once a piece completes the journey across the board successfully, a score is registered for the player owning that piece, and it is taken off the board.

# Discovered Bugs:

 - When a piece re-enters the board at a later stage after being "checked" earlier, the animation makes it seem as if, it re-enters the board from the square where it was "checked". Gameplay, however, remains unaffected.
 - The animations make it seem as if pieces are clipping through objects some times, and especially through each other.
 - When zero is rolled, the animation doesn't wait long enough and immediately moves to the next turn.

# Features to be added in future versions:

 - An AI opponent for single player functionality
 - A short story mode
 - More animations, for coin flip and other such events
 - BGM and SFX
 - Updated UI along with High-Res textures for all models