using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When written: after a new ship has been purchased
    //Parameters:
    //�	ShipType
    //�	ShipID
    public class ShipyardNewEvent : JournalEvent<ShipyardNewEvent.ShipyardNewEventArgs>
    {
        public ShipyardNewEvent() : base("ShipyardNew") { }

        public class ShipyardNewEventArgs : JournalEventArgs
        {
            public long MarketID { get; set; }
            public string ShipType { get; set; }
            public int ShipId { get; set; }
        }
    }
}
