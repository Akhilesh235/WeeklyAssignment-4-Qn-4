namespace WA4_Qn4
{
    internal class OperationBase
    {

        public int AddThread(int FirstNumber, int SecondNumber)
        {
            int result = FirstNumber + SecondNumber;
            Console.WriteLine("The sum of {0} and {1} is {2}", FirstNumber, SecondNumber, result);

        }
        public void SumThread()
        {
            Thread tp = new Thread(() => { AddThread(); });
            tp.Start();
        }

        private void AddThread()
        {
            throw new NotImplementedException();
        }
    }
}