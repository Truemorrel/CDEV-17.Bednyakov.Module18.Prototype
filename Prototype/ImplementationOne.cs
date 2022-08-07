namespace Prototype
{
    internal class ImplementationOne : BaseClass
    {
        private int v;

        public ImplementationOne(int id) : base (id)
        {
        }

        public override BaseClass Clone()
        {
            return  new ImplementationOne(Id);
        }
    }
}