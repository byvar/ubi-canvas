using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PersistentGameData_Level : PersistentGameData_Level {
		[Serialize("bestLumsTaken"      )] public uint bestLumsTaken;
		[Serialize("bestDistance"       )] public float bestDistance;
		[Serialize("bestTime"           )] public float bestTime;
		[Serialize("freedPrisoners"     )] public CList<PrisonerData> freedPrisoners;
		[Serialize("cups"               )] public uint cups;
		[Serialize("medals"             )] public uint medals;
		[Serialize("completed"          )] public bool completed;
		[Serialize("isVisited"          )] public bool isVisited;
		[Serialize("bestTimeSent"       )] public bool bestTimeSent;
		[Serialize("type"               )] public uint type;
		[Serialize("luckyTicketsLeft"   )] public uint luckyTicketsLeft;
		[Serialize("historyOccurenceNb" )] public uint historyOccurenceNb;
		[Serialize("historyDateTime"    )] public online.DateTime historyDateTime;
		[Serialize("seasonalEnemyKilled")] public bool seasonalEnemyKilled;
		[Serialize("sequenceAlreadySeen")] public Placeholder sequenceAlreadySeen;
		[Serialize("onlineSynced"       )] public bool onlineSynced;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(bestLumsTaken));
				SerializeField(s, nameof(bestDistance));
				SerializeField(s, nameof(bestTime));
				SerializeField(s, nameof(freedPrisoners));
				SerializeField(s, nameof(cups));
				SerializeField(s, nameof(medals));
				SerializeField(s, nameof(completed));
				SerializeField(s, nameof(isVisited));
				SerializeField(s, nameof(bestTimeSent));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(luckyTicketsLeft));
				SerializeField(s, nameof(sequenceAlreadySeen));
				SerializeField(s, nameof(onlineSynced));
			} else {
				SerializeField(s, nameof(bestLumsTaken));
				SerializeField(s, nameof(bestDistance));
				SerializeField(s, nameof(bestTime));
				SerializeField(s, nameof(freedPrisoners));
				SerializeField(s, nameof(cups));
				SerializeField(s, nameof(medals));
				SerializeField(s, nameof(completed));
				SerializeField(s, nameof(isVisited));
				SerializeField(s, nameof(bestTimeSent));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(luckyTicketsLeft));
				SerializeField(s, nameof(historyOccurenceNb));
				SerializeField(s, nameof(historyDateTime));
				SerializeField(s, nameof(seasonalEnemyKilled));
			}
		}
		public override uint? ClassCRC => 0xC0E0FDF1;
	}
}

