﻿using LibraryApp.Models;

namespace LibraryApp.Interfaces
{
    public interface ICollectionRepository
    {
        ICollection<Collection> GetCollections();
        Collection GetCollection(int id);
        ICollection<Book> GetBooksByCollection(int collectionId);
        ICollection<Collection> GetCollectionByBook(int id);
        bool CollectionExists(int id);
    }
}
