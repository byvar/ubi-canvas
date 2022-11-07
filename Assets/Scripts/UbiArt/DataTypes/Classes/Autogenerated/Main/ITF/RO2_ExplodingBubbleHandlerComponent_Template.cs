namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ExplodingBubbleHandlerComponent_Template : AnimMeshVertexComponent_Template {
		public float bubbleZ;
		public float bubbleScale;
		public uint bubbleCount;
		public float bubbleRadius;
		public float bubbleInitAccel;
		public bool displayDebug;
		public bool DRCdisplay;
		public StringID heartAppearRumbleID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bubbleZ = s.Serialize<float>(bubbleZ, name: "bubbleZ");
			bubbleScale = s.Serialize<float>(bubbleScale, name: "bubbleScale");
			bubbleCount = s.Serialize<uint>(bubbleCount, name: "bubbleCount");
			bubbleRadius = s.Serialize<float>(bubbleRadius, name: "bubbleRadius");
			bubbleInitAccel = s.Serialize<float>(bubbleInitAccel, name: "bubbleInitAccel");
			displayDebug = s.Serialize<bool>(displayDebug, name: "displayDebug");
			DRCdisplay = s.Serialize<bool>(DRCdisplay, name: "DRCdisplay");
			heartAppearRumbleID = s.SerializeObject<StringID>(heartAppearRumbleID, name: "heartAppearRumbleID");
		}
		public override uint? ClassCRC => 0xC37619CF;
	}
}

