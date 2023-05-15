namespace DemoPortfal_IceCodeTest.Data
{
    public enum Status
    {
        Success,
        Error
    }
    public class Message
    {
        public int ID {get; set;}
        public int Number {get; set;} = 12134521;

        public String? Content {get; set;}
        public int Response {get; set;} = 12134521;
        public Status Status {get; set;}
        public DateTime CreatedAt { get; set; }
        public DateTime ResponseAt { get; set; }


        
    }
}