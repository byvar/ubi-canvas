namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimTreeNodePlayAnimProceduralSmooth_Template : AnimTreeNodePlayAnim_Template {
		public float startCursor = -1f;
		public float stiffConstant = 120f;
		public float dampConstant = 10f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startCursor = s.Serialize<float>(startCursor, name: "startCursor");
			stiffConstant = s.Serialize<float>(stiffConstant, name: "stiffConstant");
			dampConstant = s.Serialize<float>(dampConstant, name: "dampConstant");
		}
		public override uint? ClassCRC => 0xEEF2E99F;
	}
}

