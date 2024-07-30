//Phase One
// Print the message "Plan Your Heist!".
// Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
// Prompt the user to enter a team member's name and save that name.
// Prompt the user to enter a team member's skill level and save that skill level with the name.
// Prompt the user to enter a team member's courage factor and save that courage factor with the name.
// Display the team member's information.
//Phase Two
// Create a way to store several team members.
// Collect several team members' information.
// Stop collecting team members when a blank name is entered.
// Display a message containing the number of members of the team.
// Display each team member's information.
//Phase Three
// Stop displaying each team member's information.
// Store a value for the bank's difficulty level. Set this value to 100.
// Sum the skill levels of the team. Save that number.
// Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
// Phase Four
// Create a random number between -10 and 10 for the heist's luck value.
// Add this number to the bank's difficulty level.
// Before displaying the success or failure message, display a report that shows.
// The team's combined skill level
// The bank's difficulty level
//Phase Five
// Run the scenario multiple times.
// After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
// Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.
// Phase Six
// At the beginning of the program, prompt the user to enter the difficulty level of the bank.
// At the end of the program, display a report showing the number of successful runs and the number of failed runs.
namespace Heist
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Enter the difficulty level of the bank you are robbing:");
            int difficulty = Int32.Parse(Console.ReadLine());

            List<CrewMember> HeistTeam = new List<CrewMember>();
            
            Console.WriteLine("Who is in your crew?");
            while(true)
            {
            Console.WriteLine("Name");
            string name = Console.ReadLine();
            if(name == "")
            {
                break;
            }
           
            Console.WriteLine("Skill Level");
            int skillLevel = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Courage Factor");
            float courageFactor = float.Parse(Console.ReadLine());
                CrewMember newMember = new CrewMember()
                {
                    Name = name,
                    SkillLevel = skillLevel,
                    CourageFactor = courageFactor
                };
            HeistTeam.Add(newMember);
            }
            int totalSkillLevel = HeistTeam.Sum(x => x.SkillLevel);
            Console.WriteLine("How many times would you like to play?");
            int plays = Int32.Parse(Console.ReadLine());
            int wins = 0;
            int losses = 0;
            for(int i = 0; i < plays; i++)
            {
            int luckValue = new Random().Next(-10, 10);
            int bankLevel = difficulty + luckValue;
            Console.WriteLine($"Team's combined skill level: {totalSkillLevel}");
            Console.WriteLine($"Bank difficulty level: {bankLevel}");
            if(totalSkillLevel >= bankLevel)
            {
                Console.WriteLine("Great success! Hairbrushes for everyone!");
                wins++;
            }
            else 
            {
                Console.WriteLine("Failure");
                losses++;
            }
            }
            Console.WriteLine($"Wins: {wins} Losses: {losses}");

            // Console.WriteLine($"Team Members: {HeistTeam.Count}");
            // Console.WriteLine($"Your crew member is: Name:{name} Skill Level:{skillLevel} Courage Factor:{courageFactor}");

            

        }
    }
}