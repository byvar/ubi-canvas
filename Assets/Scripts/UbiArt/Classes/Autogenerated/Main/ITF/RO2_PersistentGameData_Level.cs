using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PersistentGameData_Level : PersistentGameData_Level {
		public uint bestLumsTaken;
		public float bestDistance;
		public float bestTime;
		public CListO<PrisonerData> freedPrisoners;
		public uint cups;
		public uint medals;
		public bool completed;
		public bool isVisited;
		public bool bestTimeSent;
		public uint type;
		public uint luckyTicketsLeft;
		public uint historyOccurenceNb;
		public online.DateTime historyDateTime;
		public bool seasonalEnemyKilled;
		public CArrayO<ObjectPath> sequenceAlreadySeen;
		public int onlineSynced;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				bestLumsTaken = s.Serialize<uint>(bestLumsTaken, name: "bestLumsTaken");
				bestDistance = s.Serialize<float>(bestDistance, name: "bestDistance");
				bestTime = s.Serialize<float>(bestTime, name: "bestTime");
				freedPrisoners = s.SerializeObject<CListO<PrisonerData>>(freedPrisoners, name: "freedPrisoners");
				cups = s.Serialize<uint>(cups, name: "cups");
				medals = s.Serialize<uint>(medals, name: "medals");
				completed = s.Serialize<bool>(completed, name: "completed");
				isVisited = s.Serialize<bool>(isVisited, name: "isVisited");
				bestTimeSent = s.Serialize<bool>(bestTimeSent, name: "bestTimeSent");
				type = s.Serialize<uint>(type, name: "type");
				luckyTicketsLeft = s.Serialize<uint>(luckyTicketsLeft, name: "luckyTicketsLeft");
				sequenceAlreadySeen = s.SerializeObject<CArrayO<ObjectPath>>(sequenceAlreadySeen, name: "sequenceAlreadySeen");
				onlineSynced = s.Serialize<int>(onlineSynced, name: "onlineSynced");
			} else {
				bestLumsTaken = s.Serialize<uint>(bestLumsTaken, name: "bestLumsTaken");
				bestDistance = s.Serialize<float>(bestDistance, name: "bestDistance");
				bestTime = s.Serialize<float>(bestTime, name: "bestTime");
				freedPrisoners = s.SerializeObject<CListO<PrisonerData>>(freedPrisoners, name: "freedPrisoners");
				cups = s.Serialize<uint>(cups, name: "cups");
				medals = s.Serialize<uint>(medals, name: "medals");
				completed = s.Serialize<bool>(completed, name: "completed");
				isVisited = s.Serialize<bool>(isVisited, name: "isVisited");
				bestTimeSent = s.Serialize<bool>(bestTimeSent, name: "bestTimeSent");
				type = s.Serialize<uint>(type, name: "type");
				luckyTicketsLeft = s.Serialize<uint>(luckyTicketsLeft, name: "luckyTicketsLeft");
				historyOccurenceNb = s.Serialize<uint>(historyOccurenceNb, name: "historyOccurenceNb");
				historyDateTime = s.SerializeObject<online.DateTime>(historyDateTime, name: "historyDateTime");
				seasonalEnemyKilled = s.Serialize<bool>(seasonalEnemyKilled, name: "seasonalEnemyKilled");
			}
		}
		public override uint? ClassCRC => 0xC0E0FDF1;
	}
}

