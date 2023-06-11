namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_InvasionEnemyComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x587D8C1C;
	}
}

