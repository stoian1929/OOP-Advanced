namespace BashSoft.Commands
{
    using System.Diagnostics;
    using BashSoft.IO.Executor;
    using BashSoft.Judge.Contracts;
    using BashSoft.Repository.Contracts;
    using Execptions;

    public class OpenFileCommand : Command
    {
        public OpenFileCommand(string input, string[] data, IContentComparer judge, IDatabase repository, IDirectoryManager inputOutputManager)
            : base(input, data, judge, repository, inputOutputManager)
        {
            
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            var filename = this.Data[1];
            Process.Start(SessionData.currentPath + "\\" + filename);
        }
    }
}
