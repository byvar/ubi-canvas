namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Pad2Touch_Template : ActorComponent_Template {
		public CMap<StringID, RLC_Pad2TouchInput> InputMapping;
		public bool SelectInactive;
		public bool ActiveOnScreenOnly;
		public bool ActiveOnBackground;
		public bool SensibleToAdventureLock;
		public bool SensibleToIncubatorLock;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			InputMapping = s.SerializeObject<CMap<StringID, RLC_Pad2TouchInput>>(InputMapping, name: "InputMapping");
			SelectInactive = s.Serialize<bool>(SelectInactive, name: "SelectInactive");
			ActiveOnScreenOnly = s.Serialize<bool>(ActiveOnScreenOnly, name: "ActiveOnScreenOnly");
			ActiveOnBackground = s.Serialize<bool>(ActiveOnBackground, name: "ActiveOnBackground");
			SensibleToAdventureLock = s.Serialize<bool>(SensibleToAdventureLock, name: "SensibleToAdventureLock");
			SensibleToIncubatorLock = s.Serialize<bool>(SensibleToIncubatorLock, name: "SensibleToIncubatorLock");
		}
		public override uint? ClassCRC => 0xD8678F00;
	}
}

