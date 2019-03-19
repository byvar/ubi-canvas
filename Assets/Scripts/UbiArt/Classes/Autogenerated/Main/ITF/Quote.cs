using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class Quote : CSerializable {
		[Serialize("Appear"   )] public QuoteCondition Appear;
		[Serialize("Disappear")] public QuoteCondition Disappear;
		[Serialize("IconScale")] public float IconScale;
		[Serialize("Idx"      )] public LocalisationId Idx;
		[Serialize("ArrayIdx" )] public uint ArrayIdx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Appear));
			SerializeField(s, nameof(Disappear));
			SerializeField(s, nameof(IconScale));
			SerializeField(s, nameof(Idx));
			SerializeField(s, nameof(ArrayIdx));
		}
	}
}

