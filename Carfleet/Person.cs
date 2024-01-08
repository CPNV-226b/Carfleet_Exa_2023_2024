using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Carfleet
{
    public class Person
    {
        #region private attributes
        private readonly string _emailaddress;
        private string _name;
        private string _firstname;
        private string _phonenumber;
        private List<string> _languages = new List<string>();
        #endregion private attributes

        #region public methods
        public Person(string emailaddress, string name, string firstname, string phonenumber, List<string> languages = null)
        {
            //TODO a good place to check the emailaddress (check the private method region)
            _emailaddress = emailaddress;
            _name = name;
            _firstname = firstname;
            _phonenumber = phonenumber;
            _languages = languages;
        }

        public string Emailaddress { get => _emailaddress; }
        public string Name { get => _name; }
        public string Firstname { get => _firstname; }
        public string Phonenumber { get => _phonenumber; }
        public List<string> Languages
        {
            get
            {
                return _languages;
            }
            set
            {
                foreach (string newLanguage in value)
                {
                    if (!_languages.Contains(newLanguage))
                    {
                        _languages.Add(newLanguage);
                    }
                }
            }
        }
        #endregion public methods

        #region private methods
        private bool CheckEmailaddressFormat(string emailAdressToCheck)
        {
            //TODO Help - Try to instantiate a new Object of MailAddress(string email)
            //if the instantiation fails, it means that the mail provided isn't correct.
            throw new NotImplementedException();
        }
        #endregion private methods

        #region nested classes
        public class PersonException : Exception { }
        public class EmailaddressException : Exception { }

        #endregion nested classes
    }
}
