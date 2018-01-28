using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbertEinsteinCommunity
{
    public class Permission
    {
        public Permission(string permissionType, string specificPermissionForum)
        {
            PermissionType = permissionType;
            SpecificPermissionForum = specificPermissionForum;
        }
        public string PermissionType { get; set; }
        public string SpecificPermissionForum { get; set; }
    }
}
