using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RockFishAIComponent_Template : ActorComponent_Template {
		[Serialize("attackDetectionShape")] public Generic<PhysShape> attackDetectionShape;
		[Serialize("detectionRadius"     )] public float detectionRadius;
		[Serialize("minDetectTime"       )] public float minDetectTime;
		[Serialize("minIdleTime"         )] public float minIdleTime;
		[Serialize("sleepAnim"           )] public StringID sleepAnim;
		[Serialize("detectAnim"          )] public StringID detectAnim;
		[Serialize("openAnim"            )] public StringID openAnim;
		[Serialize("closeAnim"           )] public StringID closeAnim;
		[Serialize("grabbedAnim"         )] public StringID grabbedAnim;
		[Serialize("openTime"            )] public float openTime;
		[Serialize("points"              )] public CArray<Vector2> points;
		[Serialize("regionType"          )] public StringID regionType;
		[Serialize("gameMaterial"        )] public Path gameMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(attackDetectionShape));
				SerializeField(s, nameof(detectionRadius));
				SerializeField(s, nameof(minDetectTime));
				SerializeField(s, nameof(minIdleTime));
				SerializeField(s, nameof(sleepAnim));
				SerializeField(s, nameof(detectAnim));
				SerializeField(s, nameof(openAnim));
				SerializeField(s, nameof(closeAnim));
				SerializeField(s, nameof(grabbedAnim));
				SerializeField(s, nameof(openTime));
				SerializeField(s, nameof(points));
				SerializeField(s, nameof(regionType));
				SerializeField(s, nameof(gameMaterial));
			} else {
				SerializeField(s, nameof(attackDetectionShape));
				SerializeField(s, nameof(detectionRadius));
				SerializeField(s, nameof(minDetectTime));
				SerializeField(s, nameof(minIdleTime));
				SerializeField(s, nameof(sleepAnim));
				SerializeField(s, nameof(detectAnim));
				SerializeField(s, nameof(openAnim));
				SerializeField(s, nameof(closeAnim));
				SerializeField(s, nameof(grabbedAnim));
				SerializeField(s, nameof(openTime));
				SerializeField(s, nameof(points));
				SerializeField(s, nameof(points));
				SerializeField(s, nameof(regionType));
				SerializeField(s, nameof(gameMaterial));
			}
		}
		public override uint? ClassCRC => 0x28BADD8F;
	}
}

