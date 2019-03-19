using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class DJ_ReticleComponent_Template : ActorComponent_Template {
		[Serialize("animDie"  )] public StringID animDie;
		[Serialize("lifeTime" )] public float lifeTime;
		[Serialize("faction"  )] public uint faction;
		[Serialize("isHitable")] public bool isHitable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animDie));
			SerializeField(s, nameof(lifeTime));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(isHitable));
		}
		public override uint? ClassCRC => 0xAC1FEBA0;
	}
}

