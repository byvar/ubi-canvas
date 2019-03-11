using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_183_sub_781AC0 : CSerializable {
		[Serialize("trappedShape")] public Placeholder trappedShape;
		[Serialize("animOff"     )] public StringID animOff;
		[Serialize("animTrapped" )] public StringID animTrapped;
		[Serialize("revealedFx"  )] public StringID revealedFx;
		[Serialize("activatedFx" )] public StringID activatedFx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(trappedShape));
			SerializeField(s, nameof(animOff));
			SerializeField(s, nameof(animTrapped));
			SerializeField(s, nameof(revealedFx));
			SerializeField(s, nameof(activatedFx));
		}
		public override uint? ClassCRC => 0x94721363;
	}
}

