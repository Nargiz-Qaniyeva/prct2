using System;
using System.Collections.Generic;
using System.Text;

namespace general.Exceptions.Models
{
    internal class Status
    {
        //   - Id  +
        //   - Title+
        //   - Content+
        //   - SharedDate -+ DateTime tipindən bir property, statusdan yeni bir obyekt yaranan zaman yarandığı tarix set olunacaq.
        //   - GetStatusInfo() - geriyə "Title: test title - Content: test content - shared 5 seconds ago"(burda qeyd olunan "shared 5 seconds ago" hissəsi dinamik olmalıdı status neçə saniyə əvvəl paylaşılıbsa o yazılmalıdı) bu tipdə bir məlumat qaytaracaq.

        //ps: Title, content olmadan status obyekti yaratmaq olmaz.
        public int Id { get; set; }
        static int id=0;
        public string Tittle { get; set; }
        public string Content { get; set; }
        public DateTime SharedDate { get; set; }
        public User User { get; internal set; }
        public string UserName { get; internal set; }

        public void GetStatusInfo()
        {
            Console.WriteLine($"Title:{Tittle}-Content:{Content}");
        }
        public Status()
        {
            this.Tittle = Tittle;
            this.Content = Content;
            Id += id;
        }

        internal void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
