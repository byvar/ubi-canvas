using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionSendEvent_Template : CSerializable {
		[Serialize("event"   )] public Placeholder _event;
		[Serialize("Id"      )] public Placeholder Id;
		[Description("e.g: Aurora, Igniculus")]
		[Serialize("PlayerID")] public StringID PlayerID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(_event));
			SerializeField(s, nameof(Id));
			SerializeField(s, nameof(PlayerID));
		}
		public override uint? ClassCRC => 0xE4163580;
	}
}

