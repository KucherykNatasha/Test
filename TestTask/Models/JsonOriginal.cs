using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace TestTask.Models
{
    public class JsonOriginal:IJson
    {
       
        public string WriteJson()
        {
            return JsonConvert.SerializeObject(Routes()); 
        }
        public Route Routes()
        {
            Route jRoute = new Route()
            {

                Name = "25School",
                ActiveDays = ActiveDays.Mondey | ActiveDays.Tuesday,
                EndDate = new DateTime(2020, 12, 31),
                StartDate = new DateTime(2020, 01, 02),
                Riders = new List<Ride>()
               {  new Ride()
                  {

                   DateOfRide=new DateTime(2020,01,06),
                   StartTime="07:00:00",
                   PlannedStartTime="07:00:00",

                   Driver=new Driver
                       {

                         Person=new Person
                           {

                             FirstName="Oleg",
                             LastName="Vlasov"
                            },
                         LicenseNumber=123456
                       },
                   PlannedDriver=new Driver
                       {

                         Person=new Person
                           {

                             FirstName="Oleg",
                             LastName="Vlasov"
                            },
                         LicenseNumber=123456
                       },
                   Cancelled=false,
                   Stations=new List<Station>()
                       { new Station()
                         {

                           Name="Vishenka",
                           Address="Nikola Vashchuk str. 12",
                           Passengers=new List<Passenger>()
                               {  new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Petro",
                                        LastName="Dudnik"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                   new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Oleksandr",
                                        LastName="Petrik"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                    new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Dmitro",
                                        LastName="Suslov"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     }




                           },
                           Order =1,
                           PlannedOrder=1,
                           IsActive=true
                          },
                        new Station()
                         {

                           Name="Yunosty",
                           Address="Prospekt Yunosty str. 2",
                           Passengers=new List<Passenger>()
                               {  new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Lina",
                                        LastName="Novak"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                   new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Olga",
                                        LastName="Trach"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                    new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Viktor",
                                        LastName="Mazur"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     }

                       },

                           Order =2,
                           PlannedOrder=2,
                           IsActive=true

                    }

                   }


                 },

                 new Ride()
                  {

                   DateOfRide=new DateTime(2020,01,07),
                   StartTime="07:00:00",
                   PlannedStartTime="07:00:00",

                   Driver=new Driver
                       {

                         Person=new Person
                           {

                             FirstName="Ivan",
                             LastName="Kanavalov"
                            },
                         LicenseNumber=789543
                       },
                   PlannedDriver=new Driver
                       {

                         Person=new Person
                           {

                             FirstName="Ivan",
                             LastName="Kanavalov"
                            },
                         LicenseNumber=789543
                       },
                   Cancelled=false,
                   Stations=new List<Station>()
                       { new Station()
                         {

                            Name="Vishenka",
                           Address="Nikola Vashchuk str. 12",
                           Passengers=new List<Passenger>()
                               {  new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Ian",
                                        LastName="Boris"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                   new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Vitaliy",
                                        LastName="Nazarov"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                    new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Olga",
                                        LastName="Mirna"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     }




                           },
                           Order =1,
                           PlannedOrder=1,
                           IsActive=true
                          },
                        new Station()
                         {

                           Name="Yunosty",
                           Address="Prospekt Yunosty str. 2",
                           Passengers=new List<Passenger>()
                               {  new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Polina",
                                        LastName="Sivak"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                   new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Diana",
                                        LastName="Bila"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                    new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Mila",
                                        LastName="Bondar"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     }

                       },

                           Order =2,
                           PlannedOrder=2,
                           IsActive=true

                    }
            }
                 },
                 new Ride()
                  {

                   DateOfRide=new DateTime(2020,02,03),
                   StartTime="07:00:00",
                   PlannedStartTime="07:00:00",

                   Driver=new Driver
                       {

                         Person=new Person
                           {

                             FirstName="Viktor",
                             LastName="Gomel"
                            },
                         LicenseNumber=564322
                       },
                   PlannedDriver=new Driver
                       {

                         Person=new Person
                           {

                             FirstName="Viktor",
                             LastName="Gomel"
                            },
                         LicenseNumber=564322
                       },
                   Cancelled=false,
                   Stations=new List<Station>()
                       { new Station()
                         {

                           Name="Vishenka",
                           Address="Nikola Vashchuk str. 12",
                           Passengers=new List<Passenger>()
                               {  new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Petro",
                                        LastName="Dudnik"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                   new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Oleksandr",
                                        LastName="Petrik"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                    new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Dmitro",
                                        LastName="Suslov"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     }




                           },
                           Order =1,
                           PlannedOrder=1,
                           IsActive=true
                          },
                        new Station()
                         {

                           Name="Yunosty",
                           Address="Prospekt Yunosty str. 2",
                           Passengers=new List<Passenger>()
                               {  new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Lina",
                                        LastName="Novak"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                   new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Olga",
                                        LastName="Trach"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                    new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Viktor",
                                        LastName="Mazur"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     }

                       },

                           Order =2,
                           PlannedOrder=2,
                           IsActive=true

                    }

                   }


                 },
                 new Ride()
                  {

                   DateOfRide=new DateTime(2020,02,04),
                   StartTime="07:00:00",
                   PlannedStartTime="07:00:00",

                   Driver=new Driver
                       {

                         Person=new Person
                           {

                             FirstName="Petro",
                             LastName="Kogan"
                            },
                         LicenseNumber=777888
                       },
                   PlannedDriver=new Driver
                       {

                         Person=new Person
                           {

                             FirstName="Petro",
                             LastName="Kogan"
                            },
                         LicenseNumber=777888
                       },
                   Cancelled=false,
                   Stations=new List<Station>()
                       { new Station()
                         {

                           Name="Vishenka",
                           Address="Nikola Vashchuk str. 12",
                           Passengers=new List<Passenger>()
                               {  new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Petro",
                                        LastName="Dudnik"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                   new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Oleksandr",
                                        LastName="Petrik"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                    new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Dmitro",
                                        LastName="Suslov"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     }




                           },
                           Order =1,
                           PlannedOrder=1,
                           IsActive=true
                          },
                        new Station()
                         {

                           Name="Yunosty",
                           Address="Prospekt Yunosty str. 2",
                           Passengers=new List<Passenger>()
                               {  new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Lina",
                                        LastName="Novak"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                   new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Olga",
                                        LastName="Trach"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                    new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Viktor",
                                        LastName="Mazur"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     }

                       },

                           Order =2,
                           PlannedOrder=2,
                           IsActive=true

                    }

                   }


                 },
                  new Ride()
                  {

                   DateOfRide=new DateTime(2020,03,02),
                   StartTime="07:00:00",
                   PlannedStartTime="07:00:00",

                   Driver=new Driver
                       {

                         Person=new Person
                           {

                             FirstName="Oleg",
                             LastName="Vlasov"
                            },
                         LicenseNumber=123456
                       },
                   PlannedDriver=new Driver
                       {

                         Person=new Person
                           {

                             FirstName="Oleg",
                             LastName="Vlasov"
                            },
                         LicenseNumber=123456
                       },
                   Cancelled=false,
                   Stations=new List<Station>()
                       { new Station()
                         {

                           Name="Vishenka",
                           Address="Nikola Vashchuk str. 12",
                           Passengers=new List<Passenger>()
                               {  new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Petro",
                                        LastName="Dudnik"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                   new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Oleksandr",
                                        LastName="Petrik"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                    new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Dmitro",
                                        LastName="Suslov"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     }




                           },
                           Order =1,
                           PlannedOrder=1,
                           IsActive=true
                          },
                        new Station()
                         {

                           Name="Yunosty",
                           Address="Prospekt Yunosty str. 2",
                           Passengers=new List<Passenger>()
                               {  new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Lina",
                                        LastName="Novak"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                   new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Olga",
                                        LastName="Trach"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                    new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Viktor",
                                        LastName="Mazur"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     }

                       },

                           Order =2,
                           PlannedOrder=2,
                           IsActive=true

                    }

                   }


                 },

                 new Ride()
                  {

                   DateOfRide=new DateTime(2020,03,03),
                   StartTime="07:00:00",
                   PlannedStartTime="07:00:00",

                   Driver=new Driver
                       {

                         Person=new Person
                           {

                             FirstName="Ivan",
                             LastName="Kanavalov"
                            },
                         LicenseNumber=789543
                       },
                   PlannedDriver=new Driver
                       {

                         Person=new Person
                           {

                             FirstName="Ivan",
                             LastName="Kanavalov"
                            },
                         LicenseNumber=789543
                       },
                   Cancelled=false,
                   Stations=new List<Station>()
                       { new Station()
                         {

                            Name="Vishenka",
                           Address="Nikola Vashchuk str. 12",
                           Passengers=new List<Passenger>()
                               {  new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Ian",
                                        LastName="Boris"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                   new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Vitaliy",
                                        LastName="Nazarov"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                    new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Olga",
                                        LastName="Mirna"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     }




                           },
                           Order =1,
                           PlannedOrder=1,
                           IsActive=true
                          },
                        new Station()
                         {

                           Name="Yunosty",
                           Address="Prospekt Yunosty str. 2",
                           Passengers=new List<Passenger>()
                               {  new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Polina",
                                        LastName="Sivak"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                   new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Diana",
                                        LastName="Bila"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     },
                                    new Passenger()
                                    {
                                      Person = new Person()
                                      {

                                        FirstName="Mila",
                                        LastName="Bondar"
                                      },
                                      DestinationStation="School 25",
                                      IsActive=true

                                     }

                       },

                           Order =2,
                           PlannedOrder=2,
                           IsActive=true

                    }
            }
                 }

            }

            };
            return jRoute;

        }

    }
}
