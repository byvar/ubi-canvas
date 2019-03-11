using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ScoreRecapComponent_Template : ActorComponent_Template {
		[Serialize("animPlayerDance")] public StringID animPlayerDance;
		[Serialize("music"          )] public StringID music;
		[Serialize("bar"            )] public uint bar;
		[Serialize("failSafeTime"   )] public float failSafeTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animPlayerDance));
			SerializeField(s, nameof(music));
			SerializeField(s, nameof(bar));
			SerializeField(s, nameof(failSafeTime));
		}
		public override uint? ClassCRC => 0x7F5938ED;
	}
}

