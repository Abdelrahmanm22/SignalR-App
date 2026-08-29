using Microsoft.AspNetCore.SignalR;
using SignalRTestApp.Models;

namespace SignalRTestApp.Hubs
{
    public class ChatHub : Hub
    {
        ChatContext _db;
        public ChatHub(ChatContext db)
        {
            _db = db;
        }
        public void sendmessage(string name, string message)
        {
            //broadcast to all clients
            Clients.All.SendAsync("newmessage", name, message);
            
            //save in database
            message mess = new message()
            {
                username = name,
                messagetxt = message,
            };
            _db.messages.Add(mess);
            _db.SaveChanges();
            
        }
    }
}
