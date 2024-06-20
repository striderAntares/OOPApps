using _14_OOPInterfaceBallers;

Defenders defans1  = new Defenders()
{
    NameSurname = "Caglars",
    JerseyNumber = 1,
    ShootingPower = 75,
    Reflexes = 87,
    NationalTeamParticipater = true,
    LeftFooted = false,
    Stamina = 91
};

Defenders defans2 = new Defenders()
{
    NameSurname = "Servet Cetin",
    JerseyNumber = 2,
    ShootingPower = 68,
    Reflexes = 15,
    NationalTeamParticipater = true,
    LeftFooted = false,
    Stamina = 91
};

List<Defenders> defs = new List<Defenders>()
{ defans1, defans2 };

foreach (Defenders defers in defs)
    Console.WriteLine(defers.NameSurname + " " + defers.JerseyNumber + "-" + defers.ShootingPower.ToString());

Goalkeeper goalie1 = new Goalkeeper()
{
    NameSurname = "Rushtu Rechber",
    JerseyNumber = 0,
    Stamina = 100,
    ShootingPower = 100,
    Reflexes = 100,
    NationalTeamParticipater = true,
    LeftFooted = true,
    CanUseHands = true
};
Goalkeeper goalie2 = new Goalkeeper()
{
    NameSurname = "Vulcan Ironhand",
    JerseyNumber = 3,
    Stamina = 88,
    ShootingPower = 88,
    Reflexes = 1,
    NationalTeamParticipater = true,
    LeftFooted = false,
    CanUseHands = true

};

List<Goalkeeper> goealies = new List<Goalkeeper>()
{ goalie1, goalie2 };

foreach (Goalkeeper goaliess in goealies)
    Console.WriteLine(goaliess.NameSurname + " " + goaliess.JerseyNumber + "-" + goaliess.ShootingPower.ToString());

//List<IBallers> ballers = new List<IBallers>()
//{ goalie1, goalie2, defans1 , defans2 };

//foreach (IBallers balls in ballers)
//    Console.WriteLine(balls.NameSurname + " " + balls.JerseyNumber + "-" + balls.ShootingPower); //as you can see this listing is superior. we commented it because after we wrote this we changed the interface of the goalie.
