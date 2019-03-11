using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ParticlesFluxComponent_Template : ActorComponent_Template {
		[Serialize("standAnim"            )] public StringID standAnim;
		[Serialize("offsetRange"          )] public float offsetRange;
		[Serialize("scale"                )] public float scale;
		[Serialize("startAlpha"           )] public float startAlpha;
		[Serialize("endAlpha"             )] public float endAlpha;
		[Serialize("m_alphaTransitionTime")] public float m_alphaTransitionTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(standAnim));
			SerializeField(s, nameof(offsetRange));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(startAlpha));
			SerializeField(s, nameof(endAlpha));
			SerializeField(s, nameof(m_alphaTransitionTime));
		}
		public override uint? ClassCRC => 0x620E7978;
	}
}

