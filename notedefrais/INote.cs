namespace notedefrais
{
    public interface INote
    {
        ICommercial AgentCommercial { get; set; }
        decimal MontantARembourser { get; set; }
        bool Rembourse { get; set; }

        decimal CalculMontantARembourser();
        void SetGiveMoneyBack();
        void SetMontantARembourser();
        void ToString();
    }
}