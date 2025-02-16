namespace LibraryApp.Models
{
    sealed class Book : LibraryItem 
    {
        private string Title;
        private string Author;
        public Book(string title,string author)
    {
        Title=title;
        Author=author;
        UniqueID= Guid.NewGuid();
        Random random= new Random();
        ShelfNo= random.Next(1,10);
        RowNo =random.Next(1,10);
        
       
    }
        protected override string GetItemLocation()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
           // return base.ToString();
           return   $"{Title} by {Author}";
        }

    }
}

