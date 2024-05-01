﻿using LibraryApp.Models;

namespace LibraryApp.Interfaces
{
    public interface INewsRepository
    {
        ICollection<News> GetNews();
        News GetNewsById(int id);
        bool NewsExists(int id);
        bool CreateNews(News news);
        bool Save();
    }
}