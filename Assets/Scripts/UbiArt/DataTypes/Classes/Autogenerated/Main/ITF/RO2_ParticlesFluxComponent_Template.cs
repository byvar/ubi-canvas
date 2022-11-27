namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ParticlesFluxComponent_Template : ActorComponent_Template {
		public StringID standAnim;
		public float offsetRange;
		public float scale = 1f;
		public float startAlpha;
		public float endAlpha = 1f;
		public float m_alphaTransitionTime = 0.2f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			standAnim = s.SerializeObject<StringID>(standAnim, name: "standAnim");
			offsetRange = s.Serialize<float>(offsetRange, name: "offsetRange");
			scale = s.Serialize<float>(scale, name: "scale");
			startAlpha = s.Serialize<float>(startAlpha, name: "startAlpha");
			endAlpha = s.Serialize<float>(endAlpha, name: "endAlpha");
			m_alphaTransitionTime = s.Serialize<float>(m_alphaTransitionTime, name: "m_alphaTransitionTime");
		}
		public override uint? ClassCRC => 0x620E7978;
	}
}

