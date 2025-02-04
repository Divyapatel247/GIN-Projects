string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

// Console.WriteLine(corporate[0,1]); 

string externalDomain = "@hayworth.com";

void PrintMail(int row,string externalDomain = "@contoso.com")
{

    Console.WriteLine((corporate[row, 0].Substring(0, 2).ToLower() + corporate[row, 1].ToLower()) + externalDomain);
}

for (int i = 0; i < corporate.GetLength(0); i++)
{
   PrintMail(i);
}



for (int i = 0; i < external.GetLength(0); i++)
{
    PrintMail(i,externalDomain);
}
