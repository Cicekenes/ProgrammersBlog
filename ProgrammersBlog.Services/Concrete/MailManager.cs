﻿using Microsoft.Extensions.Options;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.DTOs.ContactDTOs;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using ProgrammersBlog.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Concrete
{
    public class MailManager : IMailService
    {
        private readonly SmtpSettings _smtpSettings;

        public MailManager(IOptions<SmtpSettings> smtpSettings)
        {
            _smtpSettings = smtpSettings.Value;
        }

        public IResult Send(EmailSendDto emailSendDto)
        {
            MailMessage message = new MailMessage()
            {
                From = new MailAddress(_smtpSettings.SenderEmail), //Kişi adı
                To = { new MailAddress(emailSendDto.Email) }, //kime gelecek
                Subject = emailSendDto.Subject,
                IsBodyHtml = true,
                Body = emailSendDto.Message
            };
            SmtpClient smtpClient = new SmtpClient()
            {
                Host = _smtpSettings.Server,
                Port = _smtpSettings.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(message);
            return new Result(ResultStatus.Success, $"E-Postanız başarıyla gönderilmiştir.");
        }

        public IResult SendContactEmail(EmailSendDto emailSendDto)
        {
          

            MailMessage message = new MailMessage()
            {
                From = new MailAddress(_smtpSettings.SenderEmail,"ProgrammersBlog İletişim",System.Text.Encoding.UTF8), //Kişi adı
                To = { new MailAddress("siteadmin@gmail.com") }, //kime gelecek
                Subject = emailSendDto.Subject,
                IsBodyHtml = true,
                Body = $"<strong> Gönderen Kişi : {emailSendDto.Name}, Gönderen E-Posta Adresi: {emailSendDto.Email}<strong/> <br/> {emailSendDto.Message}"
            };
            SmtpClient smtpClient = new SmtpClient()
            {
                Host = _smtpSettings.Server,
                Port = _smtpSettings.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpSettings.Username,_smtpSettings.Password),
                DeliveryMethod=SmtpDeliveryMethod.Network
            };
            smtpClient.Send(message);
            return new Result(ResultStatus.Success,$"E-Postanız başarıyla gönderilmiştir.");
        }
    }
}

