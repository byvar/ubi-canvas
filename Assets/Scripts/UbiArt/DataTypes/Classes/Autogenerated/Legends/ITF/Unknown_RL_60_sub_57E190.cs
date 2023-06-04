namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class AnimMeshVertexResource : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD3F1C1DF;
	}
}

