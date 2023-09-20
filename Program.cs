
// Three Cubic Dice

Console.WriteLine("===== SIMPLE DICE GAME =====\nType 'Start' or 'S' to roll the dice: ");

string startGame = Console.ReadLine()!;

if (startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase))
{
    Random random = new();

    int diceOne = random.Next(1, 7);
    int diceTwo = random.Next(1, 7);
    int diceThree = random.Next(1, 7);
    int originalScore = diceOne + diceTwo + diceThree;
    const int DOUBLE_POINT = 2;
    const int TRIPPLE_POINT = 6;
    int totalPoint = 0;


    if (diceOne == diceTwo && diceTwo == diceThree )

    {
        totalPoint += TRIPPLE_POINT + originalScore;

        Console.WriteLine($"Dice One: {diceOne}\nDice two: {diceTwo}\nDice three {diceThree} \nYou rolled TRIPPLE!\nYou got a total point of {totalPoint}");
    }

    else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)

    {
        totalPoint += DOUBLE_POINT + originalScore;

        Console.WriteLine($"Dice One: {diceOne}\nDice two: {diceTwo} \nDice three {diceThree} \nYou rolled DOUBLE!\nYou got a total point of {totalPoint}");
    }

    else 
    {
        totalPoint += originalScore;
        Console.WriteLine($"Dice One: {diceOne}\nDice two: {diceTwo} \nDice three {diceThree}\nYou got a total point of {originalScore}");
    }

        if (totalPoint <= 9)
    {
        Console.WriteLine("Sorry no gift, Try again!");
    }

    if (totalPoint >= 10 && totalPoint <= 13)
    {
        Console.WriteLine("you won a wonderful BALLON");
    }

    if (totalPoint >= 14 && totalPoint <= 16)
    {
        Console.WriteLine("you won an Exercise Book from his Excellency Bola Ahmed Tinubu GCFR");
    }
    
        if (totalPoint == 17)
    {
        Console.WriteLine("you won 5000mAH ORAIMO POWERBANK");
    }
    
        if (totalPoint == 21)
    {
        Console.WriteLine("yo! its a lucky number, you won a brand new Samsung A21");
    }

        if (totalPoint >= 18 && totalPoint <= 20)
    {

        Console.WriteLine("you won a free ticket to Silver Bird Gallery");
    
    }
    
            if (totalPoint >=22 && totalPoint <=24)
    {

        Console.WriteLine("you won a Ballon\n5000mAh oraimo power bank\nSamsung A21\nTicket to SiverBird Gallery");

    }
    
    

}