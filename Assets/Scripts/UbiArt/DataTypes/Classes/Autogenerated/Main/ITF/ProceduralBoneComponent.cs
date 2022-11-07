namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class ProceduralBoneComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9189C777;
	}
}

