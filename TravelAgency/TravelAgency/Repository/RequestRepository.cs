using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Proxy;

namespace TravelAgency.Repository
{
    class RequestRepository : IEnumerable
    {
        private List<Request> _requests;

        public IQueryable<Request> Query { get => _requests.AsQueryable(); }

        public RequestRepository()
        {
            _requests = new List<Request>();
        }

        public void Add(Request request)
        {
            if (request == null)
            {
                return;
            }

            _requests.Add(request);
            return;
        }

        public void Remove(Request request)
        {
            _requests.Remove(request);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var request in _requests.ToList())
            {
                yield return request;
            }
        }
    }
}
