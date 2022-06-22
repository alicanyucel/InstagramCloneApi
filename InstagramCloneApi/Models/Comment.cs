namespace InstagramCloneApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public  int PhotoId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public virtual User User { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
