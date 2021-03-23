using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15.BLL
{
    class StaffManagement
    {
        private string staffID;
        private string Type;

        public StaffManagement(string staffID, string type)
        {
            this.staffID = staffID;
            Type = type;
        }

        public StaffManagement(){ }
        public override bool Equals(object obj)
        {
            return obj is StaffManagement management &&
                   staffID == management.staffID &&
                   Type == management.Type;
        }

        public override int GetHashCode()
        {
            int hashCode = 1572025329;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(staffID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            return hashCode;
        }
        public LinkedList<Staff> GetStaff(string Type)
        {
            return null;
        }
        public Type AllTypesOfStaffEdits(Type type)//types gee error glo dit moes type wees
        {
            return null;
        }
    }
}
