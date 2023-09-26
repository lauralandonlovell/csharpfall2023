//Contains menu options for the user to choose from
public class JournalMenu
{
    public string _writeEntry;
    public string _readEntry;
    public string _saveEntry;
    public string _fetchEntry;
    public string _quitJournal;
    List<JournalMenu>_choices = new List<JournalMenu>("1. Write", "2. Read", "3. Save", "4. Load", "5. Quit");

    public void Display()
    {
        foreach (JournalMenu choice in _choices)
        {
           choice.Display();
        }
    }
    

}