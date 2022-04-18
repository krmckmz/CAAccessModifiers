namespace MappingLibrary
{
    public class MapperClass
    {
        private protected void TestPrivateProtectedMethod()
        {
            Console.WriteLine(("Reached private protected method"));
        }

        protected internal void TestProtectedInternalMethod()
        {
            Console.WriteLine(("Reached protected internal method"));
        }
        internal void TestInternalMethod()
        {
            Console.WriteLine(("Reached internal method"));
        }
        protected void TestProtectedMethod()
        {
            Console.WriteLine(("Reached protected method"));
        }
    }
}