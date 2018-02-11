using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //    When written: when the current player selects a new target
    //    The amount of data written depends on the extent to which the target ship has been scanned
    //Parameters:
    //�	TargetLocked: bool (ie false when losing target)

    //If target locked:
    //�	Ship: name
    //�	ScanStage: number

    //If Scan stage >= 1
    //�	PilotName: name
    //�	PilotRank: rank name

    //If scan stage >= 2
    //�	ShieldHealth
    //�	HullHealth

    //If scan stage >= 3
    //�	Faction
    //�	LegalStatus
    //�	Bounty
    //�	SubSystem
    //�	SubSystemHealth
    public class ShipTargettedEvent : JournalEvent<ShipTargettedEvent.ShipTargettedEventArgs>
    {
        public ShipTargettedEvent() : base("ShipTargetted") { }

        public class ShipTargettedEventArgs : JournalEventArgs
        {
            public bool TargetLocked { get; set; }
            public string Ship { get; set; }
            public int ScanStage { get; set; }
            public string PilotName { get; set; }
            public CombatRank PilotRank { get; set; }
            public double ShieldHealth { get; set; }
            public double HullHealth { get; set; }
            public string Faction { get; set; }
            public string LegalStatus { get; set; }
            public long Bounty { get; set; }
            public string SubSystem { get; set; }
            public double SubSystemHealth { get; set; }
        }
    }
}
