using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public class WatchServices : IWatchServices
    {
        private readonly WatchShopDbContext context;
        private readonly IMapper mapper;


        public WatchServices(WatchShopDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }



        public IEnumerable<WatchDto> GetAll()
        {
            var watches = context.Watches.Include(x => x.ClockFace).ToList();
            return mapper.Map<IEnumerable<WatchDto>>(watches);
        }



        public WatchDto? GetById(int id)
        {
            var watches = context.Watches.Find(id);

            if (watches == null) return null;
            return mapper.Map<WatchDto>(watches);
        }


        public void Create(WatchDto watches)
        {
            context.Watches.Add(mapper.Map<Watch>(watches));
            context.SaveChanges();
        }


        public void Edit(WatchDto watches)
        {
            var data = context.Watches.AsNoTracking().FirstOrDefault(w => w.Id == watches.Id);

            if (data == null) return;

            context.Watches.Update(mapper.Map<Watch>(watches));
            context.SaveChanges();
        }


        public void Delete(int id)
        {
            var watches = context.Watches.Find(id);

            if (watches == null) return;

            context.Watches.Remove(watches);
            context.SaveChanges();
        }
    }
}