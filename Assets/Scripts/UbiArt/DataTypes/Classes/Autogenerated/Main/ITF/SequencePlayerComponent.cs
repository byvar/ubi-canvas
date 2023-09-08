namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class SequencePlayerComponent : ActorComponent {
		public uint bankState = 0xFFFFFFFF;
		public bool allowPrefetch;
		public bool useCustomAABB;
		public EditableShape customAABB;
		public bool overrideActorAABB;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO || s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				bankState = s.Serialize<uint>(bankState, name: "bankState");
			} else {
				bankState = s.Serialize<uint>(bankState, name: "bankState");
				allowPrefetch = s.Serialize<bool>(allowPrefetch, name: "allowPrefetch");
				useCustomAABB = s.Serialize<bool>(useCustomAABB, name: "useCustomAABB");
				customAABB = s.SerializeObject<EditableShape>(customAABB, name: "customAABB");
				overrideActorAABB = s.Serialize<bool>(overrideActorAABB, name: "overrideActorAABB");
			}
		}
		public override uint? ClassCRC => 0x35A4CFCF;
	}
}

