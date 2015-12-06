namespace _04.GenericListVersion
{
    using System;
    using _03.GenericList;

    class MainProgram
    {
        static void Main()
        {
            GenericList<int> gl = new GenericList<int>();
            gl.Add(12);

            Console.WriteLine(gl.Version());
        }
    }
}
