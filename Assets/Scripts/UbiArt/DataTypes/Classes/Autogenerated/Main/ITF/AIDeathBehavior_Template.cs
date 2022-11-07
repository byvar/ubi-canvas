namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AIDeathBehavior_Template : AIPlayActionsBehavior_Template {
		public bool pauseComponentWhenDone;
		public bool pauseActorWhenDone;
		public bool destroyActorWhenDone;
		public bool deactivatePhysics;
		public bool nullWeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pauseComponentWhenDone = s.Serialize<bool>(pauseComponentWhenDone, name: "pauseComponentWhenDone");
			pauseActorWhenDone = s.Serialize<bool>(pauseActorWhenDone, name: "pauseActorWhenDone");
			destroyActorWhenDone = s.Serialize<bool>(destroyActorWhenDone, name: "destroyActorWhenDone");
			deactivatePhysics = s.Serialize<bool>(deactivatePhysics, name: "deactivatePhysics");
			nullWeight = s.Serialize<bool>(nullWeight, name: "nullWeight");
		}
		public override uint? ClassCRC => 0x961AB13C;
	}
}

