namespace FizzBuzz
{
    public delegate TResult Func<in T, out TResult>(T arg);

    public class Translation
    {
        #region construction
        private readonly Func<int, bool> isTriggeredBy;
        public Translation(Func<int, bool> translationTriggeredWhen, string output)
        {
            this.isTriggeredBy = translationTriggeredWhen;
            Output = output;
        }
        #endregion

        public bool IsTriggeredBy(int input) { return this.isTriggeredBy(input); }

        public string Output { get; }
    }
}