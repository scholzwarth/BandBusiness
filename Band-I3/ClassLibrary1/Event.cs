using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace band_Business_I1
{
    public class Event
    {
        public int evntId { get; set; }
        public string evntName { get; set; }
        public string website { get; set; }
        public byte evntSizeId { get; set; }
        public byte evntTypeId { get; set; }
        public byte serviceLevelId { get; set; }
        public byte soundEquipmentLevelId { get; set; }
        public byte venueTypeId { get; set; }
    }
}
