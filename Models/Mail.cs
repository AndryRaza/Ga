using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesAbsencesv1.Models
{
    class Mail
    {
        string _mailOf;
        string _mailTo;
        string _object;
        string _message;

        public Mail(string mailOf, string mailTo, string objec, string message)
        {
            _mailOf = mailOf;
            _mailTo = mailTo;
            _object = objec;
            _message = message;
        }

        public string MailOf
        {
            get
            {
                return _mailOf;
            }
        }

        public string MailTo
        {
            get
            {
                return _mailTo;
            }
        }

        public string Object
        {
            get
            {
                return _object;
            }
        }

        public string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
