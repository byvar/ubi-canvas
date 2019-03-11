using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_RockFishAIComponent_Template : CSerializable {
		[Serialize("attackDetectionShape")] public Placeholder attackDetectionShape;
		[Serialize("detectionRadius"     )] public float detectionRadius;
		[Serialize("minDetectTime"       )] public float minDetectTime;
		[Serialize("minIdleTime"         )] public float minIdleTime;
		[Serialize("sleepAnim"           )] public StringID sleepAnim;
		[Serialize("detectAnim"          )] public StringID detectAnim;
		[Serialize("openAnim"            )] public StringID openAnim;
		[Serialize("closeAnim"           )] public StringID closeAnim;
		[Serialize("openTime"            )] public float openTime;
		[Serialize("points"              )] public Placeholder points;
		[Serialize("regionType"          )] public StringID regionType;
		[Serialize("gameMaterial"        )] public Path gameMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(attackDetectionShape));
			SerializeField(s, nameof(detectionRadius));
			SerializeField(s, nameof(minDetectTime));
			SerializeField(s, nameof(minIdleTime));
			SerializeField(s, nameof(sleepAnim));
			SerializeField(s, nameof(detectAnim));
			SerializeField(s, nameof(openAnim));
			SerializeField(s, nameof(closeAnim));
			SerializeField(s, nameof(openTime));
			SerializeField(s, nameof(points));
			SerializeField(s, nameof(regionType));
			SerializeField(s, nameof(gameMaterial));
		}
		public override uint? ClassCRC => 0x656104B1;
	}
}

