namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_SlingShotManagerComponent_Template : CSerializable {
		public Path EnemyPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			EnemyPath = s.SerializeObject<Path>(EnemyPath, name: "EnemyPath");
		}
		public override uint? ClassCRC => 0x1D9217DE;
	}
}

