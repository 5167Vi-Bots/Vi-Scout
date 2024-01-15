using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vi_Scout.DTO.Export.BotActions;
using Vi_Scout.DTO.Export.GameActions;
using Vi_Scout.DTO.Export.Score;

namespace Vi_Scout.DTO.Export
{
    class Match
    {
        public List<ScoreAttempt> ScoringAttempts { get; } = new List<ScoreAttempt>();
        public List<Pickup> PiecePickups { get; } = new List<Pickup>();
        public List<Drop> PieceDrops { get; set; } = new List<Drop>();
    }
}
