namespace MappingLibrary
{
    class AutoMapperClass : MapperClass
    {
        private void AccessMethods()
        {
            TestPrivateProtectedMethod();
            TestProtectedInternalMethod();
            TestInternalMethod();
            TestProtectedMethod();

            MapperClass mapper = new MapperClass();
            mapper.TestProtectedInternalMethod();
            mapper.TestInternalMethod();
            //mapper.TestPrivateProtectedMethod();
            //mapper.TestProtectedMethod();
            ///This class cannot call protected methods of MapperClass
            ///Because the compiler doesnt know what actually MapperClass is.
        }
    }
}
