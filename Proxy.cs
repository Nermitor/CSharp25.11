namespace CSharp09._12
{
    public class Proxy : Subject
    {
        private RealSubject _rsubj;
        private bool _deferredMode;
        private bool _protectedMode;

        public Proxy(bool deferredMode, bool protectedMode)
        {
            _deferredMode = deferredMode;
            _protectedMode = protectedMode;

            if (!_deferredMode)
            {
                _rsubj = new RealSubject();
            }
        }

        public override string RequestA()
        {
            if (!_deferredMode && !_protectedMode)
            {
                return "A (Proxy)";
            }
            else if (_protectedMode)
            {
                return "A denied";
            }
            else
            {
                return "A (Proxy) (Deferred)";
            }
        }

        public override string RequestB()
        {
            if (!_protectedMode)
            {
                return "B (Proxy)";
            }
            else
            {
                return "B denied";
            }
        }

        public override string RequestC()
        {
            if (_rsubj == null)
            {
                _rsubj = new RealSubject();
            }

            return _rsubj.RequestC();
        }

        public override string RequestD()
        {
            if (!_protectedMode)
            {
                if (_rsubj == null)
                {
                    _rsubj = new RealSubject();
                }

                return _rsubj.RequestD();
            }
            else
            {
                return "D denied";
            }
        }
    }
}