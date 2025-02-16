namespace LibraryApp.Models
{
    sealed class Film : LibraryItem
    {

        private string Title ;

        private string Producedby ;
        private StorageType  StorageType;
        public Film(string title, StorageType storageType, string producedby)
        {
            Title = title;
            StorageType = storageType;
            Producedby =producedby;
            UniqueID= Guid.NewGuid();
            Random random= new Random();
            ShelfNo= random.Next(1,10);
            RowNo =random.Next(1,10);
        }

        public override string ToString()
        {
            return $"{Title} produced by {Producedby} ({StorageType})";
        }
        protected override string GetItemLocation()
        {
            throw new NotImplementedException();
        }
    }
}

