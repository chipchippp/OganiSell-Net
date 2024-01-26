using Ogani.Models;
using System;
using System.Collections.Generic;

namespace Ogani.Repository
{
    public class LoaiSpRepository : ILoaiSpRepository
    {
        private readonly OganiSellContext _context;

        public LoaiSpRepository(OganiSellContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public TLoaiSp Add(TLoaiSp loaiSp)
        {
            _context.TLoaiSps.Add(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }

        public TLoaiSp Delete(TLoaiSp maloaiSp)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TLoaiSp> GetAllLoaiSp()
        {
            return _context.TLoaiSps;
        }

        public TLoaiSp GetLoaiSp(string maloaiSp)
        {
            return _context.TLoaiSps.Find(maloaiSp);
        }

        public TLoaiSp Update(TLoaiSp loaiSp)
        {
            _context.Update(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }
    }
}
