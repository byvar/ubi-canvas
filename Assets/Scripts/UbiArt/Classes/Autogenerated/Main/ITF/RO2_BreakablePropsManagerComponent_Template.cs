using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BreakablePropsManagerComponent_Template : ActorComponent_Template {
		[Serialize("breakablePropsPath")] public Path breakablePropsPath;
		[Serialize("transitionAnim"    )] public StringID transitionAnim;
		[Serialize("standAnim"         )] public StringID standAnim;
		[Serialize("standDrcAnim"      )] public StringID standDrcAnim;
		[Serialize("deathAnim"         )] public StringID deathAnim;
		[Serialize("deathDrcAnim"      )] public StringID deathDrcAnim;
		[Serialize("hitAnim"           )] public StringID hitAnim;
		[Serialize("hitDrcAnim"        )] public StringID hitDrcAnim;
		[Serialize("shakeAnim"         )] public StringID shakeAnim;
		[Serialize("shakeDrcAnim"      )] public StringID shakeDrcAnim;
		[Serialize("noAnimForEmpty"    )] public bool noAnimForEmpty;
		[Serialize("shakeShapeRadius"  )] public float shakeShapeRadius;
		[Serialize("shakeTime"         )] public float shakeTime;
		[Serialize("hitShapeRadius"    )] public float hitShapeRadius;
		[Serialize("hitShapeOffset"    )] public Vector2 hitShapeOffset;
		[Serialize("squashAnim"        )] public StringID squashAnim;
		[Serialize("squashDrcAnim"     )] public StringID squashDrcAnim;
		[Serialize("standBrokenAnim"   )] public StringID standBrokenAnim;
		[Serialize("standBrokenDrcAnim")] public StringID standBrokenDrcAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(breakablePropsPath));
			SerializeField(s, nameof(transitionAnim));
			SerializeField(s, nameof(standAnim));
			SerializeField(s, nameof(standDrcAnim));
			SerializeField(s, nameof(deathAnim));
			SerializeField(s, nameof(deathDrcAnim));
			SerializeField(s, nameof(hitAnim));
			SerializeField(s, nameof(hitDrcAnim));
			SerializeField(s, nameof(shakeAnim));
			SerializeField(s, nameof(shakeDrcAnim));
			SerializeField(s, nameof(noAnimForEmpty));
			SerializeField(s, nameof(shakeShapeRadius));
			SerializeField(s, nameof(shakeTime));
			SerializeField(s, nameof(hitShapeRadius));
			SerializeField(s, nameof(hitShapeOffset));
			SerializeField(s, nameof(squashAnim));
			SerializeField(s, nameof(squashDrcAnim));
			SerializeField(s, nameof(standBrokenAnim));
			SerializeField(s, nameof(standBrokenDrcAnim));
		}
		public override uint? ClassCRC => 0x1494BBE0;
	}
}

