# Go Fish

#### By _Seung Lee, Alex Shevlin_

#### _A simple application to play Go Fish._

## Technologies Used

* _C#_
* _MSTest_
* _Razor_
* _HTML_
* _CSS_
* _Bootstrap_

## Description

The application allows 2 users to play Go Fish. Players recieve a hand of 5 cards and a deck is placed face down for players to draw from. Players should try to pair cards of the same suit and number by asking the other player. If player 2 does not have a match for player 1, player 1 will draw a card from the deck and their turn will end. If player 2 does have a match they give the card to player 1 and player one gets to go again. The winner is the player with the most pairs.

## Setup/Installation Requirements

1. Open Git Bash if on Windows and terminal if on Mac
2. Run the command

    ``git clone https://github.com/leark/GoFish.Solution.git``

3. Run the command

    ``cd GoFish.Solution``

* You should now have a folder `GoFish.Solution` with a following structure.
    <pre>GoFish.Solution
    ├── GoFish
    └── GoFish.Tests</pre>

<details>
<summary><strong>To Run</strong></summary>
Navigate to  
   <pre>GoFish.Solution
   ├── <strong>GoFish</strong>
   └── GoFish.Tests</pre>

Run ```$ dotnet run``` in the console
</details>

<details>
<summary><strong>For Testing</strong></summary>
Navigate to  
    <pre>GoFish.Solution
    ├── GoFish
    └── <strong>GoFish.Tests</strong></pre>

Run ```$ dotnet test``` in the console

</details>
<br>

This program was built using _`Microsoft .NET SDK 5.0.401`_, and may not be compatible with other versions. Your milage may vary.

## Known Bugs

* _Any known issues_
* _should go here_

## License

[GNU](/LICENSE)

Copyright (c) 2022 Seung Lee, Alex Shevlin