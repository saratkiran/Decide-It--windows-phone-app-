using System;
using System.Collections.Generic;
using System.Linq;

namespace Decisions
{
    public class DecisionType
    {
        public static IEnumerable<DecisionType> GetDecisionTypes()
        {
            return new[]
            {
                new DecisionType
                {
                    Name = "\n\t Yes / No",
                    Choices = new[]
                    {
                        "Yes", "No"
                    }
                },
                new DecisionType
                {
                    Name = "\n\t A / B / C / D",
                    Choices = new[]
                    {
                        "A", "B", "C", "D"
                    }
                },
                new DecisionType
                {
                    Name = "\n\t1 - 100",
                    Choices = Enumerable.Range(1, 100).Select(i => i.ToString())
                },
                new DecisionType
                {
                    Name = "\n\tLeft / Right",
                    Choices = new[]
                    {
                        "Left", "Right"
                    }
                },
                new DecisionType
                {
                    Name = "\n\tUp / Down",
                    Choices = new[]
                    {
                        "Up", "Down"
                    }
                },

                new DecisionType
                {
                    Name = "\n\tBuy / Sell / Hold",
                    Choices = new[]
                    {
                        "Buy", "Sell", "Hold"
                    }
                },
                new DecisionType
                {
                    Name = "\n\tAgree / Disagree",
                    Choices = new[]
                    {
                        "Agree", "Disagree"
                    }
                },
                new DecisionType
                {
                    Name = "\n\tHeads / Tails",
                    Choices = new[]
                    {
                        "Heads", "Tails"
                    }
                },
                
            };
        }

        public string Name
        {
            get; set;
        }

        public IEnumerable<string> Choices
        {
            get; set;
        }
    }
}
