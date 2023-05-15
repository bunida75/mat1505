class progam{
    static void main (string[] args){
        Console.WriteLine("Enter the number of cities:");
        int numCities=int.Parse(Console.ReadLine());
        static[] cityNames=new string[numcities];
        int[] numContacts=new int[numcities];
        int[][] contacts=new int[numcities][];
        int[] covidlevels=new int[numcities];
       
        for(int i= 0;l < numCities; i++) 
        Console.WriteLine("Enter details for city {i}:");
        Console.WriteLine("Name");
        cityNames[i]=Console.ReadLine()ว
        Console.WriteLine("Numbre of contacts:");
        numContacts[i]=int.Parse(Console.ReadLine());
        contacts[i]=new int[numContacts[i]];
          for (int j = 0; j < numContacts[i]; j++)
         Console.WriteLine($"Contact {j + 1}:");
                    int contactNum = int.Parse(Console.ReadLine());
                    if (contactNum == i || contactNum >= numCities)
         Console.WriteLine("Invalid ID");
                        j--;
                    }
                    else
                    {
                        contacts[i][j] = contactNum;
                           }
             while (true)
         Console.WriteLine("Enter an action (Outbreak, Vaccinate, Lock down, Spread, Exit):");
                string action = Console.ReadLine();
                if (action == "Outbreak" || action == "Vaccinate" || action == "Lock down");
         Console.WriteLine("Enter the city number:");
                    int cityNum = int.Parse(Console.ReadLine());
                    if (cityNum >= numCities)
                    {     
          Console.WriteLine("Invalid ID");
                        continue;
                    }
                    if (action == "Outbreak")
                    {
                        covidLevels[cityNum] += 2;
                        if (covidLevels[cityNum] > 3)
                        {
                            covidLevels[cityNum] = 3;
                        }
                        for (int i = 0; i < numContacts[cityNum]; i++)
                        {
                            int contactNum = contacts[cityNum][i];
                            covidLevels[contactNum] += 1;
                            if (covidLevels[contactNum] > 3)
                            {
                                covidLevels[contactNum] = 3;
                            }    
                }
                    }
                    else if (action == "Vaccinate")
                    {
                        covidLevels[cityNum] = 0;
                    }
                    else if (action == "Lock down")
                    {
                        covidLevels[cityNum] -= 1;
                        if (covidLevels[cityNum] < 0)
                        {
                            covidLevels[cityNum] = 0;
                        }
                        for (int i = 0; i < numContacts[cityNum]; i++)
                        {
                            int contactNum = contacts[cityNum][i];
                            covidLevels[contactNum] -= 1;
                            if (covidLevels[contactNum] < 0)
                            {
                                covidLevels[contactNum] = 0;
                            }
          }
                else if (action == "Spread")
                {
                    for (int i = 0; i < numCities; i++)
                    {
                        covidLevels[i] += 1;
                        if (covidLevels[i] > 3)
                        {
                            covidLevels[i] = 3;
                        }
                    }
                }
                else if (action == "Exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid action");
                }                                                     
             for (int i = 0; i < numCities; i++)
                }
                {
                    Console.WriteLine($"City {i}: {cityNames[i]}, COVID-19 outbreak level: {covidLevels[i]}");
                }
             Console.WriteLine("Program terminated.");
            }

}