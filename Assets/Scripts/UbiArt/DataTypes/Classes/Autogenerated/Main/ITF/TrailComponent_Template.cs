namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class TrailComponent_Template : GraphicComponent_Template {
		public Path texture;
		public uint nbFrames;
		public float thicknessBegin;
		public float thicknessEnd;
		public float alphaBegin;
		public float alphaEnd;
		public int startActive;
		public float trailFaidingTime;
		public float trailBlending;
		public StringID attachBone;
		public int draw2D;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			texture = s.SerializeObject<Path>(texture, name: "texture");
			nbFrames = s.Serialize<uint>(nbFrames, name: "nbFrames");
			thicknessBegin = s.Serialize<float>(thicknessBegin, name: "thicknessBegin");
			thicknessEnd = s.Serialize<float>(thicknessEnd, name: "thicknessEnd");
			alphaBegin = s.Serialize<float>(alphaBegin, name: "alphaBegin");
			alphaEnd = s.Serialize<float>(alphaEnd, name: "alphaEnd");
			startActive = s.Serialize<int>(startActive, name: "startActive");
			trailFaidingTime = s.Serialize<float>(trailFaidingTime, name: "trailFaidingTime");
			trailBlending = s.Serialize<float>(trailBlending, name: "trailBlending");
			attachBone = s.SerializeObject<StringID>(attachBone, name: "attachBone");
			draw2D = s.Serialize<int>(draw2D, name: "draw2D");
		}
		public override uint? ClassCRC => 0xB64E18CE;
	}
}

