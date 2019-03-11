using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_WM_FootpathComponent_Template : GraphicComponent_Template {
		[Serialize("speed"               )] public float speed;
		[Serialize("zOffset"             )] public float zOffset;
		[Serialize("tangentStretch"      )] public float tangentStretch;
		[Serialize("visualFadeInDuration")] public float visualFadeInDuration;
		[Serialize("fxFadeInDuration"    )] public float fxFadeInDuration;
		[Serialize("cameraFollowDistance")] public float cameraFollowDistance;
		[Serialize("samplePerEdge"       )] public uint samplePerEdge;
		[Serialize("connectFxName"       )] public StringID connectFxName;
		[Serialize("bezierRenderer"      )] public Placeholder bezierRenderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(tangentStretch));
			SerializeField(s, nameof(visualFadeInDuration));
			SerializeField(s, nameof(fxFadeInDuration));
			SerializeField(s, nameof(cameraFollowDistance));
			SerializeField(s, nameof(samplePerEdge));
			SerializeField(s, nameof(connectFxName));
			SerializeField(s, nameof(bezierRenderer));
		}
		public override uint? ClassCRC => 0x86786731;
	}
}

