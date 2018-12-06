using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class SqlLhouseDataAccess : ILhouseDataAccess
    {
        private LhouseNquery _nonQuery;
        private LhouseRead _read;
        private SqlConnection _connection;

        public SqlLhouseDataAccess()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ToString());
            _nonQuery = new LhouseNquery(_connection);
            _read = new LhouseRead(_connection);
        }

        public int NewEmployee(EmployeeM employee)
        {
            return _nonQuery.NewEmployee(employee);
        }
        public int NewSubject(SubjectM subject)
        {
            return _nonQuery.NewSubject(subject);
        }
     
        public int AddSpecializationToEmployee(int eId, int sId)
        {
            return _nonQuery.AddSpecializationToEmployee(eId, sId);
        }


        public List<SubjectM> GetSubjects()
        {
            return _read.GetSubjects();
        }
      
        public List<SubjectM> GetEmpSpecializations(int id)
        {
            return _read.GetEmpSpecializations(id);
        }

        public List<EmployeeM> GetEmployees()
        {
            return _read.GetEmployees();
        }


        public int UpdateSubject(SubjectM ls)
        {
            return _nonQuery.UpdateSubject(ls);
        }

        public int UpdateEmployee(EmployeeM emp)
        {
            return _nonQuery.UpdateEmployee(emp);
        }

        public int CloseEmployee(int id)
        {
            return _nonQuery.CloseEmployee(id);
        }

        // To delete
        public int DeleteSubject(int id)
        {
            return _nonQuery.DeleteSubject(id);
        }
    }
}
