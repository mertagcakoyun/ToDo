using System.Collections.Generic;
using ToDo.Business.Interfaces;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly IReportDal _reportDal;
        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;

        }
        public void Delete(Report table)
        {
            _reportDal.Delete(table);
        }

        public List<Report> GetAll()
        {
            return _reportDal.GetAll();
        }

        public Report GetWithId(int id)
        {
           return _reportDal.GetWithId(id);
        }

        public void Save(Report table)
        {
            _reportDal.Save(table);
        }

        public void Update(Report table)
        {
            _reportDal.Update(table);
        }
    }
}
