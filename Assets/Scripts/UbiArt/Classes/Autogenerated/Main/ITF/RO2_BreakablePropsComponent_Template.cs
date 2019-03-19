using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BreakablePropsComponent_Template : ActorComponent_Template {
		[Serialize("noAnimForEmpty"  )] public bool noAnimForEmpty;
		[Serialize("defaultAnim"     )] public StringID defaultAnim;
		[Serialize("explodeAnim"     )] public StringID explodeAnim;
		[Serialize("emptyAnim"       )] public StringID emptyAnim;
		[Serialize("squashAnim"      )] public StringID squashAnim;
		[Serialize("shakeAnim"       )] public StringID shakeAnim;
		[Serialize("breathlessAnim"  )] public StringID breathlessAnim;
		[Serialize("shakeShapeRadius")] public float shakeShapeRadius;
		[Serialize("shakeTime"       )] public float shakeTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(noAnimForEmpty));
			SerializeField(s, nameof(defaultAnim));
			SerializeField(s, nameof(explodeAnim));
			SerializeField(s, nameof(emptyAnim));
			SerializeField(s, nameof(squashAnim));
			SerializeField(s, nameof(shakeAnim));
			SerializeField(s, nameof(breathlessAnim));
			SerializeField(s, nameof(shakeShapeRadius));
			SerializeField(s, nameof(shakeTime));
		}
		public override uint? ClassCRC => 0x5A415956;
	}
}

