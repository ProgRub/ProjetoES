using System;
using ServicesLibrary.Commands;

namespace Forms.CommandsCreatePrescription
{
    public class CommandCreateRecommendedTime : ICommand
    {
        public CommandCreateRecommendedTime(TimeSpan recommendedTimeSpan)
        {
            RecommendedTime = recommendedTimeSpan;
        }

        public TimeSpan? RecommendedTime { get; set; }

        public void Execute()
        {
            RecommendedTime = RecommendedTime;
        }

        public void Undo()
        {
            RecommendedTime = null;
        }

        public void Redo()
        {
            Execute();
        }
    }
}