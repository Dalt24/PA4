using PA4.Characters;
using PA4.UserFunctionality;

StartMain();

static void StartMain()
{
    System.Console.WriteLine("Welcome to the Battle of Calypso's Maelstrom");

    Factory factory = new Factory();
    Character? currPlayerOne = factory.GetPlayer();
    Character? currPlayerTwo = factory.GetPlayer();

    DisplayCharacter(currPlayerOne, currPlayerTwo);

    StartGame(currPlayerOne, currPlayerTwo);
}

static void Attack(Character? c1, Character? c2, double bonus)
{
    double damage = (c1.AttackStrength() - c2.DefensePower()) * bonus;
    if (damage < 1)
    {
        System.Console.WriteLine($"{c1?.characterName}'s Attack Did No Damage!");
        System.Console.WriteLine("");
    }
    else
    {
        c2.health = c2.health - damage;
        if (c2?.health < 0) c2.health = 0;
        System.Console.WriteLine($"{c1?.characterName}'s Attack Has {c1.maxPower} Power and Does {Math.Round(damage, 2)} Damage");
        System.Console.WriteLine($"{c2?.characterName} Has {Math.Round(c2.health, 2)} Health Left");
        System.Console.WriteLine("");
    }
}

static void StartGame(Character? currPlayerOne, Character? currPlayerTwo)
{
    User user = new User();
    int currentUser = user.GetCoinFlip();
    double bonus = GetBonusDamage(currPlayerOne, currPlayerTwo);


    while (currPlayerOne?.health > 0 && currPlayerTwo?.health > 0)
    {
        if (currentUser == 1)
        {
            currentUser = 0;
            currPlayerTwo?.attackBehavior?.Attack();
            Attack(currPlayerTwo, currPlayerOne, bonus);
        }
        else
        {
            currentUser = 1;
            currPlayerOne?.attackBehavior?.Attack();
            Attack(currPlayerOne, currPlayerTwo, bonus);
        }
        Thread.Sleep(1500);
    }
    if (currPlayerOne?.health > 0) System.Console.WriteLine(currPlayerOne.name + " Wins With the Character " + currPlayerOne.characterName + "!");
    else
    {
        System.Console.WriteLine(currPlayerTwo?.name + " Wins With the Character " + currPlayerTwo?.characterName + "!");
    }
}

static double GetBonusDamage(Character? c1, Character? c2)
{
    double bonus = 0;
    switch ((c1?.characterName, c2?.characterName))
    {
        case ("Jack Sparrow", "Will Turner"):
            bonus = 1.2;
            System.Console.WriteLine("Jack Sparrow Gets a 20% Damage Boost Against Will Turner!");
            break;
        case ("Will Turner", "Davy Jones"):
            bonus = 1.2;
            System.Console.WriteLine("Will Turner Gets a 20% Damage Boost Against Davy Jones!");
            break;
        case ("Davy Jones", "Jack Sparrow"):
            bonus = 1.2;
            System.Console.WriteLine("Davy Jones Gets a 20% Damage Boost Against Jack Sparrow!");
            break;
        default:
            bonus = 1;
            break;
    }
    return bonus;
}

static void DisplayCharacter(Character currPlayerOne, Character currPlayerTwo)
{
    System.Console.WriteLine($"\n\nPlayer One: {currPlayerOne.characterName}\nHealth: {Math.Round(currPlayerOne.health, 2)} \nMax Power: {currPlayerOne.maxPower} \nAttack: {currPlayerOne.attackStrength} \nDefense: {currPlayerOne.defensivePower}");
    System.Console.WriteLine($"\nPlayer Two: {currPlayerTwo.characterName} \nHealth: {currPlayerTwo.health} \nMax Power: {currPlayerTwo.maxPower} \nAttack: {currPlayerTwo.attackStrength} \nDefense: {currPlayerTwo.defensivePower}\n");
}

