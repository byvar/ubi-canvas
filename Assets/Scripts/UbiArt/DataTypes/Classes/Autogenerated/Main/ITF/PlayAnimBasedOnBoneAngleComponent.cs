namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class PlayAnimBasedOnBoneAngleComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x73D8DB8B;
	}
}

