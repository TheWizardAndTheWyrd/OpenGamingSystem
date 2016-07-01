namespace AuthenticationApi.Models
{
    using OpenGamingSystem.Entities.Authentication;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AuthenticationContext : DbContext
    {
        // Your context has been configured to use a 'AuthenticationContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'AuthenticationApi.Models.AuthenticationContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AuthenticationContext' 
        // connection string in the application configuration file.
        public AuthenticationContext()
            : base("name=AuthenticationContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<ChangeEmailModel> ChangeEmailModels { get; set; }
        public virtual DbSet<ChangePasswordModel> ChangePasswordModels { get; set; }
        public virtual DbSet<ChangeSecurityQuestionModel> ChangeSecurityQuestions { get; set; }
        public virtual DbSet<EmailModel> EmailModels { get; set; }
        public virtual DbSet<ForgotPasswordChangeModel> ForgotPasswordChangeModels { get; set; }
        public virtual DbSet<ForgotPasswordModel> ForgotPasswordModels { get; set; }
        public virtual DbSet<GetVerificationTokenModel> GetVerificationTokenModels { get; set; }
        public virtual DbSet<LoginModel> LoginModels { get; set; }
        public virtual DbSet<RegistrationAdditionalData> RegistrationAdditionalData { get; set; }
        public virtual DbSet<RegistrationModel> RegistrationModels { get; set; }
        public virtual DbSet<SendVerificationSMSModel> SendVerificationSMSModels { get; set; }
        public virtual DbSet<VerifyUserBySMSModel> VerifyUserBySMSModels { get; set; }
    }
}