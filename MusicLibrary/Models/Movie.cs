using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using Library.Database;
using Library.Interfaces;

namespace MusicLibrary.Models
{
    [Table(Name="Movie")]
    public class Movie : IObjectBase
    {
        private readonly IDBSource _dbSource;

        #region Constructors

        public Movie(IDBSource dbsource = null)
        {
            _dbSource = dbsource ?? new DBSource();
        }

        #endregion

        #region Properties

        public int ID { get; set; }

        public string Name { get; set; }

        public string Director { get; set; }

        public string MusicDirector { get; set; }

        public byte[] Image { get; set; }

        public List<Song> Songs { get; set; }


        #endregion

        #region Public Methods

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
