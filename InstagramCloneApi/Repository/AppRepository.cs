using AutoMapper;
using InstagramCloneApi.Data;
using InstagramCloneApi.Dtos;
using InstagramCloneApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace InstagramCloneApi.Repository
{
    public class AppRepository : IRepository
    {
        private IMapper _mapper;
        private DataContext _context;
        public AppRepository(DataContext context, IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<Comment> GetComments()
        {
            var cmn = _context.Comments.ToList();
            return cmn;

        }

        //public Like GetLikeById(int Likeid)
        //{
        //    var like = _context.Likes.Include(c => c.PhotoId).FirstOrDefault(c => c.PhotoId == Likeid);
        //    return like;
        //}

        public Photo GetPhoto(int id)
        {
            var photo = _context.Photos.FirstOrDefault(p => p.Id == id);
            return photo;

        }

        public List<Photo> GetPhotosByUser(int id)
        {
            var photos = _context.Photos.Where(p => p.Id == id).ToList();
            return photos;
        }

        public List<UsersDto> GetUsers()
        {
            var userList = _context.Users.ToList();

            var users = _mapper.Map<List<UsersDto>>(userList);

            return users;
            
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
