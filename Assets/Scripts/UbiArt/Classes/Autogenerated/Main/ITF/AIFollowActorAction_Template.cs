using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIFollowActorAction_Template : AIAction_Template {
		[Serialize("aiFollowActorRelativPos"    )] public Vector3 aiFollowActorRelativPos;
		[Serialize("aiFollowActorRelativPosNext")] public Vector3 aiFollowActorRelativPosNext;
		[Serialize("aiFollowActorAcceleration"  )] public float aiFollowActorAcceleration;
		[Serialize("aiFollowActorFriction"      )] public float aiFollowActorFriction;
		[Serialize("aiFollowActorDoFlip"        )] public bool aiFollowActorDoFlip;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(aiFollowActorRelativPos));
			SerializeField(s, nameof(aiFollowActorRelativPosNext));
			SerializeField(s, nameof(aiFollowActorAcceleration));
			SerializeField(s, nameof(aiFollowActorFriction));
			SerializeField(s, nameof(aiFollowActorDoFlip));
		}
		public override uint? ClassCRC => 0x4E176A36;
	}
}

