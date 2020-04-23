using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Factory;

namespace TravelAgency.Repository
{
    class UsersRepository : IEnumerable
    {
        private List<User> _users;

        public IQueryable<User> Query { get => _users.AsQueryable(); }

        public UsersRepository()
        {
            _users = new List<User>();
        }

        public void AddRange(params User[] users)
        {
            if (users == null)
            {
                return;
            }

            _users.AddRange(users);
        }

        public void Add(User user)
        {
            if (user == null)
            {
                return;
            }

            _users.Add(user);
        }

        public void Remove(User user)
        {
            _users.Remove(user);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var user in _users.ToList())
            {
                yield return user;
            }
        }
    }
}
