namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class AngleAnimatedComponent_Template : ActorComponent_Template {
		public bool CounterClockWise;
		public StringID AnimRotationName;
		public bool bool__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.VH) {
				bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			} else {
				CounterClockWise = s.Serialize<bool>(CounterClockWise, name: "CounterClockWise");
				AnimRotationName = s.SerializeObject<StringID>(AnimRotationName, name: "AnimRotationName");
			}
		}
		public override uint? ClassCRC => 0x132C748D;
	}
}

