using AdminDBHandler.Models.Dept_Level_Term;
using System.ComponentModel.DataAnnotations;
namespace AdminDBHandler.Models.User.User_Types
{
    public class Teachers : IDiffUser
    {
        public string? ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Department? Dept { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Designation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Phone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public User? Individual { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
