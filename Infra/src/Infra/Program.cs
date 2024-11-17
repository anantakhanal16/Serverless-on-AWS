using Amazon.CDK;
using Infrastructure.Stacks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new BaseStack(app, "BaseStack", new StackProps
            {
            });
            app.Synth();
        }
    }
}
