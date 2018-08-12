namespace FontAwesomeCS.CodeGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var faCSRoot = @"..\..\FontAwesomeCS\";

            // Generate mappings
            CodeGenerator.GenerateMappings(faCSRoot + "FontAwesomeCS.cs");

            // Create single-file version
            CodeGenerator.CombineSourceFiles(faCSRoot, @"..\..\FontAwesomeCS.SingleFile\FontAwesomeCS.cs");
        }
    }
}