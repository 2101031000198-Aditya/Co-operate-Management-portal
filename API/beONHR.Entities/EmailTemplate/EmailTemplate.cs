﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beONHR.Entities.EmailTemplate
{
    public class EmailTemplate
    {
        public string forgetpassword = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <title></title>\r\n    <style>\r\n        a {\r\n            border-radius: 1px;\r\n            line-height: 120%;\r\n            display: inline-block;\r\n            text-decoration: none;\r\n            text-align: center;\r\n            padding: 15px 40px;\r\n            background-color: rgb(3, 118, 250);\r\n            color: rgb(255, 255, 255);\r\n            width: auto;\r\n            max-width: 100%;\r\n            overflow-wrap: break-word;\r\n            font-size: 14px;\r\n            position: relative;\r\n        }\r\n    p{\r\n            font-size: 25px;\r\n            text-align: center;\r\n        }  </style></head>\r\n<body>\r\n    <p>\r\n   <strong>Hello {{UserName}},</strong> <br />\r\n   We have sent you this email in response to your request to reset your password on BeoN.\r\n    <br><br>       Click on the following link to reset your password. <br /><br />\r\n\r\n        <a href=\"{{Link}}\">Reset password</a>\r\n</body>\r\n</html>";
        public string applyleave= "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <style>\r\n      body { font-family: Arial, sans-serif; }\r\n        .email-container { background-color: #f4f4f4; padding: 20px; }\r\n        .email-content { background-color: #ffffff; padding: 20px; margin: 20px 0; border-radius: 10px; border: 1px solid #ddd; }\r\n        .header { color: #444; }\r\n        .footer { font-size: 12px; color: #999; }\r\n    </style>\r\n</head>\r\n<body>\r\n    <div class=\"email-container\">\r\n        <div class=\"email-content\">\r\n            <h1 class=\"header\">Leave Application</h1>\r\n            <p>Dear {{UserName}},</p>\r\n            <p>{{EmployeeName}} writing to formally request a leave of absence for personal reasons from {{StartDate}} to {{EndDate}}. I have ensured that all my duties are up to date and have delegated my responsibilities adequately to ensure the continuity of workflow in my absence.</p>\r\n            <p>Please let me know if you need any further information or have any other requirements for this leave application.</p>\r\n            <p>Thank you for considering my request. I look forward to your approval.</p>\r\n            <p>Best regards,</p>\r\n            <p>{{EmployeeName}}<br></p>\r\n        </div>\r\n        <div class=\"footer\">\r\n            <p>This is an automated message. Please do not reply directly to this email.</p>\r\n        </div>\r\n    </div>\r\n</body>\r\n</html>\r\n";
        public string actionOnleave= "<!DOCTYPE html><html>\r\n\r\n<head> <style>\r\n    .Rejected {color: Red;}  .Approved {color:Green;}  body {\r\n      font-family: Arial, sans-serif;\r\n    }\r\n\r\n     .email-container {\r\n      background-color: #f4f4f4;\r\n      padding: 20px;\r\n    }\r\n\r\n     .email-content {\r\n      background-color: #ffffff;\r\n      padding: 20px;\r\n      margin: 20px 0;\r\n      border-radius: 10px;\r\n      border: 1px solid #ddd;\r\n    }\r\n\r\n     .header {\r\n      color: #444;\r\n    }\r\n\r\n     .footer {\r\n      font-size: 12px;\r\n      color: #999;\r\n    }\r\n\r\n    \r\n  </style></head>\r\n\r\n<body><div class=\"email-container\"><div class=\"email-content\"> <h1 class=\"header\">Leave Request Action\r\n      </h1> <p>Dear {{EmployeeName}},</p> <p>We have received your leave request for{{StartDate}} To {{EndDate}}. After reviewing your application and considering the team's workload, we <strong class=\"{{Action}}\">{{Action}}</strong> your leave.</p> <p>Please\r\n        let me know if you need any further information or have any other requirements for this leave application.</p>\r\n        <p>If you have any questions or need further assistance, please feel free to contact HR.</p> <p>Best regards,</p>\r\n      <p>{{leaderName}}<br></p> </div> <div class=\"footer\"> <p>This is an automated message. Please do\r\n        not reply directly to this email.</p> </div> </div></body>\r\n\r\n</html>";
    }
}
