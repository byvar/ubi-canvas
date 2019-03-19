using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameGlobalsEndDateCondition : GameGlobalsCondition {
		[Serialize("end")] public online.DateTime end;
		[Serialize("utc")] public bool utc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(end));
			SerializeField(s, nameof(utc));
		}
		public override uint? ClassCRC => 0xFA33FBDB;
	}
}

