using _11_PolymorphismTraitsVehicles;

List<MotorVehicle> moto =  new List<MotorVehicle>();
moto.Add(new Cars());
moto.Add(new Boats());

foreach (MotorVehicle item in moto)
    item.Move();