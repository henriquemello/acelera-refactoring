using PerformanceBiller.Statement.Storage.Entities;
using System;

namespace PerformanceBiller.Statement.Models.Builders
{
    public class PerfomanceBuilder
    {
        public Play Play { get; private set; }
        public int Audience { get; private set; }

        public PerfomanceBuilder WithPlayEntity(PlayEntity play)
        {
            Play = new Play(play.Name, play.Type);
            return this;
        }

        public PerfomanceBuilder WithPerfomanceEntity(PerfomanceEntity perfomanceEntity)
        {
            Audience = perfomanceEntity.Audience;
            return this;
        }

        public Perfomance Build()
        {
            switch (Play.Type)
            {
                case "tragedy":
                    return new Tragedy(this);
                case "comedy":
                    return new Comedy(this);
                default:
                    throw new NotImplementedException(Play.Type);
            }
        }
    }
}
