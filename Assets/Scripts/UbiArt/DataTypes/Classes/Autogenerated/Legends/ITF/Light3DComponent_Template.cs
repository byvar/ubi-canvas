namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class Light3DComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5D50B800;
	}
}

