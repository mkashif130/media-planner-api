using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniComMediaPlanner.Business
{
    public class MediaChannel
    {
        private Data.IGet _db;
        public MediaChannel(Data.IGet db)
        {
            _db = db;
        }
        public IEnumerable<Model.IModel> GetMediaChannels()
        {
            return _db.Get();
        }
    }
}
