using System;

namespace PseudoRegisters
{
    public class RegistersProcessor
    {
        private readonly Register _t1;
        private readonly Register _t2;

        public RegistersProcessor()
        {
            _t1 = new Register("T1");
            _t2 = new Register("T2");
        }

        public void Zero(Register r)
        {
            r.Value = 0;
        }

        public void Inc(Register r)
        {
            r.Value++;
        }

        public void Loop(Register r, Action body)
        {
            for (var i = 0; i < r.Value; i++) body();
        }

        public void Copy(Register source, Register dest)
        {
            Zero(dest);
            Loop(source, () => { Inc(dest); });
        }

        public void Dec(Register r)
        {
            Loop(r, () =>
            {
                Copy(_t2, _t1);
                Inc(_t2);
            });
            Copy(_t1, r);
        }
    }
}