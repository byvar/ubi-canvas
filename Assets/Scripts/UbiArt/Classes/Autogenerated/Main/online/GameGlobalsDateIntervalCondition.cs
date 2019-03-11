using UnityEngine;

namespace UbiArt.online {
	public partial class GameGlobalsDateIntervalCondition : GameGlobalsCondition {
		[Serialize("start")] public online.DateTime start;
		[Serialize("end"  )] public online.DateTime end;
		[Serialize("utc"  )] public bool utc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(start));
			SerializeField(s, nameof(end));
			SerializeField(s, nameof(utc));
		}
		public override uint? ClassCRC => 0x70781E25;
	}
}

