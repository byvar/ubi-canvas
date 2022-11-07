namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_FootpathComponent_Template : GraphicComponent_Template {
		public float speed;
		public float zOffset;
		public float tangentStretch;
		public float visualFadeInDuration;
		public float fxFadeInDuration;
		public float cameraFollowDistance;
		public uint samplePerEdge;
		public StringID connectFxName;
		public Placeholder bezierRenderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.Serialize<float>(speed, name: "speed");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			tangentStretch = s.Serialize<float>(tangentStretch, name: "tangentStretch");
			visualFadeInDuration = s.Serialize<float>(visualFadeInDuration, name: "visualFadeInDuration");
			fxFadeInDuration = s.Serialize<float>(fxFadeInDuration, name: "fxFadeInDuration");
			cameraFollowDistance = s.Serialize<float>(cameraFollowDistance, name: "cameraFollowDistance");
			samplePerEdge = s.Serialize<uint>(samplePerEdge, name: "samplePerEdge");
			connectFxName = s.SerializeObject<StringID>(connectFxName, name: "connectFxName");
			bezierRenderer = s.SerializeObject<Placeholder>(bezierRenderer, name: "bezierRenderer");
		}
		public override uint? ClassCRC => 0x86786731;
	}
}

