using Amazon.CDK;
using Amazon.CDK.AWS.Cognito;
using Constructs;

namespace Infrastructure.Stacks
{
    public class BaseStack : Stack
    {
        public BaseStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
          
            // Create a Cognito User Pool
            var userPool = new UserPool(this, "MyUserPool", new UserPoolProps
            {
                SelfSignUpEnabled = true,
                SignInAliases = new SignInAliases { Username = true, Email = true },
                PasswordPolicy = new PasswordPolicy
                {
                    MinLength = 8,
                    RequireLowercase = true,
                    RequireUppercase = true,
                    RequireDigits = true,
                    RequireSymbols = true
                },
                Mfa = Mfa.OPTIONAL,
                MfaSecondFactor = new MfaSecondFactor { Sms = true, Otp = true }
            });

            // Create a Cognito User Pool Client
            var appClient = userPool.AddClient("AppClient", new UserPoolClientOptions
            {
                GenerateSecret = false,
                AuthFlows = new AuthFlow
                {
                    UserPassword = true,
                    AdminUserPassword = true
                },
                OAuth = new OAuthSettings
                {
                    Flows = new OAuthFlows { AuthorizationCodeGrant = true, ImplicitCodeGrant = true },
                    Scopes = new[] { OAuthScope.EMAIL, OAuthScope.OPENID, OAuthScope.PROFILE },
                    CallbackUrls = new[] { "https://yourapp.com/callback" }
                }
            });
          

        }
    }
}
