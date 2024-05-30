using KP_Dykun_Classes;
using OfficeLab;

string fileName = "TestDoc";
string fullName = $"{Directory.GetCurrentDirectory()}\\{fileName}.xlsx";
using (ExcelDoc excelDoc = new ExcelDoc()) {
    Companion comp = new Companion("Login", "12345", "+38(097)-0455689", "Diana");
    Companion driv = new ("Login", "12345", "+38(097)-0455689", "AAA");
    // administrator = new Administrator("Admin", "333456");
    List<Companion> users = [comp, driv];

    for (int i = 0; i < users.Count; i++)
        excelDoc[i+1, 1] = users[i].CompanionInfo();
    
    excelDoc.SaveAs(fullName);
}
    Thread.Sleep(3000);

string fileNameDoc = "TestWordDoc";
string fullNameDoc = $"{Directory.GetCurrentDirectory()}\\{fileNameDoc}.docx";
using (WordDoc wordDoc = new WordDoc())
{
    
    Companion comp2 = new Companion("Login", "12345", "+38(097)-0455689", "Diana");
    Companion driv2 = new("Login", "12345", "+38(097)-0455689", "AAA");
    List<Companion> users2 = [comp2, driv2];

    for (int i = 0; i < users2.Count; i++)
        wordDoc[i + 1] = users2[i].CompanionInfo();

    wordDoc.CreateTable(users2.Count, 3, "Таблиця 1 – Список попутників");

    for (int i = 0; i < users2.Count; i++)
    {
        string Info = users2[i].CompanionInfo();
        string[] splitInfo = Info.Split(",");

        for (int j = 0; j < splitInfo.Length; j++)
        {
            wordDoc[i + 1, j + 1] = splitInfo[j];
        }
    }
    wordDoc.SaveAs(fullNameDoc);
}
Thread.Sleep(6000);