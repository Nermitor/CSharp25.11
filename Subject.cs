namespace CSharp09._12
{
    public abstract class Subject
    {
        public abstract string RequestA();
        public abstract string RequestB();
        public abstract string RequestC();
        public abstract string RequestD();
    }

    public class RealSubject : Subject
    {
        public override string RequestA()
        {
            return "A (Real)";
        }

        public override string RequestB()
        {
            return "B (Real)";
        }

        public override string RequestC()
        {
            return "C (Real)";
        }

        public override string RequestD()
        {
            return "D (Real)";
        }
    }
    
}