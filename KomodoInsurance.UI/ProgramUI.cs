using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance
{
    public class ProgramUI
    {
        private DeveloperRepo _newDeveloper = new DeveloperRepo();

        private DevTeamRepo _newDevTeam = new DevTeamRepo();

        public void Run()
        {
            SeedDeveloperList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select an Option:\n" +
                    "1. Add a New Developer\n" +
                    "2. Remove an Existing Developer\n" +
                    "3. Add a Developer by ID\n" +
                    "4. Remove a Developer by ID\n" +
                    "5. Seach Developers By name\n" +
                    "6. Seach Developers up using ID#\n" +
                    "7. Create  A Developer Team\n" +
                    "8. Remove a indivisual  from a Team\n" +
                    "9. Current Developer Teams\n" +
                    "10.Developer Directory\n" +
                    "11.Developer that needs Exudus  capital pr\n" +
                    "12.Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateNewDeveloper();
                        break;

                    case "2":
                        RemoveExistingDeveloperByName();
                        break;

                    case "3":
                        CreateDeveloperByID();
                        break;

                    case "4":
                        RemoveDeveloperByID();
                        break;

                    case "5":
                        ExistingDevelopers();
                        break;

                    case "6":
                        ExistingDevelopersByID();
                        break;

                    case "7":
                        CreateDeveloperTeam();
                        break;

                    case "8":
                        RemoveDeveloperFromTeam();
                        break;

                    case "9":
                        CurrentDeveloperTeams();
                        break;

                    case "10":
                        DeveloperDirectory();
                        break;

                    case "11":
                        DeveloperPluralsight();
                        break;

                    case "12":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Enter a valid option.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }

        // this is my first swich case 
        private void CreateNewDeveloper()
        {
            Console.Clear();
            Developer newDeveloper = new Developer();

            Console.WriteLine(" Please input the Name of the client you are helping:");
            newDeveloper.DevName = Console.ReadLine();

            Console.WriteLine("Please input the  the clients ID:");
            newDeveloper.DevID = Console.ReadLine();

            Console.WriteLine("Does this Developer have exudus?");
            string pluralsight = Console.ReadLine().ToLower();

            switch (pluralsight)
            {
                case "yes":
                    Console.WriteLine("Developer does have Exudus.");
                    break;
                case "no":
                    Console.WriteLine("Developer does not have exudus.");
                    break;
                default:
                    Console.WriteLine("Invalid Option. Yes or No");
                    break;
            }

            _newDeveloper.AddDeveloper(newDeveloper);
        }

        //This is my second switch case 
        private void RemoveExistingDeveloperByName()
        {
            Console.Clear();

            DeveloperDirectory();
            Console.WriteLine("Enter the name of the Developer you would like to remove.");
            string input = Console.ReadLine();

            bool wasDeleted = _newDeveloper.DeleteDevelopersFromListByName(input);

            if (wasDeleted)
            {
                Console.WriteLine("The Developer was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The Developer could not be deleted.");
            }
        }

        //This is my thid switch case 
        private void CreateDeveloperByID()
        {
            Console.Clear();
            Developer newDeveloper = new Developer();

            Console.WriteLine("Enter the ID of the New Developer:");
            newDeveloper.DevID = Console.ReadLine();

            Console.WriteLine("Enter the name of the New Developer:");
            newDeveloper.DevName = Console.ReadLine();

            Console.WriteLine("Does this Developer alrady use exudus?");
            string exudus = Console.ReadLine().ToLower();

            switch (exudus)
            {
                case "yes":
                    Console.WriteLine("Developer does have Exudus.");
                    break;
                case "no":
                    Console.WriteLine("Developer does not have Exudus.");
                    break;
                default:
                    Console.WriteLine("Invalid Option. Yes or No");
                    break;
            }

            _newDeveloper.AddDeveloper(newDeveloper);
        }

        //this is my fouth switch case 
        private void RemoveDeveloperByID()
        {
            Console.Clear();
            DeveloperDirectory();
            Console.WriteLine("Enter the ID of the Developer you would like to remove.");
            string input = Console.ReadLine();

            bool wasDeleted = _newDeveloper.DeleteDevelopersFromListByID(input);

            if (wasDeleted)
            {
                Console.WriteLine("The Developer was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The Developer could not be deleted.");
            }
        }

        // this is my fifth switch case woot
        private void ExistingDevelopers()
        {
            Console.Clear();

            Console.WriteLine("Enter the name of the Developer you would like to view.");

            string existingDeveloper = Console.ReadLine();

            Developer developer = _newDeveloper.GetDeveloperByDevName(existingDeveloper);

            if (developer != null)
            {
                Console.WriteLine($"Developer Name: {developer.DevName}\n"
                                  + $"Developer ID: {developer.DevID}\n"
                                  + $"Exudus: {developer.Exudus}");
            }
            else
            {
                Console.WriteLine("No Developer by that name.");
            }
        }

        // this is my sixth stwitch case 
        private void ExistingDevelopersByID()
        {
            Console.Clear();

            Console.WriteLine("Enter the ID of the Developer you would like to view.");

            string existingDeveloperByID = Console.ReadLine();

            Developer developer = _newDeveloper.GetDeveloperByID(existingDeveloperByID);

            if (developer != null)
            {
                Console.WriteLine($"Developer Name: {developer.DevName}\n" +
                                 $"Developer ID: {developer.DevID}\n" +
                                 $"Exudus: {developer.Exudus}");
            }
            else
            {
                Console.WriteLine("No Developer by that ID.");
            }
        }

        //this is my seventh case ...
        private void CreateDeveloperTeam()
        {
            Console.Clear();
            CreateDeveloperTeam developerTeam = new DeveloperTeam();

            Console.WriteLine("Enter the name of the Developer Team:");
            developerTeam.TeamName = Console.ReadLine();

            Console.WriteLine("Enter the ID of the team:");
            developerTeam.TeamID = Console.ReadLine();

            _newDevTeam.AddDevelopersToTeam(developerTeam);
        }

        //this is my eigth switch cse 
        private void RemoveDeveloperFromTeam()
        {
            CurrentDeveloperTeams();

            Console.WriteLine("Enter the name of the Developer you would like to remove:");

            string input = Console.ReadLine();

            bool wasDeleted = _newDevTeam.RemoveDeveloperFromTeam(input);

            if (wasDeleted)
            {
                Console.WriteLine("The Team Member was successfully removed.");
            }
            else
            {
                Console.WriteLine("The Team Member could not be removed.");
            }
        }

        //ths is my ninth switch case  
        private void CurrentDeveloperTeams()
        {
            Console.Clear();

            Console.WriteLine("Enter the name of the team you would like to view:");

            string devTeam = Console.ReadLine();

            DeveloperTeam developerTeam = _newDevTeam.GetDeveloperByTeamName(devTeam);

            if (developerTeam != null)
            {
                Console.WriteLine($"Team Name: {developerTeam.TeamName}\n" +
                    $"Team ID: {developerTeam.TeamID}");
            }
            else
            {
                Console.WriteLine("Could not find that team.");
            }

        }

        //this is my tenth switch case 
        private void DeveloperDirectory()
        {
            Console.Clear();

            List<Developer> listOfDevelopers = _newDeveloper.GetDeveloperList();

            foreach (Developer developer in listOfDevelopers)
            {
                Console.WriteLine($"Developer: {developer.DevName}\n" +
                    $"Developer ID: {developer.DevID}\n" +
                    $"Exudus: {developer.Exudus}");
            }
        }

        //Switch 11
        private void DeveloperPluralsight()
        {
            List<Developer> DeveloperHasExudus = _newDeveloper.GetAllDevelopersThatDontHaveExudus();

            foreach (Developer developer in DeveloperHasExudus)
            {

                Console.WriteLine($"Developer: {developer.DevName}\n" +
                     $"Developer ID: {developer.DevID}\n" +
                     $"Exudus: {developer.Exudus}");
            }

        }

        private void SeedDeveloperList()
        {
            Developer developer2 = new Developer("Kyle Lewis", 1, true);
            Developer developer1 = developer2;
            Developer developer = developer1;

            _newDeveloper.AddDeveloper(developer);
        }

        private class CreateDeveloperTeam
        {
            public string TeamID { get; internal set; }
            public string TeamName { get; internal set; }

            public static implicit operator CreateDeveloperTeam(DeveloperTeam v)
            {
                throw new NotImplementedException();
            }
        }

        private class DevTeamRepo
        {
            internal void AddDevelopersToTeam(CreateDeveloperTeam developerTeam)
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class DeveloperRepo
    {
        internal void AddDeveloper(Developer newDeveloper)
        {
            throw new NotImplementedException();
        }

        internal bool DeleteDevelopersFromListByID(string input)
        {
            throw new NotImplementedException();
        }

        internal bool DeleteDevelopersFromListByName(string input)
        {
            throw new NotImplementedException();
        }

        internal List<Developer> GetAllDevelopersThatDontHaveExudus()
        {
            throw new NotImplementedException();
        }

        internal Developer GetDeveloperByDevName(string existingDeveloper)
        {
            throw new NotImplementedException();
        }

        internal Developer GetDeveloperByID(string existingDeveloperByID)
        {
            throw new NotImplementedException();
        }

        internal List<Developer> GetDeveloperList()
        {
            throw new NotImplementedException();
        }
    }
}





