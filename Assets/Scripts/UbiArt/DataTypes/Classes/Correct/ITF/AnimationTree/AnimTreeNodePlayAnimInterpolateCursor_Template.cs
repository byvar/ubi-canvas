namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimTreeNodePlayAnimInterpolateCursor_Template : AnimTreeNodePlayAnim_Template {
		public float interpolationTime;
		public float startCursor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			interpolationTime = s.Serialize<float>(interpolationTime, name: "interpolationTime");
			startCursor = s.Serialize<float>(startCursor, name: "startCursor");
		}
		public override uint? ClassCRC => 0x93FBE508;
	}
}

