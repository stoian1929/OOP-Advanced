namespace BashSoft.Executor
{
    using BashSoft.Executor.Contracts;
    using System;

    public class InputReader : IReader
    {
        private const string endCommand = "quit";
        private ICommandInterpreter interpreter;

        public InputReader(ICommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }
        public  void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}" + "> ");
            string input = Console.ReadLine().Trim();

            while (input != endCommand)
            {
                this.interpreter.InterpretCommand(input);
                OutputWriter.WriteMessage($"{SessionData.currentPath}" + "> ");
                input = Console.ReadLine().Trim();
            }
        }
    }
}
