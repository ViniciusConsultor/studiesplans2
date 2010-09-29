using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
using StudiesPlansModels.Helpers;
using System.Data.Entity;

namespace StudiesPlansWeb.Providers
{
	public class SPMembershipProvider : MembershipProvider
	{
		private string connectionString;
		private IUsersRepository repository;

		public SPMembershipProvider()
			: this(new UsersRepository())
		{
		}

		public SPMembershipProvider(IUsersRepository repository)
		{
			this.repository = repository;
		}

		public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
		{
            //string connStringName = config["connectionStringName"];

            //if (string.IsNullOrEmpty(connStringName))
            //    throw new ArgumentNullException("Provider's connection string name");

            //this.connectionString = StudiesPlansModels.Helpers.Connection.GetDatabaseConnectionString(connStringName);

            //if (string.IsNullOrEmpty(this.connectionString))
            //    throw new ArgumentNullException(connStringName + " connection string");

			base.Initialize(name, config);
		}

		public override string ApplicationName
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public override bool ChangePassword(string username, string oldPassword, string newPassword)
		{
            throw new NotImplementedException();
            //User user = this.repository.GetUser(username);

            //if (user == null)
            //    return false;

            //if (string.Compare(oldPassword, user.Password, true) == 0)
            //{
            //    this.repository.UpdateUser(new UserPasswordEdit()
            //    {
            //        UserID_2 = user.UserID,
            //        UserName_2 = user.Name,
            //        Password_2 = newPassword
            //    });

            //    return true;
            //}
            //else
            //    return false;
		}

		public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
		{
			throw new NotImplementedException();
		}

		public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
		{
			throw new NotImplementedException();
		}

		public override bool DeleteUser(string username, bool deleteAllRelatedData)
		{
			throw new NotImplementedException();
		}

		public override bool EnablePasswordReset
		{
			get { throw new NotImplementedException(); }
		}

		public override bool EnablePasswordRetrieval
		{
			get { throw new NotImplementedException(); }
		}

		public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
		{
			throw new NotImplementedException();
		}

		public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
		{
			throw new NotImplementedException();
		}

		public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
		{
			throw new NotImplementedException();
		}

		public override int GetNumberOfUsersOnline()
		{
			throw new NotImplementedException();
		}

		public override string GetPassword(string username, string answer)
		{
            throw new NotImplementedException();
            //User user = this.repository.GetUser(username);

            //if (user == null)
            //    return null;
            //else
            //    return user.Password;
		}

		public override MembershipUser GetUser(string username, bool userIsOnline)
		{
			User user = this.repository.GetUser(username);

			if (user == null)
				return null;

			return new MembershipUser(
				this.Name,
				user.Name,
				user.UserID,
				user.Email,
				null,
				null,
				true,
				false,
				DateTime.UtcNow,
                user.LastActiveDate.HasValue ? user.LastActiveDate.Value : DateTime.UtcNow,
				DateTime.UtcNow,
				DateTime.UtcNow,
				DateTime.UtcNow
				);
		}

		public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
		{
			throw new NotImplementedException();
		}

		public override string GetUserNameByEmail(string email)
		{
			throw new NotImplementedException();
		}

		public override int MaxInvalidPasswordAttempts
		{
			get { throw new NotImplementedException(); }
		}

		public override int MinRequiredNonAlphanumericCharacters
		{
			get { throw new NotImplementedException(); }
		}

		public override int MinRequiredPasswordLength
		{
			get { throw new NotImplementedException(); }
		}

		public override int PasswordAttemptWindow
		{
			get { throw new NotImplementedException(); }
		}

		public override MembershipPasswordFormat PasswordFormat
		{
			get { throw new NotImplementedException(); }
		}

		public override string PasswordStrengthRegularExpression
		{
			get { throw new NotImplementedException(); }
		}

		public override bool RequiresQuestionAndAnswer
		{
			get { throw new NotImplementedException(); }
		}

		public override bool RequiresUniqueEmail
		{
			get { throw new NotImplementedException(); }
		}

		public override string ResetPassword(string username, string answer)
		{
			throw new NotImplementedException();
		}

		public override bool UnlockUser(string userName)
		{
			throw new NotImplementedException();
		}

		public override void UpdateUser(MembershipUser user)
		{
			throw new NotImplementedException();
		}

		public override bool ValidateUser(string username, string password)
		{
            //throw new NotImplementedException();
            User user = this.repository.GetUser(username);

            if (user == null)
                return false;

            string passwordHash = this.repository.HashPassword(password);

            if (string.Compare(passwordHash, user.Password, true) == 0)
            {
                

                return true;
            }
            else
                return false;
		}
	}
}