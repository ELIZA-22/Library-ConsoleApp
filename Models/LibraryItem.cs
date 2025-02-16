using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    

    abstract class LibraryItem
    {

      protected Guid UniqueID { get; set;}
      protected int ShelfNo { get; set;}
      protected int RowNo { get; set;}
      protected abstract string GetItemLocation();

    }
}

