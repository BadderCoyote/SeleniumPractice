using NUnit.Framework;
using SeleniumAutomation.Models;
using System.Collections;

namespace SeleniumAutomation.Data
{
    public  class FillAllTextBoxPageDataSource
    {
        public static IEnumerable FillAllTextBoxPage()
        {
            List<Users> usersList = Enum.GetValues(typeof(Users)).Cast<Users>().ToList();
            foreach (var user in usersList)
            {
                TextBoxData validUserData = user switch
                {
                    Users.Anita => TextBoxDataInstances.Anita,
                    Users.Carlos => TextBoxDataInstances.Carlos,
                    Users.Juan => TextBoxDataInstances.Juan,
                    Users.Mike => TextBoxDataInstances.Mike,
                };

                yield return new TestCaseData(user, validUserData).SetName($"FillAllTextBoxPage{"_With_"+user}");
            }
        }
    }
}
