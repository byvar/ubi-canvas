namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class ToggleAnimOnEventComponent : ActorComponent {
		public bool startOpen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				startOpen = s.Serialize<bool>(startOpen, name: "startOpen");
			}
		}
		public override uint? ClassCRC => 0x40B26DFB;
	}
}

