using System.IO;

namespace WeeBas.Grammar
{
    public class Cls : ICommand
    {
        public const string Keyword = "cls";

        public static Cls Parse( Input input, TextWriter output )
        {
            return input.ArglessSymbol<Cls>( Keyword );
        }

        public void ExecuteIn( Vm vm )
        {
            vm.Cls();
        }
    }
}