using ForskerNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForskerNet.Services
{
    public interface IPublicationData
    {
        IEnumerable<Publication> GetAll();
        void Insert(Publication publication);
    }
    public class PublicationDataInMemory : IPublicationData
    {
        public PublicationDataInMemory()
        {
            _publications = new List<Publication>
            {
                new Publication { Id = 1, Author = "Marcus", Date = DateTime.Now, Keywords = null, Resume = null, Title = "How to be a Noob" },
                new Publication { Id = 2, Author = "Seb", Date = DateTime.Now, Keywords = null, Resume = null, Title = "Store bryster" },
                new Publication { Id = 3, Author = "Nicolas", Date = DateTime.Now, Keywords = null, Resume = null, Title = "Legendaries in wow" }
            };
        }
        private IEnumerable<Publication> _publications;
        public IEnumerable<Publication> GetAll()
        {
            return _publications;
        }

        public void Insert(Publication publication)
        {
            throw new NotImplementedException();
        }
    }
}
