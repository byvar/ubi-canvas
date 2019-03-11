using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LeafsComponent_Template : ActorComponent_Template {
		[Serialize("standAnims"  )] public CList<StringID> standAnims;
		[Serialize("explodeAnims")] public CList<StringID> explodeAnims;
		[Serialize("randomDelay" )] public float randomDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(standAnims));
			SerializeField(s, nameof(explodeAnims));
			SerializeField(s, nameof(randomDelay));
		}
		public override uint? ClassCRC => 0xF375DAEE;
	}
}

