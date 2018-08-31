﻿
namespace M3Pact.Infrastructure
{
    public class BusinessConstants
    {
        public const string SaveSuccess = "Saved Successfully";
        public const string Contract = "Contract";
        public const string Admin = "Admin";
        public const string PartialCompleted = "P";
        public const string RecordStatusActive = "A";
        public const string DEPOSIT_LOG_SAVE_SUCCESS = "Saved Successfully";
        public const string DEPOSIT_LOG_SAVE_FAIL = "Error occured while saving client details";
        public const string M3USERS_GET_FAIL = "Error occured while getting M3users details";
        public const int DEFAULT_TOKEN_LEN = 6;
        public const string NUMERIC = "n";
        public const string SERVER_BASE_ADDRESS = "ServerBaseAddress";
        public const string VIEW_ALL_CHECKLIST_FAIL = "Error occured while getting Checklists";
        public const string YES = "Yes";
        public const string NO = "No";
        public const string DEPOSIT_LOG_ATTRIBUTE_SAVE_FAIL = "Error occured while saving";
        public const string DEPOSIT_LOG_CLOSE_MONTH_FAIL = "failed to close";
        public const string DEPOSIT_LOG_REOPEN_MONTH_FAIL = "failed to reopen";
        public const string DEPOSIT_LOG_REOPEN_MONTH_SUCCESS = "reopened successfully";
        public const string DEPOSIT_LOG_CLOSE_MONTH_SUCCESS = "closed successfully";
        public const string STATUS_UP = "up";
        public const string STATUS_DOWN = "down";
        public const int CENT_VALUE = 100;
        public const string Failed = "Failed";
        public const string Completed = "Completed";
        public const string EscalationStart = "EscalationStart";
        public const string EscalationEnd = "EscalationEnd";

        #region Client Steps
        public const int CLIENTSTEP_STATUS_NEW = 0;
        public const string CLIENT_DATA_SAVE_SUCCESS = "Client Data details saved successfully";
        public const string CLIENT_DATA_SAVE_FAIL = "Error occured while saving client details";
        public const string CLIENT_CODE_EXISTS = "Client Code already exists. Please enter new Client Code";
        #endregion
        

        #region Checklists
        public const string CHECKLIST_OPEN_FAIL = "Failed to open selected checklist";
        public const string CHECKLIST_OPEN_SUCCESS = "Selected checklist is opened successfully";
        #endregion Checklists

        #region User Registration Email
        public const string MAIL_CLIENTUSER_SUBJECT = "M3Pact Registration";
        public const string MAIL_M3USER_SUBJECT = "M3Pact Successful Registration";
        public const string MAIL_BODY = "Hi {1},<br/><br/> Please complete your registration by clicking on following link. <br /> {0} <br/><br/> Please do not reply to this e-mail, this is autogenerated.";
        public const string MAIL_M3USER_BODY = "Hi {0},<br/><br/> You have been successfully registered to M3Pact. <br /> Click on the following link to log in with your M3 credentials. <br /> {1}";
        public const string MAIL_FORMAT = "{0}/login/resetpassword?userid={1}&token={2}";
        public const string M3USER_REDIRECTION = "{0}/login";
        #endregion User Registration Email

        #region Update Password 

        public const string PASSWORD_SAVED = "Password updated succesfully.";
        public const string CANNOT_REUSE_PASSWORD = "Cannot reuse old password. Please select an other password.";
        public const string CHANGE_IN_URL = "Identified change in URL.";
        public const string LINK_EXPIRED = "Link is expired";
        public const string EMAIL_IS_EMPTY = "EmailAddress or PasswordToken is empty.";
        public const string MAIL_FORGOTPWD_SUBJECT = "M3Pact - Reset Password";
        public const string MAIL_FORGOTPWD_BODY = "Hi {1},<br/><br/> Please reset your password by clicking on following link. <br /> {0}";

        #endregion update Password 

        public const string INVALID_USERNAME = "Username is invalid.";
        public const string APPLICATION_ERROR = "Application encountered an error.";
        public const string LINK_EMAILED = "A link has been sent to your email address.";


        public const string ERROR_GET_DETAILS = "Error occured while getting details";
        public const string ERROR_SAVE_DETAILS = "Error Occured while saving details";
        public const string ERROR_OCCURED = "Error occured";
        #region  Email

        public const string MAIL_FROM = "MailFrom";
        public const string MAIL_FROM_DISPLAYNAME = "MailFromDisplayName";
        public const string SMTP_PORT = "SMTPPort";
        public const string SMTP_HOST = "SMTPHost";
        public const string FROM_PASSWORD = "FromPassword";
        public const string USE_DEFAULT_EMAIL_FOR_M3PACT_USER = "UseDefaultEmailForM3PactUser";
        public const string EMAIL_ALREADY_EXIST = "Email Address already exists";

        #endregion  Email

        #region Alert/Escalation Mail
        public const string MAIL_DEVIATED_KPI_BODY_START = "<label>Hi ##RECIPIENTNAME,</label><br><br><label>Please find the deviated KPIs of following client(s).</label><br><br>";
        public const string COLUMN_KPI = "<b>KPI</b>";
        public const string COLUMN_DATE = "<b>Metrics/Checklist of</b>";
        public const string COLUMN_TYPE = "<b>Type</b>";
        public const string COLUMN_SLA = "<b>Is SLA</b>";
        public const string COLUMN_STANDARD = "<b>Standard Value</b>";
        public const string COLUMN_ACTUAL = "<b>Actual Value</b>";
        public const string COLUMN_DEVIATION = "<b>Deviating Since</b>";
        public const string COLUMN_BILLING_MGR = "<b>Billing Manager</b>";
        public const string COLUMN_RELATIONSHIP_MGR = "<b>Relationship Manager</b>";
        public const string MAIL_DEVIATED_KPI_BODY_END = "<br>Please do not reply to this e-mail, this is autogenerated. In case you have any queries/responses, please go to <a href=" + DomainConstants.m3PactLink + ">M3Pact</a>";
        public const string NOT_APPLICABLE = "N/A";
        #endregion Alert/Escalation Mail

    }
    public class Roles
    {
        public const string Admin = "Admin";
        public const string Executive = "Executive";
        public const string User = "User";
        public const string Client = "Client";
        public const string Manager = "Manager";
    }

    public class QuestionTypeConstants
    {
        public const string QuestionTypeCode_Text_Box = "Meridian_Txt_Box";
    }
    
    public class InfoMessages
    {
        public const string ItemEffectiveFrom = "This item will be effective from ";
        public const string ItemUniversalFrom = "This item will become universal from ";
        public const string ItemWillRemoveFrom = "This item will be removed from ";
        public const string ItemNonUniversalFrom = "This item will become non universal from ";
    }
}
