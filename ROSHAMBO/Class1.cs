using System;

namespace ROSHAMBO
{
    public class Roshambo
    {
        public string Play(string input1, string input2)
        {
            if(input1=="Rock"&&input2=="Scissors"|| input1 == "Scissors" && input2 == "Rock")
            {
                return "Rock beats Scissors";
            }

            return "";
        }
    }
}
