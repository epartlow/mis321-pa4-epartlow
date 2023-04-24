using pa4_epartlow;
using System;
using pa4_epartlow.Interfaces;
BeginGame();

static void BeginGame()
{
    int userSelection = Menu.Start();
    if(userSelection == 1)
    {
        Player1Menu();
    }
    else if (userSelection == 2)
    {
        Menu.ExitSystem();
    }
    else
    {
        Menu.InvalidSelection();
        BeginGame();
    }
}
static void Player1Menu()
{
    Character player1 = new Character();
    string playerOneName = Menu.PlayerOne(); //asks user for name
    int userSelection = Menu.SelectCharacter1(playerOneName); //asks user to select character
    player1.playerName = playerOneName;
    if(userSelection == 1)
    {
        System.Console.WriteLine($"{playerOneName}, you will play as Jack Sparrow");
        player1 = new JackSparrow(){playerName = player1.playerName, maxPower = player1.GetMaxPower(), health = 100, attackStrength = player1.GetAttackStrength(), defensivePower = player1.GetDefensivePower()};
        Player2Menu(player1);
    }
    else if(userSelection == 2)
    {
        System.Console.WriteLine($"{playerOneName}, you will play as Jack Davy Jones");
        player1 = new DavyJones(){playerName = player1.playerName, maxPower = player1.GetMaxPower(), health = 100, attackStrength = player1.GetAttackStrength(), defensivePower = player1.GetDefensivePower()};
        Player2Menu(player1);
    }
    else if(userSelection == 3)
    {
        System.Console.WriteLine($"{playerOneName}, you will play as Will Turner");
        player1 = new WillTurner(){playerName = player1.playerName, maxPower = player1.GetMaxPower(), health = 100, attackStrength = player1.GetAttackStrength(), defensivePower = player1.GetDefensivePower()};
        Player2Menu(player1);
    }
    else if(userSelection == 4)
    {
        System.Console.WriteLine($"{playerOneName}, you will play as Elizabeth Swann");
        player1 = new ElizabethSwann(){playerName = player1.playerName, maxPower = player1.GetMaxPower(), health = 100, attackStrength = player1.GetAttackStrength(), defensivePower = player1.GetDefensivePower()};
        Player2Menu(player1);
    }
    else if(userSelection == 5)
    {
        Menu.ExitSystem();
    }
    else
    {
        Menu.InvalidSelection();
        Player1Menu();
    }
}
static void Player2Menu(Character player1)
{
    Character player2 = new Character();
    string playerTwoName = Menu.PlayerTwo();
    int userSelection = Menu.SelectCharacter2(playerTwoName);
    player2.playerName = playerTwoName;
    if(userSelection == 1)
    {
        System.Console.WriteLine($"{playerTwoName}, you will play as Jack Sparrow");
        player2 = new JackSparrow(){playerName = player2.playerName, maxPower = player2.GetMaxPower(), health = 100, attackStrength = player2.GetAttackStrength(), defensivePower = player2.GetDefensivePower()};
        DisplayStats(player1, player2);
        GameLoop(player1, player2);
    }
    else if(userSelection == 2)
    {
        System.Console.WriteLine($"{playerTwoName}, you will play as Jack Davy Jones");
        player2 = new DavyJones(){playerName = player2.playerName, maxPower = player2.GetMaxPower(), health = 100, attackStrength = player2.GetAttackStrength(), defensivePower = player2.GetDefensivePower()};
        DisplayStats(player1, player2);
        GameLoop(player1, player2);
    }
    else if(userSelection == 3)
    {
        System.Console.WriteLine($"{playerTwoName}, you will play as Will Turner");
        player2 = new WillTurner(){playerName = player2.playerName, maxPower = player2.GetMaxPower(), health = 100, attackStrength = player2.GetAttackStrength(), defensivePower = player2.GetDefensivePower()};
        DisplayStats(player1, player2);
        GameLoop(player1, player2);
    }
    else if(userSelection == 4)
    {
        System.Console.WriteLine($"{playerTwoName}, you will play as Elizabeth Swann");
        player2 = new ElizabethSwann(){playerName = player2.playerName, maxPower = player2.GetMaxPower(), health = 100, attackStrength = player2.GetAttackStrength(), defensivePower = player2.GetDefensivePower()};
        DisplayStats(player1, player2);
        GameLoop(player1, player2);
    }
    else if(userSelection == 5)
    {
        Menu.ExitSystem();
    }
    else
    {
        Menu.InvalidSelection();
        Player2Menu(player1);
    }
}
static void GameLoop(Character player1, Character player2)
{
    bool oneFirst = Menu.DetermineFirstPlayer(); //each player rolls a die to determine who will go first
    if(oneFirst == true)
    {
        System.Console.WriteLine($"{player1.playerName}, you will go first!");
    }
    else if(oneFirst == false)
    {
        System.Console.WriteLine($"{player2.playerName}, you will go first!");
    }
    while((player1.health > 0) && (player2.health > 0))
    {
        Thread.Sleep(3000);
        if(oneFirst == true)
        {
            System.Console.WriteLine("\n");
            player1.attackBehavior.Attack();
            Thread.Sleep(2000);
            DamageInflicted(player1, player2, oneFirst);
            oneFirst = false; //player2 can now go
        }
        else
        {
            System.Console.WriteLine("\n");
            player2.attackBehavior.Attack();
            Thread.Sleep(2000);
            DamageInflicted(player1, player2, oneFirst);
            oneFirst = true;
        }
    } 
    DisplayWinner(player1, player2);
}
static void DamageInflicted(Character player1, Character player2, bool oneFirst)
{
    double boost = 1;
    if(oneFirst == true)
    {
        if(((player1.characterName == "Jack Sparrow") && (player2.characterName == "Will Turner")) || ((player1.characterName == "Will Turner") && (player2.characterName == "Davy Jones")) || ((player1.characterName == "Davy Jones") && (player2.characterName == "Elizabeth Swann")) || ((player1.characterName == "Elizabeth Swann") && (player2.characterName == "Jack Sparrow")) )
        {
            System.Console.WriteLine("20% boost on the attack!");
            boost = 1.2;
        }
        double damage = player1.attackStrength - player2.defensivePower * boost;
        if(damage >= 0)
        {
            player2.health -= damage;
            System.Console.WriteLine($"\n\n{player2.playerName}'s damage: - {Math.Round(damage, 2)}");
        }
        else if (damage < 0)
        {
            System.Console.WriteLine("\n\n");
            player2.defendBehavior.Defend();
        }
    }
    else
    {
        if(((player2.characterName == "Jack Sparrow") && (player1.characterName == "Will Turner")) || ((player2.characterName == "Will Turner") && (player1.characterName == "Davy Jones")) || ((player2.characterName == "Davy Jones") && (player1.characterName == "Elizabeth Swann")) || ((player2.characterName == "Elizabeth Swann") && (player1.characterName == "Jack Sparrow")))
        {
            boost = 1.2;
        }
        double damage = player2.attackStrength - player1.defensivePower * boost;
        if(damage >= 0)
        {
            player1.health -= damage;
            System.Console.WriteLine($"{player1.playerName}'s damage: - {Math.Round(damage, 2)}");
        }
        else if(damage < 0)
        {
            System.Console.WriteLine("\n\n");
            player1.defendBehavior.Defend();
        }
    }
    player1.attackStrength = player1.GetAttackStrength(); //resetting stats to make it more fair
    player2.attackStrength = player2.GetAttackStrength();
    player1.defensivePower = player1.GetDefensivePower();
    player2.defensivePower = player2.GetDefensivePower();
    player1.maxPower = player1.GetMaxPower();
    player2.maxPower = player2.GetMaxPower();
    DisplayStats(player1, player2);

}

static void DisplayStats(Character player1, Character player2)
{
    System.Console.WriteLine($"\n\n{player1.playerName}, here are your stats: \nHealth: {Math.Round(player1.health, 2)} \nMax Power: {player1.maxPower} \nAttack Strength: {player1.attackStrength} \nDefensive Power: {player1.defensivePower}");
    Thread.Sleep(2000);
    System.Console.WriteLine($"\n\n{player2.playerName}, here are your stats: \nHealth: {Math.Round(player2.health, 2)} \nMax Power: {player2.maxPower} \nAttack Strength: {player2.attackStrength} \nDefensive Power: {player2.defensivePower}");
    Thread.Sleep(2000);
}

// static void DisplayStats(Character player1, Character player2)
// {
//     System.Console.WriteLine($"\n\n{player1.playerName}, your current health is: {player1.health}");
//     Thread.Sleep(2000);
//     System.Console.WriteLine($"\n\n{player2.playerName}, your current health is: {player2.health}");
//     Thread.Sleep(2000);
// }
static void DisplayWinner(Character player1, Character player2)
{
    Thread.Sleep(2000);
    if(player1.health > 0)
    {
        System.Console.WriteLine($"\n\n{player1.playerName} wins!!");
    }
    else if(player2.health > 0)
    {
        System.Console.WriteLine($"\n\n{player2.playerName} wins!!");
    }
}
