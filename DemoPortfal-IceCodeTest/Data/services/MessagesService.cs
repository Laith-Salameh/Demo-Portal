namespace DemoPortfal_IceCodeTest.Data
{
    public class MessagesService
    {
        public Task<List<Message>> GetMessagesAsync(int startID,DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 10).Select(index => 
            {
                Status status = (new Random()).Next(0,10) % 2 == 0 ? Status.Success : Status.Error ;
                return new Message{
                    CreatedAt = startDate.AddDays(index),
                    ResponseAt = startDate.AddDays(index + 1),
                    ID= startID + index,
                    Content = status == Status.Success? "Your order recived Succefully!" : "Your order recived Failed!",
                    Status= status,
                };
            
            }).ToList());
        }
    }
}