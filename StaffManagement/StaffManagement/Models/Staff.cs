using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagement.Models
{
    public class Staff
    {
        public string name { get; set; }
        public int Id { get; set; }
    }
    public interface IstaffRespository
    {
        Staff GetStaff(int id);
        IEnumerable<Staff> GetAllStaffs();
    }
    public class MockStaffRepository: IstaffRespository
    {
        private List<Staff> _staffList;
        public MockStaffRepository()
        {
            _staffList = new List<Staff>()
            {

            
            new Staff(){Id = 1, name = "John"},
            new Staff(){Id = 2, name = "John"},
            new Staff(){Id = 3, name = "John"}
            };  
        }
        public Staff GetStaff(int Id)
        {
            return this._staffList.FirstOrDefault(e => e.Id == Id);
        }
        public IEnumerable<Staff> GetAllStaffs()
        {
            return _staffList;
        }

        
    }
}
