namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossNodeComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE4A13978;
	}
}

