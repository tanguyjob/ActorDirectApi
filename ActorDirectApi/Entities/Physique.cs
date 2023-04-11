namespace ActorDirectApi.Entities
{
    public class Physique
    {
        public int PhysiqueId { get; set; }
        public String Race { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Breast { get; set; }
        public int Waist { get; set; }

        public int Hip { get; set; }

        public string Comment { get; set; } = null!;
        public DateTime MensurationDate { get; set; }

        public DateTime MensurationTime { get; set; }

        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }


        public int CorpulenceId { get; set; }
        public Corpulence Corpulence { get; set; }
    }
}
