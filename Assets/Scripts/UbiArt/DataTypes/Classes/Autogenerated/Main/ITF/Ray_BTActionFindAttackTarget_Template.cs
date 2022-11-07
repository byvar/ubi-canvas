namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionFindAttackTarget_Template : BTAction_Template {
		public float radius;
		public StringID fact;
		public int filterByHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			radius = s.Serialize<float>(radius, name: "radius");
			fact = s.SerializeObject<StringID>(fact, name: "fact");
			filterByHeight = s.Serialize<int>(filterByHeight, name: "filterByHeight");
		}
		public override uint? ClassCRC => 0x3B429E2D;
	}
}

