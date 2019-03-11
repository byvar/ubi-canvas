using UnityEngine;

namespace UbiArt.online {
	public partial class GameGlobalsDayOfWeekCondition : GameGlobalsCondition {
		[Serialize("utc" )] public bool utc;
		[Serialize("week")] public uint week;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(utc));
			SerializeField(s, nameof(week));
		}
		public override uint? ClassCRC => 0xEF90E84B;
	}
}

