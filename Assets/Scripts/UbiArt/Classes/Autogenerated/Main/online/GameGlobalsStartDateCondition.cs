using UnityEngine;

namespace UbiArt.online {
	public partial class GameGlobalsStartDateCondition : GameGlobalsCondition {
		[Serialize("start")] public online.DateTime start;
		[Serialize("utc"  )] public bool utc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(start));
			SerializeField(s, nameof(utc));
		}
		public override uint? ClassCRC => 0x6EBA0BB4;
	}
}

