using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PALRitualManagerComponent_Template : ActorComponent_Template {
		[Serialize("sequenceAnimation"   )] public StringID sequenceAnimation;
		[Serialize("animVictoryPlayer"   )] public StringID animVictoryPlayer;
		[Serialize("animStandPlayer"     )] public StringID animStandPlayer;
		[Serialize("victoryTime"         )] public float victoryTime;
		[Serialize("podiumBoneList"      )] public CList<StringID> podiumBoneList;
		[Serialize("podiumBoneTeensie"   )] public StringID podiumBoneTeensie;
		[Serialize("cameraFX"            )] public StringID cameraFX;
		[Serialize("murphyOnGroundOffset")] public Vector3 murphyOnGroundOffset;
		[Serialize("murphyInAirOffset"   )] public Vector3 murphyInAirOffset;
		[Serialize("cameraOffset"        )] public Vector3 cameraOffset;
		[Serialize("cameraOffsetInAir"   )] public Vector3 cameraOffsetInAir;
		[Serialize("cameraBlend"         )] public float cameraBlend;
		[Serialize("maxPlayerSpeed"      )] public float maxPlayerSpeed;
		[Serialize("musicEvent"          )] public Generic<Event> musicEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sequenceAnimation));
			SerializeField(s, nameof(animVictoryPlayer));
			SerializeField(s, nameof(animStandPlayer));
			SerializeField(s, nameof(victoryTime));
			SerializeField(s, nameof(podiumBoneList));
			SerializeField(s, nameof(podiumBoneTeensie));
			SerializeField(s, nameof(cameraFX));
			SerializeField(s, nameof(murphyOnGroundOffset));
			SerializeField(s, nameof(murphyInAirOffset));
			SerializeField(s, nameof(cameraOffset));
			SerializeField(s, nameof(cameraOffsetInAir));
			SerializeField(s, nameof(cameraBlend));
			SerializeField(s, nameof(maxPlayerSpeed));
			SerializeField(s, nameof(musicEvent));
		}
		public override uint? ClassCRC => 0xFB944847;
	}
}

