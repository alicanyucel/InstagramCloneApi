using System.Collections.Generic;
using InstagramCloneApi.Dtos;
using InstagramCloneApi.Models;
namespace InstagramCloneApi.Repository
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll();
        List<Comment> GetComments();
        List<UsersDto> GetUsers();
        List<Photo> GetPhotosByUser(int id);
        //Like GetLikeById(int Likeid);
        Photo GetPhoto(int id);
        void Update<T>(T entity) where T : class;
    }
}
