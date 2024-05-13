using HomeTaskDocument;

namespace Document;
public static class Program
{
    public static void Main()
    {
        Return:  Console.Write("Enter your edition: ");
        string edition = Console.ReadLine();
        switch (edition)
        {
            case "basic":
                BasicDocument document = new BasicDocument();
                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();
                break;
            case "pro":
                ProDocument prodocument = new ProDocument();
                prodocument.OpenDocument();
                prodocument.EditDocument();
                prodocument.SaveDocument();
                break;
            case "expert":
                ExpertDocument expertdocument = new ExpertDocument();
                expertdocument.OpenDocument();
                expertdocument.EditDocument();
                expertdocument.SaveDocument();
                break;
            default: goto Return;
        }
        
    }
}