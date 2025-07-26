using OnlineStore.BlazorUI.Models;

namespace OnlineStore.BlazorUI.SampleData
{
    public static class MyRolesData
    {
        private static List<Roles> roles = new List<Roles>()
        {
           new Roles(){RoleId = 1 , RoleName = "User" , IsDeleted= false},
           new Roles(){RoleId = 2 , RoleName = "Admin" , IsDeleted = false},
           new Roles(){RoleId = 3 , RoleName = "Guest" , IsDeleted = false}
        };
        public static void Add(Roles obj)
        {
            obj.RoleId = roles.Max(x => x.RoleId) + 1;
            roles.Add(obj);
        }
        public static List<Roles> GetAllRoles() => roles.Where(x => !x.IsDeleted).ToList();
        public static Roles GetRoleByID(int id) => roles.FirstOrDefault(x => x.RoleId == id && !x.IsDeleted);
        public static void Update(int id,Roles obj)
        {
            if (id !=obj.RoleId) return;
            var result = GetRoleByID(id);
            if(result != null)
            {
                result.RoleName = obj.RoleName;
            }
        }
        public static void Remove (int id)
        {
            var result = GetRoleByID(id);
            if(result != null)
            {
                result.IsDeleted = true;
            }
        }
    }

}
