using System;
using System.Data.Linq.Mapping;
using Library.Database;
using Library.Interfaces;

namespace MusicLibrary.Models
{
    [Table(Name="Song")]
    public class Song : IObjectBase
    {
        private readonly IDBSource _dbSource;

        public Song(IDBSource dbSource = null)
        {
            _dbSource = dbSource ?? new DBSource();
        }

        #region Properties

        public string Name { get; set; }
        public int ID { get; set; }
        public int MovieID { get; set; }
        public string Path { get; set; }
        public string SingerName { get; set; }
        public string MusicDirector { get; set; }

        #endregion

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
