namespace Core
{
    public delegate TResult TranslationCondition<in T, out TResult>(T arg);

    public class Translation
    {
        #region construction
        private readonly TranslationCondition<int, bool> isTriggeredBy;
        public Translation(TranslationCondition<int, bool> condition, string output)
        {
            this.isTriggeredBy = condition;
            Output = output;
        }
        #endregion

        public bool IsTriggeredBy(int input) { return this.isTriggeredBy(input); }

        public string Output { get; }
    }
}