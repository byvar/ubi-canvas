namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BossMorayNodeComponent_Template : ActorComponent_Template {
		public Ray_EventBossMorayNodeReached triggerEvent;
		public float debugCorridorWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			triggerEvent = s.SerializeObject<Ray_EventBossMorayNodeReached>(triggerEvent, name: "triggerEvent");
			debugCorridorWidth = s.Serialize<float>(debugCorridorWidth, name: "debugCorridorWidth");
		}
		public override uint? ClassCRC => 0x4B2C34EF;
	}
}

