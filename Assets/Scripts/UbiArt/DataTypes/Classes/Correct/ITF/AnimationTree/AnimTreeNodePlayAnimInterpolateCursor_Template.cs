namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimTreeNodePlayAnimInterpolateCursor_Template : AnimTreeNodePlayAnim_Template {
		public float interpolationTime = 0.2f;
		public float startCursor = 0.5f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			interpolationTime = s.Serialize<float>(interpolationTime, name: "interpolationTime");
			startCursor = s.Serialize<float>(startCursor, name: "startCursor");
		}
		public override uint? ClassCRC => 0x93FBE508;
	}
}

