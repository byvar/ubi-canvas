namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_TriggerBounceComponent : ActorComponent {
		public bool useTargetActorScenePosZ = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useTargetActorScenePosZ = s.Serialize<bool>(useTargetActorScenePosZ, name: "useTargetActorScenePosZ");
		}
		public override uint? ClassCRC => 0x8E86201A;
	}
}

