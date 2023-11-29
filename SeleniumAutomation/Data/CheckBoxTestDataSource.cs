using NUnit.Framework;
using SeleniumAutomation.Models;
using System.Collections;


namespace SeleniumAutomation.Data
{
    public class CheckBoxTestDataSource
    {
        public static IEnumerable CheckBoxTest()
        {
            List<CheckBoxOptions> checkBoxOptionsList = Enum.GetValues(typeof(CheckBoxOptions)).Cast<CheckBoxOptions>().ToList();
            var checkBoxDocumentsList = Enum.GetValues(typeof(CheckBoxDocuments)).Cast<CheckBoxDocuments>().ToList();
            var checkBoxDesktopSubsectionList = new List<CheckBoxSubsection>
            {
                CheckBoxSubsection.Notes,
                CheckBoxSubsection.Commands,
            };
            var checkBoxDocumentsSubsectionList = new List<CheckBoxSubsection>
            {
                CheckBoxSubsection.Workspace,
                CheckBoxSubsection.Office,
            };
            var checkBoxDownloadsSubsectionList = new List<CheckBoxSubsection>
            {
                CheckBoxSubsection.WordFile,
                CheckBoxSubsection.ExcelFile,
            };
            var checkBoxWorkspaceDocumentList = new List<CheckBoxDocuments>
            {
                CheckBoxDocuments.React,
                CheckBoxDocuments.Angular,
                CheckBoxDocuments.Veu,
            };
            var checkBoxOfficeDocumentList = new List<CheckBoxDocuments>
            {
                CheckBoxDocuments.Public,
                CheckBoxDocuments.Private,
                CheckBoxDocuments.Classified,
                CheckBoxDocuments.General,
            };

            foreach (var checkBoxOptionsActual in checkBoxOptionsList)
            {
                List<CheckBoxSubsection> checkSubsectionList = checkBoxOptionsActual switch
                {
                    CheckBoxOptions.Desktop => checkBoxDesktopSubsectionList,
                    CheckBoxOptions.Documents => checkBoxDocumentsSubsectionList,
                    CheckBoxOptions.Downloads => checkBoxDownloadsSubsectionList,
                };

                foreach (var checkBoxSubsectionActual in checkSubsectionList)
                {

                    if (checkBoxSubsectionActual == CheckBoxSubsection.Workspace || checkBoxSubsectionActual == CheckBoxSubsection.Office)
                    {
                        foreach (var checkBoxDocumentActual in checkBoxSubsectionActual == CheckBoxSubsection.Workspace ? checkBoxWorkspaceDocumentList : checkBoxOfficeDocumentList)
                        {
                            yield return new TestCaseData(checkBoxOptionsActual, checkBoxSubsectionActual, checkBoxDocumentActual)
                                .SetName($"CheckBoxPageTest{checkBoxOptionsActual}_{checkBoxSubsectionActual}_{checkBoxDocumentActual}");
                        }
                    }
                    else
                    {
                        yield return new TestCaseData(checkBoxOptionsActual, checkBoxSubsectionActual, checkBoxDocumentsList = null)
                            .SetName($"CheckBoxPageTest{checkBoxOptionsActual}_{checkBoxSubsectionActual}");
                    }
                }
            }
        }
    }
}


