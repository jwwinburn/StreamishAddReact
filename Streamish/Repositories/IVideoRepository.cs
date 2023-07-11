﻿using System.Collections.Generic;
using Streamish.Models;

namespace Streamish.Repositories
{
    public interface IVideoRepository
    {
        void Add(Video video);
        void Delete(int id);
        List<Video> GetAll();
        Video GetById(int id);
        void Update(Video video);
        void GetAllWithComments();
    }
}