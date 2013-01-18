using System;
using System.Diagnostics;

namespace JSPerf
{
    class Program
    {
        private const string script = @"
            var o = {};
            o.Foo = 'bar';
            o.Baz = 42;
            o.Blah = o.Foo + o.Baz;
        ";

        static void Main(string[] args)
        {
            const int iterations = 1000;
            const bool reuseEngine = false;

            var watch = new Stopwatch();

            var jint = new Jint.JintEngine();
            
            watch.Restart();
            for (var i = 0; i < iterations; i++)
            {
                if (!reuseEngine)
                {
                    jint = new Jint.JintEngine();
                }

                jint.Run(script);
            }

            Console.WriteLine("Jint: {0} iterations in {1} ms", iterations, watch.ElapsedMilliseconds);
            
            var jurassic = new Jurassic.ScriptEngine();

            watch.Restart();
            for (var i = 0; i < iterations; i++)
            {
                if (!reuseEngine)
                {
                    jurassic = new Jurassic.ScriptEngine();
                }

                jurassic.Execute(script);
            }

            Console.WriteLine("Jurassic: {0} iterations in {1} ms", iterations, watch.ElapsedMilliseconds);

        }
    }
}
