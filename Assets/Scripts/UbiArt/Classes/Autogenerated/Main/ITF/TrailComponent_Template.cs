using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class TrailComponent_Template : GraphicComponent_Template {
		[Serialize("texture"         )] public Path texture;
		[Serialize("nbFrames"        )] public uint nbFrames;
		[Serialize("thicknessBegin"  )] public float thicknessBegin;
		[Serialize("thicknessEnd"    )] public float thicknessEnd;
		[Serialize("alphaBegin"      )] public float alphaBegin;
		[Serialize("alphaEnd"        )] public float alphaEnd;
		[Serialize("startActive"     )] public int startActive;
		[Serialize("trailFaidingTime")] public float trailFaidingTime;
		[Serialize("trailBlending"   )] public float trailBlending;
		[Serialize("attachBone"      )] public StringID attachBone;
		[Serialize("draw2D"          )] public int draw2D;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(texture));
			SerializeField(s, nameof(nbFrames));
			SerializeField(s, nameof(thicknessBegin));
			SerializeField(s, nameof(thicknessEnd));
			SerializeField(s, nameof(alphaBegin));
			SerializeField(s, nameof(alphaEnd));
			SerializeField(s, nameof(startActive));
			SerializeField(s, nameof(trailFaidingTime));
			SerializeField(s, nameof(trailBlending));
			SerializeField(s, nameof(attachBone));
			SerializeField(s, nameof(draw2D));
		}
		public override uint? ClassCRC => 0xB64E18CE;
	}
}

