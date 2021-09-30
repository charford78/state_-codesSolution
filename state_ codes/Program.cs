using System;
using System.Collections.Generic;

namespace state__codes
{
    class Program
    {
        static void Main(string[] args)
        {
            var states = new List<State>()
            {
                new State("OH", "Ohio"),
                new State("KY", "Kentucky"),
                new State("IN", "Indiana")
            };
            
            
            
            //var states = new List<State>();

            //var stateoh = new State("OH", "Ohio");
            //states.Add(stateoh);

            //var stateky = new State("KY", "Kentucky");
            //states.Add(stateky);

            ////doing this saves the step of creating a variable which isn't necessary
            //states.Add(new State("IN", "Indiana"));

            foreach(var state in states)
            {
                Console.WriteLine($"The statecode {state.Code} is for the state {state.Name}.");
            }
            
            
            
            
            
            
            
            //var statecodes = new Dictionary<string, string>()
            //{
            //    ["OH"] = "Ohio",
            //    ["IN"] = "Indiana",
            //    ["KY"] = "Kentucky"
            //};
            ////statecodes.Add("OH", "Ohio");
            ////statecodes.Add("IN", "Indiana");
            ////statecodes.Add("KY", "Kentucky");

            //var ohio = statecodes["OH"];
            //Console.WriteLine(ohio);
        }
    }
}
