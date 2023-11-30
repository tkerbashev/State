using State;

Console.WriteLine( "State Behavioural Design Pattern example\n" );

Car myCar = new();

myCar.Drive();

myCar.ChangeRoadType(RoadType.Uphill);;
myCar.Drive();

myCar.ChangeRoadType( RoadType.Downhill ); ;
myCar.Drive( );
