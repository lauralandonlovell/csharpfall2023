using System.Transactions;

public class Journal
{
   public string _writeEntry;
   public string _readEntry;
   public string _saveEntry;
   public string _menuChoice;
   public string _loadEntry;
   public string _quitJournal;
   public 
   Journal()
   {
   }

   public void Display()
   {
      
      Console.WriteLine(_writeEntry);
      Console.WriteLine(_readEntry);
      Console.WriteLine(_saveEntry);
      Console.WriteLine(_loadEntry);
      Console.WriteLine(_quitJournal);
      Console.WriteLine("Enter the number of your choice: ");
      _menuChoice = Console.ReadLine();
   }
   public static void StreamWriter()
   {

   }

}