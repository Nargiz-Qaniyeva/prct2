using System;
using System.Collections.Generic;
using System.Text;

namespace general.Exceptions.Models
{
    internal class User
    {
        //        Id +
        //- Statuses -  +
        //- Username +
        //- ShareStatus() - +

        //- GetStatusById() - +
        //- GetAllStatuses() - +
        //- FilterStatusByDate() - parametr olaraq bir nullable id və DateTime tipindən bir tarix qəbul edəcək göndərilən id-li user-in həmin tarixdən sonra paylaşılan bütün statuslarını geriyə qaytaracaq, göndərilən tarixdən sonra heç bir status paylaşılmayıbsa NotFoundException baş verəcək.

        //ps: Username olmadan user obyekti yaratmaq olmaz.+
        public int Id { get; }
        public string UserName { get; set; }

        private List<Status> _statuses;
        public User()
        {
            this.UserName = UserName;
        }
        public Status GetStatusById(int? id)
        {
            return _statuses.Find(x => x.Id == id); 
        }
        public List<Status> GetAllStatuses()
        {
            List<Status > statuses = new List<Status>();
            statuses.FindAll(x => x.UserName == this.UserName);
            return statuses;
        }
        public void ShareStatus(Status status)
        {
            if (status != null)
            {
                throw new NotFoundException("Status tapildi");
            }

            if (status == null)
            {
                throw new NullReferenceException("Status null ola bilmez");
            }
            _statuses.Add(status);
            return;
         }
        //public List<Status> FilterStatusByDate()
        //{
        //    return _statuses.FindAll(m => m.);
        //}


    }
}
