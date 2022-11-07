namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AIDestroyAction_Template : AIAction_Template {
		public bool waitForFx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitForFx = s.Serialize<bool>(waitForFx, name: "waitForFx");
		}
		public override uint? ClassCRC => 0x70126893;
	}
}

