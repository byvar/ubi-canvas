namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class StateDeath_Template : WithAnimStateImplement_Tempate {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9FE3DD70;
	}
}

