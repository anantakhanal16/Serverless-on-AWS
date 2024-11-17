using Amazon.CDK;
using Infrastructure.Stacks;

namespace ServerlessMoneyTransfer
{
    class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new CognitoStack(app, "CognitoStack");
            app.Synth();
        }
    }
}
