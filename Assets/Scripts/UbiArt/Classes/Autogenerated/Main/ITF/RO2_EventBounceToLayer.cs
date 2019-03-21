using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventBounceToLayer : Event {
		[Serialize("bounceHeight"           )] public float bounceHeight;
		[Serialize("bounceHeight2"          )] public float bounceHeight2;
		[Serialize("bounceSpeed"            )] public float bounceSpeed;
		[Serialize("targetActor"            )] public ObjectRef targetActor;
		[Serialize("targetPos"              )] public Vector3 targetPos;
		[Serialize("targetOffset"           )] public Vector2 targetOffset;
		[Serialize("hurt"                   )] public bool hurt;
		[Serialize("skipped"                )] public bool skipped;
		[Serialize("useTargetActorScenePosZ")] public bool useTargetActorScenePosZ;
		[Serialize("useBounceHeight"        )] public bool useBounceHeight;
		[Serialize("hurt"                   )] public uint hurt2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(bounceHeight));
				SerializeField(s, nameof(bounceHeight2));
				SerializeField(s, nameof(bounceSpeed));
				SerializeField(s, nameof(targetActor), type: typeof(uint));
				SerializeField(s, nameof(targetPos));
				SerializeField(s, nameof(targetOffset));
				SerializeField(s, nameof(hurt2));
				SerializeField(s, nameof(skipped));
				SerializeField(s, nameof(useTargetActorScenePosZ));
				SerializeField(s, nameof(useBounceHeight));
			} else {
				SerializeField(s, nameof(bounceHeight));
				SerializeField(s, nameof(bounceHeight2));
				SerializeField(s, nameof(bounceSpeed));
				SerializeField(s, nameof(targetActor));
				SerializeField(s, nameof(targetPos));
				SerializeField(s, nameof(targetOffset));
				SerializeField(s, nameof(hurt));
				SerializeField(s, nameof(skipped));
				SerializeField(s, nameof(useTargetActorScenePosZ));
				SerializeField(s, nameof(useBounceHeight));
			}
		}
		public override uint? ClassCRC => 0xE0E48A5E;
	}
}

