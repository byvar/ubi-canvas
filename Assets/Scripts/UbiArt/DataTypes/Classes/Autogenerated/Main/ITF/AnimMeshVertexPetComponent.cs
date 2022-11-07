namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class AnimMeshVertexPetComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0B9A5A1C;
	}
}

