namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_DragSpringBTComponent_Template : BTAIComponent_Template {
		public bool disablePhysics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			disablePhysics = s.Serialize<bool>(disablePhysics, name: "disablePhysics");
		}
		public override uint? ClassCRC => 0x397DE58B;
	}
}

