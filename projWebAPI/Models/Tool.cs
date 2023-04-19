namespace projWebAPI.Models
{
    public class Tool
    {
        public readonly static string GETALL = "Select Id, Description from Tool";
        public readonly static string INSERT = "Insert into Tool (Description) values (@Description)";

        public int Id { get; set; }
        public string Description { get; set; }
    }
}
