using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SapphireDb;

namespace chatPM_back.Context
{
    public class ChatContext : SapphireDbContext
    {
        

        public ChatContext(DbContextOptions<ChatContext> options, SapphireDatabaseNotifier notifier) : base(options, notifier)
        {

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Message> Messages { get; set; }
    }

    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string Name { get; set; }
    }

    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public string Content { get; set; }
        public string UserID { get; set; }
        public DateTime Date { get; set; }
    }
}