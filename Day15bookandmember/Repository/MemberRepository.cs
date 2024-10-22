using Day15bookandmember.Data;
using Day15bookandmember.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15bookandmember.Repository
{
    internal class MemberRepository
    {
        public GenericResponse<List<Member>> GetAllMembers()
        {
            var members = DataStore.Members;
            return new GenericResponse<List<Member>>
            {
                Success = true,
                Data = members,
            };
        }

        public GenericResponse<Member> GetMemberByName(string name)
        {
            Member member = null;

            foreach (var m in DataStore.Members)
            {
                if (m.Name.ToLower() == name.ToLower())
                {
                    member = m;
                    break; 
                }
            }
            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found",
                };
            }
            return new GenericResponse<Member>
            {
                Success = true,
                Data = member,
            };
        }

        public GenericResponse<Member> GetMemberByEmail(string email)
        {
            Member member = null;
            foreach (var m in DataStore.Members)
            {
                if (m.Email.ToLower() == email.ToLower())
                {
                    member = m;
                    break; 
                }
            }
            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found",
                };
            }
            return new GenericResponse<Member>
            {
                Success = true,
                Data = member,
            };
        }
    }
}
