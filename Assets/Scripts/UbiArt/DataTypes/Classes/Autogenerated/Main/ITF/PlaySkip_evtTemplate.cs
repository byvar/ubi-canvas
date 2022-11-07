namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PlaySkip_evtTemplate : SequenceEvent_Template {
		public ContextIcon skipContextIcon;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			skipContextIcon = s.Serialize<ContextIcon>(skipContextIcon, name: "skipContextIcon");
		}
		public enum ContextIcon {
			[Serialize("ContextIcon_Invalid" )] Invalid = -1,
			[Serialize("ContextIcon_Select"  )] Select = 0,
			[Serialize("ContextIcon_Continue")] Continue = 1,
			[Serialize("ContextIcon_Enter"   )] Enter = 2,
			[Serialize("ContextIcon_Skip"    )] Skip = 3,
			[Serialize("ContextIcon_Back"    )] Back = 4,
			[Serialize("ContextIcon_Retry"   )] Retry = 5,
			[Serialize("ContextIcon_Delete"  )] Delete = 6,
		}
		public override uint? ClassCRC => 0x0A5C3303;
	}
}

