namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_HomeTreeGpeComponent : ActorComponent {
		public bool isDebugActor;
		public float appearCursor;
		public bool useComponent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					isDebugActor = s.Serialize<bool>(isDebugActor, name: "isDebugActor", options: CSerializerObject.Options.BoolAsByte);
					appearCursor = s.Serialize<float>(appearCursor, name: "appearCursor");
					useComponent = s.Serialize<bool>(useComponent, name: "useComponent", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					isDebugActor = s.Serialize<bool>(isDebugActor, name: "isDebugActor");
					appearCursor = s.Serialize<float>(appearCursor, name: "appearCursor");
					useComponent = s.Serialize<bool>(useComponent, name: "useComponent");
				}
			}
		}
		public override uint? ClassCRC => 0x06493D0D;
	}
}

