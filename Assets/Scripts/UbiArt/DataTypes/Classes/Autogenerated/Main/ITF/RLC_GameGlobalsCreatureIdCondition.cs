namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_GameGlobalsCreatureIdCondition : online.GameGlobalsCondition {
		public StringID creature;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			creature = s.SerializeObject<StringID>(creature, name: "creature");
		}
		public override uint? ClassCRC => 0xA05E6782;
	}
}

