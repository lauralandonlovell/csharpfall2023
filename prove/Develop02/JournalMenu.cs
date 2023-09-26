//Contains menu options for the user to choose from
public class JournalMenu
{
    public string _writeEntry;
    public string _readEntry;
    public string _saveEntry;
    public string _fetchEntry;
    public string _quitJournal;
    public JournalMenu()
    {
    }

    public void Display()
    {
        foreach (JournalMenu choice in _choices)
        {
           choice.Display();
        }
    }
    

}