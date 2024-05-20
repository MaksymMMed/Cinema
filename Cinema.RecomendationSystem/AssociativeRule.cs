namespace Cinema.RecomendationSystem
{
    public class AssociativeRule
    {
        public string[] antecedent; // If part
        public string[] consequent; // Then part
        public double confidence;
        public AssociativeRule(string[] antecedent, string[] consequent, double confidence)
        {
            this.antecedent = new string[antecedent.Length];
            Array.Copy(antecedent, this.antecedent, antecedent.Length);
            this.consequent = new string[consequent.Length];
            Array.Copy(consequent, this.consequent, consequent.Length);
            this.confidence = confidence;
        }
    }
}
