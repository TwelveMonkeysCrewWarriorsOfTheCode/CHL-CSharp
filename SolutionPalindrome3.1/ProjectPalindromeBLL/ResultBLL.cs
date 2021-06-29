using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPalindromeBLL
{
    public enum Status
    {
        error,      // Error in method
        ispalindrome, // C'est un Palindrome
        isnotpalindrome // Ce n'est pas un palindrome
    }

    /// <summary>
    /// Class To Return The Status
    /// </summary>
    public class ResultBLL
    {
        public ResultBLL(Status pStatus, string pMessageDev, string pMessageExc)
        {
            m_status = pStatus;
            m_messageDev = pMessageDev;
            m_messageExc = pMessageExc;
        }
        private Status m_status;
        public Status PStatus
        {
            get => m_status;
            private set => m_status = value;
        }
        private string m_messageDev; // Error message from developper
        private string m_messageExc; // Error message from exception
        public string PMessageDev
        {
            get => m_messageDev;
            private set => m_messageDev = value;
        }
        public string PMessageExc
        {
            get => m_messageExc;
            private set => m_messageExc = value;
        }
    }
}
/*
class Person : IPerson
{
    public Person(string firstName, string lastName)
    {

        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            throw new System.ArgumentException();

        this.FirstName = firstName;
        this.LastName = lastName;

    }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

}

...

class PersonFactory : IPersonFactory
{
    public IPerson CreatePerson(string firstName, string lastName)
    {
        return new Person(firstName, lastName);
    }
}
...
void Consumer(IPersonFactory factory)
{
    IPerson person = factory.CreatePerson("John", "Doe");
    Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
}
*/