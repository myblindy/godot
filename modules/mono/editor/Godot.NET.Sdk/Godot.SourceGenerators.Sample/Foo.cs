namespace Godot.SourceGenerators.Sample
{
    public partial class Foo : GodotObject
    {
    }

    // Foo again in the same file
    public partial class Foo
    {
        public int P { get; set; }
        public static int SP { get; set; }
        public static void Fn(int x) { }
    }
}
