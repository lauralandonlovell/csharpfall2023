public class Journal
{
   public string _writeEntry;
   public string _readEntry;
   public string _saveEntry;
   
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
   }
   public static void StreamWriter()
   {

   }

}