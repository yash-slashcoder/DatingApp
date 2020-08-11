using System;

namespace DatingApp.API.Dtos
{
    public class MessageForCreationDto
    {
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public DateTime Messagesent { get; set; }
        public string Content { get; set; }

        public MessageForCreationDto()
        {
            Messagesent = DateTime.Now;
        }

    }
}