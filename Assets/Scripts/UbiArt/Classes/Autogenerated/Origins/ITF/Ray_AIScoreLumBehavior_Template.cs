using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIScoreLumBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("maxTimeBeforeExplosion_RedMode")] public float maxTimeBeforeExplosion_RedMode;
		[Serialize("yellowLumValue"                )] public uint yellowLumValue;
		[Serialize("redLumValue"                   )] public uint redLumValue;
		[Serialize("lumKingValue"                  )] public uint lumKingValue;
		[Serialize("startKingMusicEvent"           )] public Placeholder startKingMusicEvent;
		[Serialize("stopKingMusicEvent"            )] public Placeholder stopKingMusicEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxTimeBeforeExplosion_RedMode));
			SerializeField(s, nameof(yellowLumValue));
			SerializeField(s, nameof(redLumValue));
			SerializeField(s, nameof(lumKingValue));
			SerializeField(s, nameof(startKingMusicEvent));
			SerializeField(s, nameof(stopKingMusicEvent));
		}
		public override uint? ClassCRC => 0xA74D72A1;
	}
}

