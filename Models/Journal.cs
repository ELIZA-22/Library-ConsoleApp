namespace LibraryApp.Models
{
    class Journal : LibraryItem
    {
        private string PublishedBy;
        private string Author;
        private string Title;
        private DateTime DatePublished;

        public Journal(string publishedBy ,string author,string title ,DateTime datePublished)                 
        {
           PublishedBy=publishedBy;
           Author= author;
           DatePublished= datePublished;
           Title =title;
           UniqueID= Guid.NewGuid();
           Random random= new Random();
           ShelfNo= random.Next(1,10);
           RowNo =random.Next(1,10);

            
        }

        public override string ToString()
        {
            return $"{Title} by {Author} published by {PublishedBy} on {DatePublished.ToShortDateString()}";
        }
        protected override string GetItemLocation()
        {
            throw new NotImplementedException();
        }
    }
}
  
