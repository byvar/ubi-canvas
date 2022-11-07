namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CauldronComponent_Template : ActorComponent_Template {
		public StringID standAnim;
		public StringID lidReceptionAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			standAnim = s.SerializeObject<StringID>(standAnim, name: "standAnim");
			lidReceptionAnim = s.SerializeObject<StringID>(lidReceptionAnim, name: "lidReceptionAnim");
		}
		public override uint? ClassCRC => 0x6FBFFBC7;
	}
}

