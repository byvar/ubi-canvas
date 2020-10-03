using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionSendEvent_Template : CSerializable {
		public Placeholder _event;
		public Placeholder Id;
		[Description("e.g: Aurora, Igniculus")]
		public StringID PlayerID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			_event = s.SerializeObject<Placeholder>(_event, name: "event");
			Id = s.SerializeObject<Placeholder>(Id, name: "Id");
			PlayerID = s.SerializeObject<StringID>(PlayerID, name: "PlayerID");
		}
		public override uint? ClassCRC => 0xE4163580;
	}
}

